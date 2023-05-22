// See https://aka.ms/new-console-template for more information

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Out.WriteLine("Hello World from Gayan, This is my first C#");
            //String? name = null;
            //name = Console.ReadLine();
            //Console.Out.WriteLine("Hello " + name);

            Person.sayHi("Stranger");
            

            Person person = new Person();
            Console.Out.Write("Name: ");
            person.Name = Console.ReadLine() ?? "";

            Console.Out.Write("Age: ");
            person.Age = Convert.ToInt32(Console.ReadLine());

            Console.Out.Write("Email: ");
            person.Email = Console.ReadLine() ?? "";

            Console.Out.Write("Address Line 01: ");
            person.AddressLine01 = Console.ReadLine() ?? "";

            Console.Out.Write("Address Line 02: ");
            person.AddressLine02 = Console.ReadLine() ?? "";

            Console.Out.Write("Post Code: ");
            person.PostCode = Console.ReadLine() ?? "";


            person.printDetail();

        }
    }
}