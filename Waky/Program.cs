using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Wakey
{

    static class Program
    {

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeTrayIcon();
            InitializeTimer();
            _start_time = DateTime.Now;
            _notifyIcon.Click += NotifyIcon_Click;
            OpenForm();
            Application.Run();
            
        }
        public static void Close()
        {
            Form.Dispose();
            Form= null;
            _timer.Dispose();
            _timer = null;
            Application.Exit();

        }
        private static void OpenForm() {
            if (!_s_closed)
            {
                Form = new Timer();
                Form.Show();

            }
            else
            {
                Form.Activate();
            }
        }

        internal static void FormClosing()
        {
            Form.Dispose();
            Form = null;
        }

        #region Timer
        private static NotifyIcon _notifyIcon;
        internal static System.Timers.Timer _timer;
        internal static DateTime _start_time;
        internal static bool _isStudingTime = true;
        internal static bool _s_closed = false;
        private readonly static int[] m_studio = new int[4] { 20, 30, 45, 60 };
        private readonly static int[] m_riposo = new int[4] { 5, 10, 15, 20 };
        private static Timer Form;

        private static void InitializeTimer()
        {
            _timer = new System.Timers.Timer
            {
                Interval = 10000,
                Enabled = false
            };
            _timer.Elapsed += Timer_Tick;
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            _isStudingTime = !_isStudingTime;
            if (_isStudingTime)
            {
                ShowNotification("Your break is over!", "Your break time is over, you can sit down and study.");
                _timer.Interval = 1000 * 60 * m_studio[Properties.Settings.Default.pos_s];
            }
            else
            {
                ShowNotification("You can rest now!", "Time for a quick break! Stand up, hydrate, and stretch your body.");
                _timer.Interval = 1000 * 60 * m_riposo[Properties.Settings.Default.pos_r];
            }
            _start_time = DateTime.Now;
        }

        #endregion

        #region NotifyIcon
        private static void NotifyIcon_Click(object sender, EventArgs e)
        {
            OpenForm();

        }

        private static void InitializeTrayIcon()
        {
            _notifyIcon = new NotifyIcon
            {
                Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath),
                Text = "Sit-Stand Reminder",
                Visible = true,
                ContextMenuStrip = new ContextMenuStrip()
            };

        }

        private static void ShowNotification(string title, string message)
        {
            _notifyIcon.BalloonTipTitle = title;
            _notifyIcon.BalloonTipText = message;
            _notifyIcon.ShowBalloonTip(1000);
        }


        #endregion
    }
}
