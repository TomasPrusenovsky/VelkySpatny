using System.Diagnostics;

namespace Dankord
{
	public partial class Dankord : Form
	{
		public Dankord()
		{
			InitializeComponent();
			Zpravy.Text = string.Empty;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
		}

		public void ShowText(string text)
		{
			Zpravy.Text += text + '\n';
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Create an instance of PrintDialog
			PrintDialog printDialog = new PrintDialog();

			// Show the print dialog and check if the user clicked OK
			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				// Perform printing actions here
				Shutdown();
			}

			ShowText(textInput.Text);
			textInput.Text = string.Empty;
		}

        static void Shutdown()
        {
            // Create a ProcessStartInfo object and set the FileName and Arguments properties
            ProcessStartInfo psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;

            // Create and start the process using the ProcessStartInfo object
            Process.Start(psi);
        }
    }
}
