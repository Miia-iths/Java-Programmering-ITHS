using System;

namespace BankSimulator
{
	class Program
	{
		static void Main(string[] args)
        {
           decimal balance = 0; //starting balance
           bool running = true; //keeps the main loop going

           while (running)
           {
                //display the main menu
                Console.WriteLine("\nBanking Options:");
                Console.WriteLine("\n[D] Deposit");
                Console.WriteLine("[W] Withdrawal");
                Console.WriteLine("[B] Balance");
                Console.WriteLine("[I] Interest Calculation");
                Console.WriteLine("[E] Exit\n");

                //input menu option
                Console.Write("What can we help you with today: ");
                string? menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "D":
                    case "d": //found it cleaner to give two choices rather than converting ToUpper
                        bool validDeposit = false;
                        while (!validDeposit)
                        {
                            Console.Write("\nHow much would you like to deposit?: ");
                            string? userInput = Console.ReadLine();

                            //making sure it's a valid input - I needed some help with the best way to formulate it, but easy to reuse after
                            if (decimal.TryParse(userInput, out decimal depositAmount) && depositAmount > 0)
                            {
                                validDeposit = true;
                                balance += depositAmount;
                                Console.WriteLine($"Deposit successful {depositAmount:C}. Your new balance is: {balance:C}.");
                                //found out that :C could be used for the current computer settings currency settings - neat
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount. Please enter valid numbers.");
                            }
                        }
                        break;

                    case "W":
                    case "w":
                        bool validWithdrawal = false;
                        while (!validWithdrawal)
                        {
                            Console.Write("\nHow much would you like to withdraw?: ");
                            string? userInput = Console.ReadLine();

                            if (decimal.TryParse(userInput, out decimal withdrawalAmount) && withdrawalAmount > 0)
                            {
                                //making sure there's enough balance for withdrawal
                                if (withdrawalAmount <= balance)
                                {
                                    validWithdrawal = true;
                                    balance -= withdrawalAmount;
                                    Console.WriteLine($"Withdrawal successful {withdrawalAmount:C}. Your remaining balance is: {balance:C}.");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds. Please enter amount witihn your balance.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount. Please enter valid numbers.");
                            }
                        }
                        break;

                    case "B":
                    case "b":
                        Console.WriteLine($"\nCurrent balance: {balance:C}.");
                        break;

                    case "I":
                    case "i": //setting everything to 0 so it can be used over and over
                        decimal calDeposit = 0;
                        decimal calInterest = 0;
                        int calYears = 0;
                        decimal calBalance = 0;

                        Console.WriteLine("Interest Calculator.");

                        //deposit input
                        bool validCalDep = false;
                        while (!validCalDep)
                        {
                            Console.WriteLine("Annual deposit: ");
                            string? depositInput = Console.ReadLine();
                            
                            if (decimal.TryParse(depositInput, out calDeposit) && calDeposit > 0)
                            {
                                validCalDep = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid deposit amount. Please enter valid numbers.");
                            }
                        }

                        //interest rate input
                        bool validInterest = false;
                        string? interestInput = ""; //saving the users input to present in the finished calculation
                        while (!validInterest)
                        {
                            //I thought of finding a way to remove the input of "%" but I picture standing at a machine, there you usually just put in numbers
                            Console.WriteLine("Interest rate (in %) :");
                            interestInput = Console.ReadLine();
                            
                            if (decimal.TryParse(interestInput, out calInterest) && calInterest > 0)
                            {
                                //converting percentage to correct decimalform +1
                                validInterest = true;
                                calInterest = calInterest / 100 + 1;
                            }
                            else
                            {
                                Console.WriteLine("Invalid interest rate. Please enter valid numbers.");
                            }
                        }

                        //years input
                        bool validYears = false;
                        while (!validYears)
                        {
                            Console.WriteLine("Years: ");
                            string? yearsInput = Console.ReadLine();
                            
                            if (int.TryParse(yearsInput, out calYears) && calYears > 0)
                            {
                                validYears = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid number of years. Please enter a valid number.");
                            }
                        }

                        //interest calculation loop
                        //the for loop to repeat it a certain number of years
                        for (int i = 0; i < calYears; i++) //I had to look up the specific formula for this calculation but now I know of the i=index, good to know
                        {
                            calBalance += calDeposit;
                            calBalance *= calInterest;
                        }
                            Console.WriteLine($"After {calYears} years, with an annual deposit of {calDeposit:C} and with a {interestInput}% interest rate\nYour balance would come to {calBalance:C}.");
                        break;

                    case "E":
                    case "e":
                        Console.WriteLine("\nThank you for using the bank simulator. Have a wonderful day!");
                        running = false; //stopping the program loop
                        break;

                    default: //last precation for invalid inputs
                        Console.WriteLine("Invalid choice, please enter a valid option from the menu.");
                        break;
                }
           }
        }
    }
}