// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("EUR:");
string eur = Console.ReadLine();
int cisloEur = Convert.ToInt32(eur);
int pocetCZK = cisloEur * 26;
Console.WriteLine(pocetCZK);

if (pocetCZK > 1000)
{
    Console.WriteLine(cisloEur + " eur je vice nez 1000czk");
}

Console.WriteLine("studenti:");
string stud = Console.ReadLine();

Console.WriteLine("ucitele:");
string uct = Console.ReadLine();

float pocetu = Convert.ToInt32(uct);
float pocets = Convert.ToInt32(stud);

float pomer = pocets / pocetu;

Console.WriteLine("pomer" + pomer);