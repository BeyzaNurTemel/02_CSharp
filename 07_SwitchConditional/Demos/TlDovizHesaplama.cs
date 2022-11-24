namespace _07_SwitchConditional.Demos
{
    public class TlDovizHesaplama
    {
        public static void Calistir()
        {
            /*
            Algoritma:
            1. başla
            2. kullanıcıdan TL cinsinden para girilmesi istenir
            3. kullanıcı para girer
            4. kullanıcıdan para birimi girilmesi istenir (Dolar: d, Euro: e, Pound: p)
            5.1 eğer para birimi dolar ise 
            5.2 kullanıcının girdiği parayı tanımlı olan dolar kuruna böl
            5.3 eğer para birimi euro ise
            5.4 kullacının girdiği parayı tanımlı olan euro kuruna böl
            5.5 eğer para birimi pound ise
            5.6 kullanıcının girdiği parayı tanımlı olan pound kuruna böl
            5.7 eğer para birimi dolar, euro ve pound değil ise
            5.8 kullanıcıdan doğru tanımlı para birimi girilmesi istenir
            6. işlem sonucu ekrana tarih ile birlikte yazdırılır
            7. bitir
            */

            #region If Else
            //double tl, dolar = 9.51, euro = 11.06, pound = 13.01, sonuc = -1;
            //string paraBirimi, tarih = "27 Ekim 2021";
            //Console.Write("TL cinsinden para giriniz: ");
            //tl = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Para birimi giriniz (Dolar: d, Euro: e, Pound: p): ");
            //paraBirimi = Console.ReadLine();
            ////if (paraBirimi != "d" && paraBirimi != "e" && paraBirimi != "p")
            //if (!(paraBirimi == "d" || paraBirimi == "e" || paraBirimi == "p"))
            //{
            //    Console.WriteLine("Dolar için d, euro için e veya pound için p girilmediğinden işleminiz yapılamadı!");
            //}
            //else  // paraBirimi == "d" || paraBirimi == "e" || paraBirimi == "p"
            //{
            //    if (paraBirimi == "d")
            //    {
            //        sonuc = tl / dolar;
            //    }
            //    else if (paraBirimi == "e")
            //    {
            //        sonuc = tl / euro;
            //    }
            //    else // paraBirimi == "p"
            //    {
            //        sonuc = tl / pound;
            //    }
            //}
            //if (sonuc != -1)
            //    Console.WriteLine("Tarih: " + tarih + "\nDöviz Sonucu: " + sonuc);
            //Console.ReadLine();
            #endregion

            #region Switch
            double tl;
            double dolar = 9.51;
            double euro = 11.06;
            double pound = 13.01;
            double sonuc;
            string paraBirimi;
            string tarih = "27 Ekim 2021";
            Console.Write("TL cinsinden para giriniz: ");
            tl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Para birimi giriniz (Dolar: d, Euro: e, Pound: p): ");
            paraBirimi = Console.ReadLine();
            switch (paraBirimi)
            {
                case "d":
                    sonuc = tl / dolar;
                    break;
                case "e":
                    sonuc = tl / euro;
                    break;
                case "p":
                    sonuc = tl / pound;
                    break;
                default:
                    sonuc = -1;
                    break;
            }
            if (sonuc == -1)
                Console.WriteLine("Dolar için d, euro için e veya pound için p girilmediğinden işleminiz yapılamadı!");
            else
                Console.WriteLine("Tarih: " + tarih + "\nDöviz Sonucu: " + sonuc);
            #endregion
        }
    }
}
