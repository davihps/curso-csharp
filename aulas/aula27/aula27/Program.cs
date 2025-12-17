namespace aula27;

public class Program
{
    public static void Main()
    {
        Cake ChocolateCake = new Cake("Chocolate", "Coco", "Chocolate", 3, "Médio");
        Console.WriteLine($"Sabor: {ChocolateCake.Flavor}");
        Console.WriteLine($"Recheio: {ChocolateCake.Filling}");
        Console.WriteLine($"Cobertura: {ChocolateCake.Covering}");
        Console.WriteLine($"Camadas: {ChocolateCake.Layers}");
        Console.WriteLine($"Tamanho: {ChocolateCake.Size}");

        Cake StrawberryCake = new Cake("Morango", "Morango", "Chocolate", 1, "Pequeno");
        Console.WriteLine($"\nSabor: {StrawberryCake.Flavor}");
        Console.WriteLine($"Recheio: {StrawberryCake.Filling}");
        Console.WriteLine($"Cobertura: {StrawberryCake.Covering}");
        Console.WriteLine($"Camadas: {StrawberryCake.Layers}");
        Console.WriteLine($"Tamanhp: {StrawberryCake.Size}");
    }
}