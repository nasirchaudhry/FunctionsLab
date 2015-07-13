using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLab
{
    /// <summary>
    /// This program would approve or reject expense, each level of management can only approve expense upto a certain amount
    /// 1st Level Manager can approve any expense upto $250 but won't approve entertainment
    /// 2nd Level Manager can approve any expense upto $500 but won't approve towncars
    /// Director can approve any expense uptop $1000 but won't approve hardware>5000
    /// CEO could approve anything
    /// </summary>

    //start class program
    class Program
    {
        enum review
        {
            approved = 3, rejected = 1, escalated = 2
        };

        //start main method
        static void Main(string[] args)
        {
            //Declare variables
            double cost = 0;
            string item = " ";

            //Prompt user to enter the description & cost of item
            Console.WriteLine("Please enter description of expense: ");
            item = Console.ReadLine();
            Console.WriteLine("Please enter cost of item to expense: ");
            cost = double.Parse(Console.ReadLine());

            firstLevelManager(cost, item);
            Console.ReadLine();

        }//End main method

        //Declaring conditions for 1st Level manager authority
        public static void firstLevelManager(double c, string i)
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
                secondLevelManager(c, i);
            }
            else
            {
                decisionMade(choice);
            }
        }

        //Declaring conditions for 2nd Level manager authority
        public static void secondLevelManager(double c, string i)
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
                directorLevel(c, i);
            }
            else
            {
                decisionMade(choice);
            }
        }

        //Declaring conditions for Director authority
        public static void directorLevel(double c, string i)
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
                ceoLevel(c, i);
            }
            else
            {
                decisionMade(choice);
            }
        }

        //Declaring conditions for CEO authority
        public static void ceoLevel(double c, string i)
        {
            int choice = 0;

            Console.WriteLine("Enter 1 to reject or 3 to approve");
            choice = int.Parse(Console.ReadLine());

            decisionMade(choice); ;
        }

        //start function decisionMade
        public static void decisionMade(int choice)
        {
            switch (choice)
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
        }//end function decisionMade
    }//end Class Program
}//end namespace FunctionsLab