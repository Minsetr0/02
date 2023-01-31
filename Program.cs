string loopCondition = "exit";
string condition = null;

while (condition != loopCondition)
{
    Console.WriteLine("для выхода из цикла напишите exit");
    string message = Console.ReadLine();
    condition = message;

    Console.Clear();
}