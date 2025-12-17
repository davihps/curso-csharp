namespace aula26;

public class Program
{
    public static void Main()
    {
        Cake cake = new Cake();
        Console.WriteLine($"Sabor: {cake.Flavor}");
        Console.WriteLine($"Recheio: {cake.Filling}");
        Console.WriteLine($"Corbetura: {cake.Covering}");
        Console.WriteLine($"Camadas: {cake.Layers}");
        Console.WriteLine($"Tamanho: {cake.Size}");
    }
}