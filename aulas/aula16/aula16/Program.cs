namespace aula16;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("===========Arrays===========");

        string[] fruits = { "Maçã", "Banana", "Caju", "Manga" };

        Console.WriteLine("\n-+-+-+-+-Acessar valores-+-+-+-+-");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\n-+-+-+-+-Trocar Valores-+-+-+-+-");
        Console.WriteLine("Valor Anterior: " + fruits[1]);
        fruits[1] = "Abacaxi";
        Console.WriteLine("Valor Agora: " + fruits[1]);

        Console.WriteLine("\n-+-+-+-+-Contagem de Índices-+-+-+-+-");
        Console.WriteLine("Quantidade de índices: " + fruits.Length);

        Console.WriteLine("\n-+-+-+-+-Declarar sem inicializar-+-+-+-+-");
        int[] numbers = new int[3];
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        numbers = [1, 2, 3];
        numbers[1] = 5423;
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}