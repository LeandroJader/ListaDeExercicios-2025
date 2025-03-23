namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Calculando o volume de uma caixa retangular");
            Console.ResetColor();
            Console.WriteLine("=========================");

            Console.WriteLine("Digite o comprimento do retangulo");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a altura do retangulo");
            decimal altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a largura do retangulo");
            decimal largura = Convert.ToDecimal(Console.ReadLine());


            decimal volume = 0;


            volume = comprimento * largura * altura;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"o volume e de {volume} cm ³ ");
            Console.ResetColor();
            Console.ReadLine();

        }
    }
}
