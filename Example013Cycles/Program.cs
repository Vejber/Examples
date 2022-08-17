// Цикл for:
string Method4(int count, string c)
{
  string result = String.Empty;
  for (int i = 0; i< count; i++)
  {
    result = result + c;
  }
  return result;
}
// вызов:
string res = Method4(10, "TEXT");
Console.WriteLine(res);

//Цикл в цикле, здесь таблица умножения. Так можно менять несколько переменных:
for (int i = 2; i <= 10; i++)
{
  for (int j = 0; j <= 10; j++)
  {
    Console.WriteLine($"{i}*{j}={i*j}");
  }
  Console.WriteLine();
}
