namespace LabAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 19;
            p1.FirstName = "Brandon";
            p1.LastName = "Wright";
            
            Person p2 = new Person();
            p2.Age = 25;
            p2.FirstName = "Selena";
            p2.LastName = "Gomez";

            System.Console.WriteLine(p1.GetFullName());
            System.Console.WriteLine(p2.GetFullName());

            p1.PrintNameAndAge();
            p2.PrintNameAndAge();

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();

        }
    }
}
