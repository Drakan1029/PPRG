using System.Net.Security;
using System.Runtime.InteropServices;

Console.WriteLine("Wprowadź imię bohatera");
string imie = Console.ReadLine();
int punktyŻycia;
string[] znaleziska =
{
    "Mikstura",
    "Klucz",
    "Pochodnia",
    "Zwój"
};
List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura"
};
List<string> historia = new List<string>();
int[] zlotoZdobyteWTurach = new int[20];
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
int numerTury = 1;
bool graDziala = true;
int exploracja = 0;
while(graDziala && punktyŻycia > 0 && numerTury <=20)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"\n=== Hello Adventurer ===");
    Console.ResetColor();
    Console.WriteLine($"Tura: {numerTury}");
    Console.WriteLine($"Bohater: {imie}");
    Console.WriteLine($"Bohater: {plecak.Count}/6");
    Console.WriteLine($"");
    Console.WriteLine($"1 - Eksploruj loch");
    Console.WriteLine($"2 - Pokaż plecak");
    Console.WriteLine($"3 - Użyj przedmiotu");
    Console.WriteLine($"4 - Dodaj znalezisko");
    Console.WriteLine($"5 - Wyrzuć przedmiot");
    Console.WriteLine($"6 - Pokaż historię");
    Console.WriteLine($"7 - Pokaż statystyki");
    Console.WriteLine($"8 - Zakończ gre\n");

    int wybor = 0;
    while (!int.TryParse(Console.ReadLine(), out wybor));
    switch(wybor)
    {
        case 1:
            if(punktyŻycia > 8)
            {
                exploracja ++;
                zloto += 10;
                punktyŻycia -= 8;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"zdobyłem 10 sztuk złota i straciłem 8 punktów Zdrowia");
                Console.ResetColor();
                historia.Add("Wykonano eksplorację.");
                zlotoZdobyteWTurach[numerTury - 1] += 10;
            }
            break;
        case 2:
            if(plecak.Count > 0)
            {
                for(int i = 0; i < plecak.Count; i++){Console.WriteLine($"{i+1} - {plecak[i]}");}
                
            }
            else {Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine($"Plecak pusty!");Console.ResetColor();}
            historia.Add("Przejrzenie plecaka.");
            break;
        case 3:
            for(int i = 0; i < plecak.Count; i++){Console.WriteLine($"{i+1} - {plecak[i]}");}
            while (!int.TryParse(Console.ReadLine(), out wybor));
            if(wybor >= 1 && wybor <= plecak.Count)
            {
                var przedmiot = plecak[wybor - 1];
                if(przedmiot == "Mikstura")
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
                    plecak.RemoveAt(wybor-1);
                    historia.Add("Użyłem mikstury.");
                }
                if(przedmiot == "Pochodnia"){Console.ForegroundColor = ConsoleColor.Green;Console.WriteLine("Rozświetlono korytarz");Console.ResetColor();plecak.RemoveAt(wybor-1);}
                if(przedmiot == "Zwój"){Console.ForegroundColor = ConsoleColor.Green;Console.WriteLine("Otzymałeś 15 złota!");zloto+=15;Console.ResetColor();plecak.RemoveAt(wybor-1);}
                if(przedmiot == "Klucz"){Console.ForegroundColor = ConsoleColor.Yellow;Console.WriteLine("Nie jest teraz potrzebny");Console.ResetColor();continue;}
                if(przedmiot == "Miecz"){Console.ForegroundColor = ConsoleColor.Yellow;Console.WriteLine("Zwykły Miecz");Console.ResetColor();continue;}
            }
            break;
        case 4:
            if(plecak.Count < 6)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1}. {znaleziska[i]}");
                }
                Console.WriteLine($"Podaj numer przedmiotu do znalezienia");
                while (!int.TryParse(Console.ReadLine(), out wybor));
                plecak.Add(znaleziska[wybor-1]);
                var przedmiotDoDodania = znaleziska[wybor-1];
                historia.Add($"Dodano {przedmiotDoDodania} do plecaka.");
            }
            else {Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine($"Plecak jest pełny!");Console.ResetColor();continue;}
            break;
        case 5:
            if(plecak.Count > 0)
            {
                Console.WriteLine($"Podaj numer przedmiotu do wyrzucenia");
                while (!int.TryParse(Console.ReadLine(), out wybor));
                if(wybor-1 > plecak.Count || wybor-1 < 0){continue;}
                var przedmiotDoWyrzucenia = plecak[wybor-1];
                historia.Add($"Usunięto {przedmiotDoWyrzucenia} z plecaka.");
                plecak.RemoveAt(wybor-1);
            }
            else {Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine($"Plecak pusty!");Console.ResetColor();continue;}
            break;
        case 6:
            if (historia.Count > 0)
            {
                for (int i = 0; i < historia.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {historia[i]}");
                }
            }
            else
            {
                Console.WriteLine("Historia jest pusta.");
            }
            break;
        case 7:
            Console.WriteLine($"Eksploracji wykonano - {exploracja}");
            int suma = 0;
            foreach(int zlotoTury in zlotoZdobyteWTurach)
            {
                suma += zlotoTury; 
            }
            Console.WriteLine($"Zloto zdobyta w eksploracjach - {suma}");
            continue;
        case 8:
            graDziala = false;
            numerTury--;
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
Console.WriteLine($"\nEksploracj wykonano: {exploracja}");
if(punktyŻycia == 0){Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine($"Zmarł");Console.ResetColor();}
else{Console.ForegroundColor = ConsoleColor.Cyan;Console.WriteLine($"Zakączył gre");Console.ResetColor();}
