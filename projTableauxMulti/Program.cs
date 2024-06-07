using System;
using System.Data;
class MainProgram
{
    public static void Main(string[] args)
    {
        
        int[,] arrayUniforme = new int[3, 3];
        arrayUniforme = new int[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
        int[][] jaggedArray = new int[3][];
        int a = arrayUniforme[0,0];
        int b = arrayUniforme[0,1];
        int c = arrayUniforme[0,2];
        int d = arrayUniforme[1,2];
        int e = arrayUniforme[2,2];



        jaggedArray[0] = new int[3] {a,b,c};
        jaggedArray[1] = new int[2] {c,d};
        jaggedArray[2] = new int[1] {e};

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