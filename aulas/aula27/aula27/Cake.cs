namespace aula27;

internal class Cake
{
    public string? Flavor;
    public string? Filling;
    public string? Covering;
    public int Layers;
    public string? Size;

    public Cake(string cakeFlavor, string cakeFilling, string cakeCovering, int cakeLayers, string cakeSize)
    {
        Flavor = cakeFlavor;
        Filling = cakeFilling;
        Covering = cakeCovering;
        Layers = cakeLayers;
        Size = cakeSize;
    }
}