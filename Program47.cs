// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
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
                for (int j = 0; j < n; j++) array[i, j] = new Random().Next(-10, 10);
            }
            return array;
        }
        Console.WriteLine("Введите количество строк двумерного массива ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов двумерного массива ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[,] mas = FillArray(m,n);
        PrintArray(mas);
    }
}