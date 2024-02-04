using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server_Chat
{
    internal class Client
    {
        private TcpClient tcpClient;
        private StreamReader STR;
        private StreamWriter STW;

        public Client(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;
            STR = new StreamReader(this.tcpClient.GetStream());
            STW = new StreamWriter(this.tcpClient.GetStream());
        }
    }
}
