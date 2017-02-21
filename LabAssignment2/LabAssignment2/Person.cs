namespace LabAssignment2
{
    class Person
    {
        Person p1 = new Person();
        public string FirstName;
        public string LastName;
        public int Age;

        public string GetFullName()
        {
            string FullName = "";
            FullName += this.FirstName;
            FullName += " ";
            FullName += this.LastName;
            return FullName;
        }
    
        public void PrintNameAndAge()
        {
            System.Console.WriteLine("My name is " + this.GetFullName());
            System.Console.WriteLine("My age is " + this.Age);
        }
     
    }
}
