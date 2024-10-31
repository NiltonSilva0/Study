namespace RPG.Entities;

public class Knight : Hero
{
    private int Rage { get; set; }
    private const int MaxHealth = 500; // Limite máximo de HP do Knight

    public Knight(string name, int level, string heroType, int health, int defense, int rage, int damage)
        : base(name, level, heroType, health, defense, damage)
    {
        Rage = rage;
    }

    // Método para o ataque leve (light)
    public int LightAttack()
    {
        const int cost = 10;
        if (cost > Rage)
        {
            Console.WriteLine("Not enough rage to perform a light attack.");
            return 0;
        }

        Rage -= cost;
        int attackDamage = Damage + (cost / 2);

        // Chance de autocura em 15%
        SelfHeal();

        return attackDamage;
    }

    // Método para o ataque pesado (heavy)
    public int HeavyAttack()
    {
        const int cost = 30;
        if (cost > Rage)
        {
            Console.WriteLine("Not enough rage to perform a heavy attack.");
            return 0;
        }

        Rage -= cost;
        int attackDamage = Damage + cost;

        // Chance de autocura em 15%
        SelfHeal();

        return attackDamage;
    }

    // Método para autocura com 15% de chance
    private void SelfHeal()
    {
        if (new Random().NextDouble() <= 0.15)
        {
            const int healingAmount = 50;
            Health += healingAmount;

            // Garantir que a saúde não ultrapasse o máximo
            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }

            Console.WriteLine($"{Name} healed himself for {healingAmount} HP! Current HP: {Health}");
        }
    }

    // Método para regenerar rage
    public void RegenerateRage()
    {
        // Regeneração de rage entre 2 a 4
        int regeneratedRage = new Random().Next(2, 5);
        Rage += regeneratedRage;
        Console.WriteLine($"{Name} regenerated {regeneratedRage} rage. Current Rage: {Rage}");
    }
}