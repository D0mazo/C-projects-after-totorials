using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Turn-Based Combat Game");
        
      
        Character player = new Character("Player", 100);
        Character enemy = new Character("Enemy", 50);

      
        while (player.IsAlive && enemy.IsAlive)
        {
            Console.WriteLine($"{player.Name}'s turn:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    player.Attack(enemy);
                    break;
                case "2":
                    player.Heal();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            if (enemy.IsAlive)
            {
                Console.WriteLine($"{enemy.Name}'s turn:");
                enemy.Attack(player);
            }

           
            Console.WriteLine($"{player.Name}: Health - {player.Health}");
            Console.WriteLine($"{enemy.Name}: Health - {enemy.Health}");
            Console.WriteLine();
        }

   
        if (player.IsAlive)
            Console.WriteLine("Congratulations! You defeated the enemy.");
        else
            Console.WriteLine("Game over. You were defeated by the enemy.");
    }
}

class Character
{
    public string Name { get; }
    public int Health { get; private set; }
    public bool IsAlive => Health > 0;

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void Attack(Character target)
    {
        Random random = new Random();
        int damage = random.Next(5, 15); 
        Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
        target.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (IsAlive)
            Console.WriteLine($"{Name} takes {damage} damage and has {Health} health remaining.");
        else
            Console.WriteLine($"{Name} has been defeated!");
    }

    public void Heal()
    {
        int healing = 10;
        Health += healing;
        Console.WriteLine($"{Name} heals for {healing} points. {Name}'s health is now {Health}.");
    }
}
