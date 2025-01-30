using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        abstract class Kargo
        {
            public abstract int KacBirim { get; }
            public abstract string KargoSuresiGoster();
            public int KargoUcretiHesaplama(int kilometre)
            {
                return KacBirim * kilometre;
            }
            class HizliKargo : Kargo
            {
                public override int KacBirim => 5;
                public override string KargoSuresiGoster()
                {
                    return "Hızlı kargo teslimat süresi : 1-2 Gün.";
                }
            }
            class StandartKargo : Kargo
            {
                public override int KacBirim => 2;
                public override string KargoSuresiGoster()
                {
                    return "Standart kargo teslimat süresi : 3-5 Gün.";
                }
            }
            class EkonomikKargo : Kargo
            {
                public override int KacBirim => 1;
                public override string KargoSuresiGoster()
                {
                    return "Ekonomik kargo teslimat süresi : 5-10 Gün.";
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Lütfen kargo seçeneğini giriniz : 1-Hızlı Kargo / 2-Standart Kargo / 3-Ekonomik Kargo");
                int secim = int.Parse(Console.ReadLine());
                Console.WriteLine("Lütfen kilometreyi giriniz : ");
                int kilometre = int.Parse(Console.ReadLine());
                Kargo kargo;
                if (secim == 1) kargo = new HizliKargo();
                else if (secim == 2) kargo = new StandartKargo();
                else kargo = new EkonomikKargo();
                Console.WriteLine($"Kargo ücreti : {kargo.KargoUcretiHesaplama(kilometre)} Birimdir.");
                Console.WriteLine($"Teslim süresi : {kargo.KargoSuresiGoster()}");
            }
        }
    }
}
