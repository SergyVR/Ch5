// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] arr = new int[8];     
    Random rnd = new Random();  
    int count = 0;
    for (int i = 0; i < 8; i++) 
    {         
        arr[i] = rnd.Next(100,1000);    
        Console.Write($"{arr[i]} ");

        if (arr[i]%2==0)
        {
           count=count+1; 
        }
         } 
         Console.WriteLine();
Console.WriteLine($"чётных чисел {count}");
