// Console.Write("");
// Console.WriteLine(" _________________ ");
// Console.WriteLine("|   Infromatyka   |");
// Console.WriteLine("|Imie: Dzianis    |");
// Console.WriteLine("|Wiek: 20         |");
// Console.WriteLine("|Gra: FTD         |");
// Console.WriteLine("|_________________|\n\n");
// Console.WriteLine("Jak masz na Imię?");
// string imie = Console.ReadLine();
// Console.WriteLine("Jaki masz ulubiony kolor?");
// string color = Console.ReadLine();
// Console.WriteLine("\n\nCześć, " + imie + "! " + color + " to świetny kolor na płaszcz poszukiwacza przygód.");

// Console.WriteLine("Ile kilometrów do celu?");
// int road = int.Parse(Console.ReadLine());
// Console.WriteLine("Ile kilometrów pokanujesz każdego dnia?");
// int step = int.Parse(Console.ReadLine());
// Console.WriteLine($"Za {road / step} dni będziesz u celu");

// Console.WriteLine("Ile masz złotych monet?");
// int Zl = int.Parse(Console.ReadLine());
// Console.WriteLine("Ile masz srebrnych monet?");
// int Sr = int.Parse(Console.ReadLine());
// Console.WriteLine("Ile masz miedzianych monet?");
// int Md = int.Parse(Console.ReadLine());
// Console.WriteLine($"Łącznie masz {Zl * 10 + Sr + (Md / 10)} w srebrnych monetach");

// Console.WriteLine("Ile chcesz mikstur?");
// int mix = int.Parse(Console.ReadLine());
// Console.WriteLine(" _________________ ");
// Console.WriteLine($"|Mixtur:\t{mix}|");
// Console.WriteLine($"|Kszystałów:\t{mix * 3}|");
// Console.WriteLine($"|Ziół:\t\t{mix * 2}|");
// Console.WriteLine("|_________________|\n\n");

// Console.WriteLine("Ile kosztuje nocleg?");
// decimal price = decimal.Parse(Console.ReadLine());
// Console.WriteLine("Ile nocy planujesz w nim być?");
// int night = int.Parse(Console.ReadLine());
// Console.WriteLine($"Będziesz musiał zapłacić {price * night}zł");

// --------------Poziom trudny

// Console.WriteLine("Podaj czas w sekundach");
// int sec = int.Parse(Console.ReadLine());
// Console.WriteLine($"To będzie {sec/3600}h {(sec/60)%60}min {sec%60}sec");

// Console.WriteLine("Podaj ilość drużyny");
// int druz = int.Parse(Console.ReadLine());
// if(druz != 0){
// Console.WriteLine("Podaj ilość zlotych monet");
// int nagroda = int.Parse(Console.ReadLine());
// Console.WriteLine($"Każdy otrzymał {nagroda / druz} monet, przy tym zostanie {nagroda % druz} monet");}

// Console.WriteLine("Podaj obrażenia broni");
// int obraz = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj siłę");
// int power = int.Parse(Console.ReadLine());
// Console.WriteLine($"Twój złykwy atak naniósł {obraz + power}");
// Console.WriteLine($"Twój specjalny atak naniósł {(obraz + power) * 2}");
// Console.WriteLine($"Obrażenia po 3 atakach złykwych i jednym specjalnym wyniosły {(obraz + power)*3 + (obraz + power)*2}");

// Console.WriteLine("Podaj nazwe bohatera");
// string name = Console.ReadLine();
// Console.WriteLine("Podaj nazwe krainy");
// string country = Console.ReadLine();
// Console.WriteLine("Podaj liczbe dni wyprawy");
// int day = int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj ilość punktów doświadczeń");
// double score = double.Parse(Console.ReadLine());
// Console.WriteLine("Podaj ilość zebranego złota");
// decimal money = decimal.Parse(Console.ReadLine());
// Console.WriteLine("_____________________________________");
// Console.WriteLine($"|       {name}       ");
// Console.WriteLine($"|Kraj:\t\t{country}");
// Console.WriteLine($"|Liczba dni:\t\t{day}");
// Console.WriteLine($"|Średnia Punktów:\t{(score/day)}");
// Console.WriteLine($"|Średnia Złota:\t\t{(money/day)}");
// Console.WriteLine($"|___________________________________\n\n");

