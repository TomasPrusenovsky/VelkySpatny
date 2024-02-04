using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	[Serializable]
	internal class Client
	{
		private TcpClient tcpClient;
		private StreamReader reader;
		private StreamWriter writer;

		private string userName;
		//private Image icon; // nebo tak neco kamo

		public bool Connected { get { return tcpClient.Connected; } }

		public Client(TcpClient tcpClient)
		{
			userName = "danek";
			// tomas smrdi
			this.tcpClient = tcpClient;
			reader = new(this.tcpClient.GetStream());
			writer = new(this.tcpClient.GetStream());
			writer.AutoFlush = true;
		}

		private string? ReadMessage()
		{
			string? message;
			try
			{
				message = reader.ReadLine();
				return message;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "Client class");
			}
			return null;
		}

		public async Task<string> AwaitMessage()
		{
			return await reader.ReadLineAsync();
		}

		//public string HandleMessage()
		//{
		//	string? message = reader.ReadLine();
		//	if (message == null)
		//		return string.Empty;
		//	return message;
		//}
	}
}
