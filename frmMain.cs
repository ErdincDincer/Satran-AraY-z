using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SatrançAraYüz.Forms;
using SatrançAraYüz.Dialogs;
using SatrançAraYüz.Entities;

namespace SatrançAraYüz
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            dlgNewBoard dlg = new dlgNewBoard();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                frmBoard childForm = new frmBoard();
                childForm.MdiParent = this;
                childForm.KareSayısı = dlg.KareSayısı;
                childForm.Text = "Tahta " + childFormNumber++;
                childForm.Show();
            }
        }
        private void addPieceToolStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                MessageBox.Show("Tahta yaratmadan taş ekleyemezsiniz");
                return;
            }
            dlgAddPiece dlgAdd = new dlgAddPiece();
            dlgAdd.frmParent = this;
            dlgAdd.ShowDialog();

            frmBoard frm = (frmBoard)this.ActiveMdiChild;
            Satranç.TaşlarıTahtayaEkle(frm.SatrançTahtası.TümTaşlarım, frm.karelerim);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new dlgAbout()).ShowDialog();
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

    }
}
