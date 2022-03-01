using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_II
{


    class Account
    {
        private long accountNo { get; set; }
        private double accountBalance { get; set; }
        private string accountPassword { get; set; }
        private string bankName { get; set; }

        public Account()
        {
            this.accountNo = 123456789;
            this.accountBalance = 50123.23;
            this.accountPassword = "praveen123";
            this.bankName = "HDFC";
        }

        public Account(long number, double balance, string password, string bank_name)
        {
            this.accountNo = number;
            this.accountBalance = balance;
            this.accountPassword = password;
            this.bankName = bank_name;
        }

        

            public void displayAccount()
            {

                Console.WriteLine("\n\n--------WELCOME---------");
                Console.WriteLine("Your account details are as follows: ");
                Console.WriteLine("Bank Name: {0}", bankName);
                Console.WriteLine("Account Number: {0}", accountNo);
                Console.WriteLine("Account Password: {0}", accountPassword);
                Console.WriteLine("Bank Name: {0}", bankName);

            }
        
    



            public static void Main()
            {
                Account a = new Account();
                Console.WriteLine("\n Calling the default constructor");
                a.displayAccount();

                Console.Write("\nEnter your account number: ");
                long number = Convert.ToInt64(Console.ReadLine());
                Console.Write("\nEnter your account balance: ");
                double balance = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nEnter your password: ");
                string password = Console.ReadLine();
                Console.Write("\nEnter your bank name: ");
                string bank_name = Console.ReadLine();

            Console.WriteLine("enter the Bank minimum balance");
            int minimumbalance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bank minium balance is" + minimumbalance);

            Console.WriteLine("enter the Bank overdraft balance");
            int overdraft = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bank overdraft balance is" + overdraft);

            Console.WriteLine("\nCalling the parameterized constructor");
                Account a1 = new Account(number, balance, password, bank_name);
                a1.displayAccount();
                Console.ReadLine();

            




            SavingAccount1 savingAccount1 = new SavingAccount1();
            savingAccount1.displayAccount();
           
            CurrentAccount  currentAccount = new CurrentAccount();
            currentAccount.displayAccount();







            }
        }

    internal class SavingAccount1 : Account
    {
        internal int minimumBalance;
        public virtual void display(int minimumBalance)
        {
            Console.Write("\n Your minimum balance is : " + minimumBalance);
        }
    }

    internal class CurrentAccount : Account
    {
        internal int overdraftLimitAmount;
        public virtual void display(int overdraftLimitAmount)
        {
            overdraftLimitAmount = 7575;
            Console.Write("\n Your overdraft limit amount : " + overdraftLimitAmount);
        }
    }


}


    
