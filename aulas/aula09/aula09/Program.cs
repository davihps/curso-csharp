namespace aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("==========Operadores Lógicos==========");
        bool isLogged = true;
        bool hasAdminAcess = false;
        bool hasSistemAcess = false;

        //Operador (||) - OU
        if (isLogged || hasSistemAcess)
        {
            Console.WriteLine("Bem vindo!");
            isLogged = true;
        }
        else
        {
            Console.WriteLine("Por favor insira seu login");
        }

        //Operador (&&) - E
        if (isLogged && hasAdminAcess)
        {
            Console.WriteLine("Você tem acesso ao painel de administrador");
        }

        //Negação de boleano (!) - Não.......
        if (isLogged && !hasAdminAcess)
        {
            Console.WriteLine("Você tem acesso apenas ao sistema");
        }
    }
}