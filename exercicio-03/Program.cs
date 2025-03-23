namespace exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Media de combustivel");
            Console.WriteLine("=============================");
            Console.WriteLine("informe a km inicial do veiculo ");

            double Kminicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=============================");
            Console.WriteLine("informe a quilometragem final ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=============================");
            Console.WriteLine("informe a quantidade de combustivel consumida ");
            double consumoCombustivel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=============================");
            Console.WriteLine($"o carro percorreu {(kmFinal - Kminicial)}km e fez um consumo medio por litro de {1 / consumoCombustivel:F3}");
            Console.ReadLine();

        }
    }
}
