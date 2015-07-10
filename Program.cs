using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLab
{
    class Program
    {
        enum review
        {
            approved, rejected, escalated
        };

        static void Main(string[] args)
        {
            double cost = 0;
            string item = " ";
            int decision = 0;
            //string userInput = "no";
            Console.WriteLine("Enter description of expense: ");
            item = Console.ReadLine();
            Console.WriteLine("Enter cost of item to expense: ");
            cost = double.Parse(Console.ReadLine());

            decision = firstLevel(cost, item);
            decision = secondLevel(cost, item);
            decision = thirdLevel(cost, item);
            decision = fourthLevel(cost, item);

        }
        public static int firstLevel(double c, string i) 
        {
            int choice = 0;            
            if (i.Contains("entertainment"))
            {
                choice = (int)review.rejected;
            }
            else if (c > 250) 
            {
                Console.WriteLine("Enter 1 to reject or 2 to escalate");
                choice = int.Parse(Console.ReadLine());
            }
            else 
            {
                Console.WriteLine("Enter 1 to reject or 2 to escalate and 3 to approve");
                choice = int.Parse(Console.ReadLine());
            }
            if (choice == (int)review.escalated)
            {
                secondLevel(c, i);
            }
            else
            {
                decisionMade(choice);
            }
            return choice;

        }
        public static int secondLevel(double c, string i)
        {
            int choice = 0;
            if (i.Contains("towncars"))
            {
                choice = (int)review.rejected;
            }
            else if (c > 500)
            {
                Console.WriteLine("Enter 1 to reject or 2 to escalate");
                choice = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter 1 to reject or 2 to escalate and 3 to approve");
                choice = int.Parse(Console.ReadLine());
            }
            if (choice == (int)review.escalated)
            {
                thirdLevel(c, i);
            }
            else
            {
                decisionMade(choice);
            }
            return choice;
        }
        public static int thirdLevel(double c, string i)
        {
            int choice = 0;
            if (i.Contains("hardware"))
            {
                choice = (int)review.rejected;
            }
            if (c > 1000)
            {
                Console.WriteLine("Enter 1 to reject or 2 to escalate");
                choice = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter 1 to reject or 2 to escalate and 3 to approve");
                choice = int.Parse(Console.ReadLine());
            }
            if (choice == (int)review.escalated)
            {
                fourthLevel(c, i);
            }
            else
            {
                decisionMade(choice);
            }
            return choice;
        }
        public static int fourthLevel(double c, string i)
        {
            int choice = 0;
            
            Console.WriteLine("Enter 1 to reject or 3 to approve");
            choice = int.Parse(Console.ReadLine());
            
            return choice;
        }
        public static void decisionMade(int choice) 
        {
            switch(choice)
            {
                case 0:
                    {
                        Console.WriteLine("Expense is approved");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Expense is rejected");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }                
        }
    }
}
