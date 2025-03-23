namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================");
            Console.WriteLine("calculando salário");
            Console.WriteLine("==================");


            Console.WriteLine("digite o salario base");
            decimal SalarioBase = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("==================");
            Console.WriteLine("digite o total de vendas realizadas");
            decimal TotalVendas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("==================");
            Console.WriteLine("digite a porcentagem de comissão ");
            decimal comissao = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("==================");
            decimal total_comissao = comissao / 100;

            decimal AdicionalComissao = TotalVendas * total_comissao;

            Console.WriteLine($"Salario normativo : {SalarioBase}R$......");
            Console.WriteLine($"Adicional comissão sobre vendas {AdicionalComissao} R$");
            Console.WriteLine($"Salario total :{SalarioBase + TotalVendas * total_comissao}");



            Console.ReadLine();
        }
    }
}
