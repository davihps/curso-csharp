namespace aula22;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Cardápio de bolos");

        // Nova instância(objeto)
        var prestigeCake = new Cake();
        var strawberryCake = new Cake();

        prestigeCake.Name = "ChoCoco Sublime";
        prestigeCake.Flavor = ["Prestígio", "Chocolate"];
        prestigeCake.IsFilling = true;
        prestigeCake.Layers = 2;
        prestigeCake.Price = 49.99;

        strawberryCake.Name = "Doce Rosé";
        strawberryCake.Flavor = ["Morango"];
        strawberryCake.IsFilling = false;
        strawberryCake.Layers = 1;
        strawberryCake.Price = 19.99;

        // Lista de instâncias
        List<Cake> cakeList = [prestigeCake, strawberryCake];
        foreach (Cake cake in cakeList)
        {
            Console.WriteLine("\nNome: " + cake.Name);
            if (cake.Flavor != null)
            {
                Console.Write("Sabor:");
                foreach (string flavor in cake.Flavor)
                {
                    Console.Write(" [" + flavor + "]");
                }
            }
            Console.WriteLine("\nTem recheio? " + cake.IsFilling);
            Console.WriteLine("Camadas: " + cake.Layers);
            Console.WriteLine("Preço: R$" + cake.Price);
        }
    }
}