/*
 * Dependency Inversion Principle
 *
 * Dependency Injection
 * Constructor Injection
 */

using CountTextsStartingWithA;

var textFetcher = new FileTextFetcher("TextFile1.txt");
var consoleTextFetcher = new ConsoleTextFetcher();
var service = new CountTextService(consoleTextFetcher);

var count = service.Count("A");
Console.WriteLine(count);

//var count = 0;
//using var fileStream = File.OpenRead("TextFile1.txt");
//using var streamReader = new StreamReader(fileStream);
//String line;
//while ((line = streamReader.ReadLine()) != null)
//{
//    if (line.StartsWith('A')) count++;
//}

//Console.WriteLine(count);