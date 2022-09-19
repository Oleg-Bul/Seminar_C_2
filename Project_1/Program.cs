//void int string bool
void WriteTwo()
{
    Console.WriteLine(2);
}
void WriteHello(string name)
{
    Console.WriteLine("Hello, "+ name);
}
string HelloToWord(string name)
{
    return "Hello, " + name;
}
WriteTwo();
string word = HelloToWord("Oleg");
Console.WriteLine(word + " Как дела ?");