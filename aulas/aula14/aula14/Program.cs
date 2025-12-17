namespace aula14;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("========For========");

        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                //$ = formatador de string / $"O valor da váriavel é {variavel,padding}"
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }
}