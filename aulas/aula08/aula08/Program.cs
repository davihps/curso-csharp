namespace aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("==========Operadores Relacionais=========");

        Console.WriteLine("\nDigite o primeiro número (x): ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número (y): ");
        int y = Convert.ToInt32(Console.ReadLine());

        //Operador de igualdade
        if (x == y)
        {
            Console.WriteLine("\nX é igual a Y");
        }
        else
        {
            Console.WriteLine("\nX não é igual a Y");
        }

        //Operador de diferença
        if (x != y)
        {
            Console.WriteLine("\nX é diferente de Y");
        }
        else
        {
            Console.WriteLine("\nX não é diferente de Y");
        }

        //Operador de maior
        if (x > y)
        {
            Console.WriteLine("\nX é maior que Y");
        }
        else
        {
            Console.WriteLine("\nX não é maior que Y");
        }

        //Operador de menor
        if (x < y)
        {
            Console.WriteLine("\nX é menor que Y");
        }
        else
        {
            Console.WriteLine("\nX não é menor que Y");
        }

        //Operador de maior ou igual
        if (x >= y)
        {
            Console.WriteLine("\nX é maior ou igual a Y");
        }
        else
        {
            Console.WriteLine("\nX não é maior ou igual a Y");
        }

        //Operador de menor ou igual
        if (x <= y)
        {
            Console.WriteLine("\nX é menor ou igual a Y");
        }
        else
        {
            Console.WriteLine("\nX não é menor ou igual a Y");
        }
    }
}