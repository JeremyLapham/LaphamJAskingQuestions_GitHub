//Jeremy Lapham
//10-17-22
//Asking Questions
//This program will ask the user their name and what time they woke up and say it back to them



bool playAgain = true;
while(playAgain)
{
Console.WriteLine("Hello, what is your name?");
string youName = Console.ReadLine();

Console.WriteLine("Hey " + youName + " What time did you wake up?");
string wakeUp = Console.ReadLine();

Console.WriteLine("Damn bro you woke up at " + wakeUp + " that's insane");

Console.WriteLine("Do you want to play again? Type yes to play again type end to stop");
string playAgain2 = Console.ReadLine().ToLower();
if(playAgain2 == "end")
{
    playAgain = false;
}
}
Console.WriteLine("Thanks for playing!");