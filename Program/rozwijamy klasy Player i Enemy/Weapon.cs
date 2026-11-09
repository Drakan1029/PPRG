public class Weapon
{
    public string Name { get; }
    public int Block { get; }
    public int Damage { get; }

    public Weapon(string name, int damage,int block)
    {
        Name = name;
        Block = block;
        Damage = damage;
    }
}