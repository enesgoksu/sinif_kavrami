namespace sinif_kavrami.sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            // {
            //     // [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            //     // [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //     // {
                        // Metot Komutları
            //     // }
            // }

            // Erişim Belirleyiciler
            // # Public
            // # Private
            // # İnternal
            // # Protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 23415634;
            calisan1.Deparman = "İnsan Kaynakları";

            calisan1.CalisanBilgileri();
            
            Console.WriteLine("********************");
            
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 54789625;
            calisan2.Deparman = "Satın Alma";

            calisan2.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Deparman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan Numarası:{0}",No);
            Console.WriteLine("Çalışan Departmanı:{0}",Deparman);
        }
    }
}