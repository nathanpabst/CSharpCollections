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

            //---------------JAGGED ARRAY----------------
            //creating a spreadsheet with 100 rows and 10 columns (outer array with an array inside)...
            //Cell[][] sheet = new Cell[3][];
            //create the rows of the spreadsheet by instantiating an array for each index of the sheet array
            //first row of the spreadsheet [0] will have 10 items..
            //sheet[0] = new Cell[2];
            ////using a for loop to create the other 99 rows. r represents the row index
            //for (int r = 0; r < sheet.Length; r++)
            //{
            //    //add 10 items to each row
            //    sheet[r] = new Cell[2];
            //    //initialize the values in the inner arrays i.e. sheet[r] with a nested loop. c represents column index
            //    for (int c = 0; c < sheet[r].Length; c++)
            //    {
            //        sheet[r][c] = new Cell();
            //    }
            ////Console.Write(sheet);
            //}
            //foreach (Cell[] row in sheet)
            //{
            //    foreach (Cell cell in row)
            //    {
            //        Console.Write(cell);
            //    }
            //    Console.WriteLine();
            //}

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

            //------------2D/MULTI-DIMENSIONAL ARRAY--------------
            //foreach loop will not work for 2d arrays..no inner arrays to loop through
            //Cell[,] sheet = new Cell[100, 10];
            //for (int r = 0; r < sheet.GetLength(0); r++)
            //{
            //    for (int c = 0; c < sheet.GetLength(1); c++)
            //    {
            //        sheet[r, c] = new Cell();
            //    }
            //    Console.WriteLine(sheet);
            //}

            ////initializing both values at once
            //int[,] matrix = new int[5, 5];
            //Console.WriteLine(matrix);
            ////example of an array with 3 dimensions
            //int[,,] threeDimMatrix = new int[5, 5, 5];
            ////example of combining jagged and multi-dimensional arrays..
            ////integer array of a three-dimensional multi-dimensional array of a single dimension array called yikes
            //int[][,,][] yikes = new int[5][,,][];

            //---------ADDING TO ARRAYS--------------

            //starting array containing three values
            int[] ages = { 24, 31, 56 };
            //adding a new array that holds four values
            int[] agesCopy = new int[4];
            //using CopyTo method to ages into the larger array
            ages.CopyTo(agesCopy, 1);
            //inserting the value 16 to the first position in the agesCopy array
            agesCopy[0] = 16;
            //overriding the copied value back into the ages variable
            ages = agesCopy;
            //use debugger to see results
            //note..other classes uses a reference to the ages array will not reflect these changes. 
            //every class using the ages variable would need to be changed
            //this is an inefficient practice and could slow the program down. 
            //same applies to removing an item from an array. use List instead.

            Console.Read();
        }
    }
}
