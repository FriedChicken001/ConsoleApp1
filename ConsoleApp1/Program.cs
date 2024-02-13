namespace ConsoleApp1
{

    class Person
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is : {Name} and my Age is {Age}");
        }

        private void SayBye()
        {
            Console.WriteLine("Bye");
        }

        public void GiveMorningStandup()
        {

            SayHello();
            SayBye();
        }


        //CamelCase - first letter is lowered case but every word after is capitalized - variables
        //Pascel case- Every word starts with an upper case - properties (settings within an object i.e stats & modifiers)
        // Method: set of instructions that we want the program to do & want it to be contained. 
        // Private --> Cannot be used outside of its original container. 

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int h = 7;

            string k = "pepperoni";


           

            bool pepperoni = true;

            double triple = 1.5;

            Person jamar = new Person();

            jamar.Name = "Jamar";

            jamar.Age = 25;


            Console.WriteLine(jamar.Name + " " + "is" + " "+ jamar.Age);

            Console.WriteLine($"Jamar's Age is: {jamar.Age} and his name is: {jamar.Name}");

            Console.WriteLine("I hate this stuff" + h + k);





            // string interporlation: incorporates my values into the string  // string cacatonation: impplementing the  values within the string
            // Define varibales at the top. As future variables cannot be used before definition. 
        }
    }
}