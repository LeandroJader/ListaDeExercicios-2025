namespace exercicio_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número até onde deseja ver a sequência de Fibonacci: ");
            int limite = Convert.ToInt32(Console.ReadLine());

            int primeiro = 0, segundo = 1;

            Console.Write("Sequência de Fibonacci: ");
            Console.Write(primeiro + " " + segundo + " ");

            while (true)
            {
                int proximo = primeiro + segundo;
                if (proximo > limite)
                    break;

                Console.Write(proximo + " ");
                primeiro = segundo;
                segundo = proximo;
            }

            Console.WriteLine();
            Console.ReadLine();
        }
       
    }
}
