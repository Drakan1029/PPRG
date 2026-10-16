// zadanie 1

// Console.WriteLine("Podaj imię bohatera");
// string imie = Console.ReadLine();
// Console.WriteLine("Podaj symbol bohatera");
// char symbol = char.Parse(Console.ReadLine());
// Console.WriteLine("Podaj poziom doświadczenia");
// int poziom = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj liczbe złota");
// double zloto = double.Parse(Console.ReadLine());
// Console.WriteLine("Podaj wagę bohatera");
// double waga = double.Parse(Console.ReadLine());
// Console.WriteLine("Czy jest na mapie? (true/false)");
// bool mapa = bool.Parse(Console.ReadLine());
// Console.WriteLine("-=-=-= Ekvipunek =-=-=-");
// Console.WriteLine($"Imie (string): {imie}");
// Console.WriteLine($"Symbol (char): {symbol}");
// Console.WriteLine($"Poziom (int): {poziom}");
// Console.WriteLine($"Złoto (double): {zloto}");
// Console.WriteLine($"Waga (double): {waga}");
// Console.WriteLine($"Na mapie (bool): {mapa}");

//zadanie 2

// int zloto1 = 8;
// int punktyDoswiadczenia = 40;
// int trening = 0;
// Console.WriteLine($"Na początku\nZłota = {zloto1}\nPunktów doświadczenia = {punktyDoswiadczenia}\nTreningów = {trening}");
// punktyDoswiadczenia += 25;
// punktyDoswiadczenia *= 2;
// zloto1 -= 8;
// zloto1 += 15;
// trening++;
// Console.WriteLine($"\n\nNa koniec\nZłota = {zloto1}\nPunktów doświadczenia = {punktyDoswiadczenia}\nTreningów = {trening}");

//zadanie 3

// Console.WriteLine("Podaj liczbę racji drużyny");
// int racja = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj liczbę członków drużyny");
// int członków = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj liczbę dni wyprawy");
// int dni = int.Parse(Console.ReadLine());
// Console.WriteLine($"Każdy członek otrzyma: {racja/członków}");
// Console.WriteLine($"Pozostanie racji: {racja%członków}");
// Console.WriteLine($"Codzinnie drużyna otrzymuje: {(double)racja/dni}");
// Console.WriteLine($"Średnia liczba racji dla 1 członka: {(double)racja/członków/dni}");

//zadanie 4

// Console.WriteLine("Ile masz punktów życia?");
// int hp = int.Parse(Console.ReadLine());
// Console.WriteLine("Ile masz mikstur?");
// int mikstur = int.Parse(Console.ReadLine());
// Console.WriteLine("Czy masz klucz?");
// bool klucz = bool.Parse(Console.ReadLine());
// Console.WriteLine("Czy masz mapę?");
// bool map = bool.Parse(Console.ReadLine());
// bool zyje = hp > 0;
// Console.WriteLine($"Żyje?: {zyje}");
// bool maPewneZdrowie = hp == 100;
// Console.WriteLine($"Ma pewne zdrowie?: {maPewneZdrowie}");
// bool wymagaLeczenia = !maPewneZdrowie;
// Console.WriteLine($"Wymaga leczenia?: {wymagaLeczenia}");
// bool maZaopatrzenie = mikstur > 0;
// Console.WriteLine($"Ma zaopatrzenie?: {maZaopatrzenie}");
// bool Mapa1Klucz = map || klucz;
// Console.WriteLine($"Ma mapę czy klucz?: {Mapa1Klucz}");
// bool gotowy = zyje && maZaopatrzenie && Mapa1Klucz;
// Console.WriteLine($"Gotowy do wyprawy?: {zyje}");

//zadanie 5

// Console.WriteLine("Podaj imię bohatera:");
// string name = Console.ReadLine();
// Console.WriteLine("Podaj maksymalne zdrowie bohatera:");
// int maxHP = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj zdrowie bohatera:");
// int HP = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj obrażenia broni bohatera:");
// int damage = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj siłę bohatera:");
// int bonus = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj mnożnik ataku specjalnego:");
// double bonusSpecialAttack = double.Parse(Console.ReadLine());
// Console.WriteLine("Podaj liczbę attacków bohatera:");
// int liczbaAtakow = int.Parse(Console.ReadLine());
// int normalAttack = damage + bonus;
// double specialAttack = normalAttack * bonusSpecialAttack;
// specialAttack = (int)specialAttack;
// int allDamage = (normalAttack * liczbaAtakow) + (int)specialAttack;
// double procentHp = (maxHP / HP) * 100;
// bool Żyje = HP > 0;
// bool maPewneHp = HP == maxHP;
// Console.WriteLine("-=-=-=-= Raport z Walki =-=-=-=-");
// Console.WriteLine($"Bohater: {name}");
// Console.WriteLine($"Zdrowie: {HP}/{maxHP} ({procentHp})");
// Console.WriteLine($"Złykwy atak: {normalAttack}");
// Console.WriteLine($"Atak specjalny: {specialAttack}");
// Console.WriteLine($"Łączne obrażenia {allDamage}");
// Console.WriteLine($"Zyje?: {Żyje}");
// Console.WriteLine($"Pełne zdrowie?: {maPewneHp}");

//Zadanie 6

const decimal kosztPodrozy = 10.25m;
Console.WriteLine("Podaj imię bohatera:");
string Name = Console.ReadLine();
Console.WriteLine("Podaj siłę bohatera:");
int sila = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj wzrost bohatera:");
double Wzrost = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj złoto bohatera:");
decimal Zloto = decimal.Parse(Console.ReadLine());
Console.WriteLine("Podaj jaki będzie symbol na mapie:");
char mapSymbol = char.Parse(Console.ReadLine());
Console.WriteLine("Podaj szybkość bohatera:");
int szybkosc = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj wytrzymałość bohatera:");
int stamina = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj ilość jedzenia:");
int jedzenie = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj ilość km do pokonania:");
double km = double.Parse(Console.ReadLine());
double m = km * 1000;
m = (int)m;
szybkosc += 1;
stamina += 1;
int metrowDzien = szybkosc * stamina * 10;
int dni = (int)m / metrowDzien;
bool czyPodrozowal = Zloto >= kosztPodrozy;
bool dlugaPodroz = dni > 7;
bool czyJestSilny = sila > 10;
bool czyStarczyJedzenia = jedzenie / dni / 3 >= 0;
int inventory = 2;
inventory *= sila;
inventory -= 2;
metrowDzien /= 2;
jedzenie %= (dni * 3);

Console.WriteLine("-=-=-=-= Wielka Podróża =-=-=-=-");
Console.WriteLine($"Bohater: {Name}");
Console.WriteLine($"Wzrost: {Wzrost}");
Console.WriteLine($"Symbol na mapie: {mapSymbol}");
Console.WriteLine($"Czy podróżował? - {czyPodrozowal}");
Console.WriteLine($"Złota: {Zloto}");
Console.WriteLine($"Siła: {sila}");
Console.WriteLine($"Bohater jest silny? - {czyJestSilny}");
Console.WriteLine($"Mijsca w plecaku: {inventory}");
Console.WriteLine($"Metrów pokonywane w jednym dniu: {metrowDzien}");
Console.WriteLine($"Podróż trwała {dni}");
Console.WriteLine($"Czy jest długa podróż? - {dlugaPodroz}");
Console.WriteLine($"Czy starczyło jedzenia? - {czyStarczyJedzenia}");
Console.WriteLine($"Jedzenia starczy jeszcze na takich {jedzenie} podróży");


