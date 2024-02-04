using System.ComponentModel;

namespace Server
{
	public partial class ServerForm : Form
	{
		private Server server;
		private int port = 3333;
		public ServerForm()
		{
			InitializeComponent();
			server = new Server(port);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			MessageBox.Show("Danek je borec", "Je to tak");
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			server.Start();
			backgroundWorker1.RunWorkerAsync();
			backgroundWorker2.RunWorkerAsync();
			backgroundWorker3.RunWorkerAsync();
		}

		private void RefreshButton_Click(Object sender, EventArgs e)
		{
			MessagesBox.Text = server.allMessages;
		}

		private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			MessageBox.Show("Worker running");
			while (true)
			{
				try
				{
					await server.HandleMessages();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Worker 1");
				}
			}
		}

		private async void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			while (true)
			{
				try
				{
					await server.HandleConnection();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Worker 2");
				}

			}
		}

        private async void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
		{
			await server.ProcessMessages();
		}


    }
}
