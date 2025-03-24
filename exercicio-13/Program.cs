namespace exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ler valores A e B ");
            Console.WriteLine("-------------------");
            Console.WriteLine("dgite o valor A");
            double ValorA= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("dgite o valor B");
            double ValorB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("dgite o valor C");
            double ValorC = Convert.ToDouble(Console.ReadLine());

            double somavalores = ValorA + ValorB;

            if (somavalores < ValorC)
            {
                Console.WriteLine($"O resultado da soma A e B e menor que C");

            }
            else
            {
                Console.WriteLine("O resultado da soma e maior que C");
            }

                Console.ReadLine();
        }
    }
}
