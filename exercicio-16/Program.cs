namespace exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Verificar se o numero e par ou impar");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("digite um número para verificar se e par ou impar");
            decimal numero = Convert.ToInt32(Console.ReadLine());


            if (numero %2==0) {

                Console.WriteLine("o número e par");
            
            }
            else
            {
                Console.WriteLine("o número e impar");
            }
            Console.ReadLine();
        }
    }
}
