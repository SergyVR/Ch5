// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] arr = new int[8];     
    Random rnd = new Random();  
    int count = 0;
    for (int i = 0; i < 8; i++) 
    {         
        arr[i] = rnd.Next(-20,20);    
        Console.Write($"{arr[i]} ");        
         } 
    for (int i = 1; i < 8; i=i+2)
    {
        count=count+arr[i]; 
    }
         Console.WriteLine();
Console.WriteLine($"сумма элементов на нечётных позициях {count}");
