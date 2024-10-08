using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class LoginGuiController
    {

        private static LoginGuiController instance;
        public static LoginGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGuiController();
                }
                return instance;
            }
        }
        private LoginGuiController()
        {
        }

        private FrmLogin frmLogin;

        internal void ShowFrmLogin()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new FrmLogin();
            frmLogin.AutoSize = true;
            frmLogin.BtnLogin.Click += Login;
            frmLogin.LblRegistracija.MouseEnter += lblRegistracija_MouseEnter;
            frmLogin.LblRegistracija.MouseLeave += lblRegistracija_MouseLeave;
            frmLogin.LblRegistracija.MouseClick += lblRegistracija_MouseClick;
            frmLogin.TxtPassword.TextChanged += txtLozinka_TextChanged;
            frmLogin.TxtUsername.TextChanged += txtKorisnickoIme_TextChanged;
           
            Application.Run(frmLogin);
        }

        public void Login(object sender, EventArgs e)
        {
            if (!Validacija()) return;
            try
            {
                if (!Communication.Instance.Connect())
                {
                    return;
                }

                Korisnik user = new Korisnik
                {
                KorisnickoIme = frmLogin.TxtUsername.Text,
                 Lozinka = frmLogin.TxtPassword.Text,
                };
                user = Communication.Instance.Login(user);
                if ( user!= null)
                {
                    MessageBox.Show("Uspešno ste se prijavili!","Prijava");
                    frmLogin.Visible = false;
                    MainCoordinator.Instance.ShowFrmMain();
                    frmLogin.Visible = true;

                }
                else
                {
                    MessageBox.Show("Neuspesna prijava","Prijava");
                    Communication.Instance.Close();
                    
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show("Server je ugasen!","Greška");
                Debug.WriteLine(ex.Message);
               // MainCoordinator.Instance.Logout();
                return;
            }
        }
        private void lblRegistracija_MouseEnter(object sender, EventArgs e)
        {
            frmLogin.LblRegistracija.ForeColor = Color.Coral;
            frmLogin.LblRegistracija.Font = new Font(frmLogin.LblRegistracija.Font, FontStyle.Underline);

        }

        private void lblRegistracija_MouseLeave(object sender, EventArgs e)
        {
            frmLogin.LblRegistracija.ForeColor = Color.Black;
            frmLogin.LblRegistracija.Font = new Font(frmLogin.LblRegistracija.Font, FontStyle.Regular) ;
        }
        private void lblRegistracija_MouseClick(object sender, MouseEventArgs e)
        {
            frmLogin.Visible = false;
            RegistracijaGuiController.Instance.ShowFrmRegistracija();
            frmLogin.Visible = true;


            
        }

        private bool Validacija()
        {
            Resetuj();

            string message = "";
            if (string.IsNullOrEmpty(frmLogin.TxtUsername.Text) || frmLogin.TxtUsername.Text.Length < 5)
            {
                message += "Korisničko ime mora sadržati bar 6 karaktera!";
                
                frmLogin.TxtUsername.BackColor = Color.Coral;
                frmLogin.LblKorisnickoIme.Text= "Korisničko ime mora sadržati bar 6 karaktera!";
                frmLogin.LblKorisnickoIme.Visible = true;
            }
            if (string.IsNullOrEmpty(frmLogin.TxtPassword.Text) || frmLogin.TxtPassword.Text.Length < 4)
            {
                message += "Lozinka mora sadržati bar 6 karaktera!";
                frmLogin.TxtPassword.BackColor = Color.Coral;
                frmLogin.LblLozinka.Text += "Lozinka mora sadržati bar 6 karaktera!"; ;

                frmLogin.LblLozinka.Visible = true;
            }
            if (!frmLogin.TxtPassword.Text.Contains("!") && !frmLogin.TxtPassword.Text.Contains("?") && !frmLogin.TxtPassword.Text.Contains("/") && !frmLogin.TxtPassword.Text.Contains("*"))
            {
                message += "Lozinka mora sadržati bar neki od znakova !,?, * ili / \n";
                frmLogin.TxtPassword.BackColor = Color.Coral;
                frmLogin.LblLozinka.Text += "Lozinka mora sadržati bar neki od znakova!,?, *ili / \n";
                frmLogin.LblLozinka.Visible = true;

            }
            if (message != "")
            {
                return false;
            }
            return true;
        }

        private void Resetuj()
        {
            frmLogin.LblKorisnickoIme.Visible= false;
            frmLogin.LblLozinka.Visible = false;

            frmLogin.LblKorisnickoIme.Text = "";
            frmLogin.LblLozinka.Text = "";
        }
        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            frmLogin.TxtPassword.BackColor = Color.White;
        }

        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            frmLogin.TxtUsername.BackColor = Color.White;
        }
    }
}