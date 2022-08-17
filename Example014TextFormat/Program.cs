// Дан текст. в нем нужно заменить все пробелы на черточки, маленькие буквы к на большие,
// большие С на маленькие
// работа с текстом как с массивом:
// string s = "qwerty"
// s[3] = r

string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
              + "ежели бы вас послали вместо нашего милого Винценгероде, "
              + "вы бы взяли приступом согласие прусского короля. "
              + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)              // string - номер строки, oldValue - старый символ, newValue - новый символ
{
string result = String.Empty;
int length = text.Length;
for(int i=0; i < length; i++)
{
if(text[i]==oldValue)
{
result= result + $"{newValue}";
}
else
{
result = result + $"{text[i]}";
}
}
return result;
}

string NewText = Replace (text, ' ', '|');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Replace (NewText, 'С', 'с');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Replace (NewText, 'к', 'К');
Console.WriteLine(NewText);
