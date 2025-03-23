namespace exercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Ler as dimensões de um terreno");
            Console.WriteLine("==============================");

            Console.WriteLine("digite a largura do terreno ");
            double largura  = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o comprimento do terreno ");
            double comprimento  = Convert.ToDouble(Console.ReadLine());

            double area = largura * comprimento;

            Console.WriteLine($"seu terreno contem {area} m²");
            Console.ReadLine();
        }
    }
}
