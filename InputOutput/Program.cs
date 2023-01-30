using System.Runtime.CompilerServices;

String name;
int age;

Console.WriteLine("Name: ");
name = Console.ReadLine();

Console.WriteLine("Age: ");
try
{
    age = Int32.Parse(Console.ReadLine());  // Can use Convert.ToInt32
    if (age is 0 or > 150)
    {
        Console.WriteLine("Invalid Age");
    }
}
catch (FormatException) {
    Console.WriteLine("Unable to parse age");
}

String num;
num = Console.ReadLine();

void Counter(int value)
{
    for (int i = 1; i <= value; i++)
    {
        Console.Write(i);
    }    
}

Counter(Convert.ToInt32(num));

Console.WriteLine("Hello! " + name);

void Shout(String word)
{
    Console.WriteLine(word.ToUpper());
}

Shout(name);
