namespace Dankord
{
	public class Messager(LocalUser LocalUser)
	{
		public LocalUser LocalUser = LocalUser;
		public LocalUser? RemoteUser;

		public void Connect(string IP, string Port = "25565")
		{

		}

		public void Disconnect(LocalUser user)
		{

		}

		public void SendMessage(string message)
		{
		}

		public void ReceivedMessage(string message)
		{

		}
	}

	public class LocalUser(string Username)
	{
		public string Username = Username;
		public Image? Icon;



		public void ChangeUsername()
		{

		}

		public void ChangeIcon()
		{

		}
	}

	public class RemoteUser(string Username, string IP, string Port) : LocalUser(Username)
	{
		public readonly string IP = IP;
		public readonly string Port = Port;
	}
}