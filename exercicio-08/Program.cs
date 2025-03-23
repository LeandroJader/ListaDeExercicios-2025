class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        bool NumeroPrimo = true;

        if (numero < 2)
        {
            NumeroPrimo = false;
        }
        else
        {
            int raiz = (int)Math.Sqrt(numero);
            for (int i = 2; i <= raiz; i++)
            {
                if (numero % i == 0)
                {
                    NumeroPrimo = false;
                    break;
                }
            }
        }

        if (NumeroPrimo)
        {
            Console.WriteLine($"{numero} é primo.");
        }
        else
        {
            Console.WriteLine($"{numero} não é primo.");
        }
    }
}
