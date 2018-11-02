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
            int[] lockCombination = { 10, 5, 32 };
            //retrieving an item from an array
            int last = lockCombination[2];
            //setting or updating an index position in the array
            lockCombination[2] = 20;

            //creating a spreadsheet (array within an array)...
            Cell[][] sheet = new Cell[100][];
            sheet[0] = new Cell[10];
            for (int rowIndex = 0; rowIndex < sheet.Length; rowIndex++)
            {
                //create a row of 10 cells
                sheet[rowIndex] = new Cell[10];
                //nested loop
                for (int colIndex = 0; colIndex < sheet[rowIndex].Length; colIndex++)
                {
                    sheet[rowIndex][colIndex] = new Cell();
                }
            }
            foreach (Cell[] row in sheet)
            {
                foreach (Cell cell in row)
                {
                    Console.Write(cell);

                }
                Console.WriteLine();
            }

            Console.WriteLine(sheet[4][7]);

            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