Console.WriteLine("*****Steal A Damage*****");
Console.WriteLine("Jak masz na imię bohaterze?");
string gameName = Console.ReadLine();

// Bawiłem się
// if(gameName == "TungTungSahur")
// {
//     Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢟⣛⣛⣛⣛⡻⠿⣿⣿⣿\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⢁⣺⣿⣿⣿⣿⣿⣿⣿⣶⠈⣿\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠃⠼⢽⣿⣿⠿⠻⠛⠻⢿⣿ ⣾\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁   ⠙⠁  ⢠⡀ ⢬⠃⣿\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟  ⠻⡄ ⣇ ⠃ ⠘⡇ ⠄⢿\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟   ⢈⢸⡿⣦⣀⢀⣀⣴⣿⡆⢸\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠙⠳⠞⠁⠸⠷⠦⠈⠉⠉⠉  ⢸\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦  ⠆  ⠤⠿⠂    ⢸\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⡄   ⠈⣠⡼⠃   ⢸\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃   ⠛⠉ ⢀⠠  ⢸\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠠    ⢤⠘⠤⠁⢰⡆⢸\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿   ⢠⠋⠤⡉⠐⡀ ⢿⠸\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ ⠄  ⡘⢀⠆⠡  ⣈ \n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇    ⡐⠈⠤⢁⠂ ⡟⢰\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⡀   ⠠⠁⠂⠄ ⣸⠁⣸\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠁       ⠈⠁⢰⣿\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢁⠆   ⢀⣐   ⢀⣸⣿\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⡁⠁⣼⡇  ⣿⣿ ⡀⢀⣷⣿⣿\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⡔ ⣼⣿⡇⣀ ⣿⣿⡆⣡⠘⣿⣿⣿\n⣿⣿⣿⣿⣿⣿⣿⡿⢡⡞⢀⣾⣿⣿⣇  ⢿⣿⡇⠁ ⣿⣿⣿\n⣿⣿⣿⣿⣿⣿⡏⣴⡇⢠⣾⣿⣿⣿⣿  ⢸⣿⣧  ⣿⣿⣿\n⣿⣿⣿⣿⣿⠏⣼⠍⢀⣿⣿⣿⣿⣿⣿⡀ ⢸⣿⣿⡀ ⣻⣿⣿\n⣿⣿⣿⡿⠋⡸⠁⢀⣾⣿⣿⣿⣿⣿⣿⣇⢀⠈⣿⣿⡇ ⢸⣿⣿\n⣿⣿⠟⠁⠄ ⢠⣾⣿⣿⣿⣿⣿⣿⣿⡟  ⢿⡿⠁ ⠘⣿⣿\n⡿⠋   ⣠⣾⣿⣿⣿⠿⠛⣛⣹⡏    ⢠⣾⣆ ⢻⣿\n⣦⣀⡀ ⢰⣿⣿⣿⡃⠄⠤⡶⠋⠉⣁⣠⣴⡆⠰⠛⠻⠻⠢⠘⣿\n⣿⣿⣿⣷⣿⣿⣿⣿⣿⣷⣶⣶⣾⣿⣿⣿⣯⣁⣀⡊⣘⣀⣀⣤⣿");
//     return;
// }

Console.WriteLine("Jaką broń wybierasz? (1-Miecz, 2-Włócznia, 3-Łuk)");
int Bron = int.Parse(Console.ReadLine());
int Damage = 12/Bron;
int Range = Bron*2;
Console.WriteLine("Kim jesteś? (naprzykład Ork, krasnolud, elf)");
string Race = Console.ReadLine();
Console.WriteLine("Wybież losową liczbę");
decimal money = decimal.Parse(Console.ReadLine());
money = ((money * 17513)/2)%300;
Console.WriteLine("*****Steal A Damage*****\n");
Console.WriteLine($"Bohater: !{gameName}! - {Race};");
Console.WriteLine($"Damage - {Damage}");
Console.WriteLine($"Range - {Range}m");
Console.WriteLine($"Money - {money}zł");
Console.WriteLine("************************");
