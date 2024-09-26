using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form2_v1
{
    public class Yuzey
    {
        point3d m;int en; int boy; int yukeklik;
        public Yuzey()
        {
            M = new point3d(); //köşe noktası
            En = 0; Boy = 0;
            yukeklik = 0;
        }
        public Yuzey(point3d p,int en, int boy, int yukseklik)
        {
            En = en; Boy = boy;
            Yukseklik = yukseklik;
            M = p;
        }
        public point3d M { get => m; set => m = value; }
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }
        public int Yukseklik { get => yukeklik; set => yukeklik = value;}
    }
}
