using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form2_v1
{
    public class point3d : point
    {
        int z;
        public point3d() : base()
        { Z = 0; }
        public point3d(int x, int y, int z) : base(x, y)
        { Z = z; }
        public int Z { get => z; set => z = value; }
    }
}
