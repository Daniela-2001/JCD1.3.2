namespace JCD1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {

                int resultado = numero * i;

                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}