// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
string pattern = "^[A-Za-z]+$";
bool isValid = false;
string message = "Please enter a valid input";
Console.WriteLine("Please enter your first name");

string? firstname = Console.ReadLine();
firstname = firstname!.Trim();
if (string.IsNullOrEmpty(firstname) || string.IsNullOrWhiteSpace(firstname))
{
    Console.WriteLine(message);
    Console.ReadLine();
    
    return;
}
isValid = Regex.IsMatch(firstname!, pattern);

if (!isValid)
{
    Console.WriteLine($"{firstname} is invalid. Gaskia!!");
    Console.ReadLine();
    return;
}
Console.WriteLine("Please enter your last name");

string? lastname = Console.ReadLine();
if (string.IsNullOrEmpty(lastname) || string.IsNullOrWhiteSpace(lastname))
{
    Console.WriteLine(message);
}

isValid = Regex.IsMatch(lastname!, pattern);
if (!isValid)
{
    Console.WriteLine($"{lastname} is invalid. Gaskia!!");
    Console.ReadLine();
    return;
}
Console.WriteLine($"Good evening {firstname} {lastname}");
Console.ReadLine();

