using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatrançAraYüz.Dialogs
{
    public partial class dlgNewBoard : dlgTemplate
    {
        public dlgNewBoard()
        {
            InitializeComponent();
        }

        public int KareSayısı { get; internal set; } = 8;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            KareSayısı =(int) numericUpDown1.Value;
        }
    }
}
