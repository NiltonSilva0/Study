using RPG.Entities;

Knight knight = new Knight("Arus", 23, "Knight", 500, 50, 100, 115);
Boss boss = new Boss("Maulz", 35, "Boss", 500, 50, 100, 100);

int round = 1;

while (boss.Health > 0 && knight.Health > 0)
{
    Console.WriteLine($"\n--- Round {round} ---");

    // Regenera energia para Knight e Boss apenas nas rodadas subsequentes
    if (round > 1)
    {
        knight.RegenerateRage();
        boss.RegenerateEnergy();
    }

    // O jogador escolhe o tipo de ataque
    Console.WriteLine("Choose an attack type:");
    Console.WriteLine("(1) Light Attack - Cost: 10 Rage");
    Console.WriteLine("(2) Heavy Attack - Cost: 30 Rage");
    string choice = Console.ReadLine();

    int knightDamage = 0; // Variável para armazenar o dano do knight

    // Knight attacks Boss baseado na escolha
    if (choice == "1")
    {
        knightDamage = knight.LightAttack(); // Chama o método LightAttack do Knight
    }
    else if (choice == "2")
    {
        knightDamage = knight.HeavyAttack(); // Chama o método HeavyAttack do Knight
    }
    else
    {
        Console.WriteLine("Invalid choice! Knight misses his attack this round.");
    }

    if (knightDamage > 0) // Verifica se o Knight conseguiu atacar
    {
        int bossFinalDamage = boss.TakeDamage(knightDamage);
        Console.WriteLine(
            $"{knight.Name} attacked {boss.Name} for {knightDamage} damage. Boss HP: {boss.Health}");
    }

    // Verificar se o Boss foi derrotado
    if (boss.Health <= 0)
    {
        Console.WriteLine($"{boss.Name} has been defeated!");
        break;
    }

    // Boss attacks Knight
    int bossDamage = boss.AttackDamage(); // Chama o método AttackDamage do Boss
    if (bossDamage > 0) // Verifica se o Boss conseguiu atacar
    {
        int knightFinalDamage = knight.TakeDamage(bossDamage); // Atualiza para usar o método TakeDamage do Knight
        Console.WriteLine(
            $"{boss.Name} attacked {knight.Name} for {bossDamage} damage. Knight HP: {knight.Health}");
    }

    // Verificar se o Knight foi derrotado
    if (knight.Health <= 0)
    {
        Console.WriteLine($"{knight.Name} has been defeated!");
        break;
    }

    Console.WriteLine("--- End of Round ---");
    round++; // Incrementa a rodada
}

// Mensagem final após as rodadas
if (boss.Health <= 0)
{
    Console.WriteLine("The heroes have won!");
}
else if (knight.Health <= 0)
{
    Console.WriteLine("The hero has been defeated!");
}
else
{
    Console.WriteLine("The battle ended without a clear winner.");
}
