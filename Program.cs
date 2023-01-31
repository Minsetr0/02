bool isWorking = true;
string loopCondition = "exit";
while (isOpen)
{
    Console.WriteLine("для выхода из цикла напишите exit");
    string message = Console.ReadLine();

    if (message == loopCondition)
        break;

    Console.Clear();
}