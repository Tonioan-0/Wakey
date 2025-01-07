using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Wakey
{
    public class RoundedTableLayoutPanel : TableLayoutPanel
    {
        public int CornerRadius { get; set; } = 10;

        public bool RoundTopOnly { get; set; } = true;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rect = this.ClientRectangle;

            using (GraphicsPath path = RoundTopOnly
                ? GetRoundedTopRectanglePath(rect, CornerRadius)
                : GetRoundedRectanglePath(rect, CornerRadius))
            using (Pen borderPen = new Pen(Color.FromArgb(255, 31, 31, 31), 5))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(borderPen, path);
                this.Region = new Region(path);
            }
        }

        private GraphicsPath GetRoundedTopRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            path.AddArc(arcRect, 180, 90);

            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            path.AddLine(rect.Right, rect.Top + radius, rect.Right, rect.Bottom);
            path.AddLine(rect.Right, rect.Bottom, rect.Left, rect.Bottom);
            path.AddLine(rect.Left, rect.Bottom, rect.Left, rect.Top + radius);

            path.CloseFigure();
            return path;
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));

            path.AddArc(arcRect, 180, 90);


            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}