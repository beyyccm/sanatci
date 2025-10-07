using System;
using System.Collections.Generic;
using System.Linq;

namespace SanatciLinqOrnek
{
    public class Sanatci
    {
        public string AdSoyad { get; set; }
        public string MuzikTuru { get; set; }
        public int CikisYili { get; set; }
        public int AlbumSatisi { get; set; } // milyon cinsinden
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Sanatci> sanatcilar = new List<Sanatci>
            {
                new Sanatci { AdSoyad = "Ajda Pekkan", MuzikTuru = "Pop", CikisYili = 1968, AlbumSatisi = 20 },
                new Sanatci { AdSoyad = "Sezen Aksu", MuzikTuru = "Türk Halk Müziği / Pop", CikisYili = 1975, AlbumSatisi = 20 },
                new Sanatci { AdSoyad = "Funda Arar", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatisi = 5 },
                new Sanatci { AdSoyad = "Sertab Erener", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatisi = 3 },
                new Sanatci { AdSoyad = "Sıla", MuzikTuru = "Pop", CikisYili = 2007, AlbumSatisi = 3 },
                new Sanatci { AdSoyad = "Serdar Ortaç", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatisi = 10 },
                new Sanatci { AdSoyad = "Tarkan", MuzikTuru = "Pop", CikisYili = 1992, AlbumSatisi = 15 },
                new Sanatci { AdSoyad = "Hande Yener", MuzikTuru = "Pop", CikisYili = 2000, AlbumSatisi = 5 },
                new Sanatci { AdSoyad = "Hadise", MuzikTuru = "Pop", CikisYili = 2005, AlbumSatisi = 1 },
                new Sanatci { AdSoyad = "Gülben Ergen", MuzikTuru = "Pop / Türk Halk Müziği", CikisYili = 1997, AlbumSatisi = 4 },
                new Sanatci { AdSoyad = "Müslüm Gürses", MuzikTuru = "Türk Halk Müziği / Türk Sanat Müziği", CikisYili = 1969, AlbumSatisi = 2 }
            };

            // 1. Adı 'S' ile başlayan şarkıcılar
            var sIleBaslayanlar = sanatcilar.Where(s => s.AdSoyad.StartsWith("S"));
            Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
            foreach (var s in sIleBaslayanlar)
                Console.WriteLine($"- {s.AdSoyad}");

            // 2. Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
            var onMilyonUstu = sanatcilar.Where(s => s.AlbumSatisi > 10);
            Console.WriteLine("\nAlbüm satışları 10 milyon'un üzerinde olanlar:");
            foreach (var s in onMilyonUstu)
                Console.WriteLine($"- {s.AdSoyad} ({s.AlbumSatisi} milyon)");

            // 3. 2000 yılı öncesi çıkış yapmış ve pop müzik yapanlar (gruplanmış ve alfabetik)
            var eskiPopcular = sanatcilar
                .Where(s => s.CikisYili < 2000 && s.MuzikTuru.Contains("Pop"))
                .OrderBy(s => s.CikisYili)
                .ThenBy(s => s.AdSoyad);
            Console.WriteLine("\n2000 yılı öncesi çıkış yapmış ve pop müzik yapanlar:");
            foreach (var s in eskiPopcular)
                Console.WriteLine($"- {s.CikisYili}: {s.AdSoyad}");

            // 4. En çok albüm satan şarkıcı
            var enCokSatan = sanatcilar.OrderByDescending(s => s.AlbumSatisi).First();
            Console.WriteLine($"\nEn çok albüm satan şarkıcı: {enCokSatan.AdSoyad} ({enCokSatan.AlbumSatisi} milyon)");

            // 5. En yeni ve en eski çıkış yapan şarkıcı
            var enYeni = sanatcilar.OrderByDescending(s => s.CikisYili).First();
            var enEski = sanatcilar.OrderBy(s => s.CikisYili).First();
            Console.WriteLine($"\nEn yeni çıkış yapan şarkıcı: {enYeni.AdSoyad} ({enYeni.CikisYili})");
            Console.WriteLine($"En eski çıkış yapan şarkıcı: {enEski.AdSoyad} ({enEski.CikisYili})");

            Console.WriteLine("\nProgram tamamlandı.");
        }
    }
}
