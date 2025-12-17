namespace aula25;

public class BankTerminal
{
    public int Balance;

    public void Start()
    {
        BankOperations BankOperations = new BankOperations();
        BankOperations.Balance = Balance;
        while (true)
        {
            DisplayMenu();
            Console.WriteLine("Digite o número da operação para continuar:");
            string? Operation = Console.ReadLine();
            switch (Operation)
            {
                case "1":
                    BankOperations.CheckBalance();
                    break;
                case "2":
                    BankOperations.Deposit();
                    break;
                case "3":
                    BankOperations.Withdraw();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine("\n======BANK======");
        Console.WriteLine("1- Checar saldo");
        Console.WriteLine("2- Depósito");
        Console.WriteLine("3- Saque");
        Console.WriteLine("4- Sair");
    }
}
