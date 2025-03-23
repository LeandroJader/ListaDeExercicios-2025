namespace exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal multiplicacao_resultado1 = 0;
            decimal multiplicacao_resultado2 = 0;
            decimal Soma_multiplicacao = 0;
            decimal Soma_peso = 0;
            decimal resultadoMediaPonderada = 0;



            Console.WriteLine("Calcular a média ponderada");
            Console.WriteLine("==========================");

            Console.WriteLine("informe o peso da prova 1");
            decimal peso1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("==========================");

            Console.WriteLine("informe a nota da aprova 1");
            decimal nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("informe o peso da prova 2");
            decimal peso2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==========================");
            Console.WriteLine("informe a nota da aprova 2");
            decimal nota2 = Convert.ToDecimal(Console.ReadLine());


            multiplicacao_resultado1 = nota1 * peso1;
            multiplicacao_resultado2 = nota2 * peso2;

            Soma_multiplicacao = multiplicacao_resultado1 + multiplicacao_resultado2;
            Soma_peso = peso1 + peso2;

            resultadoMediaPonderada = Soma_multiplicacao / Soma_peso;

            Console.WriteLine($" media ponderada :{resultadoMediaPonderada:f3}");
            Console.ReadLine();
        }
    }
}
