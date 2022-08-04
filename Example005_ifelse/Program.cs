// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter username");
string username = Console.ReadLine();
if(username.ToLower() == "masha")
{
  Console.WriteLine("Hooray, it's Masha");
}
else
{
  Console.Write ("Hello, ");
  Console.WriteLine (username);
}
