namespace aula10;

public class Program
{
    public static void Main()
    {
        bool varContinue = true;
        while (varContinue) //enquanto
        {
            //Socilita os 2 números para a calculadora
            Console.WriteLine("=======Calculadora=======");
            Console.WriteLine("\nDigite o primeiro número: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            //Solicita a operação desejada
            Console.WriteLine("\nEscolha uma operação:");
            Console.WriteLine("1. Adição (+)\n2. Subtração(-)");
            Console.WriteLine("3. Multiplicação (*)\n4. Divisão(/)");
            Console.WriteLine("Digite o número da operação");
            int operation = Convert.ToInt32(Console.ReadLine());

            //Calcula e escreve o Resultado
            dynamic result = 0;
            if (operation == 1)
            {
                result = number1 + number2;
            }
            else if (operation == 2)
            {
                result = number1 - number2;
            }
            else if (operation == 3)
            {
                result = number1 * number2;
            }
            else if (operation == 4 && number2 != 0)
            {
                result = number1 / number2;
            }
            else if (operation == 4 && number2 == 0)
            {
                result = "indefinido";
            }
            else
            {
                result = "Operação inválida";
            }
            Console.WriteLine("\nResultado: " + result);

            //Pergunta se quer utilizar novamente
            Console.WriteLine("\nDeseja realizar outra operação (s/n)");
            string? response = Console.ReadLine();
            Console.WriteLine("");
            if (response != "s")
            {
                varContinue = false;
            }
        }
        Console.WriteLine("Obrigado por utilizar a calculadora!");
    }
}