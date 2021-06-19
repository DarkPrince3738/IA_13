using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var User = new User();
            Console.WriteLine("Write your first name");
            try
            {
                User.FirstName = Console.ReadLine();
            }
            catch (FocusPocusException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            Console.WriteLine("Write your last name");
            User.LastName = Console.ReadLine();
            Console.WriteLine("Write your middle name");
            User.MiddleName = Console.ReadLine();
            Console.WriteLine("Write your age");
            User.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Write your gender");
            User.Gender = (Gender) Enum.Parse(typeof(Gender), Console.ReadLine());
            Console.WriteLine("Write your job");
            User.Job = Console.ReadLine();
            Console.WriteLine("Write your education");
            User.Education = Console.ReadLine();
            Console.WriteLine("Write your married status");
            User.MaritalStatus = (MarriedStatus) Enum.Parse(typeof(MarriedStatus), Console.ReadLine());
            Console.WriteLine($"{User.FirstName}, {User.LastName}, {User.MiddleName}, {User.Age}, {User.Gender}, {User.Job}, {User.Education}, {User.MaritalStatus}");
        }
    }
    public class FocusPocusException : Exception
    {
        public FocusPocusException() { }
        public FocusPocusException(string message): base(message)
        {

        }
        public FocusPocusException(string message, Exception innerException): base(message, innerException)
        {

        }
    }
}
