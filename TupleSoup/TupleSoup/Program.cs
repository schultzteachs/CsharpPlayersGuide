
(string type, string ingredient, string flavor) Recipe;

Console.WriteLine("Pick a soup base! Here are the options:");
Console.WriteLine(Food.soup);
Console.WriteLine(Food.stew);
Console.WriteLine(Food.gumbo);
Recipe.type = Console.ReadLine();

Console.WriteLine("Pick a main ingredient! Here are the options:");
Console.WriteLine($"{Main.mushrooms} , {Main.chicken}, {Main.carrots}, {Main.potatoes}");
Recipe.ingredient= Console.ReadLine();

Console.WriteLine("Pick a seasoning! Here are the options:");
Console.WriteLine($"{Seasoning.spicy}, {Seasoning.salty}, {Seasoning.sweet}");
Recipe.flavor = Console.ReadLine();

Console.WriteLine($"You have selected {Recipe.flavor} {Recipe.ingredient} {Recipe.type}");


enum Food {soup, stew, gumbo};
enum Main { mushrooms, chicken, carrots, potatoes}
enum Seasoning {spicy, salty, sweet}
