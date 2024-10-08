using Client.UserControls.UCGrupa;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Communication
    {

        private static Communication _instance;
        public static Communication Instance { 
            get 
            {
                if( _instance == null ) _instance = new Communication();
                return _instance;
            } 
        }

        public Korisnik User { get; internal set; }

        private Communication()
        {
            
        }

        Socket socket;
        Sender sender;
        Receiver receiver;

        public bool Connect()
        {
            try
            {
                if (socket == null || !socket.Connected)
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(ConfigurationManager.AppSettings["ip"], int.Parse(ConfigurationManager.AppSettings["port"]));
                    sender = new Sender(socket);
                    receiver = new Receiver(socket);
                }
                return true;
            }
            catch (SocketException)
            {
                System.Windows.Forms.MessageBox.Show("Greška u povezivanju");
                return false;
            }
        }
        public void Close()
        {
            socket?.Close();
            socket = null;
        }
        internal Korisnik Login(Korisnik user)
        {
            Request req = new Request
            {
                Argument = user,
                Operation = Operation.Login
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            if (response.Message != null)
            {
               // System.Windows.Forms.MessageBox.Show("Korisnik je vec ulogovan!","Neuspešno");
                return null;
            }
            if (response != null)
            {
                User = (Korisnik)response.Result;
            }
            else System.Windows.Forms.MessageBox.Show("Ne postoji korisnik sa zadatim kredencijalima", "Neuspešno");

            return (Korisnik)response.Result;
        }

        public Response DodajKorisnika(Korisnik user)
        {
            
                Request request = new Request
                {
                    Operation = Operation.AddUser,
                    Argument = user
                };
            
                sender?.Send(request);
                Response response = (Response)receiver.Receive();
                return response;
            
            
        }

        internal Response ZapamtiKurs(Kurs kurs)
        {
            Request request = new Request(Operation.ZapamtiKurs, kurs);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal List<Kurs> PretraziSveKurseve()
        {
            Request request = new Request(Operation.VratiKurseve, null);
            sender.Send(request);
            Response res= (Response)receiver.Receive();
            return (List<Kurs>)res.Result;
        }

        internal List<Kurs> SearchKursByName(string pretraga)
        {
            Request request = new Request(Operation.VratiKursevePoPretrazi, pretraga);
            sender.Send(request);
            Response res=(Response)receiver.Receive();
            return (List<Kurs>)res.Result;
        }

        internal Kurs GetKursById(int id)
        {
            Request request = new Request(Operation.VratiKursSaId, id);
            sender.Send(request);
            Response res = (Response)receiver.Receive();
            return (Kurs)res.Result;
        }

        internal Response IzmeniKurs(Kurs kurs)
        {
            Request request = new Request(Operation.AzurirajKurs, kurs);
            sender.Send(request);
            Response res = (Response)receiver.Receive();
            return res;
        }

        internal Response IzbrisiKurs(Kurs kurs)
        {
            Request request = new Request(Operation.IzbrisiKurs, kurs);
            sender.Send(request);
            Response res = (Response)receiver.Receive();
            return res;
        }

        internal Response PrijavaNaKurs(Prijava prijava)
        {
            Request request = new Request(Operation.DodajPrijavu, prijava);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal Response ZapamtiGrupu(Grupa grupa)
        {
            Request request = new Request
            {
                Operation = Operation.ZapamtiGrupu,
                Argument = grupa
            };

            sender?.Send(request);
            Response response = (Response)receiver.Receive();
            return response;
        }

        

        internal List<Grupa> VratiSveGrupeZaKurs(Grupa grupa)
        {
            Request request = new Request
            {
                Operation = Operation.VratiGrupeZaKurs,
                Argument = grupa
            };

            sender?.Send(request);
            Response response = (Response)receiver.Receive();
            return (List<Grupa>)response.Result;
        }

        internal List<Raspored> VratiRasporedeZaGrupu(Raspored raspored)
        {
            Request request = new Request
            {
                Operation = Operation.VratiRasporedeZaGrupu,
                Argument = raspored
            };

            sender?.Send(request);
            Response response = (Response)receiver.Receive();
            return (List<Raspored>)response.Result;
        }

        internal Response IzmeniGrupu(Grupa grupa)
        {
            Request request = new Request
            {
                Operation = Operation.IzmeniGrupu,
                Argument = grupa
            };

            sender?.Send(request);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response Logout()
        {
            try
            {
                Request request = new Request
                {
                    Operation = Operation.Logout,
                    Argument = Communication.Instance.User
                };

                sender?.Send(request);
                Response response = (Response)receiver?.Receive();
                return response;
            }
            catch (IOException ex)
            {

                Debug.WriteLine(ex.Message);
                
                return null;
            }

        }

        internal List<Jezik> VratiJezike()
        {
            Request request = new Request
            {
                Operation = Operation.VratiJezike,
                Argument = null
            };

            sender?.Send(request);
            Response response = (Response)receiver.Receive();
            return (List<Jezik>)response.Result;
        }

        internal Grupa GetGrupaById(Grupa grupa)
        {
            Request request = new Request
            {
                Operation = Operation.VratiGrupuPoId,
                Argument = grupa
            };

            sender?.Send(request);
            Response response = (Response)receiver.Receive();
            return (Grupa)response.Result;
        }
    }
}
