using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExampleConsole_29_12_21
{
    internal class Program
    {
        static List<Musteri> mList = new List<Musteri>();
        static SanalDB db = new SanalDB();
        
        static void Main(string[] args)
        {  
            //int sayac = 0;
            //İsminin baş harfi A ile başlayan müşterilerin adedi (LİNQ KULLANIMI)

            //foreach (var item in db.MusteriListesi().Where(x => x.Ulke.StartsWith("A")))
            //{
            //    Console.WriteLine(item.MusteriNo);
            //    Console.WriteLine(item.Ad);
            //    Console.WriteLine(item.Soyad);
            //    Console.WriteLine(item.DogumTarihi);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine(item.TelNo);
            //    Console.WriteLine(item.Ulke);
            //    Console.WriteLine(item.Il);
            //    Console.WriteLine(item.Ilce);
            //    Console.WriteLine(" ");
            //    sayac++;
            //}
            //Console.WriteLine($"Ülke Adı 'A' harfi ile başlayan toplam {sayac} kayıt bulundu!");

            //foreach (var item in db.MusteriListesi().Where(x => x.Ad.ToLower().Contains("b") && x.Ulke.ToLower().Contains("a")))
            //{
            //    Console.WriteLine(item.MusteriNo);
            //    Console.WriteLine(item.Ad);
            //    Console.WriteLine(item.Soyad);
            //    Console.WriteLine(item.DogumTarihi);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine(item.TelNo);
            //    Console.WriteLine(item.Ulke);
            //    Console.WriteLine(item.Il);
            //    Console.WriteLine(item.Ilce);
            //    Console.WriteLine(" ");
            //    sayac++;
            //}
            //foreach (var item in db.MusteriListesi().Where(x => x.Ad.Contains("b") && x.Ulke.Contains("a")))
            //{
            //    Console.WriteLine(item.MusteriNo);
            //    Console.WriteLine(item.Ad);
            //    Console.WriteLine(item.Soyad);
            //    Console.WriteLine(item.DogumTarihi);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine(item.TelNo);
            //    Console.WriteLine(item.Ulke);
            //    Console.WriteLine(item.Il);
            //    Console.WriteLine(item.Ilce);
            //    Console.WriteLine(" ");
            //    sayac++;
            //}

            //var bulunanmusteri = from M in db.MusteriListesi()
            //                     where M.DogumTarihi.Year > 1990 && M.Ad.ToLower().Contains("a")
            //                     select M;
            //foreach(var item in bulunanmusteri)
            //{
            //    Console.WriteLine(item.MusteriNo);
            //    Console.WriteLine(item.Ad);
            //    Console.WriteLine(item.Soyad);
            //    Console.WriteLine(item.DogumTarihi);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine(item.TelNo);
            //    Console.WriteLine(item.Ulke);
            //    Console.WriteLine(item.Il);
            //    Console.WriteLine(item.Ilce);
            //    Console.WriteLine(" ");
            //}
            //Console.WriteLine($"Toplam bulunan kayıt {bulunanmusteri.Count()}");


            //LİNQ Sorgulama Çeşitleri

            //int toplammusteri = db.MusteriListesi().Where(x => x.Ad.EndsWith("A")).Count();

            //var bulunanmusteri = from I in db.MusteriListesi()
            //                     where I.Ad.EndsWith("A")
            //                     select I;

            //Func<Musteri, bool> funcdelegate = new Func<Musteri, bool>(FuncDelegateKullanimi);

            //var delegatekullanim2 = mList.Where(FuncDelegateKullanimi);
            //var delegatekullanim3 = mList.Where(new Func<Musteri, bool>(FuncDelegateKullanimi)); // Func delegate kullanımı
            //var delegatekullanim4 = mList.Where(delegate(Musteri mu) { return mu.Ad.StartsWith("A")? true : false; }); // Ternary kullanımı ? :
            //var delegatekullanim5 = mList.Where((Musteri m) => { return m.Ad.StartsWith("A") ? true : false; }); // Ternary kullanımı ? :
            //var delegatekullanim6 = mList.Where((m) => { return m.Ad.StartsWith("A") ? true: false; });  // Ternary kullanımı ? :
            //var delegatekullanim7 = mList.Where(m => m.Ad.StartsWith("A")); // Linq kullanımı


            //PREDICATE DELEGATE

            //Predicate<Musteri> predicate = new Predicate<Musteri>(PredicateKullanimi);


            //var predicateKullanimi01 = mList.FindAll(PredicateKullanimi);
            //var predicateKullanimi02 = mList.FindAll(new Predicate<Musteri>(PredicateKullanimi));
            //var predicateKullanimi03 = mList.FindAll(delegate(Musteri m) { return m.DogumTarihi.Year > 1990 ? true : false; });
            //var predicateKullanimi04 = mList.FindAll((Musteri m) => { return m.DogumTarihi.Year > 1990 ? true : false; });
            //var predicateKullanimi05 = mList.FindAll((m)=> { return m.DogumTarihi.Year > 1990 ? true : false; });
            //var predicateKullanimi06 = mList.FindAll(m => m.DogumTarihi.Year > 1990);





            Console.ReadLine();

        }
        //static bool FuncDelegateKullanimi(Musteri m)
        //{           
        //        if (m.Ad.StartsWith("A"))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //}

        //static bool PredicateKullanimi(Musteri m)
        //{
        //    if(m.DogumTarihi.Year > 1990)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
