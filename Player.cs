namespace LAB_3;

class Player : Entity
{
    private string _name;
    private int _money;
    private int _loot;
    private int _arrows;
    public Player(int health, int damage) : base(health,damage) {}
    public Player(
        int health, 
        int damage,
        string name, 
        int money, 
        int loot, 
        int arrows) : this(health,damage)
    {
        _name = name;
        _money = money;
        _loot = loot;
        _arrows = arrows;
    }

    public void Buy()
    {
        if(_money < 100) Console.WriteLine("Недостатньо коштів!");
        else
        {
            Console.WriteLine($"Ви купили 10 стріл");
            _money -= 100;
            _arrows += 10;
        }
    }

    public void Sell()
    {
        if(_loot <= 0) Console.WriteLine("Нема здобичі на продаж");
        else
        {
            Console.WriteLine($"Ви отримуєте {_loot * 25} грошей");
            _money += _loot * 25;
            _loot = 0; 
        }
    }

    public void ConsumeArrow()
    {
       _arrows -= 1;
    }

    public int arrows()
    {
        return _arrows;
    }

    public void GetLoot(int drop)
    {
        _loot += drop;
    }

    public int loot()
    {
        return _loot;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine("===[Інформація про мисливця]=======================");
        Console.WriteLine($"Ім'я: {_name}");
        Console.WriteLine($"♥ Здоров'я: {_health}");
        Console.WriteLine($"$ Гроші: {_money}");
        Console.WriteLine($"➶ Стріли: {_arrows}");
        Console.WriteLine($"⌬ Здобич: {_loot}");
        Console.WriteLine($"⬸ Шкода: 1 - {_damage}");
    }

}
