using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Alex";
            bool isWorking = true;

            var aVariable = "Hi"; //Var will autodetect type based on what is assigned instead of needing to specify a type

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(aVariable);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //Using a format string as a template to insert values at runtime
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;

            Console.WriteLine(Pi);

        }
    }
}
