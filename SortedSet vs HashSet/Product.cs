namespace Product_NS;
internal class Product
{
    public string Name { get; set; } = "Noname";
    public decimal Price { get; set; } = 0;

    override public int GetHashCode()
    {
        return HashCode.Combine(Name, Price); // - обчислюємо хеш-код на основі хеш-кодів полів Name та Price
    }

    override public bool Equals(object? obj)
    {
        if (obj is Product other)
        {
            return Name == other.Name && Price == other.Price;
        }
        return false;
    }
}