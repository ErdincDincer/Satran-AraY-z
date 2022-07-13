using SatrançAraYüz.Enums;
using SatrançAraYüz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrançAraYüz.Entities.Taşlar
{
    public class Kale : ITaş
    {
        public TaşTipleri TaşTipleri { get => TaşTipleri.Kale; }
        public TaşRenkleri TaşRenkleri { get; set; }
        public Lokasyon Lokasyon { get; set; }
        public string ResimYolu
        {
            get
            {
                if (this.TaşRenkleri == TaşRenkleri.Beyaz)
                    return @"C:\Users\erdin\Desktop\Images\kale-beyaz.png";
                else return @"C:\Users\erdin\Desktop\Images\kale-siyah.png";
            }
        }

        public void İlerle(Yön Yön)
        {
            if (Yön == Yön.Kuzey)
                Lokasyon.Y ++;
            else if (Yön == Yön.Güney)
                Lokasyon.Y--;
            else if (Yön == Yön.Doğu)
                Lokasyon.X++;
            else Lokasyon.X --; // Batı
        }
    }
}
