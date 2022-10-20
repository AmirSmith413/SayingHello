//Mini Challenge #1 
//Finished on:8/9/22
//Peer Reviewed by:Saul Suazo

//This program will ask you for your name and say "Hello" to you.
string name;
string decision;
bool playAgain = true;
while(playAgain == true)
{
Console.WriteLine("Hello there! What is your name?");

//random name will go here
name = Console.ReadLine();

//Aw thanks you too <3
Console.WriteLine($"Hello {name}! I hope you are having a wonderful day!!");  
Console.WriteLine("Would you like to try again?Type Y to try again or N to end.");
 decision = Console.ReadLine().ToUpper();
 //if the user wanted to try again, pressing "Y" will send them to the beginning
 if(decision == "Y")
    {
      playAgain = true;
    }
    else if(decision == "N")
    {
      //if the user wanted to stop pressing "N" will end the program
      playAgain = false;
    }
    else
    {
        Console.WriteLine("Please pick a valid option.");
    }       
}
