using Common;
using Common.Domain;
using DBBroker;
using Server.SystemOperation;
using Server.SystemOperation.SOGrupa;
using Server.SystemOperation.SOJezik;
using Server.SystemOperation.SOKurs;
using Server.SystemOperation.SOPrijava;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controller
    {
        private Broker broker;

        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if(instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller() { broker = new Broker(); }

        public Korisnik Login(Korisnik user)
        {
            UlogujKorisnikaSO so = new UlogujKorisnikaSO(user);
            so.ExecuteTemplate();
            return (Korisnik)so.result;
        }

        internal void DodajKorisnika(Korisnik u)
        {
            ZapamtiKorisnikaSO so = new ZapamtiKorisnikaSO(u);
            so.ExecuteTemplate();
        }

        internal void ZapamtiKurs(Kurs kurs)
        {
            ZapamtiKursSO so = new ZapamtiKursSO(kurs);
            so.ExecuteTemplate();

        }

        internal object VratiKurseve()
        {
            UcitajListuKursevaSO so = new UcitajListuKursevaSO();
            so.ExecuteTemplate();
            return so.result.Cast<Kurs>().ToList();
        }

        internal object VratiKursevePoPretrazi(string search)
        {
            UcitajListuKursevaSO so = new UcitajListuKursevaSO(search) ;
            so.ExecuteTemplate();
            return so.result.Cast<Kurs>().ToList();
        }

        internal Kurs VratiKursSaId(int id)
        {
            UcitajKursSO so = new UcitajKursSO(new Kurs { Id = id });
            so.ExecuteTemplate();
            return (Kurs)so.result;

        }

        internal void AzurirajKurs(Kurs kurs)
        {
            IzmeniKursSO so = new IzmeniKursSO(kurs);
            so.ExecuteTemplate();
        }

        internal void ObrisiKurs(Kurs kurs)
        {
            ObrisiKursSO so = new ObrisiKursSO(kurs);
            so.ExecuteTemplate();
                }

        internal void DodajPrijavu(Prijava prijava)
        {
            ZapamtiPrijavuSO so = new ZapamtiPrijavuSO(prijava);
            so.ExecuteTemplate();
        }

        internal void DodajGrupu(Grupa grupa)
        {
            ZapamtiGrupuSO so = new ZapamtiGrupuSO(grupa);
            so.ExecuteTemplate();
        }

        internal object VratiGrupeZaKurs(Grupa grupa)
        {
            UcitajListuGrupaSo so = new UcitajListuGrupaSo(grupa);
            so.ExecuteTemplate();
            return so.result.Cast<Grupa>().ToList();



        }

        internal object VratiRasporedeZaGrupu(Raspored raspored)
        {
            UcitajListuRasporedaSO so = new UcitajListuRasporedaSO(raspored);
            so.ExecuteTemplate();
            return so.result.Cast<Raspored>().ToList();
        }

        internal void IzmeniGrupu(Grupa grupa)
        {
            IzmeniGrupuSO so = new IzmeniGrupuSO(grupa);
            so.ExecuteTemplate();
        }

        internal object VratiJezike()
        {
            UcitajListuJezikaSO so = new UcitajListuJezikaSO();
            so.ExecuteTemplate();
            return so.result.Cast<Jezik>().ToList();
        }

        internal object VratiGrupuPoId(Grupa grupa)
        {
            UcitajGrupuSO so = new UcitajGrupuSO(grupa);
            so.ExecuteTemplate();
            return (Grupa)so.result;
        }
    }
}
