using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
	internal class Server
	{
		private TcpListener listener;
		private List<Client> clientPool = new List<Client>();
		public string allMessages;

		public Server(int port)
		{
			listener = new TcpListener(IPAddress.Any, port);
			allMessages = string.Empty;
		}

		public void Start()
		{
			try
			{
				listener.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "Internal Server");
			}
		}

		public async Task HandleConnection()
		{
			Client client = new Client(await listener.AcceptTcpClientAsync());
			clientPool.Add(client);
		}

		public async Task HandleMessages()
		{
			await Parallel.ForEachAsync(clientPool,  await =>
			{
				if (client == null) // TODO: shift clientPool
					continue;
				if (!client.Connected)
					continue;

				try
				{
					allMessages += await client.AwaitMessage() + "\n";
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message.ToString(), "Internal client");
				}
			});

		}
	}
}
