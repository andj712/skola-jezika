using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Sender sender;
        private Receiver receiver;
        private Socket socket;
        private Korisnik user;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        public void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Request req = (Request)receiver.Receive();
                    Response r = ProcessRequest(req);
                    sender.Send(r);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>>>>" + ex.Message);
                Server.clients.Remove(this);
                socket.Close();
            }
            catch(SerializationException ex)
            {
                Debug.WriteLine(">>>>>>" + ex.Message);
                Server.clients.Remove(this);
                socket.Close();
            }

        }

        private Response ProcessRequest(Request req)
        {
            Response r = new Response();
            try
            {

                switch (req.Operation)
                {

                    case Operation.Login:

                        r.Result = Controller.Instance.Login((Korisnik)req.Argument);
                        user = (Korisnik)r.Result;
                        List<ClientHandler> klijenti = Server.clients;
                        foreach (ClientHandler client in klijenti)
                        {
                            if (client.user.Equals(user)) r.Message = "Korisnik sa tim korisnickim imenom je vec ulogovan";
                        };
                        if (r.Message == null) Server.clients.Add(this);

                        break;
                    case Operation.AddUser:
                        r.Message = "Sistem ne može da zapamti korisnički nalog!";
                        Controller.Instance.DodajKorisnika((Korisnik)req.Argument);
                        r.Message = "Sistem je zapamtio korisnički nalog !";
                        break;
                    case Operation.ZapamtiKurs:
                        r.Message = "Sistem ne može da zapamti kurs!";
                        Controller.Instance.ZapamtiKurs((Kurs)req.Argument);
                        r.Message = "Sistem je uspesno kreirao kurs!";
                        break;
                    case Operation.VratiKurseve:
                        r.Result = Controller.Instance.VratiKurseve();

                        break;
                    case Operation.VratiKursevePoPretrazi:
                        r.Result = Controller.Instance.VratiKursevePoPretrazi((string)req.Argument);
                        break;
                    case Operation.VratiKursSaId:
                        r.Result = Controller.Instance.VratiKursSaId((int)req.Argument);
                        break;
                    case Operation.AzurirajKurs:
                        r.Message = "Sistem nije izmenio kurs!";
                        Controller.Instance.AzurirajKurs((Kurs)req.Argument);
                        r.Message = "Sistem je uspesno izmenio kurs!";

                        break;
                    case Operation.IzbrisiKurs:
                        r.Message = "Sistem nije izbrisao kurs! Proverite postoje li grupe za kurs";
                        Controller.Instance.ObrisiKurs((Kurs)req.Argument);
                        r.Message = "Sistem je uspesno izbrisao kurs!";
                        break;
                    case Operation.DodajPrijavu:
                        r.Message = r.Message = "Sistem nije zapamtio prijavu!";
                        Controller.Instance.DodajPrijavu((Prijava)req.Argument);
                        r.Message = "Sistem je uspesno zapamtio prijavu!";

                        break;
                    case Operation.ZapamtiGrupu:
                        r.Message = "Sistem nije zapamtio grupu!";
                        Controller.Instance.DodajGrupu((Grupa)req.Argument);
                        r.Message = "Sistem je uspešno zapamtio grupu!";
                        break;
                    case Operation.VratiGrupeZaKurs:
                        r.Result = Controller.Instance.VratiGrupeZaKurs((Grupa)req.Argument);

                        break;
                    case Operation.VratiRasporedeZaGrupu:
                        r.Result = Controller.Instance.VratiRasporedeZaGrupu((Raspored)req.Argument);
                        break;
                    case Operation.IzmeniGrupu:
                        r.Message = "Sistem ne može da zapamti grupu!";
                        Controller.Instance.IzmeniGrupu((Grupa)req.Argument);
                        r.Message = "Sistem je zapamtio grupu!";
                        break;
                    case Operation.Logout:
                        Server.clients.Remove(this);
                        r.Message = "Izlogovani ste!";
                        break;
                    case Operation.VratiJezike:
                        r.Result = Controller.Instance.VratiJezike();
                        break;
                    case Operation.VratiGrupuPoId:
                        r.Result = Controller.Instance.VratiGrupuPoId((Grupa)req.Argument);
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                Server.clients.Remove(this);
                r.Exception = ex;
                Debug.WriteLine(ex.Message);
            }
            return r;
        }
        public void Close()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket?.Close();
        }
    }
}
