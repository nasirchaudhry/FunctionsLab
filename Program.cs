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
            approved = 3, rejected = 1, escalated = 2
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

            firstLevel(cost, item);
            Console.ReadLine();

        }
        public static void firstLevel(double c, string i) 
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
                Console.WriteLine("Escalating to Second Level Manager");
                secondLevel(c, i);
            }
            else
            {
                decisionMade(choice);
            }
            

        }
        public static void secondLevel(double c, string i)
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
                Console.WriteLine("Escalating to director");
                thirdLevel(c, i);
            }
            else
            {
                
                decisionMade(choice);
            }
        }
        public static void thirdLevel(double c, string i)
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
                Console.WriteLine("Escalating to CEO");
                fourthLevel(c, i);
            }
            else
            {
                
                decisionMade(choice);
            }
        }
        public static void fourthLevel(double c, string i)
        {
            int choice = 0;
            
            Console.WriteLine("Enter 1 to reject or 3 to approve");
            choice = int.Parse(Console.ReadLine());

            decisionMade(choice);
;
        }
        public static void decisionMade(int choice) 
        {
            switch(choice)
            {
                case (int)review.approved:
                    {
                        Console.WriteLine("Expense is approved");
                        break;
                    }
                case (int)review.rejected:
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
