using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SatrançAraYüz.Entities;
//using Satranç;
using SatrançAraYüz.Enums;
using SatrançAraYüz.Forms;

namespace SatrançAraYüz.Dialogs
{
    public partial class dlgAddPiece : Form
    {
        public frmMain frmParent;
        public dlgAddPiece()
        {
            InitializeComponent();
        }

        private void frmTaşEkle_Load(object sender, EventArgs e)
        {
            cmbTaşTipi.DataSource = Enum.GetValues(typeof(TaşTipleri));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TaşRenkleri Renk = rbBeyaz.Checked ? TaşRenkleri.Beyaz : TaşRenkleri.Siyah;

            frmBoard frm = (frmBoard)frmParent.ActiveMdiChild;
            frm.SatrançTahtası.YeniTaşEkle(
                (TaşTipleri)cmbTaşTipi.SelectedItem,Renk,
                new Lokasyon(Convert.ToInt32(txtLokasyon.Text.Substring(0, 1)),
                       Convert.ToInt32(txtLokasyon.Text.Substring(1, 1)))
                );
            this.Close();
        }
    }
}
