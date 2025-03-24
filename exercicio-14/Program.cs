namespace exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valores em ordem decrecente");

            int[] valoresDecresdecrecente = new int[3];

            Console.WriteLine("insira o primeiro valor");
            valoresDecresdecrecente[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira o primeiro valor");
            valoresDecresdecrecente[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira o terceiro valor");
            valoresDecresdecrecente[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------");
           
             var ordenados = valoresDecresdecrecente.OrderByDescending(v => v);

            foreach(var valor  in  ordenados)
            {
                Console.WriteLine(valor);

            }
            Console.ReadLine();
        }
    }
}
