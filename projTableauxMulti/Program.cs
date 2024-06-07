using System;
class MainProgram
{
    public static void Main(string[] args)
    {
        
        int[,] ArrayUniforme = new int[3, 3];
        ArrayUniforme = new int[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
        int[][] jaggedArray = new int[3][];

       
        jaggedArray[0] = new int[3] {1,2,3};
        jaggedArray[1] = new int[2] {3,4};
        jaggedArray[2] = new int[1] {5};

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
            
        }
    }
}