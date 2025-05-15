using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<T> ile öğrenci isimlerini tutalım
            List<string> ogrenciler = new List<string>
        {
            "Ahmet", "Mehmet", "Ayşe", "Fatma", "Ali", "Aylin"
        };

            Console.WriteLine("Tüm Öğrenciler:");
            foreach (var isim in ogrenciler)
                Console.WriteLine(isim);

            // LINQ ile 'A' harfi ile başlayan öğrencileri filtrele
            var aIleBaslayanlar = ogrenciler.Where(o => o.StartsWith("A")).ToList();

            Console.WriteLine("\nA ile başlayan öğrenciler:");
            foreach (var isim in aIleBaslayanlar)
                Console.WriteLine(isim);

            // Dictionary ile öğrenci - not eşlemesi
            Dictionary<string, int> notlar = new Dictionary<string, int>
        {
            {"Ahmet", 85},
            {"Mehmet", 90},
            {"Ayşe", 70},
            {"Fatma", 95},
            {"Ali", 60},
            {"Aylin", 80}
        };

            Console.WriteLine("\nÖğrenci Notları:");
            foreach (var entry in notlar)
                Console.WriteLine($"{entry.Key}: {entry.Value}");

            // LINQ ile 80 üzeri not alanları filtrele
            var basarili = notlar.Where(pair => pair.Value >= 80);

            Console.WriteLine("\nBaşarılı Öğrenciler:");
            foreach (var ogr in basarili)
                Console.WriteLine($"{ogr.Key} - Not: {ogr.Value}");
        }
    }
}
