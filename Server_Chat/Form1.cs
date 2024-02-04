using System.Net;
using System.Net.Sockets;

namespace Server_Chat
{
    public partial class Form1 : Form
    {
        private List<Client> clients = new List<Client>();
        public TcpListener listener;

        public Form1()
        {
            InitializeComponent();

        }

        private async void Strart_Click(object sender, EventArgs e)
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, int.Parse(PortBox.Text.Trim()));
                listener.Start();
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private async void ClientAccept()
        {
            while (true)
            {
                clients.Add(new Client(await listener.AcceptTcpClientAsync()));
                MessageBox.Show("new client");
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ClientAccept();
        }
    }
}
