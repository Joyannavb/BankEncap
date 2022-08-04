using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class Program
    {
        public static double DepositAmount()
        {
            Console.WriteLine("How much would you like to deposit?");
            var deposit = Console .ReadLine();
            bool isNumber = double.TryParse(deposit, out double result);
            do
            {
                Console.WriteLine("How much would you like to deposit?");
            } while (isNumber == false);

            return result;
        }


        public static void UserEngagment()
        {
            var account = new BankAccount();
            string userImput;

            do
            {
                Console.WriteLine("If you would like to see your balance, please enter 'balance'.");
                Console.WriteLine("If you would like to make a deposit, please enter 'deposit'.");
                userImput = Console.ReadLine();
            }
            while (userImput != "balance" && userImput != "deposit");


            if (userImput == "balance")
            {
                Console.WriteLine($" Account Balance: ${account.GetBalance()}");
            }
            else if (userImput == "deposit")
            {
                account.Deposit(DepositAmount());
            }

            

        }

        static void Main(string[] args)
        {
            UserEngagment();
            Console.WriteLine("Thank you for your buissness!");
        }
    }
}
