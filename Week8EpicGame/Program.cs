//[]
//{}
//$

string folderPath = @"/Users/MarinSalumets/projects/data";
string heroFile = @"/Users/MarinSalumets/projects/data/heroes.txt";
string villainFile = @"/Users/MarinSalumets/projects/data/villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


//string[] heroes = {"Venom", "Spiderman", "Wonder Woman", "Scooby-Doo"};
//string[] villains = { "Joker", "Hans Gruber", "Dracula", "Thanos", "Voldemort" };


string[] weapon = { "magic wand", "sword", "revolver", "switchblade"};


string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with a {heroWeapon} saves the day!");


string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with a {villainWeapon} tries to take over the world!");


static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}
