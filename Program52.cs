// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
internal class Program
{
    static void Main(string[] args)
    {
        void PrintArray(double[,] table)
        {
            for(int i=0; i<table.GetLength(0); i++)
            {
                for (int j=0; j<table.GetLength(1); j++)
                {
                  Console.Write(table[i,j] +"\t"); 
                }
                Console.WriteLine();
            }
        }
        double[,] FillArray(int m, int n)
        {
            double[,] array = new double [m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++) array[i, j] = new Random().Next(0, 10);
            }
            return array;
        }
        Console.WriteLine("Введите количество строк двумерного массива ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов двумерного массива ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[,] mas = FillArray(m,n);             
        double sum =0;
        PrintArray(mas); 
       for(int j =0; j<n; j++)
       {
         sum=0;
         for (int i=0;i<m;i++) 
        {
              sum = sum +  mas[i,j];           
        }        
          Console.WriteLine(sum/m  );                    
           
        }
    }
}
         
       
                                 
    
