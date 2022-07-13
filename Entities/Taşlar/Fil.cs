using SatrançAraYüz.Enums;
using SatrançAraYüz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrançAraYüz.Entities.Taşlar
{
    public class Fil : ITaş
    {
        public TaşTipleri TaşTipleri { get => TaşTipleri.Fil; }
        public TaşRenkleri TaşRenkleri {get;set;}
        public Lokasyon Lokasyon { get; set; }
        public string ResimYolu
        {
            get
            {
                if (this.TaşRenkleri == TaşRenkleri.Beyaz)
                    return @"C:\Users\erdin\Desktop\Images\fil-beyaz.png";
                else return @"C:\Users\erdin\Desktop\Images\fil-siyah.png";
            }
        }

        public void İlerle(Yön Yön)
        {
            if(Yön == Yön.KuzeyDoğu)
            {
                Lokasyon.Y++;
                Lokasyon.X++;
            }
            else if(Yön == Yön.GüneyDoğu)
            {
                Lokasyon.Y--;
                Lokasyon.X++;
            }
            else if(Yön == Yön.GüneyBatı)
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
