using HZH_Controls.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 温室监控.Controls
{
    public class mLED:UserControl
    {
        private Graphics g;

        private Color ledColor=Color.FromArgb(255,255,77,59);
        [Description("ELD颜色"), Category("自定义")]
        public Color LedColor
        {
            get { return ledColor; }
            set { this.ledColor = value;this.Invalidate(); }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.BackColor = Color.FromArgb(00);
            g=e.Graphics;
            g.DrawEllipse(new Pen(new SolidBrush(LedColor)),
                new Rectangle(0,0,Width,Height));
            g.FillEllipse(new SolidBrush(LedColor),
                new Rectangle(0, 0, Width, Height));
            // g.DrawPath(new Pen(new SolidBrush(Color.White)),);
            var graphicsPath=new GraphicsPath();
            Rectangle rect = new Rectangle(5, 5, base.Width - 10 - 1, base.Height - 10 - 1);
            graphicsPath.AddEllipse(rect);
            PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath);
            pathGradientBrush.CenterColor = Color.White;
            Color[] colors = new Color[] { LedColor };
            pathGradientBrush.SurroundColors = colors;
            g.FillPath(pathGradientBrush, graphicsPath);
        }
    }
}
