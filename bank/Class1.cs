using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class BankAccount
    {

        string Accountnumber,AccountHolderName;
        Double Balance;


        public BankAccount() 
        {
            Accountnumber ="12345";
            AccountHolderName ="Tsiko";
            Balance = 500;
        }
        public void create_account()
        {
           
            {
                Console.WriteLine("Create Account");
                Console.WriteLine();
                Console.WriteLine("Enter your name");
                String? Name=Console.ReadLine();
                Console.WriteLine("Enter your surname");
                string? Surname=Console.ReadLine();
                Console.WriteLine("Enter your gender");
                String? Gender=Console.ReadLine();
                Console.WriteLine("Enter your ID NUMBER/PASSPORT NUMBER");
                String? ID=Console.ReadLine();
                Console.WriteLine("Enter your Address");
                String? Address=Console.ReadLine();

                Console.WriteLine("Choose account A for credit, B for debit");
                String? user_input=Console.ReadLine();

                if(user_input == null)
                {
                    Console.WriteLine("an Error has occurred");
                }
                else if (user_input =="a")
                {
                    Console.WriteLine("Account creation successfull");

                    Console.WriteLine("Account details");
                    Console.WriteLine("Account Holder       :"+Surname+" "+Name);
                    Console.WriteLine("Bank Name            :Macamza Bank");
                    Console.WriteLine("Branch Code          :554428");
                    Console.WriteLine("Account type         :Credit");        
                    Console.WriteLine("Account Number       :");






                }
                else 
                {
                    Console.WriteLine("Account creation successfull");

                    Console.WriteLine("Account details");
                    Console.WriteLine("Account Holder       :" + Surname + " " + Name);
                    Console.WriteLine("Bank Name            :Macamza Bank");
                    Console.WriteLine("Branch Code          :554428");
                    Console.WriteLine("Account type         :Debit");
                    Console.WriteLine("Account Number       :");


                }


                Random r = new Random();

                int[] numbers = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    numbers[i] = r.Next(1, 9);
                }

                for (int show = 0; show < 5; show++)
                {
                    Console.WriteLine(numbers[show]);
                }
            }
        }
        

        public void Deposit()
        {
       
            Console.WriteLine("Enter the amount you want to deposit");
            int amount = Convert.ToInt32(Console.ReadLine());
            Balance += amount;
            Console.WriteLine("your balance is changed to : " + Balance);

        }
        public virtual void Withdraw()
        {
            if (Balance < 100)
            {
                Console.WriteLine("Make a Deposit as soon as posible");
                Console.WriteLine();
                double Widthdrawal_amount;
                Console.WriteLine($"Enter the widthdrawal amount");
                Widthdrawal_amount = Convert.ToInt32(Console.ReadLine());
                if (Balance < Widthdrawal_amount)
                {
                    Console.WriteLine("Insufficient funds ");
                }

                Console.WriteLine();
                Balance = Balance - Widthdrawal_amount;
                Console.WriteLine("Your new balance has been changed to : " + Balance);
            
            }
            
            else
            {
                double Widthdrawal_amount;
                Console.WriteLine($"Enter the widthdrawal amount");
                Widthdrawal_amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Balance = Balance - Widthdrawal_amount;
                Console.WriteLine("Your new balance has been changed to : " + Balance);

            }
        


        }
        public void cardless_transaction()
        {
            Console.WriteLine("Welcome to Cardless Banking");
            Console.WriteLine("Enter your cell number");
            int phoneN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter w to withdraw or s to send money");
            String? userInput=Console.ReadLine();
            if(userInput=="w")
            {
                double amount=0;
                Console.WriteLine("enter the amount you want to withdraw");
                Double useramount = Convert.ToDouble(Console.ReadLine());
                amount=amount - useramount;
                Console.WriteLine("Your balance R" + amount);


            }
            
             else if(userInput=="s")
             {
                Console.Write("Enter the amount you want to send :");
                Console.WriteLine();
                int amount = Convert.ToInt32(Console.ReadLine());
                int Total=amount+10;
                Console.WriteLine("Total cost is R" + Total);
                Console.WriteLine("press enter to confirm");
                Console.ReadKey();

                if (amount < 10)
                {
                    Console.WriteLine("Invalid Amount");
                }
                else { Console.WriteLine("Successfull"); }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
  }

        }
    }
}
