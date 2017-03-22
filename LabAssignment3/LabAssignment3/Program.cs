namespace LabAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Instructor("John", "English");
            var mike = new Instructor("Mike", "Math");

            var jane = new Student("Jane", john);
            var joe = new Student("Joe", john);
            var melissa = new Student("Melissa", mike);
            var matt = new Student("Matt", mike);

            john.SetStudentGrade(jane, 95);
            john.SetStudentGrade(joe, 85);
            mike.SetStudentGrade(melissa, 90);
            mike.SetStudentGrade(matt, 92);

            john.PrintInstructorInfo();
            mike.PrintInstructorInfo();

            jane.PrintStudentInfo();
            joe.PrintStudentInfo();
            melissa.PrintStudentInfo();
            matt.PrintStudentInfo();

            System.Console.ReadKey();

           
        }
    }
}
