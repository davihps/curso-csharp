namespace aula25;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Qual a senha?");
        string? password = Console.ReadLine();
        if (password == "f42u6b")
        {
            BankTerminal bank = new BankTerminal();
            bank.Balance = 1000;
            bank.Start();
        }
        else
        {
            Console.WriteLine("Senha incorreta! Tente novamente mais tarde...");
        }

    }
}