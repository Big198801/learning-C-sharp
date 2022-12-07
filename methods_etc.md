int a = new Random() .Next(min, max-1)    - генератор случайных чисел. создает целое число в диапазоне от мин до max-1





Метод нахождения максимального числа:

    int Max(int arg1, int arg2, int arg3)
    {int result = arg1;
    
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    
    return result;
    }


tryCatch
try
{все значения должны быть True}
catch(exception)
чтобы программа не крашилась, а выдавало сообщение об ошибке и могла продолжать работать дальше

