namespace aula26;

public class Cake
{
    public string? Flavor;
    public string? Filling;
    public string? Covering;
    public int Layers;
    public string? Size;

    // Construtores: Chamado de forma automática na criação de um objeto
    // # Mesmo nome da classe
    // # Toda classe tem
    // # Pode ou não ter parâmetros
    // # Não tem retorno
    public Cake()
    {
        Flavor = "Chocolate";
        Filling = "Coco";
        Covering = "Chocolate";
        Layers = 3;
        Size = "Pequeno";
    }
}