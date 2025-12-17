namespace aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("============Operadores de atribuição============");
        int x = 10; //x = 10;
        Console.WriteLine("\nOperador de atribuição(=)");
        Console.WriteLine("O valor da váriavel é: " + x);
        x++; //x = x + 1;
        Console.WriteLine("\nOperador incremento(++)");
        Console.WriteLine("O valor novo da váriavel é: " + x);
        x += 10; //x = x + 10;
        Console.WriteLine("\nOperador de atribuição composta(+=)");
        Console.WriteLine("O valor novo da váriavel é: " + x);
        x -= 10; //x = x - 10;
        Console.WriteLine("\nOperador de atribuição composta(-=)");
        Console.WriteLine("O valor novo da váriavel é: " + x);
        x *= 10; // x = x * 10;
        Console.WriteLine("\nOperador de atribuição composta(*=)");
        Console.WriteLine("O valor novo da váriavel é: " + x);
        x /= 10; // x = x / 10;
        Console.WriteLine("\nOperador de atribuição composta(/=)");
        Console.WriteLine("O valor novo da váriavel é: " + x);
    }
}