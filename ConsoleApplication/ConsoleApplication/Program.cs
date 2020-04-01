using System;
namespace ConsoleApplication
{
    class Task
    {


        public static string TaskName()
        {
            Console.WriteLine("Enter Task Name");
            string taskName = Console.ReadLine();
            return taskName;
        }

        public static string Description()
        {
            Console.WriteLine("Enter description");
            string description = Console.ReadLine();
            return description;
        }
        public static string Deadline()
        {
            Console.WriteLine("Enter deadline");
            string deadline = Console.ReadLine();
            
            return deadline;
        }

            public static void GetInfo(string a, string b, DateTime c)
            {
                Console.WriteLine($"Task Name: {a}. Description: {b}. Deadline: {c}");
            }
            public static DateTime Shit()
            {

                DateTime b = DateTime.MinValue;
               
                while (DateTime.Now>b)
                {

                    b = Parse(  Deadline());
                    if(DateTime.MinValue<b && b<(DateTime.Now))
                        Console.WriteLine("Back to the future");
                }

                return b;
            }
            public static DateTime Parse(string a)
        {
            if (DateTime.TryParse(a, out DateTime result))
            {
                DateTime b = result;
                return b;

            }
            else
            {
                Console.WriteLine("Bad input");
                return DateTime.MinValue;

            }
        }
            
            
            static void Main(string[] args)
            {
               
                GetInfo(TaskName(), Description(), Shit());
            }
    }
}