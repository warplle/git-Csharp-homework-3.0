

//namespace hw
//{
//    public class Homework
//    {

//        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
//        {
//            //    /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
//            //     * |   input           | result             |
//            //     * |-------------------|--------------------|
//            //     * | {                 |                    |
//            //     * |  { 1,   3,  5},   |    The central     |
//            //     * |  {-1, 100, 11},   |  element is 100    |
//            //     * |  { 2,  15, 44}    |                    |
//            //     * |  }                |                    |
//            //     * |----------------------------------------|
//            //     * |{                  |                    |
//            //     * | { 1,  6, 21,  8 },| This matrix doesn't|
//            //     * | { 5, -4,  5,  7 },| have a central     |
//            //     * | {77,  5,  0, 74 } |  element           |
//            //     * | }                 |                    |
//            //     * ------------------------------------------
//            //     *    
//            //     */

//            int rowLength = matrixOfIntegers.GetLength(0);
//            int columnLength = matrixOfIntegers.GetLength(1);
//            int middle = matrixOfIntegers[rowLength/2, columnLength/2];
//            int x = rowLength + columnLength;

//            if (x % 2 == 0)
//            {
//                Console.WriteLine("The middle element is: " + middle);
//            }
//            else
//            {
//                Console.WriteLine("This matrix doesn't have a central element");
//            }

//            Console.WriteLine();
//        }

//        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
//        {
//            //    /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
//            //     * |   input           | result              |
//            //     * |-------------------|---------------------|
//            //     * | {                 |                     |
//            //     * |  { 1,   3,  5},   | First diagonal: 145 |
//            //     * |  {-1, 100, 11},   | Second diagonal: 107|
//            //     * |  { 2,  15, 44}    |                     |
//            //     * |  }                |                     |
//            //     * |-----------------------------------------|
//            //     * |{                  |                     |
//            //     * | { 1,  6, 21,  8 },| This matrix doesn't |
//            //     * | { 5, -4,  5,  7 },| have a diagonals    |
//            //     * | {77,  5,  0, 74 } |                     |
//            //     * | }                 |                     |
//            //     * ------------------------------------------
//            //     *    
//            //     */

//            int principal = 0;
//            int secondary = 0;
//            int rowLength = matrixOfIntegers.GetLength(0);
//            int columnLength = matrixOfIntegers.GetLength(1);
//            int x = rowLength + columnLength;

//            if (x % 2 == 0)
//            {
//                for (int i = 0; i<matrixOfIntegers.GetLength(0); i++)
//                {
//                    for (int j = 0; j<matrixOfIntegers.GetLength(1); j++)
//                    {
//                        //principal diagonal
//                        if (i==j)
//                        {
//                            principal+=matrixOfIntegers[i, j];
//                        }

//                        //secondary diagonal
//                        if ((i+j) == (matrixOfIntegers.GetLength(0)-1))
//                        {
//                            secondary+=matrixOfIntegers[i, j];
//                        }
//                    }
//                }
//                Console.WriteLine("Sum of Principal Diagonal: " + principal);
//                Console.WriteLine("Sum of Principal Secondary: " + secondary);
//            }
//            else
//            {
//                Console.WriteLine("This matrix doesn't have diagonals");
//            }

//            //for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
//            //{
//            //    for (var j = 0; j < matrixOfIntegers.GetLength(1); j++)
//            //    {
//            //        Console.Write(matrixOfIntegers[i, j] + " ");
//            //    }
//            //    Console.WriteLine();
//            //}
//            Console.WriteLine();
//        }
//        public void starprinter(int trianglehight)
//        {
//            //    /* write a programm that will print a triagle of stars  with hight = trianglehight
//            //     *  example: trianglehight = 3;
//            //     *  result:   *
//            //     *           * *
//            //     *          * * * 
//            //     */

//            Console.WriteLine("The triangle: ");

//            for (int i = 0; i<trianglehight; i++)
//            {
//                for (int j = 1; j <= trianglehight - i; j++)
//                {
//                    Console.Write(" ");
//                }
//                for (int k = 1; k <= 2* i-1; k++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }

//        public void sortlist(IList<int> listofnumbers)
//        {
//            //    print to console elements of listofnumbers in ascending order

//            for (int i = 0; i < listofnumbers.Count - 1; i++)
//            {
//                for (int j = 0; j < listofnumbers.Count - i - 1; j++)
//                {
//                    if (listofnumbers[j] > listofnumbers[j + 1])
//                    {
//                        int temp = listofnumbers[j];
//                        listofnumbers[j] = listofnumbers[j + 1];
//                        listofnumbers[j + 1] = temp;
//                    }
//                }
//            }
//            Console.Write("The sorted elementes of the list: ");
//            foreach (int i in listofnumbers)
//            {
//                Console.Write(i + " ");
//            }

//            Console.WriteLine();
//        }

//        public static void Main(String[] args)
//        {

//            Homework homework = new Homework();

//            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };

//            int[,] matrix = new int[3, 3]
//            {
//                     { 1,   3,  5},
//                     { 2, 3, 5},
//                     {100, 56 , -54}
//            };

//            int[,] matrix2 = new int[3, 4]
//            {
//                     { 1,   3,  5,   6},
//                     { 2,   3,  5,  78},
//                     {100, 56 , -54, 6}
//            };

//            homework.GetCentralElementFromMatrix(matrix);
//            homework.GetCentralElementFromMatrix(matrix2);
//            homework.GetSummOfDiagonalsElements(matrix);
//            homework.GetSummOfDiagonalsElements(matrix2);
//            homework.starprinter(5);
//            homework.sortlist(list);
//        }
//    }
//}

