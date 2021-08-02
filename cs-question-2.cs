
// version 1

static void Main()
{
    var names = new List<string> {"usa", "uk", "germany", "italy", "france", "australia", "china"};
    var moreThanFiveLetters = names.Where(w => w.Length > 5);
    names[0] = "canada";

    foreach (var name in moreThanFiveLetters)
    {
        Console.WriteLine(name);
    }
}


// version 2

static void Main()
{
    var names = new List<string> {"usa", "uk", "germany", "italy", "france", "australia", "china"};
    var moreThanFiveLetters = names.Where(w => w.Length > 5).ToList();    
    names[0] = "canada";

    foreach (var name in moreThanFiveLetters)
    {
        Console.WriteLine(name);
    }
}
