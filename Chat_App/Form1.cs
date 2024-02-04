using System.ComponentModel;
using System.Net;
using System.Net.Sockets;

namespace Chat_App
{
	public partial class Form1 : Form
	{
		private TcpClient _client;

		private List<TcpClient> _clients;

		public TcpListener listener;
		public StreamReader reader;
		public StreamWriter writer;

		public string receive;
		public string textToSend;
		private string _name = "Danek";

		public Form1()
		{
			InitializeComponent();
			nameBox.Text = _name;
			_clients = new List<TcpClient>();


			IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
			foreach (IPAddress ip in localIP)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					ServerIP.Text = ip.ToString();
				}
			}
		}

		private async void StartServer_Click(object sender, EventArgs e)
		{
			try
			{
				listener = new TcpListener(IPAddress.Any, int.Parse(ServerPort.Text.Trim()));
				listener.Start();
				_client = await listener.AcceptTcpClientAsync();
				reader = new(_client.GetStream());
				writer = new(_client.GetStream());
				writer.AutoFlush = true;
				backgroundWorker1.RunWorkerAsync();
				backgroundWorker2.WorkerSupportsCancellation = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
		}

		private async void ClientosAs()
		{

		}

		private void ConnectClient_Click(object sender, EventArgs e)
		{
			_client = new TcpClient();
			IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(ClientIP.Text.Trim()), int.Parse(ClientPort.Text.Trim()));

			try
			{
				_client.Connect(IpEnd);
				Messages.Text += ("Connect to Server" + "\n");
				writer = new StreamWriter(_client.GetStream());
				reader = new StreamReader(_client.GetStream());
				writer.AutoFlush = true;
				backgroundWorker1.RunWorkerAsync();
				backgroundWorker2.WorkerSupportsCancellation = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			while (_client.Connected)
			{
				try
				{
					receive = reader.ReadLine();
					this.Messages.Invoke(new MethodInvoker(delegate ()
					{
						Messages.Text += (receive + "\n");
					}));
					receive = string.Empty;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message.ToString());
				}
			}
		}

		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			if (_client.Connected)
			{
				writer.WriteLine(textToSend);
				this.Messages.Invoke(new MethodInvoker(delegate ()
				{
					Messages.Text += (textToSend + "\n");
				}));
			}
			else
			{
				MessageBox.Show("Sending failed");
			}
			backgroundWorker2.CancelAsync();
		}

		private void Send_Click(object sender, EventArgs e)
		{
			if (MessText.Text != string.Empty)
			{
				textToSend = _name + ": " + MessText.Text;
				backgroundWorker2.RunWorkerAsync();
			}
			MessText.Text = string.Empty;
		}

		private void Change_Click(object sender, EventArgs e)
		{
			_name = nameBox.Text.Trim();
		}

		private void Local_Click(object sender, EventArgs e)
		{
			ClientIP.Text = "127.0.0.1";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			MessageBox.Show("Danek je borec");
		}
	}
}
