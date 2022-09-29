// See https://aka.ms/new-console-template for more information

string userName;

Console.WriteLine("Hello There! What is your name?");
userName = Console.ReadLine();

Console.WriteLine("Welcome " + userName + "! Please enter a number between 1 and 100. 1 and 100 are acceptable inputs.");

int userNumber = int.Parse(Console.ReadLine());

if (userNumber >= 1 && userNumber <= 100)
{
    if (userNumber % 2 == 1 && userNumber < 60)
    {
        Console.WriteLine(userName + ", you entered " + userNumber + ", which is Odd and less than 60.");
    }
    else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 24)
    {
        Console.WriteLine(userName + ", you entered " + userNumber + ", which is even and less than 25.");
    }
    else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
    {
        Console.WriteLine(userName + ", you entered " + userNumber + ", which is even and between 26 and 60 inclusive.");
    }
    else if (userNumber % 2 == 0 && userNumber > 60)
    {
        Console.WriteLine(userName + ", you entered " + userNumber + ", which is even and greater than 60.");
    }
    else if (userNumber % 2 == 1 && userNumber > 60)
    {
        Console.WriteLine(userName + ", you entered " + userNumber + ", which is odd and greater than 60.");
    }
} else
{
    Console.WriteLine("Sorry, the number you entered does not meet the specifications.");
}



