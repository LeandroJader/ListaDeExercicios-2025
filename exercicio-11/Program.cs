namespace exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Calcular dias vividos");
            Console.WriteLine("---------------------");

            Console.WriteLine("informe seu nome ");
            string nome = Console.ReadLine()!;

            Console.WriteLine("informe sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"{nome}, você viveu cerca de {idade*365} dias ");

            Console.ReadLine();

        }
    }
}
