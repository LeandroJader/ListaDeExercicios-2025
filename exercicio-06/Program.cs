namespace exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Cálculo de média harmônica");
            Console.WriteLine("==========================");

            Console.WriteLine("Informe a quantidade de notas para calcular a média ");
            int notas = Convert.ToInt32(Console.ReadLine());
            decimal[] total_notas = new decimal[notas];
            decimal soma_inversos = 0;

            while (true)
            {

                Console.Clear();
                for (int i = 0; i < total_notas.Length; i++)
                {
                    Console.WriteLine($"digite o {i + 1}º número");


                    total_notas[i] = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("================================================");
                    Console.WriteLine($"inverso do número escolhido: {1 / total_notas[i]}");
                    Console.WriteLine("================================================");
                    soma_inversos += 1 / total_notas[i];
                    Console.WriteLine();
                }




                Console.WriteLine($"Soma dos inversos :{soma_inversos}");
                Console.WriteLine("================================================");


                Console.WriteLine($"Média harmônica :{notas / soma_inversos:f2}");
                Console.WriteLine("================================================");


                Console.WriteLine("você deseja continuar S/N");
                string continuar = Console.ReadLine().ToUpper();
                if (continuar != "S")
                {
                    break;
                }
            }
        }
    }

}