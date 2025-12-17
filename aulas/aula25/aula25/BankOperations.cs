namespace aula25;

public class BankOperations
{
    public int Balance;

    public void CheckBalance()
    {
        Console.WriteLine($"\nSeu saldo é de R${Balance}!");
    }

    public void Deposit()
    {
        Console.WriteLine("Quanto deseja depositar?");
        int DepositValue = Convert.ToInt32(Console.ReadLine());
        Balance += DepositValue;
        Console.WriteLine($"\nSeu depósito de R${DepositValue} foi um sucesso!");
        Console.WriteLine($"O seu saldo agora é de R${Balance}");
    }

    public void Withdraw()
    {
        Console.WriteLine("Quanto deseja sacar?");
        int WithdrawValue = Convert.ToInt32(Console.ReadLine());
        if (Balance >= WithdrawValue)
        {
            Balance -= WithdrawValue;
            Console.WriteLine($"\nSeu Saque de R${WithdrawValue} foi um sucesso!");
            Console.WriteLine($"O seu saldo agora é de R${Balance}");
        }
        else
        {
            Console.WriteLine($"\nO saque de R${WithdrawValue} é maior que o seu saldo");
            Console.WriteLine($"O seu saldo é de apenas R${Balance}");
        }
    }
}