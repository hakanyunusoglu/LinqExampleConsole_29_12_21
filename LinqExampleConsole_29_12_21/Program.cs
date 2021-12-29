using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExampleConsole_29_12_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SanalDB db = new SanalDB();
            List<Musteri> mList = new List<Musteri>();
            int sayac = 0;
            //İsminin baş harfi A ile başlayan müşterilerin adedi (LİNQ KULLANIMI)

            foreach (var item in db.MusteriListesi().Where(x => x.Ulke.StartsWith("A")))
            {
                Console.WriteLine(item.MusteriNo);
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);
                Console.WriteLine(item.DogumTarihi);
                Console.WriteLine(item.Email);
                Console.WriteLine(item.TelNo);
                Console.WriteLine(item.Ulke);
                Console.WriteLine(item.Il);
                Console.WriteLine(item.Ilce);
                Console.WriteLine(" ");
                sayac++;
            }
            Console.WriteLine($"Ülke Adı 'A' harfi ile başlayan toplam {sayac} kayıt bulundu!");

            foreach (var item in db.MusteriListesi().Where(x => x.Ad.ToLower().Contains("b") && x.Ulke.ToLower().Contains("a")))
            {
                Console.WriteLine(item.MusteriNo);
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);
                Console.WriteLine(item.DogumTarihi);
                Console.WriteLine(item.Email);
                Console.WriteLine(item.TelNo);
                Console.WriteLine(item.Ulke);
                Console.WriteLine(item.Il);
                Console.WriteLine(item.Ilce);
                Console.WriteLine(" ");
                sayac++;
            }

            var bulunanmusteri = from M in db.MusteriListesi()
                                 where M.DogumTarihi.Year > 1990 && M.Ad.ToLower().Contains("a")
                                 select M;
            foreach(var item in bulunanmusteri)
            {
                Console.WriteLine(item.MusteriNo);
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);
                Console.WriteLine(item.DogumTarihi);
                Console.WriteLine(item.Email);
                Console.WriteLine(item.TelNo);
                Console.WriteLine(item.Ulke);
                Console.WriteLine(item.Il);
                Console.WriteLine(item.Ilce);
                Console.WriteLine(" ");
            }
            Console.WriteLine($"Toplam bulunan kayıt {bulunanmusteri.Count()}");
            

            //LİNQ Sorgulama Çeşitleri

            //int toplammusteri = db.MusteriListesi().Where(x => x.Ad.EndsWith("A")).Count();

            //var bulunanmusteri = from I in db.MusteriListesi()
            //                     where I.Ad.EndsWith("A")
            //                     select I;

            // 1: Müşteriler içerisinde ülke değeri A ile başlayan müşterileri LİNQ teknolojisi ile getir.
            // 2: Müşteriler içerisindeki kayıtlardan isminin içerisinde B harfi geçen ve ülke değeri içinde A harfi geçen kayıtları getir
            // 3: Müşteriler listesindeki kayıtlardan doğum yılı 1990 dan büyük olan ve isminin içerisinde A harfi geçen kayıtları linq query yöntemiyle getirin.
            //


            Console.ReadLine();

        }
    }
}
