
class Program
{
    static void Main(string[] args)
    {

        int hp = 10;
        int attack = 5;
        int enemyHp = 20;
        
        string choice;

        do
        {

            Console.WriteLine("=== POSTAĆ ===");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"Atak: {attack}");
            Console.WriteLine();
            Console.WriteLine("=== PRZECIWNIK ===");
            Console.WriteLine($"HP: {enemyHp}");
            Console.WriteLine();
            Console.WriteLine("1 - Leczenie");
            Console.WriteLine("2 - Trening");
            Console.WriteLine("3 - Atak na przeciwnika");
            Console.WriteLine("0 - Zakończ program");
            


            choice = Console.ReadLine();



            if (choice == "1")
            {
                hp++;
                Console.WriteLine($"HP zwiększone do {hp}");
            }
            else if (choice == "2")
            {
                attack++;
                Console.WriteLine($"Atak zwiększony do {attack}");
            }
            else if (choice == "3")
            {

                if (enemyHp > 0)
                {
                    enemyHp = enemyHp - attack;
                    Console.WriteLine("Atakujesz przeciwnika!");

                    if (enemyHp <= 0)
                    {
                        Console.WriteLine("Przeciwnik został pokonany!");
                    }
                    else
                    {
                        Console.WriteLine($"Przeciwnik posiada jeszcze {enemyHp} HP.");
                    }
                }
                else
                {
                    Console.WriteLine("Przeciwnik został już wcześniej pokonany!");
                }
            }
            else if (choice == "0")
            {
                Console.WriteLine("Koniec programu.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowa komenda!");
            }

        } while (choice != "0");
    }
}
