namespace aula18;
using System.IO;

public class Program
{
    public static void Main()
    {
        string path = @"E:\Arquivos\codigos\CSharp\csharp\aula18\aula18\";
        string fileName = "document.txt";
        string content = "Hello World!";
        File.WriteAllText(path + fileName, content);
        //Quando o caminho não é informado o arquivo fica em "bin"
        Console.WriteLine("Arquivo criado com sucesso");

        string addedContent = "\nEsse texto foi adicionado";
        File.AppendAllText(path + fileName, addedContent);
        Console.WriteLine("Arquivo atualizado com sucesso");

        string insideContent = File.ReadAllText(path + fileName);
        Console.WriteLine(insideContent);
    }
}