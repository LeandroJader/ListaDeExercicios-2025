namespace exercicio_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("digite um número para ver a tabuada");
            Console.WriteLine("-----------------------------------");

            int NumeroTabuada = Convert.ToInt32(Console.ReadLine());


            for (int i=0; i<11; i++)
            {
                int resultado = NumeroTabuada * i;
                Console.WriteLine($"{NumeroTabuada} x {i} = {resultado}");


            }

            Console.ReadLine();
        }
    }
}
