namespace exercicio_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial");

            Console.WriteLine("Informe o valor fatorial: ");
            int ValorN = Convert.ToInt32(Console.ReadLine());

            long fatorial = 1;
            Console.Write($"{ValorN}! = ");

            for (int i = ValorN; i >= 1; i--)
            {
                Console.Write(i);
                if (i > 1)
                {
                    Console.Write(" X ");
                }
                fatorial *= i;
            }

            Console.WriteLine($" = {fatorial}");
            Console.ReadLine();
        }
    }
}
