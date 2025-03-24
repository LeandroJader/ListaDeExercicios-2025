namespace exercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("somar numeros impares ");

            int soma = 0;

            for (int i = 1; i < 500; i++)
            {

                if (i % 2!= 0 && i %3==0)
                {
                    
                    soma += i;
                }
              

            }
                    Console.WriteLine($"resultado da soma dos numeros impares e multiplos de tres :{soma}");
            Console.ReadLine();




        }


    }
}

