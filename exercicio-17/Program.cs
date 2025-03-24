namespace exercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorC = 0;
            Console.WriteLine("------------------");
            Console.WriteLine("Ler valores A e B ");
            Console.WriteLine("------------------");

            Console.WriteLine("informe o valor A");
            int valorA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe o valor B");
            int valorB = Convert.ToInt32(Console.ReadLine());

            if (valorA == valorB)
            {
                valorC = valorA + valorB;
                Console.WriteLine($"O resultado da soma de A e B é :{valorC}");

            }
            else
            {
                valorC = valorA * valorB;
                Console.WriteLine($"O resultado da multiplicação dos valores de A e B é :{valorC}");
            }
            Console.ReadLine();
        }

    }
}
