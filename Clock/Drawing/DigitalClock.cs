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
        private Image image;

        public DigitalClock(Image image)
        {
            this.image = image;
        }

        public Image Draw(DateTime time)
        {
            return null;
        }
    }
}
