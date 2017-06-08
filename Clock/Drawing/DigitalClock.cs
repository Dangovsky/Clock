using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Clock.Drawing
{
    class DigitalClock: Drawer
    {
        private Bitmap image;

        public DigitalClock(int width, int height)
        {            
            image = new Bitmap(width, height);
        }

        public Image Draw(DateTime time)
        {
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.White);
            g.DrawString(time.Hour + ":" + time.Minute + ":" + time.Second, new Font(FontFamily.GenericSansSerif, image.Width / 8), Brushes.Black,0, image.Height / 3);
            g.Dispose();
            return image;
        }
    }
}
