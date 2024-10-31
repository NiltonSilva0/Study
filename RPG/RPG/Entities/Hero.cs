namespace RPG.Entities;

public class Hero
{
    public string Name { get; set; }
    public int Level { get; set; }
    public string HeroType { get; set; }
    public int Health { get; set; }
    public int Defense { get; set; }
    public int Damage { get; set; }
    public int MaxHealth { get; }

    protected Hero(string name, int level, string heroType, int health, int defense, int damage)
    {
        Name = name;
        Level = level;
        HeroType = heroType;
        Health = health;
        Defense = defense;
        Damage = damage;
        MaxHealth = health;
    }
    // Adicionando um método para realizar ataques
    public virtual string PerformAttack(int cost, int damage) => $"The {HeroType} {Name} attacks and used {cost} resources dealing {damage} damage.";

    public virtual int TakeDamage(int damage)
    {
        var effectiveDamage = Math.Max(damage - Defense, 0);
        Health -= effectiveDamage;
        if (Health < 0)
        {
            Console.WriteLine($"{HeroType} is dead.");
        }

        return effectiveDamage;
    }

    // Adicionando um método para calcular o dano do ataque
    public virtual int AttackDamage()
    {
        // Adicionando uma lógica para calcular o dano do ataque
        // Por exemplo, um herói com dano base de 20 poderia realizar ataques com dano de 20 + (Level * 2)
        return Damage + (Level * 2);
    }
}

