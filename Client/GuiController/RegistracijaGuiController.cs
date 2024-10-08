using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class RegistracijaGuiController
    {
        private static RegistracijaGuiController instance;
        public static RegistracijaGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RegistracijaGuiController();
                }
                return instance;
            }
        }
        private RegistracijaGuiController()
        {
        }

        FrmRegistracija frmRegistracija;
        internal void ShowFrmRegistracija()
        {
            frmRegistracija=new FrmRegistracija();
            frmRegistracija.BtnRegistrujSe.Click += Registracija;
            frmRegistracija.TxtIme.TextChanged += txtIme_TextChanged;
            frmRegistracija.TxtPrezime.TextChanged += txtPrezime_TextChanged;
            frmRegistracija.TxtKorisnickoIme.TextChanged += txtKorisnickoIme_TextChanged;
            frmRegistracija.TxtLozinka.TextChanged += txtLozinka_TextChanged;
            frmRegistracija.TxtGmail.TextChanged += txtGmail_TextChanged;
            frmRegistracija.TxtKontaktTelefon.TextChanged += txtKontaktTelefon_TextChanged;
            frmRegistracija.TxtKontaktTelefon.Text = "06";

            frmRegistracija.ShowDialog();
            PripremaForme();

        }

       

        private void PripremaForme()
        {

            frmRegistracija.TxtKontaktTelefon.Text = "06";

        }

        public void Registracija(object sender, EventArgs e)
        {
           
            if (Validacija())
            {
                if (!Communication.Instance.Connect())
                {
                    return;
                }
                Korisnik user = new Korisnik()
                {
                    KorisnickoIme = frmRegistracija.TxtKorisnickoIme.Text.Trim().Replace(" ", ""),
                    Lozinka = frmRegistracija.TxtLozinka.Text.Trim().Replace(" ", ""),
                    Ime = frmRegistracija.TxtIme.Text.Trim().Replace(" ", ""),
                    Prezime = frmRegistracija.TxtPrezime.Text.Trim().Replace(" ", ""),
                    KontaktTelefon = frmRegistracija.TxtKontaktTelefon.Text.Trim().Replace(" ", ""),
                    Gmail = frmRegistracija.TxtGmail.Text.Trim().Replace(" ", ""),
                    DatumRodjenja = frmRegistracija.McBirthday.SelectionRange.Start
                };
                Response response = Communication.Instance.DodajKorisnika(user);
                if (response != null)
                {
                    Communication.Instance.Close();
                    MessageBox.Show(response.Message, "Dodavanje korisnika");
                    //ResetujTxt();
                    frmRegistracija.Dispose();
                }
                else {
                 
                    Communication.Instance.Close();
                    MessageBox.Show("Sistem ne može da zapamti korisnički nalog", "Dodavanje korisnika");
                }



            }
        }

        private void ResetujTxt()
        {
            frmRegistracija.TxtGmail.Text = "";
            frmRegistracija.TxtIme.Text = "";
            frmRegistracija.TxtKontaktTelefon.Text = "06";
            frmRegistracija.TxtKorisnickoIme.Text = "";
            frmRegistracija.TxtLozinka.Text = "";
            frmRegistracija.TxtPrezime.Text = "";
            frmRegistracija.McBirthday.SelectionStart = DateTime.Now;
        }

        private bool Validacija()
        {
            Resetuj();
           
            string message = "";
            if (string.IsNullOrEmpty(frmRegistracija.TxtKorisnickoIme.Text) || frmRegistracija.TxtKorisnickoIme.Text.Length < 5)
            {
                message += "Korisničko ime mora sadržati bar 6 karaktera!\n";
                frmRegistracija.TxtKorisnickoIme.BackColor = Color.Coral;
                frmRegistracija.LblKorisnickoIme.Text = "Korisničko ime mora sadržati bar 6 karaktera!\n";
                frmRegistracija.LblKorisnickoIme.Visible = true;
            }
            if (string.IsNullOrEmpty(frmRegistracija.TxtLozinka.Text) || frmRegistracija.TxtLozinka.Text.Length < 4)
            {
                message += "Lozinka mora sadržati bar 6 karaktera!\n";
                frmRegistracija.TxtLozinka.BackColor = Color.Coral;
                frmRegistracija.LblLozinka.Text = "Lozinka mora sadržati bar 6 karaktera!";
                frmRegistracija.LblLozinka.Visible = true;

            }
            if (!frmRegistracija.TxtLozinka.Text.Contains("!") && !frmRegistracija.TxtLozinka.Text.Contains("?") &&!frmRegistracija.TxtLozinka.Text.Contains("/") && !frmRegistracija.TxtLozinka.Text.Contains("*"))
            {
                message += "Lozinka mora sadržati bar neki od znakova !,?, * ili / \n";
                frmRegistracija.TxtLozinka.BackColor = Color.Coral;
                frmRegistracija.LblLozinka.Text += "Lozinka mora sadržati bar neki od znakova!,?, *ili / \n";
                frmRegistracija.LblLozinka.Visible = true;

            }
            Regex rmobilni = new Regex("^06[0-9]{8}$");
            if (!rmobilni.IsMatch(frmRegistracija.TxtKontaktTelefon.Text))
            {
                message += "Mobilni mora biti u formatu 0612345678";
                frmRegistracija.TxtKontaktTelefon.BackColor = Color.Coral;
                frmRegistracija.LblKontaktTelefon.Text = "Mobilni mora biti u formatu 0612345678";
                frmRegistracija.LblKontaktTelefon.Visible = true;

            }
            if (string.IsNullOrEmpty(frmRegistracija.TxtIme.Text) || frmRegistracija.TxtIme.Text.Length < 2)
            {
                message += "Ime mora sadržati bar 2 karaktera!\n";
                frmRegistracija.TxtIme.BackColor = Color.Coral;
                frmRegistracija.LblIme.Text = "Ime mora sadržati bar 2 karaktera!";
                frmRegistracija.LblIme.Visible = true;

            }
            if (string.IsNullOrEmpty(frmRegistracija.TxtPrezime.Text) || frmRegistracija.TxtPrezime.Text.Length < 3)
            {
                message += "Prezime mora sadržati bar 3 karaktera!\n";
                frmRegistracija.LblPrezime.Text = "Prezime mora sadržati bar 3 karaktera!";

                frmRegistracija.TxtPrezime.BackColor = Color.Coral;
                frmRegistracija.LblPrezime.Visible = true;

            }
            Regex ime = new Regex("^[a-zA-Z\\s'-]+$");
            if (!ime.IsMatch(frmRegistracija.TxtIme.Text))
            {
                message += "Ime mora biti string!\n";
                frmRegistracija.TxtIme.BackColor = Color.Coral;
                frmRegistracija.LblIme.Text += "Ime mora biti string!\n";
                frmRegistracija.LblIme.Visible = true;

            }
            Regex prezime = new Regex("^[a-zA-Z\\s'-]+$");
            if (!prezime.IsMatch(frmRegistracija.TxtIme.Text))
            {
                message += "Prezime mora biti string!\n";
                frmRegistracija.TxtPrezime.BackColor = Color.Coral;
                frmRegistracija.LblPrezime.Text += "Prezime mora biti string!\n";
                frmRegistracija.LblPrezime.Visible = true;

            }
            if (frmRegistracija.McBirthday.SelectionRange.Start.ToShortDateString() == DateTime.Now.ToShortDateString()|| frmRegistracija.McBirthday.SelectionRange.Start.Year==DateTime.Now.Year)
            {
                message += "Izaberite datum rodjenja!\n";
                frmRegistracija.LblDatumRodjenja.Text = "Izaberite datum rodjenja!\n";
                frmRegistracija.LblDatumRodjenja.Visible = true;

            }
            Regex rgmail = new Regex("^[a-z0-9.]+(@)[a-z]+");
            if (!rgmail.IsMatch(frmRegistracija.TxtGmail.Text))
            {
               message += "Gmail nije u dobrom formatu mora sadrzati @ i slova pre i posle njega!\n";
                frmRegistracija.LblGmail.Text = "Gmail nije u dobrom formatu mora sadrzati @ i slova pre i posle njega";
                frmRegistracija.TxtGmail.BackColor = Color.Coral;
                frmRegistracija.LblGmail.Visible = true;

            }
            if (message != "")
            {

                return false;
            }
            return true;
        }

        private void Resetuj()
        {
            frmRegistracija.LblIme.Visible = false;
            frmRegistracija.LblPrezime.Visible = false;
            frmRegistracija.LblKorisnickoIme.Visible = false;
            frmRegistracija.LblLozinka.Visible = false;
            frmRegistracija.LblGmail.Visible = false;
            frmRegistracija.LblKontaktTelefon.Visible = false;
            frmRegistracija.LblDatumRodjenja.Visible = false;
            
            frmRegistracija.LblIme.Text = "";
            frmRegistracija.LblPrezime.Text = "";
            frmRegistracija.LblKorisnickoIme.Text = "";
            frmRegistracija.LblLozinka.Text = "";
            frmRegistracija.LblGmail.Text = "";
            frmRegistracija.LblKontaktTelefon.Text = "06";
            frmRegistracija.LblDatumRodjenja.Text = "";




        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            frmRegistracija.TxtIme.BackColor = Color.White;
        }
        private void txtKontaktTelefon_TextChanged(object sender, EventArgs e)
        {
            frmRegistracija.TxtKontaktTelefon.BackColor = Color.White;
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {
            frmRegistracija.TxtGmail.BackColor = Color.White;
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            frmRegistracija.TxtLozinka.BackColor = Color.White;
        }

        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            frmRegistracija.TxtKorisnickoIme.BackColor = Color.White;
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            frmRegistracija.TxtPrezime.BackColor = Color.White;
        }
    }
}
