using SatrançAraYüz.Entities.Taşlar;
using SatrançAraYüz.Enums;
using SatrançAraYüz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatrançAraYüz.Entities
{
    public class Satranç
    {
        List<ITaş> tümTaşlarım;
        private PictureBox[] karelerim;
        int kareSayısı;
        public Satranç(List<ITaş> TümTaşlarım, PictureBox[] Karelerim, int KareSayısı)
        {
            tümTaşlarım = TümTaşlarım;
            karelerim = Karelerim;
            kareSayısı = KareSayısı;
        }
        public void TaşlarıHareketEttir()
        {
            Random random = new Random();

            Yön yön;

            foreach (ITaş taş in tümTaşlarım)
            {
                yön = YönBelirle(taş);

                int gidilecekKareSayısı = random.Next(1, kareSayısı - 1);

                for (int i = 0; i < gidilecekKareSayısı; i++)
                {
                    Lokasyon eskiLoklasyon = new Lokasyon();
                    eskiLoklasyon.X = taş.Lokasyon.X;
                    eskiLoklasyon.Y = taş.Lokasyon.Y;

                    taş.İlerle(yön);

                    Lokasyon yeniLokasyon = taş.Lokasyon;

                    if (yeniLokasyon.X > Tahta.SatrançTahtası.SatırSayısı - 1 || yeniLokasyon.X < 0 || yeniLokasyon.Y > Tahta.SatrançTahtası.SutunSayısı - 1 || yeniLokasyon.Y < 0)
                    {
                        taş.Lokasyon = eskiLoklasyon;
                        Yön yeniYön = yön;
                        while (yeniYön == yön)
                        {
                            yön = YönBelirle(taş);
                        }
                        i--;
                    }
                    else
                    {
                        string eskiLokasyonString = eskiLoklasyon.ToString();
                        foreach (PictureBox pb in karelerim)
                        {
                            if (pb.Name == eskiLokasyonString)
                            {
                                pb.ImageLocation = null;
                            }
                        }
                    }

                    foreach (PictureBox pb in karelerim)
                    {
                        if (pb.Name == taş.Lokasyon.ToString())
                        {
                            if (pb.ImageLocation != null)
                            {
                                taş.Lokasyon = eskiLoklasyon;
                                yön = (Yön)random.Next(0, 4);
                                i--;
                            }
                        }
                    }

                    TaşlarıTahtayaEkle();
                    Beklet();

                    if (taş.GetType() == typeof(Piyon) || taş.GetType() == typeof(At) || taş.GetType() == typeof(Şah))
                        break;
                }

            }
        }
        public void TaşlarıTahtayaEkle()
        {
            TahtayıTemizle();

            foreach (ITaş taş in tümTaşlarım)
            {
                Lokasyon lokasyon = taş.Lokasyon;
                string pictureBoxName = lokasyon.X.ToString() + lokasyon.Y.ToString();
                foreach (PictureBox pb in karelerim)
                {
                    if (pb.Name == pictureBoxName)
                        pb.ImageLocation = taş.ResimYolu;
                }
            }
        }
        private void TahtayıTemizle()
        {
            foreach (PictureBox pb in karelerim)
            {
                pb.ImageLocation = null;
            }
        }
        private Yön YönBelirle(ITaş taş)
        {
            Random random = new Random();
            if (taş.GetType() == typeof(Piyon) || taş.GetType() == typeof(At) || taş.GetType() == typeof(Kale))
            {
                return (Yön)random.Next(0, 4);
            }
            else if (taş.GetType() == typeof(Fil))
            {
                return (Yön)random.Next(4, 8);
            }
            else
            {
                return (Yön)random.Next(0, 8);
            }
        }
        private void Beklet()
        {
            Application.DoEvents();
            Thread.Sleep(1);
        }
        public static void TaşlarıTahtayaEkle(List<ITaş> TümTaşlarım, PictureBox[] Karelerim)
        {
            foreach (PictureBox pb in Karelerim)
            {
                pb.ImageLocation = null;
            }

            foreach (ITaş taş in TümTaşlarım)
            {
                Lokasyon lokasyon = taş.Lokasyon;
                string pictureBoxName = lokasyon.X.ToString() + lokasyon.Y.ToString();
                foreach (PictureBox pb in Karelerim)
                {
                    if (pb.Name == pictureBoxName)
                        pb.ImageLocation = taş.ResimYolu;
                }
            }
        }
    }
}
