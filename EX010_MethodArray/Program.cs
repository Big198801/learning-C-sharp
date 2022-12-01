int[] array = {1,3,4,799,6,7,799,5};

int n = array.Length;
int find = 799;
int inde = 0;

while (inde < n)
{
if (array[inde] == find)
  {
    Console.WriteLine(inde);
    inde = inde + 1;
    break;
  }
else
   inde++ ;
}