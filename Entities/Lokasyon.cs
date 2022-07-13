using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrançAraYüz.Entities
{
    public class Lokasyon
    {
        public Lokasyon() { }
        public Lokasyon(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public Color Renk
        {
            get
            {
                if (X % 2 == 0)
                {
                    if (Y % 2 == 0)
                        return Color.White;
                    else return Color.Black;
                }
                else
                    if (Y % 2 == 0)
                    return Color.Black;
                else return Color.White;
            }
        }

        public override string ToString()
        {
            return X.ToString()+ Y.ToString();
        }
    }
}
