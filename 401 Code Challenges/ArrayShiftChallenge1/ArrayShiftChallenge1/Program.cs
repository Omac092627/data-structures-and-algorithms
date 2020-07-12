using System;

namespace ArrayShiftChallenge1
{
    class Program
    {
    static void Main(string[] args)
        {
            InsertShiftArray(new int[] { 2, 4, 6, 8}, 5);
            InsertShiftArray(new int[] { 4, 8, 15, 23, 42 }, 16);
        }

        static int[] InsertShiftArray(int[] array, int value)
        {

            Console.WriteLine($"The value of passed-in array is {string.Join(",", array)}");
            Console.WriteLine($"The value of value is {value}");


            // find the length of given array
            int counter = 0;
            foreach (int number in array)
            {
                counter++;
            }
            
            // find half the length of counter
            int halfArrayLength = 0;

            // logic for if passed-in array is an odd number
            if (counter % 2 != 0)
            {
                halfArrayLength = counter / 2 + 1;
            }
            else
            {
                halfArrayLength = counter / 2;
            }

            Console.WriteLine($"The value of halfArray is {halfArrayLength}");

            // initialize new array with room for one more number
            int[] newArray = new int[counter+1];

            // for loop to pass first half of given array values into new array
            for (int i = 0; i < halfArrayLength; i++)
            {
                newArray[i] = array[i];
            }

            // insert the given value at the halfway point
            newArray[halfArrayLength] = value;

            Console.WriteLine($"The value of newArray is now {string.Join(",", newArray)}");

            // insert the rest of the values

            if (counter % 2 != 0)
            {
                for (int i = 0; i < halfArrayLength-1; i++)
                {
                    newArray[i + halfArrayLength + 1] = array[i + halfArrayLength];
                }
            }
            else
            {
                for (int i = 0; i < halfArrayLength; i++)
                {
                    newArray[i + halfArrayLength + 1] = array[i + halfArrayLength];
                }
            }

            Console.WriteLine($"The final value of newArray is {string.Join(",", newArray)}");
            return newArray;

        }
    }
}
