using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form2_v1
{
    public class circle
    {
        point m; int r;
        public circle()
        {
            M = new point();// merkez noktası
            R = 0;
        }
        public circle(point p, int r)
        { M = p; R = r; }

        public int R { get => r; set => r = value; }
        internal point M { get => m; set => m = value; }
    }
}
