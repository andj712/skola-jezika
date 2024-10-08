using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public class Receiver
    {

        private NetworkStream _stream;
        private BinaryFormatter _formatter;
        private Socket socket;

        public Receiver(Socket socket)
        {
            this.socket = socket;
            _stream = new NetworkStream(socket);
            _formatter = new BinaryFormatter();
        }

        public object Receive()
        {
            return _formatter.Deserialize(_stream);
        }

    }
}
