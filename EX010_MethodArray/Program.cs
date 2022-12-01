int[] array = {1,3,4,799,6,7,799,5};

int n = array.Length;
int find = 799;
int index = 0;

while (index < n)
{
if (array[index] == find)
  {
    Console.WriteLine(index);
    break;
    index++ ;
  }
else
   index++ ;
}