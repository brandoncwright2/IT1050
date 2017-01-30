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

            System.Console.Write("What is your full name? ");
            fullName = System.Console.ReadLine();

            System.Console.Write("How old are you? ");
            age = int.Parse(System.Console.ReadLine());
        } 
    }
}
