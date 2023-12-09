using System;

class Program
{
    static void Main()
    {
        bool running = true;
        do
        {
            Console.WriteLine("\tWelcome to the sewerage billing system");
            Console.WriteLine("Below are the types of usage with their respective codes");
            Console.WriteLine("\n1 Residential");
            Console.WriteLine("2 Commercial");
            Console.WriteLine("3 Industrial");

            int typeOfUsage;
            decimal monthlyConsumption;

            while (true)
            {
                Console.WriteLine("Enter your code:");
                string userInputTypeOfUsage = Console.ReadLine();

                if (int.TryParse(userInputTypeOfUsage, out typeOfUsage) && typeOfUsage <= 3 && typeOfUsage > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid code!!");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter your monthly consumption");
                string userInputAmountOfUsage = Console.ReadLine();
                if (decimal.TryParse(userInputAmountOfUsage, out monthlyConsumption) && monthlyConsumption > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Monthly consumption input!!");
                }
            }

            static decimal ResidentialBillingAlgorithm(decimal monthlyConsumption)
            {
                decimal monthlySewerageBill = monthlyConsumption * 10.00m;
                Console.WriteLine($"Your monthly sewerage bill is :{monthlyConsumption}/cm^3 * 10.00 = {monthlySewerageBill}kes");
                return monthlySewerageBill;
            }

            static decimal CommercialBillingAlgorithm(decimal monthlyConsumption)
            {
                decimal monthlySewerageBill = monthlyConsumption * 12.50m;
                Console.WriteLine($"Your monthly sewerage bill is :{monthlyConsumption}/cm^3 * 12.50 = {monthlySewerageBill}kes");
                return monthlySewerageBill;
            }

            static decimal IndustrialBillingAlgorithm(decimal monthlyConsumption)
            {
                decimal monthlySewerageBill = monthlyConsumption * 15.00m;
                Console.WriteLine($"Your monthly sewerage bill is :{monthlyConsumption}/cm^3 * 15.00 = {monthlySewerageBill}kes");
                return monthlySewerageBill;
            }

            if (typeOfUsage == 1)
            {
                ResidentialBillingAlgorithm(monthlyConsumption);
            }
            else if (typeOfUsage == 2)
            {
                CommercialBillingAlgorithm(monthlyConsumption);
            }
            else if (typeOfUsage == 3)
            {
                IndustrialBillingAlgorithm(monthlyConsumption);
            }

            bool proceed = true;
            while (proceed)
            {
                Console.Write("\nRerun Sewage bill calculator? (Y/N)");
                string run = Console.ReadLine();
                switch (run.ToUpper())
                {
                    case "YES":
                        proceed = false;
                        Console.Clear();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case "Y":
                        proceed = false;
                        Console.Clear();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case "NO":
                        running = false;
                        proceed = false;
                        Console.WriteLine("Press enter to Exit");
                        Console.ReadLine();
                        break;
                    case "N":
                        running = false;
                        proceed = false;
                        Console.WriteLine("Press enter to Exit");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Wrong input made!");
                        Console.WriteLine("Press enter to Retry");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        } while (running);

    }



}