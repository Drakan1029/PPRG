List<Enemy> enemies = new List<Enemy>
{
    new Enemy("Slime",10,1),
    new Enemy("Goblin",30,5),
    new Enemy("Ork",140,10),
    new Enemy("Golem",1000, 5),
    new Enemy("Smok",500,30)
};
List<Weapon> weapons = new List<Weapon>
{
  new Weapon("Miecz", 15, 10),
  new Weapon("Łuk",40,0),
  new Weapon("Tarcza",5,30),
  new Weapon("Siekiera", 20, 5)
};

int wyborBroni()
{
    int weapon;
    Console.WriteLine("Wybierz broń");
    for(int i = 0; i < weapons.Count; i++){Console.WriteLine($"{i+1} - {weapons[i].Name}");} 
    while(true)
    {
        bool poprawnaLiczba = int.TryParse(Console.ReadLine(), out weapon);
        weapon--;
        if (!poprawnaLiczba || weapon < 0 || weapon+1 > weapons.Count)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podaj numer broni spośród przedstawionych");
            Console.ResetColor();
            continue;
        }
        Console.WriteLine($"Wybrałeś {weapons[weapon].Name}");
        Console.WriteLine($"ma {weapons[weapon].Damage} obrażenia");
        Console.WriteLine($"i {weapons[weapon].Block} obrony");
        break;
    }
    return weapon;
}

Console.WriteLine("Wprowadź imię bohatera: ");
string name = Console.ReadLine();
Console.Write("Wprowadź maksymalne zdrowie bohatera: ");
int maxHealth;
while(true)
{
    bool poprawnaLiczba = int.TryParse(Console.ReadLine(), out maxHealth);
        if (!poprawnaLiczba || maxHealth < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podaj Maksymalne Zdrowie od 0 do nieskączoności");
            Console.ResetColor();
            continue;
        }
        break;
}
Console.Write("Wprowadź złoto bohatera: ");
decimal gold;
while(true)
{
    bool poprawnaLiczba = decimal.TryParse(Console.ReadLine(), out gold);
        if (!poprawnaLiczba || gold < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podaj liczbę Złota od 0 do nieskączoności");
            Console.ResetColor();
            continue;
        }
        break;
}
int weapon = wyborBroni();
bool graDziala = true;
while(graDziala)
{
    Console.WriteLine("\n\n");
    Console.WriteLine("--\tArena\t--");
    var p1 = new Player(name,maxHealth,gold);
    Console.WriteLine($"Imie bohatera: {p1.Name}");
    Console.WriteLine($"Zdrowie Bohatera: {p1.Health}/{p1.MaxHealth}");
    Console.WriteLine($"Złoto bohatera: {p1.Gold}");
    Console.WriteLine($"Broń bohatera: {weapons[weapon].Name} (Damage:{weapons[weapon].Damage}/Block:{weapons[weapon].Block})");
    Console.WriteLine("--\t-----\t--");
    Console.WriteLine("1. Wybrać przeciewnika");
    Console.WriteLine("2. Wybrać inną broń");
    Console.WriteLine("3. Zakończ gre");
    int wybor;
    while(true)
    {
        bool poprawnaLiczba = int.TryParse(Console.ReadLine(), out wybor);
        if (!poprawnaLiczba || wybor < 0 || wybor > 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podaj numer akcji z pośród podanych");
            Console.ResetColor();
            continue;
        }
        break;
    }
    switch(wybor)
    {
        case 1:
            for(int i = 0; i < enemies.Count; i++){Console.WriteLine($"{i+1} - {enemies[i].Name} HP:{enemies[i].Health}/Damage:{enemies[i].Damage}");} 
            
            break;
        case 2:
            weapon = wyborBroni();
            break;
        case 3:
            graDziala = false;
            break;
    }
}