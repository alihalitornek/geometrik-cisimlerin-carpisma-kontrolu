using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form2_v1
{
    public class cylender
    {
        point3d m; int r; int h;
        public cylender()
        {
            M = new point3d();// merkez noktası
            R = 0;
            H = 0;
        }
        public cylender(point3d p, int r, int h)
        { M = p; R = r; H = h; }

        public int R { get => r; set => r = value; }
        public int H { get => h; set => h = value; }
        internal point3d M { get => m; set => m = value; }

    }
}
