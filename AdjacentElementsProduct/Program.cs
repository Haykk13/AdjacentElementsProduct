using System;

namespace AdjacentElementsProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter an element: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Adjacent Elements Product is {adjacentElementsProduct(array)}!");
            Console.ReadLine();
        }
        static int adjacentElementsProduct(int[] inputArray)
        {
            int result = inputArray[0] * inputArray[1];
            int temp;
            for (int i = 1; i < inputArray.Length - 1; i++)
            {
                temp = inputArray[i] * inputArray[i + 1];
                if(temp > result)
                {
                    result = temp;
                }
            }
            return result;
        }
    }
}
