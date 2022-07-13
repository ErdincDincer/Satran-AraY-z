using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SatrançAraYüz.Dialogs;
using SatrançAraYüz.Entities;
using SatrançAraYüz.Entities.Taşlar;
using SatrançAraYüz.Enums;
using SatrançAraYüz.Interfaces;

namespace SatrançAraYüz.Forms
{
    public partial class frmBoard : Form
    {
        public Tahta SatrançTahtası;
        public Satranç satranç;
        public int KareSayısı { get; set; } //Satranç Tahtası en ve boy kare sayısı
        public PictureBox[] karelerim;
        public frmBoard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SatrançTahtası = new Tahta(KareSayısı);
            karelerim = new PictureBox[Tahta.SatrançTahtası.LokasyonSayısı()];
            int karesay = 0;
            int xStart = 10;
            int YStart = 10;
            for (int x = 0; x < Tahta.SatrançTahtası.SatırSayısı; x++)
            {
                int Yükseklik = 0;
                for (int y = Tahta.SatrançTahtası.SutunSayısı - 1; y >= 0; y--)
                {
                    Lokasyon tahtaYeri = Tahta.SatrançTahtası.GetLokasyon(x, y);
                    karelerim[karesay] = new PictureBox()
                    {
                        Name = tahtaYeri.ToString(),
                        Tag = tahtaYeri,
                        BackColor = tahtaYeri.Renk,
                        Size = new System.Drawing.Size(100, 100),
                        Location = new System.Drawing.Point(xStart + x * 100, YStart + Yükseklik * 100),
                        SizeMode = PictureBoxSizeMode.CenterImage
                    };
                    Yükseklik++;
                    this.Controls.Add(karelerim[karesay]);
                    karesay++;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            satranç = new Satranç(SatrançTahtası.TümTaşlarım, karelerim, KareSayısı);
            satranç.TaşlarıHareketEttir();
        }
    }
}