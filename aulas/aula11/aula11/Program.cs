namespace aula11;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("========Switch case========");
        Console.WriteLine("Digite um dia da semana (1-7):");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());
        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("O dia da semana é: Domingo");
                break;
            case 2:
                Console.WriteLine("O dia da semana é: Segunda-Feira");
                break;
            case 3:
                Console.WriteLine("O dia da semana é: Terça-Feira");
                break;
            case 4:
                Console.WriteLine("O dia da semana é: Quarta-Feira");
                break;
            case 5:
                Console.WriteLine("O dia da semana é: Quinta-feira");
                break;
            case 6:
                Console.WriteLine("O dia da semana é: Sexta-feira");
                break;
            case 7:
                Console.WriteLine("O dia da semana é: Sabado");
                break;
            //Caso nenhum for executado ainda (se não / else)
            default:
                Console.WriteLine("O dia escolhido é Inválido");
                break;
        }

        Console.WriteLine("\nDigite uma nota de 1 a 10: ");
        int score = Convert.ToInt32(Console.ReadLine());
        switch (score)
        {
            //2 casos executando um bloco de código
            case 10:
            case 9:
                Console.WriteLine("Ótimo");
                break;
            case 8:
            case 7:
                Console.WriteLine("Bom");
                break;
            case 6:
                Console.WriteLine("Regular");
                break;
            case 5:
                Console.WriteLine("Ruim");
                break;
            //Um caso executando vários valores
            case < 5:
                Console.WriteLine("Horrível");
                break;
        }
    }
}