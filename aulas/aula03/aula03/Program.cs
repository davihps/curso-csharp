namespace aula03;

public class Program
{
    public static void Main()
    {
        var msg = "???";
        msg = "Olá mundo";
        Console.WriteLine("A váriavel tem o valor de " + msg);
        //Variáveis: não muda o tipo / muda o conteúdo

        dynamic msgDynamic = "Essa string vai mudar de tipo";
        msgDynamic = 0184210;
        Console.WriteLine("A variável dinámica tem o valor de " + msgDynamic);
        //Variáveis Dinámicas: muda o tipo / muda o conteúdo

        const string msgConst = "Não é possível mudar esse texto";
        Console.WriteLine("A constante tem o valor de " + msgConst);
        //Constantes: não muda o tipo / não muda o conteúdo

        string msgTyped = "Essa é uma váriavel, mas com tipagem";
        msgTyped = "Oi";
        Console.WriteLine("A Tipada tem o valor de " + msgTyped);
        //Tipadas: não muda o tipo / muda o conteúdo
    }
}