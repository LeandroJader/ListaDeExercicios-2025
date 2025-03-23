namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cacular o volume de um cilindro ");
            Console.WriteLine("================================");

            Console.WriteLine("digite o raio do cilindo ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite a altura do cilindro ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"O volume do cilindo e de {volume} cm ³ ");


        }
    }
}
