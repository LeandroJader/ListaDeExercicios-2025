namespace exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Calcular indice de massa muscular");
            Console.WriteLine("-----------------");

            Console.WriteLine("informe seu peso ");
            double peso=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe sua altura  ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2);

            if(imc < 18.5)
            {
                Console.WriteLine("Você esta abaixo do peso");
                }

            else if (imc >= 18.5 && imc < 25) {

                    Console.WriteLine("você esta no peso normal");
                }
            else if (imc>=25 && imc<30)
            {
                Console.WriteLine("você esta acima do peso");
            }
            else if (imc > 30)
            {
                Console.WriteLine("você esta obeso");
            }
            Console.ReadLine();


        }
    }
}
