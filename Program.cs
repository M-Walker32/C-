// See https://aka.ms/new-console-template for more information
bool playing = true;
Random rnd = new Random();
int num = rnd.Next(1, 3);
string computer = "computers choice";

// Get users name
System.Console.WriteLine("What is your name?");
string name = Console.ReadLine();

while (playing)
{
  // Ask to play game
  System.Console.WriteLine(name + ", do you want to play rock paper sissors? yes or no");
  string play = Console.ReadLine().ToLower();
  if (play == "no")
  {
    playing = false;
  }
  if (play == "yes")
  {
    playing = true;
  }
  else
  {
    Console.WriteLine("please enter yes or no");
    Console.Clear();
  };
  // User chooses rock paper sissors
  System.Console.WriteLine("Pick a number 1. Rock 2. Paper, or 3. Sissors?");
  string choice = Console.ReadLine().ToLower();
  // GAME LOGIC
  if (num == 1) { computer = "rock"; };
  if (num == 2) { computer = "paper"; };
  if (num == 3) { computer = "sissors"; };
  if (choice == "1")
  {
    Console.WriteLine("The computer chooses " + computer);
  }
  if (choice == "2")
  {
    Console.WriteLine("The computer chooses " + computer);
  }
  if (choice == "3")
  {
    Console.WriteLine("The computer chooses " + computer);
  }
  else
  {
    Console.WriteLine("Please enter 1, 2, or 3");
    Thread.Sleep(5000);
    Console.Clear();
  }

  // System.Console.WriteLine("Would you like to continue playing?");
  // if (play == "no")
  // {
  //   playing = false;
  //   Console.Clear();
  // }
  // if (play == "yes")
  // {
  //   playing = true;
  // }
  // else
  // {
  //   Console.WriteLine("please enter yes or no");
  // };
}