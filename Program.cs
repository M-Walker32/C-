// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
bool playing = true;
System.Console.WriteLine(playing);

while (playing)
{
  string keepPlaying = System.Console.ReadKey();
  if (keepPlaying == n)
  {
    playing = false;
  };
  if (keepPlaying == y)
  {
    playing = true;
  };
}