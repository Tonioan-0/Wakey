using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wakey
{
    public partial class Timer : Form, IDisposable
    {
        #region Var
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private int p_s = 0;
        private int p_r = 0;
        private readonly int[] m_studio = { 20, 30, 45, 60 };
        private readonly int[] m_riposo = { 5, 10, 15, 20 };

        private bool _timerColor = false;
        private bool _SettingsChanged= false;
        private bool _isPaused = false;
        private readonly System.Windows.Forms.Timer uiTimer;
        private readonly Color light_Purple = Color.FromArgb(255, 113, 96, 232);
        private readonly Color light_Green = Color.FromArgb(255, 85, 177, 85);
        private readonly Color dark_Purple = Color.FromArgb(255, 100, 83, 219);
        private readonly Color dark_Green = Color.FromArgb(255, 48, 100, 48);
        private readonly Color medium_Gray = Color.FromArgb(255, 36, 36,36);
        private readonly Color light_Gray = Color.FromArgb(255, 47, 47, 47);

#endregion

#region Initialize
public Timer()
        {
            InitializeComponent();
            Program._s_closed = true;
            ShowAtLocation(Cursor.Position);
            // Load saved settings
            LoadSettings();

            // Make the form draggable
            this.MouseDown += MovableForm_MouseDown;

            // Set rounded corners
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            // Initialize UI Timer
            uiTimer = new System.Windows.Forms.Timer { Interval = 300 };
            uiTimer.Tick += UI_Timer_Tick;
            if (Program._timer.Enabled)
            {
                uiTimer.Enabled = true;
                UpdateLabel();
                Btn_pause.ForeText = "Pause";
            }
            //Set UI
            Update_Style();
            SetColors();
        }
        private void StripMenu_Deactivate(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Style == 0)
            {
                tlp_img.BackgroundImage?.Dispose();
                tlp_img.BackgroundImage = null;
                uiTimer.Tick -= UI_Timer_Tick;
                uiTimer?.Dispose();
                if (_SettingsChanged)
                    Properties.Settings.Default.Save();
                Program._s_closed = false;

                this.Close();
            }

        }
        private void StripMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (tlp_img.BackgroundImage != null)
                {
                    tlp_img.BackgroundImage.Dispose();
                    tlp_img.BackgroundImage = null;
                }
                uiTimer.Tick -= UI_Timer_Tick;
                uiTimer?.Stop();
                uiTimer?.Dispose();
                if (_SettingsChanged)
                {
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during form closing cleanup: " + ex.Message);
            }
            finally
            {
                // Perform form closing operations
                Program.FormClosing();
                this.Close();
            }
        }

        #endregion

        #region Backend
        private void LoadSettings()
        {
            p_s = Properties.Settings.Default.pos_s;
            lbl_s.ForeText = m_studio[p_s].ToString();

            p_r = Properties.Settings.Default.pos_r;
            lbl_r.ForeText = m_riposo[p_r].ToString();
        }

        private void UI_Timer_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
            if (Program._isStudingTime != _timerColor)
                SetColors();

        }

        private void UpdateLabel()
        {
            if (Program._timer == null) return;
            TimeSpan elapsedTime = DateTime.Now - Program._start_time;
            int remainingSeconds = Convert.ToInt32(Program._timer.Interval / 1000 - (int)elapsedTime.TotalSeconds);
            lbl_timer.ForeText = $"{remainingSeconds / 60:00}:{remainingSeconds % 60:00}";    
        }

        private void SetColors()
        {     
            _timerColor = Program._isStudingTime;
            if (tlp_img.BackgroundImage != null)
            {
                tlp_img.BackgroundImage.Dispose();
                tlp_img.BackgroundImage = null; 
            }
            if (_timerColor)
            {
                lbl_timer.ForeColor = light_Purple;
                lbl_state.Text = "Study:";
                lbl_state.ForeColor = light_Purple;
                BackColor = light_Purple;
                Btn_pause.BackgroundColor = light_Purple;
                //using (Bitmap resizedImage = new Bitmap(Re, tlp_img.Size))
                //{
                //    tlp_img.BackgroundImage = (System.Drawing.Image)resizedImage.Clone();
                //}
            }
            else
            {
                lbl_timer.ForeColor = light_Green;
                lbl_state.Text = "Rest:";
                lbl_state.ForeColor = light_Green;
                BackColor = light_Green;
                Btn_pause.BackgroundColor = light_Green;
                //using (Bitmap resizedImage = new Bitmap(Resources.img_rest, tlp_img.Size))
                //{
                //    tlp_img.BackgroundImage = (System.Drawing.Image)resizedImage.Clone();
                //}
            }
        }
        private void Update_Style()
        {
            switch (Properties.Settings.Default.Style)
            {
                case 0:
                    Btn_active.ForeText = "Hidden";
                    this.TopMost = false;
                    break;
                case 1:
                    Btn_active.ForeText = "Fixed";
                    this.TopMost = false;
                    break;
                case 2:
                    Btn_active.ForeText = "On Top";
                    this.TopMost = true;
                    break;
                default:
                    Btn_active.ForeText = "✔";
                    break;
            }
        }
        public void ShowAtLocation(Point location, Size size = default)
        {
            this.StartPosition = FormStartPosition.Manual;

            if (size != default)
            {
                this.Size = size;
            }

            var screenBounds = Screen.FromPoint(location).WorkingArea;

            int x = Math.Min(location.X, screenBounds.Right - this.Width);
            int y = Math.Min(location.Y, screenBounds.Bottom - screenBounds.Bottom / 10 - this.Height);

            x = Math.Max(x, screenBounds.Left);
            y = Math.Max(y, screenBounds.Top);

            this.Location = new Point(x, y);
            this.Show();
        }

        #endregion

        #region MouseEvents 
        private void MovableForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Btn_Close_MouseEnter(object sender, EventArgs e)
        {
            if (sender is RoundedLabel control)
            {
                control.BackgroundColor = medium_Gray;
            }
        }

        private void Btn_Close_MouseLeave(object sender, EventArgs e)
        {
            if (sender is RoundedLabel control)
            {
                control.BackgroundColor = light_Gray;
            }

        }

        private void Btn_Arrows_MouseEnter(object sender, EventArgs e)
        {
            if (sender is RoundedLabel control)
            {
                control.BackgroundColor = light_Gray;
            }
        }

        private void Btn_Arrows_MouseLeave(object sender, EventArgs e)
        {
            if (sender is RoundedLabel control)
            {
                control.BackgroundColor = Color.Transparent;
            }
        }

        private void Btn_Play_MouseEnter(object sender, EventArgs e)
        {
            if (Btn_pause.BackgroundColor == light_Purple)
            {
                Btn_pause.BackgroundColor = dark_Purple;
            }
            else if (Btn_pause.BackgroundColor == light_Green)
            {
                Btn_pause.BackgroundColor = dark_Green;
            }
            
        }

        private void Btn_Play_MouseLeave(object sender, EventArgs e)
        {
            if (Btn_pause.BackgroundColor == dark_Purple)
            {
                Btn_pause.BackgroundColor = light_Purple;
            }
            else if (Btn_pause.BackgroundColor == dark_Green)
            {
                Btn_pause.BackgroundColor = light_Green;
            }
        }
        #endregion

        #region Click
        private void Btn_s_l_Click(object sender, EventArgs e)
        {
            p_s--;
            if (p_s < 0)
                p_s = 3;
            Properties.Settings.Default.pos_s = Convert.ToByte(p_s);
            lbl_s.ForeText = m_studio[p_s].ToString();
            
        }

        private void Btn_s_r_Click(object sender, EventArgs e)
        {
            p_s++;
            if (p_s > 3)
                p_s = 0;
            Properties.Settings.Default.pos_s = Convert.ToByte(p_s);
            lbl_s.ForeText = m_studio[p_s].ToString();
            _SettingsChanged = true;
        }

        private  void Btn_r_l_Click(object sender, EventArgs e)
        {
            p_r--;
            if (p_r < 0)
                p_r = 3;
            Properties.Settings.Default.pos_r = Convert.ToByte(p_r);
            lbl_r.ForeText = m_riposo[p_r].ToString();
            _SettingsChanged = true;
        }

        private  void Btn_r_r_Click(object sender, EventArgs e)
        {
            p_r++;
            if (p_r > 3)
                p_r = 0;
            Properties.Settings.Default.pos_r = Convert.ToByte(p_r);
            lbl_r.ForeText = m_riposo[p_r].ToString();
            _SettingsChanged = true;
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (Program._timer == null)
            {
                return;
            }
            Program._isStudingTime = true;
            _timerColor = true;
            Program._timer.Interval = 1000 * m_studio[p_s];
            Program._timer.Start();
            Program._start_time = DateTime.Now;
            if(!uiTimer.Enabled)
                uiTimer.Start(); 
            Btn_pause.ForeText = "Pause";
            study_setup();
        }

        private void study_setup()
        { 
            lbl_timer.ForeColor = light_Purple;
            lbl_state.Text = "Study:";
            lbl_state.ForeColor = light_Purple;
            BackColor = light_Purple;
            Btn_pause.BackgroundColor = light_Purple;
            if (tlp_img.BackgroundImage != null)
            {
                tlp_img.BackgroundImage.Dispose();
                tlp_img.BackgroundImage = null;
            }
            //using (Bitmap resizedImage = new Bitmap(Properties.Resources.img_study, tlp_img.Size))
            //{
            //    tlp_img.BackgroundImage = (System.Drawing.Image)resizedImage.Clone();
            //}
        }
        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            if (Program._timer != null)
            {
                Program._timer.Stop();
                Program._isStudingTime = true;
                if (uiTimer.Enabled)
                    uiTimer.Stop();
                _isPaused = false;
                lbl_timer.ForeText = "--:--";
                Btn_pause.ForeText = "Play";
                study_setup();
            }
        }

        private void Btn_pause_Click(object sender, EventArgs e)
        {
            if (Program._timer != null && (Program._timer.Enabled || _isPaused))
            {
                _isPaused = !_isPaused;
                Btn_pause.ForeText = _isPaused ? "Play" : "Pause";

                if (_isPaused)
                {
                    Program._timer.Stop();
                    uiTimer.Stop();

                    TimeSpan elapsedTime = DateTime.Now - Program._start_time;
                    Program._timer.Interval -= (int)elapsedTime.TotalMilliseconds;
                }
                else
                {
                    Program._start_time = DateTime.Now;
                    Program._timer.Start();
                    uiTimer.Start();
                }
            }
            else
            {
                Program._timer.Interval = 1000 * 60 * m_studio[p_s];
                Program._timer.Start();
                Program._start_time = DateTime.Now;
                uiTimer.Start();
                Btn_pause.ForeText = "Pause";
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Program.Close();
        }

        private void Btn_active_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Style =Convert.ToByte((Properties.Settings.Default.Style + 1) % 3);
            Update_Style();
            Properties.Settings.Default.Save();
        }


        #endregion

    }
}
