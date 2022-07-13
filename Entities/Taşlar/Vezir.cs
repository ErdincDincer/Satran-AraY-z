using SatrançAraYüz.Enums;
using SatrançAraYüz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrançAraYüz.Entities.Taşlar
{
    public class Vezir : ITaş
    {
        public TaşTipleri TaşTipleri { get => TaşTipleri.Vezir; }
        public TaşRenkleri TaşRenkleri { get; set; }
        public Lokasyon Lokasyon { get; set; }
        public string ResimYolu
        {
            get
            {
                if (this.TaşRenkleri == TaşRenkleri.Beyaz)
                    return @"C:\Users\erdin\Desktop\Images\vezir-beyaz.png";
                else return @"C:\Users\erdin\Desktop\Images\vezir-siyah.png";
            }
        }

        public void İlerle(Yön Yön)
        {
            if (Yön == Yön.Kuzey)
                Lokasyon.Y++;
            else if (Yön == Yön.Güney)
                Lokasyon.Y--;
            else if (Yön == Yön.Doğu)
                Lokasyon.X++;
            else if(Yön == Yön.Batı) Lokasyon.X--;
            else if (Yön == Yön.KuzeyDoğu)
            {
                Lokasyon.Y++;
                Lokasyon.X++;
            }
            else if (Yön == Yön.GüneyDoğu)
            {
                Lokasyon.Y--;
                Lokasyon.X++;
            }
            else if (Yön == Yön.GüneyBatı)
            {
                Lokasyon.Y--;
                Lokasyon.X--;
            }
            else //KuzeyBatı
            {
                Lokasyon.Y++;
                Lokasyon.X--;
            }
        }
    }
}
