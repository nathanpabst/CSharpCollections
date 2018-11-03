using System;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAYS
            //instantiating the array...
            //int[] lockCombination = new int[3];
            //initializing the array...
            //int[] lockCombination = { 10, 5, 32 };
            //retrieving an item from an array
            //int last = lockCombination[2];
            //setting or updating an index position in the array
            //lockCombination[2] = 20;

            //creating a spreadsheet with 100 rows and 10 columns (outer array with an array inside)...
            Cell[][] sheet = new Cell[3][];
            //create the rows of the spreadsheet by instantiating an array for each index of the sheet array
            //first row of the spreadsheet [0] will have 10 items..
            sheet[0] = new Cell[2];
            //using a for loop to create the other 99 rows. r represents the row index
            for (int r = 0; r < sheet.Length; r++)
            {
                //add 10 items to each row
                sheet[r] = new Cell[2];
                //initialize the values in the inner arrays i.e. sheet[r] with a nested loop. c represents column index
                for (int c = 0; c < sheet[r].Length; c++)
                {
                    sheet[r][c] = new Cell();
                }
            //Console.Write(sheet);
            }
            foreach (Cell[] row in sheet)
            {
                foreach (Cell cell in row)
                {
                    Console.Write(cell);
                }
                Console.WriteLine();
            }

            //challenge question..return a mult table consisting of of a 2D multidimensional array
            //the table should contain...

            //public int[][] BuildMultiplicationTable(int maxFactor)
            //{
            //    int[][] arr = new int[maxFactor + 1][];

            //    for (int i = 0; i <= maxFactor; i++)
            //    {
            //        arr[i] = new int[maxFactor + 1];

            //        for (int j = 0; j <= maxFactor; j++)
            //        {
            //            arr[i][j] = i * j;
            //        }
            //    }
            //    Console.WriteLine(arr);
            //}

            Console.Read();
        }
    }
}
