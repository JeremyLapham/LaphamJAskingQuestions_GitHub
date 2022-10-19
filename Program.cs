//Jeremy Lapham
//10-17-22
//Asking Questions
//This program will ask the user their name and what time they woke up and say it back to them
//Peer Review: Jacob Dekok


bool playAgain = true;
bool whyNumber = true;
bool whyNumber2 = true;
int needNum1 = 0;

while(playAgain)
{
Console.WriteLine("Hello, what is your name?");
string youName = Console.ReadLine();
whyNumber = Int32.TryParse(youName, out needNum1);
if(whyNumber == true)
{
    Console.WriteLine("I'm pretty sure most names aren't just numbers but who am I to judge.");
}
else if(whyNumber == false)
{
Console.WriteLine("Hey " + youName + ". What time did you wake up?");
string wakeUp = Console.ReadLine();

Console.WriteLine("Damn bro you woke up at " + wakeUp + " that's insane");
}

Console.WriteLine("Do you want to play again? Type yes to play again type end to stop");
string playAgain2 = Console.ReadLine().ToLower();
if(playAgain2 == "end")
{
    playAgain = false;
}
}
Console.WriteLine("Thanks for playing!");