using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form2_v1
{
    public class dikdortgenPrizma
    {
        List<Yuzey> yuzeyler;

        public dikdortgenPrizma(point3d nokta, int en, int boy, int yukseklik)
        {
            Yuzeyler = new List<Yuzey>();

            Yuzeyler.Add(new Yuzey(nokta, en, boy ,1));
            Yuzeyler.Add(new Yuzey(nokta, en, 1, yukseklik));
            Yuzeyler.Add(new Yuzey(nokta, 1, boy, yukseklik));

        }

        public List<Yuzey> Yuzeyler { get => yuzeyler; set => yuzeyler = value; }
    }


}
