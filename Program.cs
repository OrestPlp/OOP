namespace LAB_3;
class Program
{
    static void Main()
    { 
        int health;
        int money;
        int loot;
        int arrows;

        Console.WriteLine("""
                           ╔═ ╔═╗ ╔═╗
                           ║  ╠═╝ ╠═╣
                           ║  ║   ║ ║

        ╜╜   ▓▓▓ ▓▓▓  ▓▓ ▓  ▓▓  ▓▓   ▓  ▓ ▓ ▓ ▓  ▓▓  ╜╜
             ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓  ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓ ▓  
             ▓ ▓ ▓ ▓ ▓ ▓ ▓▓▓  ▓ ▓▓  ▓▓▓ ▓▓▓ ▓▓▓  ▓▓
             ▒ ▒ ▒ ▒ ▒ ▒ ▒ ▒  ▒ ▒ ▒ ▒ ▒ ▒ ▒ ▒ ▒ ▒ ▒
             ░ ░ ░░░ ░ ░ ░  ░░  ░░  ░ ░ ░ ░ ░ ░ ░ ░
        """);



        Console.WriteLine("Введіть ім'я мисливця:");
        string name = Console.ReadLine();
        Console.WriteLine("Введіть здоров'я:");
        Int32.TryParse(Console.ReadLine(), out health);
        Console.WriteLine("Введіть кількість грошей:");
        Int32.TryParse(Console.ReadLine(), out money);
        Console.WriteLine("Введіть кількість здобичі:");
        Int32.TryParse(Console.ReadLine(), out loot);
        Console.WriteLine("Введіть кількість стріл:");
        Int32.TryParse(Console.ReadLine(), out arrows);


        Player player = new Player(health, 5, name, money, loot, arrows);
        player.DisplayInfo();
        
        int exit = 0;
        while(exit == 0)
        {
            Console.WriteLine("===[Оберіть дію]===================================");
            Console.WriteLine("1 - Іти на полювання");
            Console.WriteLine("2 - Купити 10 стріл (100 валюти)");
            Console.WriteLine("3 - Продати усю здобич");
            Console.WriteLine("4 - Вивести інформіцію про мисливця");
            Console.WriteLine("5 - Вихід");
            int input;
            Int32.TryParse(Console.ReadLine(), out input);

            switch(input)
            {
                case 1: Hunt hunt = new Hunt(); exit = hunt.Start(player); break;
                case 2: player.Buy(); break;
                case 3: player.Sell(); break;
                case 4: player.DisplayInfo(); break;
                case 5: exit = 1; break;
                default: Console.WriteLine("Некоректне введення!"); break;
            }
        }
    }
}