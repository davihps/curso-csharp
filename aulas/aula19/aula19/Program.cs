namespace aula19;
using System.IO;

public class Program
{
    public static void Main()
    {
        string path = @"E:\Arquivos\codigos\CSharp\csharp\aula19\aula19\Arquivos\";
        string fileName = "Lista de compras.txt";
        string filePath = path + fileName;
        List<string> shoopingList = new List<string>();
        if (File.Exists(filePath))
        {
            shoopingList.AddRange(File.ReadAllLines(filePath));
        }
        foreach (string item in shoopingList)
        {
            Console.WriteLine(item);
        }

        bool proceed = true;
        while (proceed)
        {
            Console.WriteLine("\n=== Lista de Compras ===");
            Console.WriteLine("1. Adicionar item\n2. Remover item");
            Console.WriteLine("3. Exibir lista\n4. Apagar lista");
            Console.WriteLine("5. Salvar lista em um bloco de notas e sair");
            Console.WriteLine("Escolha um número para continuar:");
            string? operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    Console.WriteLine("\nQual item deseja adicionar?");
                    string? addedItem = Console.ReadLine();
                    if (!string.IsNullOrEmpty(addedItem))
                    {
                        shoopingList.Add(addedItem);
                        Console.WriteLine($"Item '{addedItem}' adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("O item não pode ser vazio!");
                    }
                    break;

                case "2":
                    Console.WriteLine("\nQual item deseja remover? ");
                    string? removedItem = Console.ReadLine();
                    if (!string.IsNullOrEmpty(removedItem))
                    {
                        if (shoopingList.Remove(removedItem))
                        {
                            Console.WriteLine($"Item '{removedItem}' removido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Item não encontrado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("O item não pode ser vazio");
                    }
                    break;

                case "3":
                    if (shoopingList.Count() == 0)
                    {
                        Console.WriteLine("\nSua lista está vazia!");
                    }
                    else
                    {
                        Console.WriteLine("\nItens na sua lista de compras:");
                        for (int i = 0; i < shoopingList.Count(); i++)
                        {
                            Console.WriteLine($"{i + 1}. {shoopingList[i]}");
                        }
                    }
                    break;

                case "4":
                    Console.WriteLine("\nVocê tem certeza que quer APAGAR sua lista? (s/n)");
                    string? confirmation = Console.ReadLine();
                    if (confirmation == "s")
                    {
                        shoopingList.Clear();
                        Console.WriteLine("Lista apagada com sucesso!");
                    }
                    break;

                case "5":
                    File.WriteAllLines(filePath, shoopingList);
                    Console.WriteLine("\nArquivo salvo!");
                    Console.WriteLine("Obrigado por usar nosso aplicativo!");
                    proceed = false;
                    break;

                default:
                    Console.WriteLine("\nTente denovo!!");
                    break;
            }
        }
    }
}