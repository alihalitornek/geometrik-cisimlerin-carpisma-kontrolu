using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form2_v1
{
    public static class Carpisma
    {
        public static bool circleCarp(circle c1, circle c2)
        {
            // Merkezler arası uzunluğu hesapla
            float d = (float)Math.Sqrt(Math.Pow((c1.M.X - c2.M.X), 2) + Math.Pow((c1.M.Y - c2.M.Y), 2));

            // Merkezler arası uzunluk yarıçaplar toplamından küçükmü kontrol et
            if ((c1.R + c2.R) > d)
                return true;
            else
                return false;
        }
        public static bool kureCarp(kure k1, kure k2)
        {
            // Merkezler arası uzunluğu hesapla
            float d = (float)Math.Sqrt(Math.Pow((k1.M.X - k2.M.X), 2) +
                Math.Pow((k1.M.Y - k2.M.Y), 2) + Math.Pow((k1.M.Z - k2.M.Z), 2));

            // Merkezler arası uzunluk yarıçaplar toplamından küçükmü kontrol et
            if ((k1.R + k2.R) > (int)d)
                return true;
            else
                return false;
        }
        public static bool dikdortgenCarp(dikdortgen d1, dikdortgen d2)
        {
            // Dikdörtgenlerin merkez noktalarını hesapla
            int Xa = d1.M.X + d1.En / 2;
            int Ya = d1.M.Y + d1.Boy / 2;
            int Xb = d2.M.X + d2.En / 2;
            int Yb = d2.M.Y + d2.Boy / 2;

            // Dikdörtgenler arasındaki mesafelerin, genişliklerinin yarısının toplamına göre kontrol et
            if (Math.Abs(Xa - Xb) < (d1.En / 2 + d2.En / 2) && Math.Abs(Ya - Yb) < (d1.Boy / 2 + d2.Boy / 2))
                return true;
            else
                return false;
        }
        public static bool cylenderCarp(cylender k1, cylender k2)
        {
            // Silindirin merkezini köşelerini hesapla
            point3d pa = new point3d(k1.M.X, k1.M.Y , k1.M.Z );
            point3d pb = new point3d(k2.M.X, k2.M.Y , k2.M.Z );

            // En kısa uzunluğu hesapla
            float d = (float)Math.Sqrt(Math.Pow((pa.X - pb.X), 2) +
                Math.Pow((pa.Y - pb.Y), 2) + Math.Pow((pa.Z - pb.Z), 2));

            // Yarıçapları toplamı en kısa uzunluktan büyükse ve yühseklikleri toplamı Z eksenleri farkından büyükse çarpışma vardır
            if ((k1.R + k2.R) > (int)d && Math.Abs(pa.Z - pb.Z) < ((k1.H + k2.H) / 2))
                return true;
            else
                return false;
        }
        public static bool DikdortgenCemberCarp(dikdortgen dikdortgen, circle cember)
        {
            // Dikdörtgenin sol üst ve sağ alt köşelerini hesapla
            int solUstX = dikdortgen.M.X;
            int solUstY = dikdortgen.M.Y;
            int sagAltX = dikdortgen.M.X + dikdortgen.En;
            int sagAltY = dikdortgen.M.Y + dikdortgen.Boy;

            // Çemberin merkezi, dikdörtgenin sınırları içinde mi kontrol et
            bool icindeMiX = (cember.M.X >= solUstX) && (cember.M.X <= sagAltX);
            bool icindeMiY = (cember.M.Y >= solUstY) && (cember.M.Y <= sagAltY);

            // Eğer çemberin merkezi, dikdörtgenin sınırları içindeyse, çarpışma vardır
            if (icindeMiX && icindeMiY)
                return true;

            // Çemberin merkezi, dikdörtgenin sınırları dışındaysa, dikdörtgenin kenarları ile çemberin mesafesini kontrol et
            double dikdortgenKenarlarX = Math.Max(solUstX - cember.M.X, cember.M.X - sagAltX);
            double dikdortgenKenarlarY = Math.Max(solUstY - cember.M.Y, cember.M.Y - sagAltY);
            double mesafe = Math.Sqrt(dikdortgenKenarlarX * dikdortgenKenarlarX + dikdortgenKenarlarY * dikdortgenKenarlarY);

            // Eğer çemberin merkezi, dikdörtgenin kenarlarına olan mesafeden küçük veya eşitse, çarpışma vardır
            if ((mesafe) <= 0.5*cember.R)
                return true;

            // Hiçbir koşula uymuyorsa çarpışma yoktur
            return false;
        }
        public static bool NoktaKureCarpisma(point3d nokta, kure kure)
        {
            // Noktanın kürenin merkezine olan mesafesini hesapla
            double mesafe = Math.Sqrt(Math.Pow((nokta.X - kure.M.X), 2) + Math.Pow((nokta.Y - kure.M.Y), 2) + Math.Pow((nokta.Z - kure.M.Z), 2));

            // Eğer mesafe kürenin yarıçapından küçük veya eşitse, çarpışma vardır
            if (mesafe <= kure.R)
                return true;

            return false;
        }
        public static bool NoktaCemberCarpisma(point nokta, circle cember)
        {
            // Noktanın kürenin merkezine olan mesafesini hesapla
            double mesafe = Math.Sqrt(Math.Pow((nokta.X - cember.M.X), 2) + Math.Pow((nokta.Y - cember.M.Y), 2));

            // Eğer mesafe kürenin yarıçapından küçük veya eşitse, çarpışma vardır
            if (mesafe <= cember.R)
                return true;

            return false;
        }
        public static bool NoktaDikdortgenPrizmaCarpisma(point3d nokta, dikdortgenPrizma prizma)
        {
            // Noktanın dikdörtgen prizmanın dört yüzeyinin her biri ile arasındaki mesafeyi kontrol et
            foreach (Yuzey yuzey in prizma.Yuzeyler)
            {
                if (NoktaDikdortgenCarpisma(nokta, yuzey))
                {
                    return true;
                }
            }

            return false;
        }
        public static bool NoktaDikdortgenCarpisma(point nokta, Yuzey yuzey)
        {
            // Noktanın dikdörtgenin içinde olup olmadığını kontrol et
            if (nokta.X >= (yuzey.M.X ) && nokta.X <= (yuzey.M.X + yuzey.En ) &&
                nokta.Y >= (yuzey.M.Y) && nokta.Y <= (yuzey.M.Y + yuzey.Boy))
            {
                return true; // Nokta dikdörtgenin içinde
            }
            else
            {
                return false; // Nokta dikdörtgenin dışında
            }
        }
        public static bool NoktaSilindirCarpisma(point3d nokta, cylender silindir)
        {
            // Silindirin merkezi ile nokta arasındaki uzaklığı hesapla
            double uzaklik = Math.Sqrt(Math.Pow((nokta.X - silindir.M.X), 2) +
                                        Math.Pow((nokta.Y - silindir.M.Y), 2));

            // Nokta, silindirin yarıçapından küçük veya eşit uzaklıkta ise çarpışma vardır
            if (uzaklik <= silindir.R)
            {
                // Noktanın z koordinatı silindirin yükseklik aralığında mı kontrol et
                if (nokta.Z >= silindir.M.Z && nokta.Z <= (silindir.M.Z + silindir.H))
                {
                    return true; // Çarpışma var
                }
            }

            return false; // Çarpışma yok
        }
        public static bool KureSilindirCarpisma(kure kure, cylender silindir)
        {
            // Kürenin merkezi ile silindirin eksenine dik mesafeyi hesapla
            double dx = Math.Abs(silindir.M.X - kure.M.X);
            double dy = Math.Abs(silindir.M.Y - kure.M.Y);
            double dz = Math.Abs(silindir.M.Z - kure.M.Z);

            // Kürenin merkezinin silindirin içinde olup olmadığını kontrol et
            double uzaklikKare = dx * dx + dy * dy + dz * dz;
            double kureYaricapKare = kure.R * kure.R;

            if (uzaklikKare <= kureYaricapKare)
            {
                return true; // Çarpışma var
            }

            // Kürenin merkezinin silindirin yükseklik aralığında olup olmadığını kontrol et
            double yukseklikFarki = Math.Abs(silindir.M.Z - kure.M.Z);
            if (yukseklikFarki <= silindir.H / 2)
            {
                // Silindirin yüzeyinden kürenin merkezine olan en kısa mesafeyi hesapla
                double enKisaMesafe = Math.Sqrt(uzaklikKare - dz * dz);
                if (enKisaMesafe <= kure.R + silindir.R)
                {
                    return true; // Çarpışma var
                }
            }

            return false; // Çarpışma yok
        }
        public static bool YuzeyKureCarpisma(Yuzey yuzey, kure kure)
        {
            // Kürenin merkezinin yüzeyin içinde olup olmadığını kontrol et
            double uzaklik = Math.Sqrt(Math.Pow((yuzey.M.X + yuzey.En - kure.M.X), 2) + Math.Pow((yuzey.M.Y + yuzey.Boy - kure.M.Y), 2) + Math.Pow((yuzey.M.Z + yuzey.Yukseklik - kure.M.Z), 2));

            if (uzaklik <= kure.R + yuzey.En/2)
            {
                return true; // Çarpışma var
            }

            return false; // Çarpışma yok
        }
        public static bool YuzeyDikdortgenPrizmaCarpisma(Yuzey yuzey1, dikdortgenPrizma prizma)
        {
            foreach (Yuzey yuzey in prizma.Yuzeyler)
            {
                // Dikdörtgen prizmanın her bir yüzeyi için çarpışmayı kontrol et
                if (DikdortgenYuzeyCarpisma(yuzey, yuzey1))
                    return true; // Çarpışma var
            }

            return false; // Çarpışma yok
        }

        private static bool DikdortgenYuzeyCarpisma(Yuzey yuzey1, Yuzey yuzey)
        {
            // Dikdörtgenin kenarları
            double minX = yuzey1.M.X;
            double maxX = yuzey1.M.X + yuzey1.En;
            double minY = yuzey1.M.Y;
            double maxY = yuzey1.M.Y + yuzey1.Boy;
            double minZ = yuzey1.M.Z;
            double maxZ = yuzey1.M.Z + yuzey1.Yukseklik;

            // Yüzeyin kenarları
            double yuzeyMinX = yuzey.M.X;
            double yuzeyMaxX = yuzey.M.X + yuzey.En;
            double yuzeyMinY = yuzey.M.Y;
            double yuzeyMaxY = yuzey.M.Y + yuzey.Boy;
            double yuzeyMinZ = yuzey.M.Z;
            double yuzeyMaxZ = yuzey.M.Z + yuzey.Yukseklik;

            // Çarpışma kontrolü
            bool xUygun = yuzeyMinX <= maxX && yuzeyMaxX >= minX;
            bool yUygun = yuzeyMinY <= maxY && yuzeyMaxY >= minY;
            bool zUygun = yuzeyMinZ <= maxZ && yuzeyMaxZ >= minZ;

            return xUygun && yUygun && zUygun;
        }
        public static bool YuzeySilindirCarpisma(Yuzey yuzey, cylender silindir)
        {
            // Silindirin tabanın kenarları
            double minX = silindir.M.X - silindir.R;
            double maxX = silindir.M.X + silindir.R;
            double minY = silindir.M.Y - silindir.R;
            double maxY = silindir.M.Y + silindir.R;
            double minZ = silindir.M.Z;
            double maxZ = silindir.M.Z + silindir.H;

            // Yüzeyin kenarları
            double yuzeyMinX = yuzey.M.X;
            double yuzeyMaxX = yuzey.M.X + yuzey.En;
            double yuzeyMinY = yuzey.M.Y;
            double yuzeyMaxY = yuzey.M.Y + yuzey.Boy;
            double yuzeyMinZ = yuzey.M.Z;
            double yuzeyMaxZ = yuzey.M.Z + yuzey.Yukseklik;

            // Çarpışma kontrolü
            bool xUygun = yuzeyMinX <= maxX && yuzeyMaxX >= minX;
            bool yUygun = yuzeyMinY <= maxY && yuzeyMaxY >= minY;
            bool zUygun = yuzeyMinZ <= maxZ && yuzeyMaxZ >= minZ;

            return xUygun && yUygun && zUygun;
        }
        public static bool KureDikdortgenPrizmaCarpisma(kure kure, dikdortgenPrizma prizma)
        {
            foreach (Yuzey yuzey in prizma.Yuzeyler)
            {
                if (KureDikdortgenCarpisma(kure, yuzey))
                    return true; // Çarpışma var
            }

            return false; // Çarpışma yok
        }

        private static bool KureDikdortgenCarpisma(kure kure, Yuzey yuzey)
        {

            // Dikdörtgenin kenarları
            double minX = yuzey.M.X;
            double maxX = yuzey.M.X + yuzey.En;
            double minY = yuzey.M.Y;
            double maxY = yuzey.M.Y + yuzey.Boy;
            double minZ = yuzey.M.Z;
            double maxZ = yuzey.M.Z + yuzey.Yukseklik;

            // Kürenin ve dikdörtgenin içinde mi kontrol et
            bool xUygun = kure.M.X + kure.R >= minX && kure.M.X - kure.R <= maxX;
            bool yUygun = kure.M.Y + kure.R >= minY && kure.M.Y - kure.R <= maxY;
            bool zUygun = kure.M.Z + kure.R >= minZ && kure.M.Z - kure.R <= maxZ;

            return xUygun && yUygun && zUygun;
        }
        public static bool DikdortgenPrizmaDikdortgenPrizmaCarpisma(dikdortgenPrizma prizma1, dikdortgenPrizma prizma2)
        {
            foreach (Yuzey yuzey1 in prizma1.Yuzeyler)
            {
                foreach (Yuzey yuzey2 in prizma2.Yuzeyler)
                {
                    if (DikdortgenDikdortgenCarpisma(yuzey1, yuzey2))
                        return true; // Çarpışma var
                }
            }

            return false; // Çarpışma yok
        }

        private static bool DikdortgenDikdortgenCarpisma(Yuzey Yuzey1, Yuzey Yuzey2)
        {
            // Dikdörtgenlerin kenarları
            double minX1 = Yuzey1.M.X;
            double maxX1 = Yuzey1.M.X + Yuzey1.En;
            double minY1 = Yuzey1.M.Y;
            double maxY1 = Yuzey1.M.Y + Yuzey1.Boy;
            double minZ1 = Yuzey1.M.Z;
            double maxZ1 = Yuzey1.M.Z + Yuzey1.Yukseklik;

            double minX2 = Yuzey2.M.X;
            double maxX2 = Yuzey2.M.X + Yuzey2.En;
            double minY2 = Yuzey2.M.Y;
            double maxY2 = Yuzey2.M.Y + Yuzey2.Boy;
            double minZ2 = Yuzey2.M.Z;
            double maxZ2 = Yuzey2.M.Z + Yuzey2.Yukseklik;

            // Çarpışma kontrolü
            bool xUygun = maxX1 >= minX2 && maxX2 >= minX1;
            bool yUygun = maxY1 >= minY2 && maxY2 >= minY1;
            bool zUygun = maxZ1 >= minZ2 && maxZ2 >= minZ1;

            return xUygun && yUygun && zUygun;
        }



    }
}
