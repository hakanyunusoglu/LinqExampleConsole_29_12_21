using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExampleConsole_29_12_21
{
    public class SanalDB
    {
        List<Musteri> musteriList;

        public SanalDB()
        {
            musteriList = new List<Musteri>();

        }
        public List<Musteri> MusteriListesi()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Musteri m = new Musteri();
                m.MusteriNo = i;
                m.Ad = FakeData.NameData.GetFirstName();
                m.Soyad = FakeData.NameData.GetSurname();
                m.DogumTarihi = FakeData.DateTimeData.GetDatetime(new DateTime(1990, 01, 01), new DateTime(1999, 01, 01));
                m.TelNo = FakeData.PhoneNumberData.GetPhoneNumber();
                m.Il = FakeData.PlaceData.GetCity();
                m.Ilce = FakeData.PlaceData.GetState();
                m.Ulke = FakeData.PlaceData.GetCounty();
                m.Email = String.Concat(m.Ad.ToLower(), ".", m.Soyad.ToLower(), "@", FakeData.NetworkData.GetDomain());

                musteriList.Add(m);
            }
            return musteriList;
        }
    }
}
