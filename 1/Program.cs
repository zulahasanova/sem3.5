семинар 3.5 


//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.

int[] RandomArray(int size, int minValue, int maxValue)
{
int[] result = new int[size];
for (int i = 0; i < size; i++)
{
result[i] = new Random().Next(minValue, maxValue + 1);
}

return result;
}

int[] SumPosNeg(int[] array)
{
int[] result = new int[2]; 
foreach (int el in array)//[1, 2, 3, 4, -5, 1, -3] el = -5
{
//int a = el > 0 ? el : 0;
//result[0] += a;
result[0] += el > 0 ? el : 0;//ps += -5 > 0? 2 : 0; //находим положительные, плюсуем
/*
if(el > 0)
result[0] += el
else
resuit[0] += 0
*/
result[1] += el < 0 ? el : 0; //находим отр-ные, плюсуем
}
return result;
}
/* for (int i = 0; i < array.Length; i++)
{
 int el = array[i];
 el += 5
 if (el > 0)
 positiveSum += el;
 else
 positiveSum += 0;
 if (el < 0)
 negativeSum += 0;
} */

int[] array = RandomArray(12, -9, 9); //рандом числа(12 элементов(int size)
                                      //(int minValue, int maxValue[промежуток -9,9])
Console.WriteLine(String.Join(", ", array));
int[] r = SumPosNeg(array);
Console.WriteLine($"Positive sum = {r[0]}, negative sum = {r[1]} ");
Console.WriteLine($"[{String.Join(", ", array)} ]");

/* задача 32. напишите программу замена элементов массива:
положительные элементы замените на отрицательные, и наоборот.
//мое решение

[-4, -8, 8, 2] -> [4, 8, -8, -2] */

int[] RandomArray(int size)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(-10, 10);
}
return array;
}

int[] ContraryArray(int[] array1)
{
for (int i = 0; i < array1.Length; i++)
{
    array1[i] *= -1;
} 
return array1;
}


int[] startarray = RandomArray(4); //создаем элементы массива
Console.WriteLine($"[{String.Join(", ", startarray)}]");//выписываем
ContraryArray(startarray); //заменяем
Console.WriteLine($"[{String.Join(", ", startarray)}]");//выписываем

/* Задайте массив. Напишите программу, которая определяет,
 присутствует ли заданное число в массиве. 
 4 -> [1, 2, 3, 4, 5] -> да
 8 -> [1, 2, 3, 4, 5] -> нет */

int[] GetArrayFromString(string stringArray)//"1 2 3"
{
string[] nums = stringArray.Split(" ");//"1 2 3" -> ["1","2","3"]
int[] array = new int[nums.Length];//[0,0,0]

for (int i = 0; i < nums.Length; i++)//[0, 0, 0] ["1","2","3"] -> [1, 2, 3]
{
array[i] = int.Parse(nums[i]);
}
return array;
}

bool FindElement(int[] array, int el)//[1, 2, 3] 3
{
foreach (int item in array)
{
if (el == item)// 3 == 3
return true;//
}
return false;//
}


Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine()!;
int[] baseArray = GetArrayFromString(elements);

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

if (FindElement(baseArray, n))
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}

