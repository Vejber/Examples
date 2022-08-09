void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while(index<length)
  {
    collection[index] = new Random().Next(1,10);
    index++;
  }
}
void PrintArray(int[] col) //void значит не возвращает значения
{
  int length = col.Length;
  int index = 0;
  while(index<length)
  {
    Console.WriteLine(col[index]);
    index++;
  }
}

int IndexOf(int[] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int position = -1;

  while(index<count)
  {
    if(collection[index] == find)
    {
      position = index;
      break;
    }
    index++;
  }
  return position;
}

int[]array = new int[10]; //создай новый массив с 10 элементами, по умолчанию все нули
FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
