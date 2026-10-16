Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Podaj imię bohatera");
string imie = Console.ReadLine();
Console.WriteLine("Podaj maksymalne punkty życia");
int maksPunktyŻycia = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj punkty życia bohatera");
int punktyŻycia = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj ilosć złota");
decimal złoto = decimal.Parse(Console.ReadLine());
Console.WriteLine("Podaj siłe bohatera");
int siła = int.Parse(Console.ReadLine());
bool jestSilny = siła > 5;
Console.WriteLine("czy posiada mapę?");
string maMapę = Console.ReadLine();
bool mapa = maMapę == "Tak" || maMapę == "tak" || maMapę == "True" || maMapę == "true";
Console.WriteLine("czy posiada miksture?");
string maMiksture = Console.ReadLine();
bool mikstura = false;
mikstura = maMiksture == "Tak" || maMiksture == "tak" || maMiksture == "True" || maMiksture == "true";
Console.WriteLine("Podaj ilość resursów na miksturę");
int resursyNaMiksture = int.Parse(Console.ReadLine());
string stan = "";
if(punktyŻycia == maksPunktyŻycia){stan = "Bohater jest w dobrej formie";}
else if(punktyŻycia > maksPunktyŻycia/2){stan = "Bohater jest ranny";}
else if(punktyŻycia > maksPunktyŻycia/4){stan = "Średni poziom zdrowia";}
else if(punktyŻycia > 0){stan = "Ma niski poziom zdrowia";}
else if(punktyŻycia <= 0){stan = "Nie żyje";}
bool gotowyDoWyprawy = punktyŻycia == maksPunktyŻycia && mikstura;
Console.WriteLine( "-=-=-=-=-=-=-= Karta Bohatera =-=-=-=-=-=-=-");
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"| Bohater: {imie}\t\t\t\t|");
Console.WriteLine($"| Zdrowie: {punktyŻycia}/{maksPunktyŻycia}\t\t\t\t|");
Console.WriteLine($"| Siła: {siła}\t\t\t\t|");
Console.WriteLine($"| Złoto: {złoto}\t\t\t\t|");
Console.WriteLine($"| Ma mapę: {maMapę}\t\t\t\t|");
Console.WriteLine($"| Ma miksturę: {maMiksture}\t\t\t|");
Console.WriteLine($"| Gotowy do wyprawy?: {gotowyDoWyprawy}\t\t|");
Console.ResetColor();
Console.WriteLine($"-=-=-=-=-=-=-=________________=-=-=-=-=-=-=-");


Console.WriteLine($"\n\n1. sprawdź stan");
Console.WriteLine("2. rozpocznij wyprawę");
Console.WriteLine("3. przygotuj miksturę");
Console.WriteLine("4. odpocznij");
int akcja = 0;
Console.WriteLine("");
akcja = int.Parse(Console.ReadLine());
switch(akcja)
{
    case 1:
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("Stan bohatera - ");
        Console.WriteLine(stan);
        break;
    case 2:
        if(gotowyDoWyprawy)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Rozpocząłęś wyprawę");
        }
        else{Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine("nie możesz wybrać się na wyprawę");}
        break;
    case 3:
        if(resursyNaMiksture < 2){Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine("Na miksture musisz mieć co najmniej 2 resursy");}
        else{Console.ForegroundColor = ConsoleColor.Green;Console.WriteLine("Przygotowałeś miksturę!"); mikstura = true;}
        break;
    case 4:
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Opdocznęłęś");
        punktyŻycia = maksPunktyŻycia;
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Nie ma takiej akcji");
        break;
}
Console.ResetColor();
