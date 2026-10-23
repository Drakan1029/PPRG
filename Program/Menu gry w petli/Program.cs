using System.Net.Security;

Console.WriteLine("Wprowadź imię bohatera");
string imie = Console.ReadLine();
int punktyŻycia;
while(true)
{
    Console.WriteLine("Wprowadź punkty życia bohatera (od 1 do 100)");
    bool poprawnaLiczba = int.TryParse(Console.ReadLine(), out punktyŻycia);
    if (!poprawnaLiczba || (punktyŻycia > 100 || punktyŻycia < 1))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Podaj całkowitę liczbe z przedziału od 1 do 100");
        Console.ResetColor();
        continue;
    }
    break;
}
const int maksymalneZdrowie = 100;
decimal zloto;
while(true)
{
    Console.WriteLine("Wprowadź ilość złota (wartość nieujemna)");
    bool poprawnaLiczba = decimal.TryParse(Console.ReadLine(), out zloto);
    if (!poprawnaLiczba || zloto < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Podaj liczbę złota od 0 do nieskączoności");
        Console.ResetColor();
        continue;
    }
    break;
}
int mikstur;
while(true)
{
    Console.WriteLine("Wprowadź ilość mikstur (wartość nieujemna)");
    bool poprawnaLiczba = int.TryParse(Console.ReadLine(), out mikstur);
    if (!poprawnaLiczba || mikstur < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Podaj liczbę mikstur od 0 do nieskączoności");
        Console.ResetColor();
        continue;
    }
    break;
}
int numerTury = 1;
bool graDziala = true;
int exploracja = 0;
while(graDziala && punktyŻycia > 0)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"\n=== Hello Adventurer ===");
    Console.ResetColor();
    Console.WriteLine($"Tura: {numerTury}");
    Console.WriteLine($"Bohater: {imie}");
    Console.WriteLine($"Zdrowie: {punktyŻycia}/{maksymalneZdrowie} | Złoto: {zloto} | liczba mikstur: {mikstur}");
    Console.WriteLine($"");
    Console.WriteLine($"1 - Eksploruj loch");
    Console.WriteLine($"2 - Użyj mikstur");
    Console.WriteLine($"3 - Odpocznij");
    Console.WriteLine($"4 - Pokaż statystyki");
    Console.WriteLine($"5 - Zakończ gre\n");
    
    int wybor = int.Parse(Console.ReadLine());
    switch(wybor)
    {
        case 1:
            exploracja ++;
            zloto += 10;
            punktyŻycia -= 8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"zdobyłem 10 sztuk złota i straciłem 8 punktów Zdrowia");
            Console.ResetColor();
            break;
        case 2:
            if(mikstur > 0)
            {
                if(maksymalneZdrowie - punktyŻycia >= 20)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Zużyłem 1 miksturę i dostałem 20 punktów zdrowia");
                    Console.ResetColor();
                    punktyŻycia += 20;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Zużyłem 1 miksturę i dostałem {maksymalneZdrowie - punktyŻycia} punktów zdrowia");
                    Console.ResetColor();
                    punktyŻycia += maksymalneZdrowie - punktyŻycia;
                }
                mikstur--;
            }
            else {Console.ForegroundColor = ConsoleColor.Red;;Console.WriteLine($"Nie masz mikstur!");Console.ResetColor();}
            break;
        case 3:
            if(zloto >= 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Miałeś dobry odpoczynek");
                zloto -= 3;
                if(punktyŻycia <= 95){punktyŻycia += 5;Console.WriteLine($"Straciłeś 3 sztuki złota i dostałeś 5 punktów życia");}
                else{punktyŻycia = 100;Console.WriteLine($"Straciłeś 3 sztuki złota i dostałeś teraz jesteś pewien życia");}
                Console.ResetColor();
            }
            else {Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine($"Nie masz wystarczająco złota!");Console.ResetColor();}
            break;
        case 4:
            if(punktyŻycia == 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Maksymalny poziom życia");
                Console.ResetColor();
            }
            if(punktyŻycia >= 75)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Wysoki poziom życia");
                Console.ResetColor();
            }
            else if(punktyŻycia >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Średni poziom życia");
                Console.ResetColor();
            }
            else if(punktyŻycia >= 25)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Niski poziom życia");
                Console.ResetColor();
            }
            else if(punktyŻycia <= 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Krytyczny poziom życia");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nEksploracj wykonano: {exploracja} ");
            Console.ResetColor();
            numerTury--;
            continue;
        case 5:
            graDziala = false;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Błąd!");
            Console.ResetColor();
            continue;
    }
    numerTury++;
}
if(punktyŻycia < 0) {punktyŻycia = 0;}
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"=== Game Over ===");
Console.ResetColor();
Console.WriteLine($"Tura: {numerTury}");
Console.WriteLine($"Bohater: {imie}");
Console.WriteLine($"Złoto: {zloto}");
Console.WriteLine($"liczba mikstur: {mikstur}");
Console.WriteLine($"\nEksploracj wykonano: {exploracja}");
if(punktyŻycia == 0){Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine($"Zmarł");Console.ResetColor();}
else{Console.ForegroundColor = ConsoleColor.Cyan;Console.WriteLine($"Zakączył gre");Console.ResetColor();}
