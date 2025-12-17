namespace aula17;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=========Listas=========");

        //Declarar e escrever
        List<string> fruits = new List<string>() { "Manga", "Abacate", "Pera" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine("O terceiro item da lista é " + fruits[2]);

        Console.WriteLine();

        //Adicionar
        fruits.Add("Limão");
        fruits.Add("Laranja");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine();

        //Remover
        fruits.Remove("Pera");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine();

        //Quantidade
        Console.WriteLine("A quantidade de itens na lista é " + fruits.Count());

        Console.WriteLine();

        //Substituir
        fruits[2] = "Maracuja";
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine();

        //Limpar
        fruits.Clear();
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine("***Como não apareceu nada a lista foi limpa***");

        Console.WriteLine();

        //Inicializar sem declarar
        List<int> numbers = new List<int>();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("***Novamente não aparece, mas a lista foi inicializada***");
        numbers.Add(21);
        numbers.Add(0);
        numbers.Add(58732);
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}