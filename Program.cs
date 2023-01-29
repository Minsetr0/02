bool isOpen = true;

while (isOpen)
{
    Console.WriteLine("для выхода из цикла напишите exit");
    string message = Console.ReadLine();
    if (message == "exit")
        break;
    Console.Clear();
}