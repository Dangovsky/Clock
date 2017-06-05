using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Clock.Drawing
{
    interface Drawer
    {
        Image Draw(DateTime time);
    }
}
