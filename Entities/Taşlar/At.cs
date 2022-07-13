using SatrançAraYüz.Enums;
using SatrançAraYüz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrançAraYüz.Entities.Taşlar
{
    public class At : ITaş
    {
        public TaşTipleri TaşTipleri { get => TaşTipleri.At; }
        public TaşRenkleri TaşRenkleri { get; set; }
        public Lokasyon Lokasyon { get; set; }
        public string ResimYolu
        {
            get
            {
                if (this.TaşRenkleri == TaşRenkleri.Beyaz)
                    return @"C:\Users\erdin\Desktop\Images\at-beyaz.png";
                else return @"C:\Users\erdin\Desktop\Images\at-siyah.png";
            }
        }

        public void İlerle(Yön Yön)
        {
            int[] yönDeger = new int[2] { -1, 1 };
            Random rnd = new Random();
            int index = rnd.Next(0, 2);

            if (Yön == Yön.Kuzey)
            {
                Lokasyon.Y += 2;
                Lokasyon.X += yönDeger[index];
            }
            else if (Yön == Yön.Güney)
            {
                Lokasyon.Y -= 2;
                Lokasyon.X += yönDeger[index];
            }
            else if (Yön == Yön.Doğu)
            {
                Lokasyon.X += 2;
                Lokasyon.Y += yönDeger[index];
            }
            else // Yön.Batı
            {
                Lokasyon.X -= 2;
                Lokasyon.Y += yönDeger[index];
            }


        }
    }
}
