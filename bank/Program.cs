namespace bank
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to macamza Bank");


            BankAccount mybank = new BankAccount();
            savingsAccount savings = new savingsAccount();
            String? userselection, userinput;
            while (true)
            {
                Console.WriteLine("Press c for card and any button for cardless");
            userinput = Console.ReadLine();
                if (userinput == "c")
                {
                    
                Console.WriteLine("Press L to login and C to create account");
                String? Userinput2= Console.ReadLine();

                if (userinput == "l")
                {
                    Console.WriteLine("Enter your account number");
                    String? acccount_number = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter your accountname");

                    String? AccountHolderName = Convert.ToString(Console.ReadLine());
                    if (acccount_number == "12345" && AccountHolderName == "Tsiko")
                    {
                        while (true)
                        {
                            Console.WriteLine("press D to deposit  W to widthdraw  B to view balance u to change pin");
                            userselection = Convert.ToString(Console.ReadLine());

                            if (userselection == "d")
                            {
                                mybank.Deposit();
                            }

                            else if (userselection == "b")
                            {

                            }
                            else if (userselection == "w")
                            {
                                mybank.Withdraw();
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }
                        }

                    }
                    else if(Userinput2=="c")
                    {
                        savings.create_account();
                    }
                    

                    else
                    {
                        Console.WriteLine("Invalid account name or account number");
                    }
                }

                }

                else
                {
                    mybank.cardless_transaction();
                }
                


                }
            }
    }
}