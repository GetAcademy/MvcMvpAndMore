
var numberList = new SortedNumbers.ModelAndController.SortedNumbers();
while (true)
{
    Console.Clear();
    var numbers = numberList.Numbers;
    if (numbers.Length > 0)
    {
        Console.WriteLine(" - " + string.Join("\n - ", numbers));
    }

    Console.WriteLine($"Summen er {numberList.Sum}");
    Console.WriteLine("Kommandoer: \n - 1 => legge til tall\n - 2 => fjerne tall");
    Console.Write("Hva vil du gjøre? ");
    var command = Console.ReadLine();
    if (command == "1")
    {
        Console.Write("Hvilket tall vil du legge til? ");
        var numberStr = Console.ReadLine();
        var number = Convert.ToInt32(numberStr);
        numberList.Add(number);
    } else if (command == "2")
    {
        Console.Write("Hvilket tall vil du fjerne? ");
        var numberStr = Console.ReadLine();
        var number = Convert.ToInt32(numberStr);
        numberList.Remove(number);
    }
}