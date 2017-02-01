using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            firstName = "Brandon";
            middleInitial = "C.";
            lastName = "Wright";
            fullName = "Brandon Curtis Wright";
            age = 19;
            isCitizen = true;
            canVote = true;
            heightFeet = 6;
            heightInches = 3;
            totalHeightCM = 190.5;

            System.Console.Write("What is your name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            System.Console.Write("Your name is : ");
            System.Console.WriteLine(fullName);

            System.Console.Write("What is your height in feet? ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches added to your base height? ");
            heightInches = double.Parse(System.Console.ReadLine());

            System.Console.Write("Total height in CM : ");
            System.Console.WriteLine(totalHeightCM);
            System.Console.ReadKey();

            System.Console.Write("How old are you? ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a United States Citizen? ");
            isCitizen = bool.Parse(System.Console.ReadLine());

            System.Console.Write("Are you eligible to vote? ");
            System.Console.WriteLine(canVote = true);
            System.Console.ReadKey();
        }
    }
}
