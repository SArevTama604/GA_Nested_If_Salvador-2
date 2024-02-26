namespace GA_Nested_If_Salvador_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.Write("Are you a student (yes/no): ");
                string studentStatus = Console.ReadLine().ToLower();
                if (studentStatus == "yes")
                {
                    Console.WriteLine("You are an adult student.");
                }
                else
                {
                    Console.WriteLine("You are an adult, but not a student. ");
                }

            }
            else
            {
                Console.WriteLine("You are not an adult");
            }
        }
    }
}
