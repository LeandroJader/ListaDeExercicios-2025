namespace exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Calcular aumento de salario e impostos");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("digite seu salario atual");
            double salarioAtual = Convert.ToDouble(Console.ReadLine());

            double AumentoSalario = salarioAtual *0.15 ;
            double impostos = (salarioAtual+AumentoSalario) * 0.08;
            double salariofinal = salarioAtual + AumentoSalario - impostos;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"seu salario inicial era {salarioAtual}R$");
            Console.WriteLine($"voce recebeu aumento de 15% seu salario ficou {AumentoSalario+salarioAtual}R$");
            Console.WriteLine($"salario final descontado 8% de impostos {salariofinal}R$");
            Console.ReadLine();
        }
    }
}
