namespace aula23;

public class Program
{
    public static void Main()
    {
        var conta = new Bank();
        conta.Id = 362;
        conta.Name = "Conta 1";
        conta.RequestNewCard();
    }
}