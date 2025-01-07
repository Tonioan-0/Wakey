using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace Wakey
{

    public class RoundedLabel : System.Windows.Forms.Label
    {
        private Color _backgroundColor = Color.White;
        private string _text = string.Empty;
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                if (_backgroundColor != value)
                {
                    _backgroundColor = value;
                    Invalidate();
                }
            }
        }
        public string ForeText
        {
            get => _text;
            set
            {
                if (_text != value)
                {
                    _text = value;
                    Invalidate();
                }
            }
        }
        public int BorderRadius { get; set; } = 15;

        public RoundedLabel()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (SolidBrush backgroundBrush = new SolidBrush(this.BackgroundColor))
            {
                e.Graphics.FillRoundedRectangle(backgroundBrush, 0, 0, this.Width, this.Height, BorderRadius);
            }


            TextRenderer.DrawText(e.Graphics, _text, this.Font, new Point(Width / 2 - TextRenderer.MeasureText(_text, this.Font).Width / 2, Height / 2 - TextRenderer.MeasureText(_text, this.Font).Height / 2), ForeColor);
        }
    }

    public static class GraphicsExtensions
    {
        public static void FillRoundedRectangle(this Graphics g, Brush brush, float x, float y, float width, float height, float radius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddLine(x + radius, y, x + width - radius * 2, y);
                path.AddArc(x + width - radius * 2, y, radius * 2, radius * 2, 270, 90);
                path.AddLine(x + width, y + radius, x + width, y + height - radius * 2);
                path.AddArc(x + width - radius * 2, y + height - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddLine(x + width - radius * 2, y + height, x + radius, y + height);
                path.AddArc(x, y + height - radius * 2, radius * 2, radius * 2, 90, 90);
                path.AddLine(x, y + height - radius * 2, x, y + radius);
                path.AddArc(x, y, radius * 2, radius * 2, 180, 90);
                path.CloseFigure();
                g.FillPath(brush, path);
            }
        }

        public static void DrawRoundedRectangle(this Graphics g, Pen pen, float x, float y, float width, float height, float radius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddLine(x + radius, y, x + width - radius * 2, y);
                path.AddArc(x + width - radius * 2, y, radius * 2, radius * 2, 270, 90);
                path.AddLine(x + width, y + radius, x + width, y + height - radius * 2);
                path.AddArc(x + width - radius * 2, y + height - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddLine(x + width - radius * 2, y + height, x + radius, y + height);
                path.AddArc(x, y + height - radius * 2, radius * 2, radius * 2, 90, 90);
                path.AddLine(x, y + height - radius * 2, x, y + radius);
                path.AddArc(x, y, radius * 2, radius * 2, 180, 90);
                path.CloseFigure();
                g.DrawPath(pen, path);
            }
        }
    }
}