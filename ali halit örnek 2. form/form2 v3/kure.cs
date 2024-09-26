using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form2_v1
{
    public class kure
    {
        point3d m; int r;
        public kure()
        {
            M = new point3d();// merkez noktası
            R = 0;
        }
        public kure(point3d p, int r)
        { M = p; R = r; }

        public int R { get => r; set => r = value; }
        internal point3d M { get => m; set => m = value; }

    }
}
