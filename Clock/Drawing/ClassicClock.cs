using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Clock.Drawing
{
    class ClassicClock: Drawer
    {
        private Image image;

        public ClassicClock(Image image)
        {
            this.image = image;
        }

        public Image Draw(DateTime time)
        {
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.White);
            g.DrawEllipse(new Pen(Color.Black, 5), 0, 0, image.Width, image.Height);
            g.FillEllipse(Brushes.Ivory, 5, 5, image.Width - 5, image.Height - 5);
            g.FillRectangle(Brushes.Black, image.Width / 2 - 2, image.Height / 2 - 2, 2, 2);
            g.TranslateTransform(image.Width, image.Height);
            g.RotateTransform(360 * Math.Abs(time.Hour - 12) / 12);
            g.DrawLine(new Pen(Color.Black, 4), 0, 0, image.Height / 2, 0);
            g.ResetTransform();
            g.TranslateTransform(image.Width, image.Height);
            g.RotateTransform(360 * time.Minute / 60);
            g.DrawLine(new Pen(Color.DarkGray, 3), 0, 0, image.Height / 3 * 2, 0);
            g.ResetTransform();
            g.TranslateTransform(image.Width, image.Height);
            g.RotateTransform(360 * time.Second / 60);
            g.DrawLine(new Pen(Color.DimGray, 2), 0, 0, image.Height / 4 * 3, 0);
            g.ResetTransform();
            g.Dispose();
            return image;
        }
    }
}
