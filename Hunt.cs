namespace LAB_3;

class Hunt
{
    public int Start(Player player)
        {
            if (player.arrows() == 0) 
            {
                Console.WriteLine($"У вас нема стріл для полювання!"); 
                return 0;
            }

            Random rnd = new Random();
            Wolf wolf = new Wolf
            (
                rnd.Next(10,15), 
                rnd.Next(3,8)
            );
            int drop;
            int damage_dealt;
            Console.WriteLine("*Ви ідете на полювання*");
            Console.WriteLine($"Ви вистежуєте вовка! Здоров'я:{wolf.health()}, Шкода: 1 - {wolf.damage()}");

            while(true)
            {
                if (player.arrows() != 0)
                {
                    damage_dealt = player.Attack(wolf, rnd);
                    player.ConsumeArrow(); 
                    Console.WriteLine($"Вовк отримав {damage_dealt} шкоди. Здоров'я вовка: {wolf.health()}");
                }
                else
                {
                    Console.WriteLine($"У вас скінчились стріли! Ви тікаєте з порожніми руками."); 
                    return 0;
                }
                     

                if(wolf.health() == 0)
                {
                    drop = rnd.Next(1,4);
                    player.GetLoot(drop);
                    Console.WriteLine($"Ви перемагаєте вовка і отримуєте {drop} здобичі!");   
                    return 0;
                } 

                damage_dealt = wolf.Attack(player, rnd);
                Console.WriteLine($"Ви отримали {damage_dealt} шкоди. Ваше здоров'я: {player.health()}");
                if(player.health() == 0)      
                {
                    Console.WriteLine($"Вовк розірвав вас на шматки! Ви програли.");  
                    return 1;     
                }
            }

        }

}