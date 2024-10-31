namespace RPG.Entities;

public class Boss : Hero
{
    private int Energy { get; set; }

    public Boss(string name, int level, string heroType, int health, int defense, int energy, int damage)
        : base(name, level, heroType, health, defense, damage)
    {
        Energy = energy; // Pode ser renomeado para algo mais apropriado
    }

    // Método para atacar
    public int AttackDamage()
    {
        // Lógica para o ataque do boss
        // Exemplo básico de dano
        int damageDealt = Damage; // Modifique conforme necessário
        return damageDealt;
    }

    // Método para regenerar energia
    public void RegenerateEnergy()
    {
        // Regeneração de energia entre 2 a 4
        int regeneratedEnergy = new Random().Next(2, 5);
        Energy += regeneratedEnergy;
        Console.WriteLine($"{Name} regenerated {regeneratedEnergy} energy. Current Energy: {Energy}");
    }
}