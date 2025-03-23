namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===========================================");
            Console.WriteLine("Conversão de graus Celsius para  Fahrenheit");
            Console.WriteLine("============================================");

            Console.WriteLine("digite os graus Celsius ");
            double GausCelcius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===========================================");

            double fahrenheit = (GausCelcius * 1.8) + 32;
            Console.WriteLine($" {GausCelcius} graus celcius são {fahrenheit} graus fahrenheit ");
            Console.ReadLine();



        }
    }
}
