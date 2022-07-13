using SatrançAraYüz.Enums;
using SatrançAraYüz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrançAraYüz.Entities.Taşlar
{
    public class Piyon : ITaş
    {
        public TaşTipleri TaşTipleri { get => TaşTipleri.Piyon; }
        public TaşRenkleri TaşRenkleri { get; set; }
        public Lokasyon Lokasyon { get; set; }
        public string ResimYolu
        {
            get
            {
                if (this.TaşRenkleri == TaşRenkleri.Beyaz)
                    return @"C:\Users\erdin\Desktop\Images\piyon-beyaz.png";
                else return @"C:\Users\erdin\Desktop\Images\piyon-siyah.png";
            }
        }
        public Yön Yön { get; set; }

        public void İlerle(Yön yön)
        {
            yön = Yön;
            if (yön == Yön.Kuzey)
                Lokasyon.Y = Lokasyon.Y + 1;
            else if (yön == Yön.Güney)
                Lokasyon.Y = Lokasyon.Y - 1;
        }
    }
}
