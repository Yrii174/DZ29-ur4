//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int[] CreateArray(int size)  
{ 
int[] array = new int[size];  
for (int i = 0; i < 8; i++)   
    { 
    array[i] = new Random().Next(0, size);
    i = i++;   
    }
    return array; 
} 
string GetArray(int[] array)  
{      
string sum = string.Empty;      
for (int i = 0; i < array.Length; i++)      
    {
      sum = sum + $"{array[i]}, ";      
    }                   
    return sum;  
} 
int[] array = CreateArray(8);
System.Console.WriteLine(GetArray(array));
