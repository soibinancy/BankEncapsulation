namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();


            Console.WriteLine("Banking App");
            Console.WriteLine("----------------");

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Deposit money");
                Console.WriteLine("3. Exit");

                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;
                }

                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter the amount you would like to deposit:");
                        double amount;
                        if(!double.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                            continue;
                        }

                        account.Deposit(amount);
                        Console.WriteLine("Deposit was successful!");
                        break;
                    case 2:
                        Console.WriteLine($"Current balance: {account.GetBalance()}");
                        break;
                    case 3:
                        Console.WriteLine("Thank you for using the Banking App!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. PLease emter a valid option.");
                    break;

                }

            }
      
        }
    }
}
