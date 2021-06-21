using System;

namespace BankEncapsulation
{
	class Program
	{
		static void Main(string[] args)
		{
			BankAccount account = new BankAccount();
			Console.WriteLine("How much money do you want to deposit?");
			double deposit = double.Parse(Console.ReadLine());
			account.Deposit(deposit);
			double readBalance = account.GetBalance();
			Console.WriteLine($"You deposited {readBalance} into your account.");

			
		}
	}
}
