using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrStart = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); // We create and initialize the array;
            int numRotation = int.Parse(Console.ReadLine());

            int startIndexNum = arrStart[0];  // value of start index            

            for (int i = 0; i < numRotation; i++)
            {
                for (int j = 0; j < arrStart.Length-1; j++)
                {
                    arrStart[j] = arrStart[j+1];
                    
                }
                arrStart[arrStart.Length - 1] = startIndexNum;
                startIndexNum = arrStart[0];

            }
            Console.WriteLine(string.Join(' ', arrStart));
            // Damn it very tricky task , Damn it! 2 hours of thinking and debugging ! 
        }
    }
}
