/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2.Ödev
**				ÖĞRENCİ ADI............: Ali Halit ÖRNEK
**				ÖĞRENCİ NUMARASI.......: B231210385
**              DERSİN ALINDIĞI GRUP...: B
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int xKoorA = 0, yKoorA = 0, zKoorA = 0;
        int xKoorB = 0, yKoorB = 0, zKoorB = 0;
        int xUzunlukA = 0, yUzunlukA = 0, zUzunlukA = 0;
        int xUzunlukB = 0, yUzunlukB = 0, zUzunlukB = 0;


        // Çizim işlemlerinin gerçekleştiği bölüm
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen kalem = new Pen(Color.Red);
            Pen kalem2 = new Pen(Color.Blue);
            Brush fırca1 = new SolidBrush(Color.Blue);
            Brush fırca2 = new SolidBrush(Color.Red);

            e.Graphics.DrawLine(kalem, 150, 50, 150, 1600);
            e.Graphics.DrawLine(kalem, 150, 50, 1600, 50);

            switch (comboBox1.SelectedIndex) 
            {
                case 0:
                    cisim1.Text = "Nokta";
                    cisim2.Text = "Dörtgen";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = true;
                    Xuzunluk1.ReadOnly = true;
                    Yuzunluk1.ReadOnly = true;
                    Zuzunluk1.ReadOnly = true;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = true;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = false;
                    Zuzunluk2.ReadOnly = true;
                    e.Graphics.FillRectangle(fırca1, new Rectangle(xKoorA+150, yKoorA+50, 1, 1));//nokta
                    e.Graphics.FillRectangle(fırca2, new Rectangle(xKoorB+150, yKoorB+50, xUzunlukB, yUzunlukB));//dikdörtgen
                    break;
                case 1:
                    cisim1.Text = "Nokta";
                    cisim2.Text = "Çember";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = true;
                    Xuzunluk1.ReadOnly = true;
                    Yuzunluk1.ReadOnly = true;
                    Zuzunluk1.ReadOnly = true;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = true;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = true;
                    Zuzunluk2.ReadOnly = true;

                    // Textbox boş iken hata vermesin diye try yazıldı
                    try
                    {
                        e.Graphics.FillRectangle(fırca1, new Rectangle(xKoorA + 150, yKoorA + 50, 1, 1));//nokta
                        e.Graphics.FillEllipse(fırca2, new Rectangle(xKoorB + 150 - Convert.ToInt32(Xuzunluk2.Text) / 2, yKoorB + 50 - Convert.ToInt32(Xuzunluk2.Text) / 2, xUzunlukB, xUzunlukB));//Çember
                    }
                    catch { }
                    break;
                case 2:
                    cisim1.Text = "Dikdörtgen";
                    cisim2.Text = "Dikdörtgen";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = true;
                    Xuzunluk1.ReadOnly = false;
                    Yuzunluk1.ReadOnly = false;
                    Zuzunluk1.ReadOnly = true;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = true;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = false;
                    Zuzunluk2.ReadOnly = true;
                    e.Graphics.FillRectangle(fırca1, new Rectangle(xKoorA + 150, yKoorA + 50, xUzunlukA, yUzunlukA));//Dikdörtgen
                    e.Graphics.FillRectangle(fırca2, new Rectangle(xKoorB + 150, yKoorB + 50, xUzunlukB, yUzunlukB));//Dikdörtgen
                    break;
                case 3:
                    cisim1.Text = "Dikdörtgen";
                    cisim2.Text = "Çember";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = true;
                    Xuzunluk1.ReadOnly = false;
                    Yuzunluk1.ReadOnly = false;
                    Zuzunluk1.ReadOnly = true;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = true;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = true;
                    Zuzunluk2.ReadOnly = true;

                    // Textbox boş iken hata vermesin diye try yazıldı
                    try
                    {
                        e.Graphics.FillRectangle(fırca1, new Rectangle(xKoorA + 150, yKoorA + 50, xUzunlukA, yUzunlukA));//Dikdörtgen
                        e.Graphics.FillEllipse(fırca2, new Rectangle(xKoorB + 150 - Convert.ToInt32(Xuzunluk2.Text) / 2, yKoorB + 50 - Convert.ToInt32(Xuzunluk2.Text) / 2, xUzunlukB, xUzunlukB));//Çember
                    }
                    catch { }
                    
                    break;
                case 4:
                    cisim1.Text = "Çember";
                    cisim2.Text = "Çember";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = true;
                    Xuzunluk1.ReadOnly = false;
                    Yuzunluk1.ReadOnly = true;
                    Zuzunluk1.ReadOnly = true;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = true;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = true;
                    Zuzunluk2.ReadOnly = true;

                    // Textbox boş iken hata vermesin diye try yazıldı
                    try
                    {// Çapın(x uzunluğunun) yarısı kadar çıkartarak çizimin merkezden başlamasını sağlıyorum yoksa sol üst köşeden(sanki merkez orası gibi) başladığı için ekranda tutarsız çizimler oluşuyordu(aslında çizimin merkezini sol üst köşeye taşıdım)
                        e.Graphics.FillEllipse(fırca1, new Rectangle(xKoorA + 150 - Convert.ToInt32(Xuzunluk1.Text)/2, yKoorA + 50 - Convert.ToInt32(Xuzunluk1.Text)/2, xUzunlukA, xUzunlukA));//Çember
                        e.Graphics.FillEllipse(fırca2, new Rectangle(xKoorB + 150 - Convert.ToInt32(Xuzunluk2.Text)/2, yKoorB + 50 - Convert.ToInt32(Xuzunluk2.Text)/2, xUzunlukB, xUzunlukB));//Çember
                    }
                    catch { }
                    break;
                case 5:
                    cisim1.Text = "Nokta";
                    cisim2.Text = "Küre";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = false;
                    Xuzunluk1.ReadOnly = true;
                    Yuzunluk1.ReadOnly = true;
                    Zuzunluk1.ReadOnly = true;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = false;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = true;
                    Zuzunluk2.ReadOnly = true;
                    try
                    {
                        e.Graphics.FillRectangle(fırca1, new Rectangle(xKoorA + 150, yKoorA + 50, 1, 1));//nokta
                        e.Graphics.FillEllipse(fırca2, new Rectangle(xKoorB + 150 - Convert.ToInt32(Xuzunluk2.Text) / 2, yKoorB + 50 - Convert.ToInt32(Xuzunluk2.Text) / 2, xUzunlukB, xUzunlukB));//küre
                    }
                    catch { }
                    break;
                case 6:
                    cisim1.Text = "Nokta";
                    cisim2.Text = "D. Prizma";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = false;
                    Xuzunluk1.ReadOnly = true;
                    Yuzunluk1.ReadOnly = true;
                    Zuzunluk1.ReadOnly = true;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = false;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = false;
                    Zuzunluk2.ReadOnly = false;
                    try
                    {
                        e.Graphics.FillRectangle(fırca1, new Rectangle(xKoorA + 150, yKoorA + 50, 1, 1));//nokta
                        e.Graphics.FillRectangle(fırca2, new Rectangle(xKoorB + 150, yKoorB + 50, xUzunlukB, yUzunlukB));//DikdörtgenPrizma
                    }
                    catch { }
                    break;
                case 7:
                    cisim1.Text = "Nokta";
                    cisim2.Text = "Silindir";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = false;
                    Xuzunluk1.ReadOnly = true;
                    Yuzunluk1.ReadOnly = true;
                    Zuzunluk1.ReadOnly = true;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = false;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = true;
                    Zuzunluk2.ReadOnly = false;
                    try
                    {
                        e.Graphics.FillRectangle(fırca1, new Rectangle(xKoorA + 150, yKoorA + 50, 1, 1));//nokta
                        e.Graphics.FillEllipse(fırca2, new Rectangle(xKoorB + 150 - Convert.ToInt32(Xuzunluk2.Text) / 2, yKoorB + 50 - Convert.ToInt32(Xuzunluk2.Text) / 2, xUzunlukB, xUzunlukB));//silindir
                    }
                    catch { }
                    break;
                case 8:
                    cisim1.Text = "Silindir";
                    cisim2.Text = "Silindir";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = false;
                    Xuzunluk1.ReadOnly = false;
                    Yuzunluk1.ReadOnly = false;
                    Zuzunluk1.ReadOnly = false;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = false;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = true;
                    Zuzunluk2.ReadOnly = false;
                    try
                    {
                        e.Graphics.FillEllipse(fırca1, new Rectangle(xKoorA + 150 - Convert.ToInt32(Xuzunluk1.Text) / 2, yKoorA + 50 - Convert.ToInt32(Xuzunluk1.Text) / 2, xUzunlukA, xUzunlukA));//silindir
                        e.Graphics.FillEllipse(fırca2, new Rectangle(xKoorB + 150 - Convert.ToInt32(Xuzunluk2.Text) / 2, yKoorB + 50 - Convert.ToInt32(Xuzunluk2.Text) / 2, xUzunlukB, xUzunlukB));//silindir
                    }
                    catch { }
                    break;
                case 9:
                    cisim1.Text = "Kure";
                    cisim2.Text = "Kure";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = false;
                    Xuzunluk1.ReadOnly = false;
                    Yuzunluk1.ReadOnly = true;
                    Zuzunluk1.ReadOnly = true;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = false;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = true;
                    Zuzunluk2.ReadOnly = true;
                    try
                    {
                        e.Graphics.FillEllipse(fırca1, new Rectangle(xKoorA + 150 - Convert.ToInt32(Xuzunluk1.Text) / 2, yKoorA + 50 - Convert.ToInt32(Xuzunluk1.Text) / 2, xUzunlukA, xUzunlukA));//silindir
                        e.Graphics.FillEllipse(fırca2, new Rectangle(xKoorB + 150 - Convert.ToInt32(Xuzunluk2.Text) / 2, yKoorB + 50 - Convert.ToInt32(Xuzunluk2.Text) / 2, xUzunlukB, xUzunlukB));//silindir
                    }
                    catch { }
                    break;
                case 10:
                    cisim1.Text = "Kure";
                    cisim2.Text = "Silindir";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = false;
                    Xuzunluk1.ReadOnly = false;
                    Yuzunluk1.ReadOnly = true;
                    Zuzunluk1.ReadOnly = true;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = false;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = true;
                    Zuzunluk2.ReadOnly = false;
                    try
                    {
                        e.Graphics.FillEllipse(fırca1, new Rectangle(xKoorA + 150 - Convert.ToInt32(Xuzunluk1.Text) / 2, yKoorA + 50 - Convert.ToInt32(Xuzunluk1.Text) / 2, xUzunlukA, xUzunlukA));//Küre
                        e.Graphics.FillEllipse(fırca2, new Rectangle(xKoorB + 150 - Convert.ToInt32(Xuzunluk2.Text) / 2, yKoorB + 50 - Convert.ToInt32(Xuzunluk2.Text) / 2, xUzunlukB, xUzunlukB));//silindir
                    }
                    catch { }
                    break;
                case 11:
                    cisim1.Text = "Yuzey";
                    cisim2.Text = "Kure";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = false;
                    Xuzunluk1.ReadOnly = false;
                    Yuzunluk1.ReadOnly = true;
                    Zuzunluk1.ReadOnly = false;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = false;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = true;
                    Zuzunluk2.ReadOnly = true;
                    try
                    {
                        e.Graphics.DrawLine(kalem2, xKoorA + 150, yKoorA + 50, xKoorA + 150 + xUzunlukA, yKoorA + 50);//yüzey
                        e.Graphics.FillEllipse(fırca2, new Rectangle(xKoorB + 150 - Convert.ToInt32(Xuzunluk2.Text) / 2, yKoorB + 50 - Convert.ToInt32(Xuzunluk2.Text) / 2, xUzunlukB, xUzunlukB));//küre
                    }
                    catch { }
                    break;
                case 12:
                    cisim1.Text = "Yuzey";
                    cisim2.Text = "D. Prizma";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = false;
                    Xuzunluk1.ReadOnly = false;
                    Yuzunluk1.ReadOnly = true;
                    Zuzunluk1.ReadOnly = false;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = false;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = false;
                    Zuzunluk2.ReadOnly = false;
                    try
                    {
                        e.Graphics.DrawLine(kalem2, xKoorA + 150, yKoorA + 50, xKoorA + 150 + xUzunlukA, yKoorA + 50);//yüzey
                        e.Graphics.FillRectangle(fırca2, new Rectangle(xKoorB + 150, yKoorB + 50, xUzunlukB, yUzunlukB));//DikdörtgenPrizma
                    }
                    catch { }
                    break;
                case 13:
                    cisim1.Text = "Yuzey";
                    cisim2.Text = "Silindir";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = false;
                    Xuzunluk1.ReadOnly = false;
                    Yuzunluk1.ReadOnly = true;
                    Zuzunluk1.ReadOnly = false;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = false;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = true;
                    Zuzunluk2.ReadOnly = false;
                    try
                    {
                        e.Graphics.DrawLine(kalem2, xKoorA + 150, yKoorA + 50, xKoorA + 150 + xUzunlukA, yKoorA + 50);//yüzey
                        e.Graphics.FillEllipse(fırca2, new Rectangle(xKoorB + 150 - Convert.ToInt32(Xuzunluk2.Text) / 2, yKoorB + 50 - Convert.ToInt32(Xuzunluk2.Text) / 2, xUzunlukB, xUzunlukB));//silindir
                    }
                    catch { }
                    break;
                case 14:
                    cisim1.Text = "Kure";
                    cisim2.Text = "D. Prizma";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = false;
                    Xuzunluk1.ReadOnly = false;
                    Yuzunluk1.ReadOnly = true;
                    Zuzunluk1.ReadOnly = true;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = false;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = false;
                    Zuzunluk2.ReadOnly = false;
                    try
                    {
                        e.Graphics.FillEllipse(fırca1, new Rectangle(xKoorA + 150 - Convert.ToInt32(Xuzunluk1.Text) / 2, yKoorA + 50 - Convert.ToInt32(Xuzunluk1.Text) / 2, xUzunlukA, xUzunlukA));//Küre
                        e.Graphics.FillRectangle(fırca2, new Rectangle(xKoorB + 150, yKoorB + 50, xUzunlukB, yUzunlukB));//DikdörtgenPrizma
                    }
                    catch { }
                    break;
                case 15:
                    cisim1.Text = "D. Prizma";
                    cisim2.Text = "D. Prizma";
                    Xkoor1.ReadOnly = false;
                    Ykoor1.ReadOnly = false;
                    Zkoor1.ReadOnly = false;
                    Xuzunluk1.ReadOnly = false;
                    Yuzunluk1.ReadOnly = false;
                    Zuzunluk1.ReadOnly = false;
                    Xkoor2.ReadOnly = false;
                    Ykoor2.ReadOnly = false;
                    Zkoor2.ReadOnly = false;
                    Xuzunluk2.ReadOnly = false;
                    Yuzunluk2.ReadOnly = false;
                    Zuzunluk2.ReadOnly = false;
                    try
                    {
                        e.Graphics.FillRectangle(fırca1, new Rectangle(xKoorA + 150, yKoorA + 50, xUzunlukA, yUzunlukA));//DikdörtgenPrizma
                        e.Graphics.FillRectangle(fırca2, new Rectangle(xKoorB + 150, yKoorB + 50, xUzunlukB, yUzunlukB));//DikdörtgenPrizma
                    }
                    catch { }
                    break;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonçiz_Click(object sender, EventArgs e )
        {
            // Boş bırakılan yerleri 0 yapar
            if (Xkoor1.Text == "")
                Xkoor1.Text = "0";
            if (Ykoor1.Text == "")
                Ykoor1.Text = "0";
            if (Zkoor1.Text == "")
                Zkoor1.Text = "0";
            if (Xuzunluk1.Text == "")
                Xuzunluk1.Text = "0";
            if (Yuzunluk1.Text == "")
                Yuzunluk1.Text = "0";
            if (Zuzunluk1.Text == "")
                Zuzunluk1.Text = "0";

            if (Xkoor2.Text == "")
                Xkoor2.Text = "0";
            if (Ykoor2.Text == "")
                Ykoor2.Text = "0";
            if (Zkoor2.Text == "")
                Zkoor2.Text = "0";
            if (Xuzunluk2.Text == "")
                Xuzunluk2.Text = "0";
            if (Yuzunluk2.Text == "")
                Yuzunluk2.Text = "0";
            if (Zuzunluk2.Text == "")
                Zuzunluk2.Text = "0";

            // Text ifadeleri daha kolay yazılması açısından burada sayıya dönüştürüyoruz
            xKoorA = Convert.ToInt32(Xkoor1.Text);
            yKoorA = Convert.ToInt32(Ykoor1.Text);
            zKoorA = Convert.ToInt32(Zkoor1.Text);
            xUzunlukA = Convert.ToInt32(Xuzunluk1.Text);
            yUzunlukA = Convert.ToInt32(Yuzunluk1.Text);
            zUzunlukA = Convert.ToInt32(Zuzunluk1.Text);
            xKoorB = Convert.ToInt32(Xkoor2.Text);
            yKoorB = Convert.ToInt32(Ykoor2.Text);
            zKoorB = Convert.ToInt32(Zkoor2.Text);
            xUzunlukB = Convert.ToInt32(Xuzunluk2.Text);
            yUzunlukB = Convert.ToInt32(Yuzunluk2.Text);
            zUzunlukB = Convert.ToInt32(Zuzunluk2.Text);

            switch (comboBox1.SelectedIndex)
            {
                case 0://Nokta Dikdörtgen çarpışmasını kontrol et
                    if(Carpisma.NoktaDikdortgenCarpisma(new point(xKoorA + 150, yKoorA + 50), new Yuzey(new point3d(xKoorB + 150, yKoorB + 50,0), xUzunlukB, yUzunlukB ,0)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 1://Nokta Çember çarpışmasını kontrol et
                    if (Carpisma.NoktaCemberCarpisma(new point(xKoorA + 150, yKoorA + 50), new circle(new point(xKoorB + 150, yKoorB + 50), xUzunlukB / 2)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 2://Dikdörtgen Dikdörtgen çarpışmasını kontrol et
                    if (Carpisma.dikdortgenCarp(new dikdortgen(new point(xKoorA + 150, yKoorA + 50), xUzunlukA, yUzunlukA), new dikdortgen(new point(xKoorB + 150, yKoorB + 50), xUzunlukB, yUzunlukB)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 3://Dikdörtgen Çember çarpışmasını kontrol et
                    if (Carpisma.DikdortgenCemberCarp(new dikdortgen(new point(xKoorA + 150, yKoorA + 50), xUzunlukA, yUzunlukA), new circle(new point(xKoorB + 150, yKoorB + 50), xUzunlukB)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 4://Çember Çember çarpışmasını kontrol et
                    if (Carpisma.circleCarp(new circle(new point(xKoorA + 150, yKoorA + 50), xUzunlukA/2), new circle(new point(xKoorB + 150, yKoorB + 50), xUzunlukB/2)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 5://Nokta Küre çarpışmasını kontrol et
                    if (Carpisma.NoktaKureCarpisma(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), new kure(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 6://Nokta Dikdörtgenprizma çarpışmasını kontrol et
                    if (Carpisma.NoktaDikdortgenPrizmaCarpisma(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), new dikdortgenPrizma(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB, yUzunlukB, zUzunlukB)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 7://Nokta Silindir çarpışmasını kontrol et
                    if (Carpisma.NoktaSilindirCarpisma(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), new cylender(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2, zUzunlukB)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 8://Silindir Silindir çarpışmasını kontrol et
                    if (Carpisma.cylenderCarp(new cylender(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA / 2, zUzunlukA), new cylender(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2, zUzunlukB)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 9://Küre Küre çarpışmasını kontrol et
                    if (Carpisma.kureCarp(new kure(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA / 2), new kure(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 10://Küre Silindir çarpışmasını kontrol et
                    if (Carpisma.KureSilindirCarpisma(new kure(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA / 2), new cylender(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2, zUzunlukB)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 11://Yüzey Küre çarpışmasını kontrol et
                    if (Carpisma.YuzeyKureCarpisma(new Yuzey(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA , yUzunlukA , zUzunlukA), new kure(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 12://Yüzey Dikdörtgenprizma çarpışmasını kontrol et
                    if (Carpisma.YuzeyDikdortgenPrizmaCarpisma(new Yuzey(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA, yUzunlukA, zUzunlukA), new dikdortgenPrizma(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB , yUzunlukB, zUzunlukB)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 13://Yüzey Silindir çarpışmasını kontrol et
                    if (Carpisma.YuzeySilindirCarpisma(new Yuzey(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA, yUzunlukA, zUzunlukA), new cylender(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2, zUzunlukB)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 14://Küre Dikdörtgenprizma çarpışmasını kontrol et
                    if (Carpisma.KureDikdortgenPrizmaCarpisma(new kure(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA / 2), new dikdortgenPrizma(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB, yUzunlukB, zUzunlukB)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
                case 15://Dikdörtgenprizma Dikdörtgenprizma çarpışmasını kontrol et
                    if (Carpisma.DikdortgenPrizmaDikdortgenPrizmaCarpisma(new dikdortgenPrizma(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA, yUzunlukA, zUzunlukA), new dikdortgenPrizma(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB, yUzunlukB, zUzunlukB)))
                    { labelÇarpışma.Text = "Çarpışma Var"; }
                    else
                    { labelÇarpışma.Text = "Çarpışma Yok"; }
                    break;
            }

            
            this.Invalidate(); // Görünümünün yeniden çizilmesini sağlar
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Sol fare düğmesi basılıysa
            {
                // Koorinatlar canlı olarak değişiyor
                Xkoor1.Text = Convert.ToString(e.X-150);
                Ykoor1.Text = Convert.ToString(e.Y-50);

                // Konum canlı olarak değişiyor
                xKoorA = e.X - 150;
                yKoorA = e.Y - 50;

                switch (comboBox1.SelectedIndex)
                {
                    case 0://Nokta Dikdörtgen çarpışmasını kontrol et
                        if (Carpisma.NoktaDikdortgenCarpisma(new point(xKoorA + 150, yKoorA + 50), new Yuzey(new point3d(xKoorB + 150, yKoorB + 50, 0), xUzunlukB, yUzunlukB, 0)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 1://Nokta Çember çarpışmasını kontrol et
                        if (Carpisma.NoktaCemberCarpisma(new point(xKoorA + 150, yKoorA + 50), new circle(new point(xKoorB + 150, yKoorB + 50), xUzunlukB / 2)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 2://Dikdörtgen Dikdörtgen çarpışmasını kontrol et
                        if (Carpisma.dikdortgenCarp(new dikdortgen(new point(xKoorA + 150, yKoorA + 50), xUzunlukA, yUzunlukA), new dikdortgen(new point(xKoorB + 150, yKoorB + 50), xUzunlukB, yUzunlukB)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 3://Dikdörtgen Çember çarpışmasını kontrol et
                        if (Carpisma.DikdortgenCemberCarp(new dikdortgen(new point(xKoorA + 150, yKoorA + 50), xUzunlukA, yUzunlukA), new circle(new point(xKoorB + 150, yKoorB + 50), xUzunlukB)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 4://Çember Çember çarpışmasını kontrol et
                        if (Carpisma.circleCarp(new circle(new point(xKoorA + 150, yKoorA + 50), xUzunlukA / 2), new circle(new point(xKoorB + 150, yKoorB + 50), xUzunlukB / 2)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 5://Nokta Küre çarpışmasını kontrol et
                        if (Carpisma.NoktaKureCarpisma(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), new kure(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 6://Nokta Dikdörtgenprizma çarpışmasını kontrol et
                        if (Carpisma.NoktaDikdortgenPrizmaCarpisma(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), new dikdortgenPrizma(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB, yUzunlukB, zUzunlukB)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 7://Nokta Silindir çarpışmasını kontrol et
                        if (Carpisma.NoktaSilindirCarpisma(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), new cylender(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2, zUzunlukB)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 8://Silindir Silindir çarpışmasını kontrol et
                        if (Carpisma.cylenderCarp(new cylender(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA / 2, zUzunlukA), new cylender(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2, zUzunlukB)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 9://Küre Küre çarpışmasını kontrol et
                        if (Carpisma.kureCarp(new kure(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA / 2), new kure(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 10://Küre Silindir çarpışmasını kontrol et
                        if (Carpisma.KureSilindirCarpisma(new kure(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA / 2), new cylender(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2, zUzunlukB)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 11://Yüzey Küre çarpışmasını kontrol et
                        if (Carpisma.YuzeyKureCarpisma(new Yuzey(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA, yUzunlukA, zUzunlukA), new kure(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 12://Yüzey Dikdörtgenprizma çarpışmasını kontrol et
                        if (Carpisma.YuzeyDikdortgenPrizmaCarpisma(new Yuzey(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA, yUzunlukA, zUzunlukA), new dikdortgenPrizma(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB, yUzunlukB, zUzunlukB)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 13://Yüzey Silindir çarpışmasını kontrol et
                        if (Carpisma.YuzeySilindirCarpisma(new Yuzey(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA, yUzunlukA, zUzunlukA), new cylender(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB / 2, zUzunlukB)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 14://Küre Dikdörtgenprizma çarpışmasını kontrol et
                        if (Carpisma.KureDikdortgenPrizmaCarpisma(new kure(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA / 2), new dikdortgenPrizma(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB, yUzunlukB, zUzunlukB)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                    case 15://Dikdörtgenprizma Dikdörtgenprizma çarpışmasını kontrol et
                        if (Carpisma.DikdortgenPrizmaDikdortgenPrizmaCarpisma(new dikdortgenPrizma(new point3d(xKoorA + 150, yKoorA + 50, zKoorA), xUzunlukA, yUzunlukA, zUzunlukA), new dikdortgenPrizma(new point3d(xKoorB + 150, yKoorB + 50, zKoorB), xUzunlukB, yUzunlukB, zUzunlukB)))
                        { labelÇarpışma.Text = "Çarpışma Var"; }
                        else
                        { labelÇarpışma.Text = "Çarpışma Yok"; }
                        break;
                }

                this.Invalidate();
            }
        }
        private void Xkoor1_Click(object sender, EventArgs e)
        {
            Xkoor1.Text = "";// Tıklandığında alanı temizler
        }

        private void Ykoor1_Click(object sender, EventArgs e)
        {
            Ykoor1.Text = "";// Tıklandığında alanı temizler
        }

        private void Zkoor1_Click(object sender, EventArgs e)
        {
            Zkoor1.Text = "";// Tıklandığında alanı temizler
        }

        private void Xuzunluk1_Click(object sender, EventArgs e)
        {
            Xuzunluk1.Text = "";// Tıklandığında alanı temizler
        }

        private void Xkoor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }

        private void Ykoor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }

        private void Zkoor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }

        private void Xuzunluk1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }

        private void Yuzunluk1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }

        private void Zuzunluk1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }

        private void Xkoor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }

        private void Ykoor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }

        private void Zkoor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }

        private void Xuzunluk2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }

        private void Yuzunluk2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }

        private void Zuzunluk2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }
        


        private void Yuzunluk1_Click(object sender, EventArgs e)
        {
            Yuzunluk1.Text = "";
        }

        private void Zuzunluk1_Click(object sender, EventArgs e)
        {
            Zuzunluk1.Text = "";
        }

        private void Xkoor2_Click(object sender, EventArgs e)
        {
            Xkoor2.Text = "";
        }

        private void Ykoor2_Click(object sender, EventArgs e)
        {
            Ykoor2.Text = "";
        }

        private void Zkoor2_Click(object sender, EventArgs e)
        {
            Zkoor2.Text = "";
        }

        private void Xuzunluk2_Click(object sender, EventArgs e)
        {
            Xuzunluk2.Text = "";
        }

        private void Yuzunluk2_Click(object sender, EventArgs e)
        {
            Yuzunluk2.Text = "";
        }

        private void Zuzunluk2_Click(object sender, EventArgs e)
        {
            Zuzunluk2.Text = "";
        }
    }
}
