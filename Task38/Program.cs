// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] arr = new int[8];     
    Random rnd = new Random();  
    int Noun = 0;
    for (int i = 0; i < 8; i++) 
    {         
        arr[i] = rnd.Next(-20,20);    
        Console.Write($"{arr[i]} ");        
         } 
    Console.WriteLine();
int Max = arr[0];
int Min = arr[0];
for (int i = 1; i < 8; i++) 
    {  if (arr[i]>Max)
    {
        Max = arr[i];
    }       
    if (arr[i]<Min)
    {
        Min= arr[i];
    }        
         } 
Noun = Max - Min;
Console.WriteLine($"максимальное число ={Max}, минимальное число{Min}, их разница {Noun}");