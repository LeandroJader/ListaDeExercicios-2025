namespace exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Sistema de calculo para padaria");
            Console.WriteLine("===============================");

            double Valorpaes =0.12;
            double Valorbroas = 1.50;
            double ValorArrecadadopaes = 0;
            double ValorArrecadadoBroas = 0;
            double poupanca = 0;

            Console.WriteLine("informe a quantidade de pães vendidos");
            int quantidadepaes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=======================================");

            Console.WriteLine("informe a quantidade de broas vendias");
            int quantidadebroas = Convert.ToInt32(Console.ReadLine());

            ValorArrecadadoBroas = quantidadebroas * Valorbroas;
            ValorArrecadadopaes = quantidadepaes * Valorpaes;
            poupanca = ValorArrecadadoBroas + ValorArrecadadopaes;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"O valor total arrecadado foi de {ValorArrecadadoBroas+ValorArrecadadopaes}R$");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"O valor a ser depositado na poupança e {poupanca*0.1:f2}R$");
            
            Console.ReadLine();
        }
    }
}
