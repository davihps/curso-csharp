namespace aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("---------CADASTRO DE USUÁRIO---------");

        Console.WriteLine("Digite o seu nome: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Digite a sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("------------------------------------");

        Console.WriteLine("Nome do usuário: " + name);
        Console.WriteLine("Idade do usuário: " + age);
    }
}