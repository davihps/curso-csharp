namespace aula06;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=======Verificador de Números Pares Ou Ímpares=======");
        Console.WriteLine("Digite um número: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = number % 2;
        if (result == 0)
        {
            Console.WriteLine("O seu número é par!");
        }
        else
        {
            Console.WriteLine("O seu número é impar!");
        }
    }
}