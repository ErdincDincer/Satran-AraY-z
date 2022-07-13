using SatrançAraYüz.Entities.Taşlar;
using SatrançAraYüz.Enums;
using SatrançAraYüz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatrançAraYüz.Entities
{
    public class Tahta
    {
        

        public static int gv_kareSayısı;
        public List<ITaş> TümTaşlarım { get; set; }
        public Tahta()
        {
            TümTaşlarım = new List<ITaş>();
        }
        public Tahta(int lv_kareSayısı)
        {
            gv_kareSayısı = lv_kareSayısı;
            SatrançTahtası.SatırSayısı = lv_kareSayısı;
            SatrançTahtası.SutunSayısı = lv_kareSayısı;
            TümTaşlarım = new List<ITaş>();
        }

        public class SatrançTahtası
        {
            public static int SatırSayısı { get; set; }
            public static int SutunSayısı { get; set; }

            public static int LokasyonSayısı()
            {
                return (int)Math.Pow(Tahta.gv_kareSayısı, 2); // Hangisi Daha Hızlı Çalışır ? Tahta.gv_kareSayısı*Tahta.gv_kareSayısı
            }

            public static Lokasyon GetLokasyon(int x, int y)
            {
                Lokasyon lokasyon = new Lokasyon(x, y);
                return lokasyon;
            }
        }

        public void YeniTaşEkle(TaşTipleri taşTipleri, TaşRenkleri taşRenkleri, Lokasyon lokasyon)
        {
            switch (taşTipleri)
            {
                case TaşTipleri.At:
                    At at = new At();
                    at.TaşRenkleri = taşRenkleri;
                    at.Lokasyon = lokasyon;
                    TümTaşlarım.Add(at);
                    break;
                
                case TaşTipleri.Piyon:
                    Piyon piyon = new Piyon();
                    piyon.TaşRenkleri = taşRenkleri;
                    piyon.Lokasyon = lokasyon;
                    if (lokasyon.Y >= gv_kareSayısı / 2)
                        piyon.Yön = Yön.Güney;
                    else piyon.Yön = Yön.Kuzey;
                    TümTaşlarım.Add(piyon);
                    break;
                
                case TaşTipleri.Şah:
                    Şah şah = new Şah();
                    şah.TaşRenkleri = taşRenkleri;
                    şah.Lokasyon = lokasyon;
                    TümTaşlarım.Add(şah);
                    break;
                
                case TaşTipleri.Kale:
                    Kale kale = new Kale();
                    kale.TaşRenkleri = taşRenkleri;
                    kale.Lokasyon = lokasyon;
                    TümTaşlarım.Add(kale);
                    break;
                
                case TaşTipleri.Fil:
                    Fil fil = new Fil();
                    fil.TaşRenkleri = taşRenkleri;
                    fil.Lokasyon = lokasyon;
                    TümTaşlarım.Add(fil);
                    break;
                
                case TaşTipleri.Vezir:
                    Vezir vezir = new Vezir();
                    vezir.TaşRenkleri = taşRenkleri;
                    vezir.Lokasyon = lokasyon;
                    TümTaşlarım.Add(vezir);
                    break;
            }
        }
    }
}
