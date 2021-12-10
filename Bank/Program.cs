using Bank.Entities;
using Bank.Exceptions;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter account data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            String holder = Console.ReadLine();

            Console.Write("Initial Balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw Limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Account account = new Account(number, holder, initialBalance, withdrawLimit);
            account.WithDraw(amount);
            Console.Write($"New Balance {account.Balance:C}");
        }
        catch (BankException ex)
        {
            Console.WriteLine("Withdraw error: "+ ex.Message);
        }
    }
}