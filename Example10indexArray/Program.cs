int[] array = {1,2,3,7,4,12,6,7,8};
int n = array.Length; //длина массива
int find = 7; //нужно найти элемент массива совпаающий по значению с этим
int index = 0; //индекс массива
while(index<n)
{
  if(array[index] == find)
  {
    Console.WriteLine($"Found {index}");
    break; //прерывает как только выполняется условие, чтобы не искал вторую семерку
  }
  index++;
}
