using Client.GuiController;
using Client.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            DaLiJeAdmin();
            kreirajNoviKursToolStripMenuItem.Click+= (s, a) => MainCoordinator.Instance.ShowKursPanel(UCOperacija.Dodaj,null);
            izmenaKursaToolStripMenuItem.Click += (s, a) => MainCoordinator.Instance.ShowKursPanel(UCOperacija.Izmeni,null);
            brisanjeKursaToolStripMenuItem.Click += (s, a) => MainCoordinator.Instance.ShowKursPanel(UCOperacija.Obrisi,null);
            prijavaNaKursToolStripMenuItem.Click += (s, a) => MainCoordinator.Instance.ShowKursPanel(UCOperacija.PrijaviSe,null);
            dodajGrupuToolStripMenuItem.Click += (s,a) => MainCoordinator.Instance.ShowGrupaPanel(UCOperacija.Dodaj,null);
            izmeniGrupuToolStripMenuItem.Click += (s,a) => MainCoordinator.Instance.ShowKursPanel(UCOperacija.IzaberiGrupu,null);
            FormClosed += (s, a) => MainCoordinator.Instance.Logout();
            odjaviSeToolStripMenuItem.Click += (s, a) => MainCoordinator.Instance.ShowPrijavaPanel();
        }

        private void DaLiJeAdmin()
        {
            if (Communication.Instance.User.KorisnickoIme.Equals("andj712"))
            {

                kursToolStripMenuItem.Visible = true;
                grupaToolStripMenuItem.Visible = true;
                
                prijavaNaKursToolStripMenuItem.Visible = false;


            }
        }

        public void ChangePanel(Control control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlMain.AutoSize = true;
            pnlMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }

        

        
    }
}
