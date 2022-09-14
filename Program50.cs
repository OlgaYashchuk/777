// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
internal class Program
{
    private static void Main(string[] args)
    {
        void PrintArray(double[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        double[,] FillArray(int m, int n)
        {
            double[,] array = new double[m, n];
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
        double[,] mas = FillArray(m, n);
        PrintArray(mas);
        Console.Write("Введите строку нахождения элемента :");
        int x = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.Write("Введите столбец нахождения элемента:");
        int y = Convert.ToInt32(Console.ReadLine()) - 1;
       
       if ((x+1>m)|(y+1>n)) 
       {
        Console.WriteLine("Элемента нет");
       }
       else    
       {
        Console.WriteLine("Значение элемента массива = {0}", mas[x, y]);
       }
       }   
}


