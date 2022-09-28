using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Eylül";
            ogrenci1.Soyisim = "Kaya";
            ogrenci1.OgrenciNo = 522;
            ogrenci1.Sinif = 3;
            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Yunus","Başer",227,1);
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();

        }

    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim
        {
            get { return soyisim; }
            set { soyisim = value; }
        }

        public int OgrenciNo
        {
            get { return ogrenciNo; }
            set { ogrenciNo = value; }
        }

        public int Sinif
        {
            get { return sinif; }

            set{
                    if(value < 1)
                    {
                        Console.WriteLine("Sınıf en az 1 olabilir!");
                        sinif = 1;
                    }
                    else 
                    {
                      sinif = value;
                    }
                    
            }
        }

        public Ogrenci() { }

        public Ogrenci(string isim, string soyisim, int ogrNo, int sinif)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.ogrenciNo = ogrNo;
            this.Sinif = sinif;
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*************** Ogrenci Bilgileri **********************");
            Console.WriteLine("Öğrencinin Adı: {0}",Isim);
            Console.WriteLine("Öğrencinin Soyadı: {0}",Soyisim);
            Console.WriteLine("Öğrencinin Örenci Numarası: {0}",OgrenciNo);
            Console.WriteLine("Öğrencinin Sınıfı: {0}",Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
