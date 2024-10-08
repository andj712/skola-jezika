using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {

        Socket socket;
        public static List<ClientHandler> clients = new List<ClientHandler>();
        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Start()
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));

                socket.Bind(endPoint);
                socket.Listen(5);
            }
            catch (SocketException)
            {
                System.Windows.Forms.MessageBox.Show("Greška pri povezivanju");
            }

            Thread thread = new Thread(AcceptClient);
            thread.IsBackground = true;
            thread.Start();

        }
        public void AcceptClient()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = socket.Accept();
                    ClientHandler handler = new ClientHandler(klijentskiSoket);
                    Thread klijentskaNit = new Thread(handler.HandleRequest);
                    klijentskaNit.IsBackground = true;
                    klijentskaNit.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>>>>>>" + ex.Message);
                Stop();
            }
        }

        public void Stop()
        {
            foreach (ClientHandler handler in clients) handler.Close();
            clients.Clear();
            socket?.Close();
        }

    } 
}
