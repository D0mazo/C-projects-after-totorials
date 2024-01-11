using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Press Enter to know in which type of relationhsip you gonna end 2024...");

        Console.ReadLine(); 

        string[] relationshipStatuses = { "Single", "In a Relationship", "Engaged", "Married", "It's Complicated", "Gay" };

        Random random = new Random();
        int index = random.Next(relationshipStatuses.Length);

        string randomStatus = relationshipStatuses[index];

        Console.WriteLine($"In the end of 2024 you will be: {randomStatus}");
    }
}