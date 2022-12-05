/*int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    
    return result;
}

int a = 3;
int b = 6;
int c = 3;
int d = 5;
int e = 10;
int f = 6;
int g = 12;
int h = 111;
int i = 12;

int max1 = Max(
            Max(a, b, c),
            Max(d, e, f),
            Max(g, h, i));

System.Console.WriteLine(max1);*/


int Mx(int x1, int x2, int x3)
{int result = x1;

if (x2  > result) result = x2;
if (x3 > result) result = x3;
return result;
}
int a = 40;
int b = 23;
int c = 32;

int larger = Mx(a, b, c);
System.Console.WriteLine(larger);