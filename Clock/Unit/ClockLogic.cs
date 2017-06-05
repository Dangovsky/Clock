using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Clock.Drawing;

namespace Clock.Unit
{
    class ClockLogic
    {
        private int gCorrection;
        private Drawer drawer;
        private List<string> types;
        private List<string> g;
        private Image image;

        public List<string> G { get { return g; } }

        public List<string> Types { get { return types; } }

        public string Type
        {
            set
            {
                switch (value)
                {
                    case "Digital":
                        drawer = new DigitalClock(image);
                        break;
                    case "Classic":
                        drawer = new ClassicClock(image);
                        break;
                }
            }
        }

        public string GCorrection
        {
            set
            {
                gCorrection = Convert.ToInt16(value);
            }
        }

        public ClockLogic()
        {
            g = new List<string>();
            types = new List<string>();
        }

        public ClockLogic(string clockType, string GCorrection, Image image)
        {
            this.image = image;
            types = new List<string> { "Digital", "Classic" };
            g = new List<string>();
            for (int i = -12; i < 13; i++)
            {
                g.Add(i.ToString());
            }
            switch (clockType)
            {
                case "Digital":
                    drawer = new DigitalClock(image);
                    break;
                case "Classic":
                    drawer = new ClassicClock(image);
                    break;
            }
            this.gCorrection = Convert.ToInt16(gCorrection);
        }

        public Image GetImage()
        {
            DateTime time = DateTime.Now;
            time.AddHours(gCorrection);
            return drawer.Draw(time);
        }
    }
}
