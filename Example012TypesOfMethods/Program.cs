// виды функций

// 1) Функция, которая ничего не принимает и ничего не возвращает
void None()
{
  Console.Write("Может выводить что-то на экран");
}
// Вызов:
None();

// 2) Ф-ция что-то принимает, ничего не возвращает
void GetArg(string msg)
{
  Console.WriteLine("msg");
}
//Вызов:
GetArg("Text");

// чтобы функция сработала несколько раз:
void GetArg(string msg, int count)
{ int i = 0;
  while (i<count)
  {
    Console.WriteLine(msg);
    i++;
  }
}
//Вызов:
GetArg("Text", 4); // сообщение "Текст" выведется 4 раза
// or
GetArg(msg:"Text", count:4);

// 3) Ничего не принимают, что-то возвращают

int Method3()
{
  return DateTime.Now.Year;
}
// вызов:
int year = Method3();
Console.WriteLine(year);

// 4) Что-то принимают и что-то возвращают
string Method4(int count, string c)
{
  int i = 0;
  string result = String.Empty;
  while (i<count)
  {
    result = result + c;
    i++;
  }
  return result;
}
// вызов:
string res = Method4(10, "TEXT");
Console.WriteLine("res");
