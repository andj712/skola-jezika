using Client.UserControls;
using Client.UserControls.UCKurs;
using Client.UserControls.UCKursevi;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls.Expressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client.GuiController
{
	internal class KursGUIController
	{
		private UCKurs uCKurs;
		private UCPretraziKurseve ucPretraziKurseve;
		Kurs kurs;

		internal Control CreateUCKurs(UCOperacija operacija, Kurs k)
		{
			switch (operacija)
			{
				case UCOperacija.Dodaj:
					uCKurs = new UCKurs();
					PrepareForm();
					uCKurs.BtnKreiraj.Click += ZapamtiKurs;

					return uCKurs;

				case UCOperacija.Izmeni:
					CreateUCPretraziKurs();
                    ucPretraziKurseve.TxtPretraga.TextChanged += SearchByName;
                    ucPretraziKurseve.BtnIzmeni.Click += IzmeniKurs;

					return ucPretraziKurseve;

				case UCOperacija.Prikazi:
					uCKurs = new UCKurs();
					this.kurs = k;
					PrepareFormIzmena(kurs);
					uCKurs.BtnIzmeni.Click += SacuvajIzmenjenKurs;
                    uCKurs.BtnNazad.Click += (s, e) => MainCoordinator.Instance.ShowKursPanel(UCOperacija.Izmeni, null);


                    return uCKurs;

				case UCOperacija.Obrisi:
					CreateUCPretraziKurs();

					ucPretraziKurseve.TxtPretraga.TextChanged += SearchByName;
					ucPretraziKurseve.BtnObrisi.Click += ObrisiKurs;
					PrepareFormObrisi();


					return ucPretraziKurseve;

				case UCOperacija.PrijaviSe:
                    
                    CreateUCPretraziKurs();
					PrepareFormPrijava();


                    ucPretraziKurseve.BtnPrijaviSe.Click += PrijaviSeNaKurs;
                    ucPretraziKurseve.DgvKursevi.SelectionChanged += PrikaziDetalje;

                    ucPretraziKurseve.TxtPretraga.TextChanged += SearchByName;
                    //ucPretraziKurseve.BtnDetalji.Click += PrikaziDetalje;

					return ucPretraziKurseve;
				case UCOperacija.IzaberiGrupu:
					CreateUCPretraziKurs();
					PrepareFormIzaberiGrupu();
                    ucPretraziKurseve.DgvKursevi.SelectionChanged += PrikaziDetalje;

                    ucPretraziKurseve.TxtPretraga.TextChanged += SearchByName;
                    //ucPretraziKurseve.BtnDetalji.Click += PrikaziDetalje;
                    ucPretraziKurseve.BtnIzmeniGrupu.Click += IzmeniGrupu;



					return ucPretraziKurseve;

				default:
					return null;


			}






		}

		private void IzmeniGrupu(object sender, EventArgs e)
		{
			Grupa grupa = new Grupa
			{
				Kurs = VratiSelektovanKurs()
		};
				grupa=VratiSelektovanuGrupu(grupa);
            
            if (grupa != null)
			{
                ucPretraziKurseve.Visible = false;
				grupa.Rasporedi = VratiRasporedeZaGrupu(grupa);
				grupa.StariRasporedi = new List<Raspored>(grupa.Rasporedi);
                MainCoordinator.Instance.ShowGrupaPanel(UCOperacija.Prikazi, grupa);

            }

            else MessageBox.Show("Izaberite iz tabele grupu koju želite da promenite");
		}

		private void PrepareFormIzaberiGrupu()
		{
			ucPretraziKurseve.GbDetalji.Visible = true;
			ucPretraziKurseve.LbKursevi.Visible = false;
			ucPretraziKurseve.BtnPrijaviSe.Visible = false;
			ucPretraziKurseve.BtnIzmeni.Visible = false;
			ucPretraziKurseve.BtnDetalji.Visible = false;
			ucPretraziKurseve.BtnObrisi.Visible = false;
			ucPretraziKurseve.BtnIzmeniGrupu.Visible = true;
			ucPretraziKurseve.BtnPretrazi.Visible = false;

		}

		private void PrikaziDetalje(object sender, EventArgs e)
		{
            kurs = VratiSelektovanKurs();
			if(kurs==null&&ucPretraziKurseve.DgvKursevi.Rows.Count>0)
            kurs = (Kurs)ucPretraziKurseve.DgvKursevi.Rows[0].DataBoundItem;
			if (kurs == null) return;
            Grupa grupa = new Grupa
			{
				Kurs = kurs
			};
			VratiSveGrupeZaKurs(grupa);
			ucPretraziKurseve.TxtBrojCasova.Text = kurs.UkupanBrojCasova.ToString();
			ucPretraziKurseve.TxtJezik.Text = kurs.Jezik.ToString();
			ucPretraziKurseve.TxtNaziv.Text = kurs.NazivKursa;
			ucPretraziKurseve.TxtTrajanje.Text = kurs.Trajanje;
			ucPretraziKurseve.RtbOpis.Text = kurs.OpisKursa;



		}
		//private void PrikaziDetalje(object sender, EventArgs e)
		//{
		//	kurs = VratiSelektovanKurs();
		//	Grupa grupa = new Grupa
		//	{
		//		Kurs = kurs
		//	};
		//	VratiSveGrupeZaKurs(grupa);
		//	ucPretraziKurseve.TxtBrojCasova.Text = kurs.UkupanBrojCasova.ToString();
		//	ucPretraziKurseve.TxtJezik.Text = kurs.Jezik.ToString();
		//	ucPretraziKurseve.TxtNaziv.Text = kurs.NazivKursa;
		//	ucPretraziKurseve.TxtTrajanje.Text = kurs.Trajanje;
		//	ucPretraziKurseve.RtbOpis.Text = kurs.OpisKursa;



		//}

		private void VratiSveGrupeZaKurs(Grupa grupa)
		{
			List<Grupa> grupe = Communication.Instance.VratiSveGrupeZaKurs(grupa);
			if (grupe == null || grupe.Count() == 0)
			{
				MessageBox.Show("Sistem nije uspeo da pronadje grupe za kurs");
				return;
			}
			//ucPretraziKurseve.LbKursevi.DataSource = null;
			//ucPretraziKurseve.LbKursevi.DataSource = kursevi;
			//ucPretraziKurseve.LbKursevi.DisplayMember = "NazivKursa


			ucPretraziKurseve.DgvGrupe.DataSource = null;
			ucPretraziKurseve.DgvGrupe.DataSource = grupe;
			if(ucPretraziKurseve.DgvGrupe.Rows.Count>0)
			ucPretraziKurseve.DgvGrupe.Rows[0].Selected = true;
			ucPretraziKurseve.DgvGrupe.Columns[0].Visible = false;
			ucPretraziKurseve.DgvGrupe.Columns[3].Visible = false;
			ucPretraziKurseve.DgvGrupe.Columns[4].Visible = false;
			ucPretraziKurseve.DgvGrupe.Columns[5].Visible = false;
			ucPretraziKurseve.DgvGrupe.Columns[6].Visible = false;

            ucPretraziKurseve.DgvGrupe.Columns[1].HeaderText = "Naziv grupe";
            ucPretraziKurseve.DgvGrupe.Columns[2].HeaderText = "Datum pocetka";


        }

		private void PrijaviSeNaKurs(object sender, EventArgs e)
		{
			kurs = VratiSelektovanKurs();
			if (kurs == null)
			{
				MessageBox.Show("morate selektovati kurs");
				return;
			}
			Grupa grupa = new Grupa { Kurs = kurs };
			 grupa=VratiSelektovanuGrupu(grupa);
			Prijava prijava = new Prijava()
			{
				DatumPrijave = DateTime.Now,
				User = Communication.Instance.User,
				Grupa = grupa
			};
			Response res = Communication.Instance.PrijavaNaKurs(prijava);
			if (res != null)
			{
				MessageBox.Show(res.Message,"Prijava na kurs");
			}
			else
			{
				MessageBox.Show("Sistem ne može da zapamti prijavu na kurs","Greška");
			}



			}

			private Grupa VratiSelektovanuGrupu(Grupa grupa)
		{
			
			int index;
			int id;
			if ( ucPretraziKurseve.DgvGrupe.SelectedRows.Count == 1)
			{

				//if (ucPretraziKurseve.DgvGrupe.SelectedCells.Count == 1)
				//{
				//	index = ucPretraziKurseve.DgvGrupe.SelectedCells[0].RowIndex;
				//                //grupa = (Grupa)ucPretraziKurseve.DgvGrupe.Rows[index].DataBoundItem;
				//                id = int.Parse(ucPretraziKurseve.DgvKursevi.Rows[index].Cells[0].Value.ToString());

				//}


				//grupa = (Grupa)ucPretraziKurseve.DgvGrupe.SelectedRows[0].DataBoundItem;
				//id = int.Parse(ucPretraziKurseve.DgvGrupe.SelectedRows[0].Cells[0].Value.ToString());

				grupa = (Grupa)ucPretraziKurseve.DgvGrupe.SelectedRows[0].DataBoundItem;
				//grupa.Id = id;
                //grupa = Communication.Instance.GetGrupaById(grupa);

            }
            return grupa;

		}

		private List<Raspored> VratiRasporedeZaGrupu(Grupa grupa)
		{
			Raspored raspored = new Raspored
			{
				Grupa = grupa,
			};
			return Communication.Instance.VratiRasporedeZaGrupu(raspored);
		}

		private void PrepareFormPrijava()
		{
			ucPretraziKurseve.GbDetalji.Visible = true;
			ucPretraziKurseve.LbKursevi.Visible = false;
			ucPretraziKurseve.BtnPrijaviSe.Visible = true;
			ucPretraziKurseve.BtnIzmeni.Visible = false;
			ucPretraziKurseve.BtnDetalji.Visible = false;
			ucPretraziKurseve.BtnObrisi.Visible = false;
            ucPretraziKurseve.BtnPretrazi.Visible = false;

        }

        private void CreateUCPretraziKurs()
		{
			ucPretraziKurseve = new UCPretraziKurseve();
			ucPretraziKurseve.Load += (s, e) => VratiSveKurseve();

        }

        private void ObrisiKurs(object sender, EventArgs e)
		{
			kurs = VratiSelektovanKurs();
			if (kurs == null)
			{
				MessageBox.Show("Morate prvo izabrati kurs");
				return;
			}
			if (MessageBox.Show($"Da li ste sigurni da zelite da obrišete kurs {kurs.NazivKursa}?", "Brisanje kursa", MessageBoxButtons.YesNo) == DialogResult.No) return;
			Response res = Communication.Instance.IzbrisiKurs(kurs);
			MessageBox.Show(res.Message);
			VratiSveKurseve();
		}

		private void PrepareFormObrisi()
		{
			ucPretraziKurseve.BtnObrisi.Visible = true;
			ucPretraziKurseve.BtnIzmeni.Visible = false;
			ucPretraziKurseve.BtnDetalji.Visible = false;
			ucPretraziKurseve.Height = 380;
			

		}

		private void SacuvajIzmenjenKurs(object sender, EventArgs e)
		{
			if (!ValidateKurs()) return;



			kurs.NazivKursa = uCKurs.TxtNaziv.Text;
			kurs.OpisKursa = uCKurs.TxtOpis.Text;
			kurs.Trajanje = uCKurs.TxtTrajanje.Text;
			kurs.UkupanBrojCasova = int.Parse(uCKurs.TxtBrojCasova.Text);
			kurs.Jezik = (Jezik)uCKurs.CbJezici.SelectedItem;




			Response response = Communication.Instance.IzmeniKurs(kurs);
			if (response != null)
			{

                DialogResult result = MessageBox.Show(response.Message + "\nŽelite li da izmenite još neki kurs?", "Pitanje", MessageBoxButtons.YesNo);
                uCKurs.Dispose();

                if (result == DialogResult.Yes)
            {
                    MainCoordinator.Instance.ShowKursPanel(UCOperacija.Izmeni, null);
            }

			}
			else
            {
                MessageBox.Show(response.Message);
            }
        }

		private void PrepareFormIzmena(Kurs kurs)
		{
			uCKurs.CbJezici.DataSource = Communication.Instance.VratiJezike();
			uCKurs.BtnKreiraj.Visible = false;
			uCKurs.BtnIzmeni.Visible = true;
			uCKurs.BtnNazad.Visible = true;
            ucPretraziKurseve.BtnDetalji.Visible = false;
			

            uCKurs.TxtNaziv.Text = kurs.NazivKursa;
			uCKurs.TxtOpis.Text = kurs.OpisKursa;
			uCKurs.TxtBrojCasova.Text = kurs.UkupanBrojCasova.ToString();
			uCKurs.TxtTrajanje.Text = kurs.Trajanje;
			uCKurs.CbJezici.SelectedIndex = uCKurs.CbJezici.FindStringExact(kurs.Jezik.NazivJezika);
           // uCKurs.CbJezici.SelectedItem = kurs.Jezik.NazivJezika;
		
			
			Console.WriteLine(kurs.Jezik.NazivJezika);
			Console.WriteLine(kurs.Jezik.Id);
			TxtChanged();


        }

        private void IzmeniKurs(object sender, EventArgs e)
		{
			kurs = VratiSelektovanKurs();
			Console.WriteLine(kurs.Jezik.NazivJezika);
			if (kurs != null)
				MainCoordinator.Instance.ShowKursPanel(UCOperacija.Prikazi, kurs);
			else MessageBox.Show("Izaberite iz tabele kurs koji želite da promenite", "Izmena kursa");
		}

		private Kurs VratiSelektovanKurs()
		{
			Kurs kurs=null;
			int index;
			int id;
			if (ucPretraziKurseve.DgvKursevi.SelectedCells.Count == 1 || ucPretraziKurseve.DgvKursevi.SelectedRows.Count == 1)
			{

				if (ucPretraziKurseve.DgvKursevi.SelectedCells.Count == 1)
				{
					index = ucPretraziKurseve.DgvKursevi.SelectedCells[0].RowIndex;
                    id = int.Parse(ucPretraziKurseve.DgvKursevi.Rows[index].Cells[0].Value.ToString());
					//kurs = (Kurs)ucPretraziKurseve.DgvKursevi.Rows[index].DataBoundItem;
				}
				else
				{
                    //kurs = (Kurs)ucPretraziKurseve.DgvKursevi.SelectedRows[0].DataBoundItem;
                    id = int.Parse(ucPretraziKurseve.DgvKursevi.SelectedRows[0].Cells[0].Value.ToString());


                }
                kurs = Communication.Instance.GetKursById(id);
            }
			return kurs;
		}
		private void SearchByName(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(ucPretraziKurseve.TxtPretraga.Text)) VratiSveKurseve();
			else
			{
				List<Kurs> kursevi = Communication.Instance.SearchKursByName(ucPretraziKurseve.TxtPretraga.Text);
				if (kursevi == null || kursevi.Count() == 0)
				{
					MessageBox.Show("Sistem nije uspeo da pronadje kurseve po zadatoj vrednosti", "Greška");
					return;
				}
               // MessageBox.Show("Sistem je našao kurseve po zadatoj vrednosti", "Pretraga kurseva");

                ucPretraziKurseve.DgvKursevi.DataSource = null;

				ucPretraziKurseve.DgvKursevi.DataSource = kursevi;
				ucPretraziKurseve.DgvKursevi.Columns[0].Visible = false;
				ucPretraziKurseve.DgvKursevi.Columns[6].Visible = false;
				ucPretraziKurseve.DgvKursevi.Columns[7].Visible = false;
				ucPretraziKurseve.DgvKursevi.Columns[8].Visible = false;

				ucPretraziKurseve.DgvKursevi.Columns[1].HeaderText = "Naziv kursa";
				ucPretraziKurseve.DgvKursevi.Columns[3].HeaderText = "Opis kursa";
				ucPretraziKurseve.DgvKursevi.Columns[4].HeaderText = "Ukupan broj casova";
				


				//ucPretraziKurseve.LbKursevi.DataSource = null;

				//ucPretraziKurseve.LbKursevi.DataSource = kursevi;
				//ucPretraziKurseve.LbKursevi.DisplayMember = "NazivKursa";
			}
		}

		private void PrepareForm()
		{

			uCKurs.CbJezici.DataSource =Communication.Instance.VratiJezike();
			uCKurs.BtnKreiraj.Visible = true;
			uCKurs.BtnIzmeni.Visible = false;
			uCKurs.Height = 300;

            TxtChanged();
		}

		private void TxtChanged()
		{
			uCKurs.TxtBrojCasova.TextChanged += TxtBrojCasova_TextChanged;
			uCKurs.TxtTrajanje.TextChanged += TxtTrajanje_TextChanged;
			uCKurs.TxtOpis.TextChanged += TxtOpis_TextChanged;
			uCKurs.TxtNaziv.TextChanged += TxtNaziv_TextChanged;
		}




		private void TxtBrojCasova_TextChanged(object sender, EventArgs e)
		{
			uCKurs.TxtBrojCasova.BackColor = Color.White;
		}
		private void TxtTrajanje_TextChanged(object sender, EventArgs e)
		{
			uCKurs.TxtTrajanje.BackColor = Color.White;
		}
		private void TxtNaziv_TextChanged(object sender, EventArgs e)
		{
			uCKurs.TxtNaziv.BackColor = Color.White;
		}
		private void TxtOpis_TextChanged(object sender, EventArgs e)
		{
			uCKurs.TxtOpis.BackColor = Color.White;
		}

		private void ZapamtiKurs(object sender, EventArgs e)
		{
			if (!ValidateKurs()) return;

			Kurs kurs = new Kurs()
			{
				NazivKursa = uCKurs.TxtNaziv.Text,
				OpisKursa = uCKurs.TxtOpis.Text,
				Trajanje = uCKurs.TxtTrajanje.Text,
				UkupanBrojCasova = int.Parse(uCKurs.TxtBrojCasova.Text),
				Jezik = (Jezik)uCKurs.CbJezici.SelectedItem

			};


			Response response = Communication.Instance.ZapamtiKurs(kurs);
			MessageBox.Show(response.Message, "Zapamti kurs");

			ResetujNaPocetno();

		}

        private void ResetujNaPocetno()
        {
			Resetuj();
			uCKurs.TxtBrojCasova.Text = "";
			uCKurs.TxtNaziv.Text = "";
			uCKurs.TxtOpis.Text = "";
			uCKurs.TxtTrajanje.Text = "";
			
        }

        private void Resetuj()
		{
			uCKurs.LblBrojCasova.Visible = false;
			uCKurs.LblJezik.Visible = false;
			uCKurs.LblNaziv.Visible = false;
			uCKurs.LblTrajanje.Visible = false;
			uCKurs.LblOpis.Visible = false;

			uCKurs.LblBrojCasova.Text = "";
			uCKurs.LblJezik.Text = "";
			uCKurs.LblNaziv.Text = "";
			uCKurs.LblTrajanje.Text = "";
			uCKurs.LblOpis.Text = "";

		}

		private bool ValidateKurs()
		{
			Resetuj();
			string message = "";
			if (string.IsNullOrEmpty(uCKurs.TxtBrojCasova.Text) || !int.TryParse(uCKurs.TxtBrojCasova.Text,out _)||
				int.Parse(uCKurs.TxtBrojCasova.Text) < 2)
			{
				message += "Unesite broj casova";

				uCKurs.TxtBrojCasova.BackColor = Color.Coral;
				uCKurs.LblBrojCasova.Text = "Unesite broj casova veći od 2!";
				uCKurs.LblBrojCasova.Visible = true;
			}
			if (string.IsNullOrEmpty(uCKurs.TxtOpis.Text) || uCKurs.TxtOpis.Text.Length < 5)
			{
				message += "Unesite opis kursa!";
				uCKurs.TxtOpis.BackColor = Color.Coral;
				uCKurs.LblOpis.Text += "Unesite opis kursa koji je duži od 5 karaktera!"; ;

				uCKurs.LblOpis.Visible = true;
			}
			if (string.IsNullOrEmpty(uCKurs.TxtNaziv.Text) || uCKurs.TxtNaziv.Text.Length < 5)
			{
				message += "Unesite naziv kursa!";
				uCKurs.TxtNaziv.BackColor = Color.Coral;
				uCKurs.LblNaziv.Text += "Unesite naziv kursa koji je duži od 5 karaktera!"; ;
				uCKurs.LblNaziv.Visible = true;
			}
			if (string.IsNullOrEmpty(uCKurs.TxtTrajanje.Text))
			{
				message += "Unesite trajanje kursa!";
				uCKurs.TxtTrajanje.BackColor = Color.Coral;
				uCKurs.LblTrajanje.Text += "unesite trajanje kursa!"; ;
				uCKurs.LblTrajanje.Visible = true;
			}
			Regex regex = new Regex(@"^\d+\s*(nedelja|nedelje|mesec|meseci|meseca)$");

            if (!regex.IsMatch(uCKurs.TxtTrajanje.Text))

			{
				message += "Unesite trajanje kursa!";
                uCKurs.TxtTrajanje.BackColor = Color.Coral;
                uCKurs.LblTrajanje.Text += "Definišite da li je u nedeljama ili mesecima npr. 5 nedelja!"; ;
                uCKurs.LblTrajanje.Visible = true;
			}
			//if (!(uCKurs.TxtTrajanje.Text.Contains("nedelja") &&!(uCKurs.TxtTrajanje.Text.Contains("mesec"))))

			//{
			//	message += "Unesite trajanje kursa!";
   //             uCKurs.TxtTrajanje.BackColor = Color.Coral;
   //             uCKurs.LblTrajanje.Text += "Definišite da li je u nedeljama ili mesecima npr. 5 nedelja!"; ;
   //             uCKurs.LblTrajanje.Visible = true;
			//}
			

			
			if (message != "")
			{
				return false;
			}
			return true;
			
		}

	 

			public void VratiSveKurseve()
			{
				List<Kurs> kursevi = Communication.Instance.PretraziSveKurseve();
				if (kursevi == null || kursevi.Count() == 0)
				{
					MessageBox.Show("Sistem nije uspeo da pronadje kurseve");
					return;
				}
			//ucPretraziKurseve.LbKursevi.DataSource = null;
			//ucPretraziKurseve.LbKursevi.DataSource = kursevi;
			//ucPretraziKurseve.LbKursevi.DisplayMember = "NazivKursa
			

					ucPretraziKurseve.DgvKursevi.DataSource = null;
					ucPretraziKurseve.DgvKursevi.DataSource = kursevi;
					ucPretraziKurseve.DgvKursevi.Columns[0].Visible = false;
					ucPretraziKurseve.DgvKursevi.Columns[6].Visible = false;
					ucPretraziKurseve.DgvKursevi.Columns[7].Visible = false;
					ucPretraziKurseve.DgvKursevi.Columns[8].Visible = false;

            ucPretraziKurseve.DgvKursevi.Columns[1].HeaderText = "Naziv kursa";
            ucPretraziKurseve.DgvKursevi.Columns[3].HeaderText = "Opis kursa";
            ucPretraziKurseve.DgvKursevi.Columns[4].HeaderText = "Ukupan broj casova";


            ucPretraziKurseve.TxtPretraga.Text = "";
			
			
                







            ;


        }


    }
}
