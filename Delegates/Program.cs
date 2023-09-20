namespace Delegates
{
	internal class Program
	{
		public delegate void MyDelegate(); // Herhangi bir void olan ve parametre almayan metodlara elçilik yapar.
		static void Main(string[] args)
		{
			CustomerManager customerManager = new CustomerManager();
			//customerManager.SendMessage();
			//customerManager.ShowAlert();


			MyDelegate myDelegate = customerManager.SendMessage;
			myDelegate += customerManager.ShowAlert;
			myDelegate();
			
				
			
			Console.ReadLine();
		}
	}
	public class CustomerManager
	{
		public void SendMessage()
		{
			Console.WriteLine("Hello!");
		}
		public void ShowAlert()
		{
			Console.WriteLine("Be Careful!");
		}
	}

	

}