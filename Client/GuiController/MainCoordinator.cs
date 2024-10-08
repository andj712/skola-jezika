using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    internal class MainCoordinator
    {
        private static MainCoordinator instance;
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        private MainCoordinator()
        {
            kursGuiController = new KursGUIController();
            grupaGuiController=new GrupaGuiController();
        }

        private FrmMain frmMain;
        private KursGUIController kursGuiController;
        private GrupaGuiController grupaGuiController;

        internal void ShowFrmMain()
        {
            frmMain = new FrmMain();
            frmMain.AutoSize = true;
            frmMain.ShowDialog();
        }

        

        internal void ShowKursPanel(UCOperacija operacija,Kurs kurs)
        {
            frmMain.ChangePanel(kursGuiController.CreateUCKurs(operacija,kurs));
        }

        internal void ShowGrupaPanel(UCOperacija operacija,Grupa grupa)
        {
            frmMain.ChangePanel(grupaGuiController.CreateUCGrupa(operacija,grupa));

        }

        internal void Logout()
        {
            Response r = Communication.Instance.Logout();
           if(r!=null)  MessageBox.Show(r.Message,"Odjava");
            else MessageBox.Show("Server je ugasen");
            Communication.Instance.Close();

        }

        internal void ShowPrijavaPanel()
        {
           
            frmMain.Dispose();
        }
    }
}
