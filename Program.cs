namespace Sauna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("Enter your temperature in sauna in Fahrenheit.");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double cel = FahrenheitToCelsius(fahrenheit);
                Console.WriteLine("I convert your fahrenheit degree to Celsius: " + cel + " so the sauna will also understand!");                Console.ReadLine();
                if (cel != 0)
                {
                    CheckTemp(fahrenheit);
                }
            }
        }

        private static void CheckTemp(double fahrenheit)
        {
            bool temerature = false;
            while (!temerature)
            {
                if (fahrenheit == 75)
                {
                    Console.WriteLine("It´s the perfect temperature.");
                    temerature = true;
                }
                else if (fahrenheit >= 77)
                {
                    Console.WriteLine("The temp is way too high!");
                    break;
                }
                else if (fahrenheit <= 73)
                {
                    Console.WriteLine("It´s too low");
                    break;
                }
                else
                {
                    Console.WriteLine("It´s acceptable temp.");
                    break;
                }
            }
            Console.ReadLine();
        }
            private static double FahrenheitToCelsius(double fahrenheit)
        {
            return ((fahrenheit - 32) * 5 / 9);
        }
    }
}