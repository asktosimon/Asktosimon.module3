const string DEFAULT_NAME = "No name";

(string name, string[] dishes) Person = (DEFAULT_NAME, new string[5]);

Console.WriteLine("What is your name?");

var name = Console.ReadLine();

Person.name = name ?? DEFAULT_NAME;

Console.WriteLine("What are your most liked dishes? Could call 5 dishes?");

foreach(var i in Enumerable.Range(0, 5))
{
    var dish = Console.ReadLine();

    Person.dishes[i] = dish ?? "";
}

Console.WriteLine($"Your name is {Person.name}");
Console.WriteLine($"Your most liked dishes are here: {string.Join(", ", Person.dishes)}");