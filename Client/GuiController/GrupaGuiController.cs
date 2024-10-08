using Client.UserControls.UCGrupa;
using Client.UserControls.UCKurs;
using Client.UserControls.UCKursevi;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Client.GuiController
{
    internal class GrupaGuiController
    {

        private UCGrupa ucGrupa;
        private List<Raspored> rasporedi;
        private List<Kurs> kursevi;
        private Grupa grupa;
        internal Control CreateUCGrupa(UCOperacija operacija, Grupa grupa)
        {
            switch (operacija)
            {
                case UCOperacija.Dodaj:
                    ucGrupa = new UCGrupa();
                    rasporedi = new List<Raspored>();

                    PrepareForm();
                    ucGrupa.McDatumPocetka.MinDate = DateTime.Now;
                    ucGrupa.BtnDodajRaspored.Click += DodajRaspored;
                    ucGrupa.BtnIzbrisiRaspored.Click += ObrisiRaspored;
                    ucGrupa.BtnDodajGrupu.Click += DodajGrupu;
                    ucGrupa.BtnIzmeniRaspored.Click += IzmeniRaspored;

                    return ucGrupa;


                case UCOperacija.Prikazi:
                    ucGrupa = new UCGrupa();
                    rasporedi = grupa.Rasporedi;
                    PrepareFormIzmena();

                    this.grupa = grupa;

                    UnesiPodatkeOGrupi();
                    ucGrupa.BtnIzmeniGrupu.Click += IzmeniGrupu;
                    ucGrupa.BtnIzmeniRaspored.Click += IzmeniRaspored;
                    ucGrupa.BtnDodajRaspored.Click += DodajRaspored;
                    ucGrupa.BtnIzbrisiRaspored.Click += ObrisiRaspored;
                    ucGrupa.BtnNazad.Click += (s, e) => MainCoordinator.Instance.ShowKursPanel(UCOperacija.IzaberiGrupu,null);
            



            return ucGrupa;

            }


            return null;


        }

        private void IzmeniRaspored(object sender, EventArgs e)
        {
            Raspored raspored;

            raspored = VratiSelektovaniRaspored();
            rasporedi.Remove(raspored);
            ucGrupa.CbDan.SelectedItem = raspored.Dan;
            ucGrupa.TxtTrajanje.Text = raspored.Trajanje;
            ucGrupa.TxtSala.Text = raspored.BrojSale;
            ucGrupa.CbDan.SelectedItem = raspored.Dan;
            ucGrupa.TxtVremePocetka.Text = raspored.VremePocetka;
            OsveziDgvGrupe();
        }

        private void UnesiPodatkeOGrupi()
        {
            ucGrupa.TxtNazivGrupe.Text = grupa.NazivGrupe;
            ucGrupa.McDatumPocetka.SetDate(grupa.DatumPocetka);
            ucGrupa.LbKursevi.SelectedIndex = ucGrupa.LbKursevi.FindStringExact(grupa.Kurs.NazivKursa);

            ucGrupa.DgvRaspored.DataSource = grupa.Rasporedi;
            ucGrupa.DgvRaspored.Columns[2].HeaderText = "Vreme pocetka";
            ucGrupa.DgvRaspored.Columns[3].HeaderText = "Broj sale";
            ucGrupa.DgvRaspored.Columns[4].Visible = false;
            ucGrupa.DgvRaspored.Columns[5].Visible = false;
            ucGrupa.DgvRaspored.Columns[6].Visible = false;
            ucGrupa.DgvRaspored.Columns[7].Visible = false;
            ucGrupa.DgvRaspored.Columns[8].Visible = false;





        }

        private void IzmeniGrupu(object sender, EventArgs e)
        {
            if (!Validate()) return;



            grupa.NazivGrupe = ucGrupa.TxtNazivGrupe.Text;
            grupa.DatumPocetka = ucGrupa.McDatumPocetka.SelectionRange.Start;
            grupa.Kurs = (Kurs)ucGrupa.LbKursevi.SelectedItem;
            grupa.Rasporedi = rasporedi;
            Console.WriteLine(grupa.StariRasporedi.Count);
            for (var i = 0; i < grupa.Rasporedi.Count; i++)

            {
                grupa.Rasporedi[i].Grupa = grupa;
                if (grupa.StariRasporedi.Any(x => x.Equals(grupa.Rasporedi[i])))
                {
                    grupa.Rasporedi[i].Stanje = Stanje.Nepromenjeno;
                }
                else
                if (grupa.StariRasporedi.Any(x => x.Dan == grupa.Rasporedi[i].Dan))
                    grupa.Rasporedi[i].Stanje = Stanje.Izmenjeno;


            }
            //foreach (Raspored r in grupa.Rasporedi)
            //{
            //    r.Grupa = grupa;
            //    if (grupa.StariRasporedi.Any(x => x.Equals(r)))
            //    {
            //        r.Stanje = Stanje.Nepromenjeno;
            //    }
            //    else
            //    if (grupa.StariRasporedi.Any(x => x.Dan == r.Dan))
            //        r.Stanje = Stanje.Izmenjeno;
                
                
            //}

            foreach (Raspored r in grupa.StariRasporedi)
            {

                if (!grupa.Rasporedi.Any(x => x.Dan == r.Dan))
                {
                    r.Stanje = Stanje.Izbrisano;
                    grupa.Rasporedi.Add(r);
                }
            }
            Response response = Communication.Instance.IzmeniGrupu(grupa);
            if (response != null)
            {
                DialogResult result = MessageBox.Show(response.Message+"\nŽelite li da izmenite još neku grupu?","Pitanje",MessageBoxButtons.YesNo);
                ucGrupa.Dispose();
                if (result== DialogResult.Yes)
                {
                    MainCoordinator.Instance.ShowKursPanel(UCOperacija.IzaberiGrupu, null);
                }
            }
            else MessageBox.Show("Sistem ne može da zapamti grupu");
        }

        private void PrepareFormIzmena()
        {
            PrepareForm();

            ucGrupa.BtnDodajGrupu.Visible = false;
            ucGrupa.BtnIzmeniGrupu.Visible = true;
            ucGrupa.BtnNazad.Visible = true;
        }

        private void DodajRaspored(object sender, EventArgs e)
        {
            if (!ValidateRaspored()) return;
            if (DaLiVecPostojiDan((Dan)ucGrupa.CbDan.SelectedItem)) return;
            Raspored raspored = new Raspored
            {
                Dan = (Dan)ucGrupa.CbDan.SelectedItem,
                Trajanje = ucGrupa.TxtTrajanje.Text,
                BrojSale = ucGrupa.TxtSala.Text,
                VremePocetka = ucGrupa.TxtVremePocetka.Text,



            };

            rasporedi.Add(raspored);
            OsveziDgvGrupe();
            ucGrupa.TxtSala.Text = "";
            ucGrupa.TxtTrajanje.Text = "";
            ucGrupa.TxtVremePocetka.Text = "";
        }

        private bool DaLiVecPostojiDan(Dan dan)
        {
            foreach (Raspored r in rasporedi)
            {
                if (r.Dan == dan)
                {
                    MessageBox.Show("Vec ste uneli raspored za taj dan");
                    return true;
                }
            }
            return false;
        }

        private void ObrisiRaspored(object sender, EventArgs e)
        {

            Raspored raspored;

            raspored = VratiSelektovaniRaspored();
            rasporedi.Remove(raspored);
            OsveziDgvGrupe();



        }

        public Raspored VratiSelektovaniRaspored()
        {
            Raspored raspored = null;

            if (ucGrupa.DgvRaspored.SelectedRows.Count == 1 )
            {
                // Raspored raspored = VratiSelektovanRaspored();
                if (ucGrupa.DgvRaspored.SelectedRows.Count == 1)
                {
                    raspored = (Raspored)ucGrupa.DgvRaspored.SelectedRows[0].DataBoundItem;

                }
                //if (ucGrupa.DgvRaspored.SelectedCells.Count == 1)
                //{
                //    int red = ucGrupa.DgvRaspored.SelectedCells[0].RowIndex;
                //    raspored = (Raspored)ucGrupa.DgvRaspored.Rows[red].DataBoundItem;

                //}
            }
            return raspored;
        }
        private void DodajGrupu(object sender, EventArgs e)
        {
            if (!Validate()) return;

            Grupa grupa = new Grupa
            {
                NazivGrupe = ucGrupa.TxtNazivGrupe.Text,
                DatumPocetka = ucGrupa.McDatumPocetka.SelectionRange.Start,
                Kurs = (Kurs)ucGrupa.LbKursevi.SelectedItem,
                Rasporedi = rasporedi


            };

            Response response = Communication.Instance.ZapamtiGrupu(grupa);
            if (response != null)
            {
                MessageBox.Show(response.Message, "Zapamti grupu");
                rasporedi.Clear();
                Resetuj();
            }
            else MessageBox.Show("Sistem ne može da zapamti grupu", "greska");

        }

        private void Resetuj()
        {
            ucGrupa.TxtNazivGrupe.Text = "";
            ucGrupa.TxtSala.Text = "";
            ucGrupa.TxtTrajanje.Text = "";
            ucGrupa.TxtVremePocetka.Text = "";

            kursevi.Clear();
            OsveziDgvGrupe();


        }

        private void PrepareForm()
        {
            kursevi = Communication.Instance.PretraziSveKurseve();
            if (kursevi == null || kursevi.Count() == 0)
            {
                MessageBox.Show("Sistem nije uspeo da pronadje kurseve", "Greška");
                return;
            }
            ucGrupa.LbKursevi.DataSource = kursevi;
            ucGrupa.LbKursevi.DisplayMember = "NazivKursa";
            ucGrupa.CbDan.DataSource = Enum.GetValues(typeof(Dan));

            TxtChanged();


        }

        private void TxtChanged()
        {
            ucGrupa.TxtNazivGrupe.TextChanged += TxtNazviGrupe_TextChanged;
            ucGrupa.TxtSala.TextChanged += TxtSala_TextChanged;
            ucGrupa.TxtTrajanje.TextChanged += TxtTrajanje_TextChanged;
            ucGrupa.TxtVremePocetka.TextChanged += TxtVremePocetka_TextChanged;

        }
        private void TxtNazviGrupe_TextChanged(object sender, EventArgs e)
        {
            ucGrupa.TxtNazivGrupe.BackColor = Color.White;
        }
        private void TxtSala_TextChanged(object sender, EventArgs e)
        {
            ucGrupa.TxtSala.BackColor = Color.White;
        }
        private void TxtTrajanje_TextChanged(object sender, EventArgs e)
        {
            ucGrupa.TxtTrajanje.BackColor = Color.White;
        }

        private void TxtVremePocetka_TextChanged(object sender, EventArgs e)
        {
            ucGrupa.TxtVremePocetka.BackColor = Color.White;
        }

        private void OsveziDgvGrupe()
        {

            ucGrupa.DgvRaspored.DataSource = null;
            ucGrupa.DgvRaspored.DataSource = rasporedi;

            ucGrupa.DgvRaspored.Columns.Remove("Grupa");
            ucGrupa.DgvRaspored.Columns.Remove("TableName");
            ucGrupa.DgvRaspored.Columns.Remove("Values");
            ucGrupa.DgvRaspored.Columns.Remove("PrimaryKey");
            ucGrupa.DgvRaspored.Columns.Remove("Stanje");


        }

        private bool Validate()
        {
            bool uspesno = true;

            if (string.IsNullOrEmpty(ucGrupa.TxtNazivGrupe.Text))
            {
                ucGrupa.TxtNazivGrupe.BackColor = Color.Coral;
                ucGrupa.LblNazivGrupe.Text = "Morate uneti naziv grupe";
                ucGrupa.LblNazivGrupe.Visible = true;
                uspesno = false;

            }
            if (ucGrupa.TxtNazivGrupe.Text.Length < 5)
            {
                ucGrupa.TxtNazivGrupe.BackColor = Color.Coral;
                ucGrupa.LblNazivGrupe.Text = "Naziv grupe ne sme biti kraći od 5 karaktera";
                ucGrupa.LblNazivGrupe.Visible = true;
                uspesno = false;

            }
            
            if (ucGrupa.McDatumPocetka.SelectionStart == null)
            {
                ucGrupa.McDatumPocetka.BackColor = Color.Coral;
                ucGrupa.LblDatumPocetka.Text = "Izaberite datum pocetka";
                ucGrupa.LblDatumPocetka.Visible = true;
                uspesno = false;
            }

           return uspesno;
        }


        private bool ValidateRaspored()
        {
            bool uspesno = true;
            ResetujRaspored();

            if (string.IsNullOrEmpty(ucGrupa.TxtSala.Text))
            {
                ucGrupa.TxtSala.BackColor = Color.Coral;
                ucGrupa.LblSala.Text = "Morate uneti naziv sale";
                ucGrupa.LblSala.Visible = true;
                uspesno = false;

            }
          
            if (string.IsNullOrEmpty(ucGrupa.TxtTrajanje.Text))
            {
                ucGrupa.TxtTrajanje.BackColor = Color.Coral;
                ucGrupa.LblTrajanje.Text = "Morate uneti trajanje kursa za izabrani dan";
                ucGrupa.LblTrajanje.Visible = true;
                uspesno = false;

            }
            if (string.IsNullOrEmpty(ucGrupa.TxtVremePocetka.Text))
            {
                ucGrupa.TxtVremePocetka.BackColor = Color.Coral;
                ucGrupa.LblVremePocetka.Text = "Morate uneti vreme pocetka";
                ucGrupa.LblVremePocetka.Visible = true;
                uspesno = false;
            }
            Regex regexZaVremePocetka = new Regex("^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$");
            //Regex regexZaVremePocetka = new Regex("^(0[0 - 9] | 1[0 - 9] | 2[0 - 3]):([0 - 5][0 - 9])$");
            if (!regexZaVremePocetka.IsMatch(ucGrupa.TxtVremePocetka.Text))
            {
                ucGrupa.TxtVremePocetka.BackColor = Color.Coral;
                ucGrupa.LblVremePocetka.Text = "Format vremena pocetka nije ispravan(npr. 12:00)";
                ucGrupa.LblVremePocetka.Visible = true;
                uspesno = false;
            }
            if (!regexZaVremePocetka.IsMatch(ucGrupa.TxtTrajanje.Text))
            {
                ucGrupa.TxtTrajanje.BackColor = Color.Coral;
                ucGrupa.LblTrajanje.Text = "Format trajanje nije ispravan(npr. 02:15)";
                ucGrupa.LblTrajanje.Visible = true;
                uspesno = false;
            }
           

            return uspesno;
        }

        private void ResetujRaspored()
        {
            ucGrupa.LblDatumPocetka.Visible = false;
            ucGrupa.LblSala.Visible = false;
            ucGrupa.LblTrajanje.Visible = false;
            ucGrupa.LblDatumPocetka.Text = "";
            ucGrupa.LblSala.Text = "";
            ucGrupa.LblTrajanje.Text = "";

        }
    }
}
