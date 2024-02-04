namespace Dankord
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			InitializeDankord();

			string LocalUsername = "pepa";

			Messager messager = new(new(LocalUsername));
		}

		static void InitializeDankord()
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new Dankord());
		}
	}
}