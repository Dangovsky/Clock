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
        private Bitmap image;

        public ClassicClock(int width, int height)
        {
            image = new Bitmap(width, height);
        }

        public Image Draw(DateTime time)
        {
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.White);
            g.FillEllipse(Brushes.Ivory, 5, 5, image.Width - 5, image.Height - 5);
            g.DrawEllipse(new Pen(Color.Black, 5), 0, 0, image.Width, image.Height);
            g.FillRectangle(Brushes.Black, image.Width / 2 - 2, image.Height / 2 - 2, 2, 2);
            g.TranslateTransform(image.Width / 2, image.Height / 2);
            if (time.Hour > 12)
            {
                g.RotateTransform(-90 + 360 * Math.Abs(time.Hour - 12) / 12f);
            }
            else
            {
                g.RotateTransform(-90 + 360 * time.Hour / 12f);
            }
            g.DrawLine(new Pen(Color.Black, 4), 0, 0, image.Height / 4, 0);
            g.ResetTransform();
            g.TranslateTransform(image.Width / 2, image.Height / 2);
            g.RotateTransform(-90 + 360 * time.Minute / 60f);
            g.DrawLine(new Pen(Color.DarkGray, 3), 0, 0, image.Height / 3, 0);
            g.ResetTransform();
            g.TranslateTransform(image.Width / 2, image.Height / 2);
            g.RotateTransform(-90 + 360 * time.Second / 60f);
            g.DrawLine(new Pen(Color.DimGray, 2), 0, 0, image.Height / 2, 0);
            g.ResetTransform();
            g.Dispose();
            return image;
        }
    }
}
