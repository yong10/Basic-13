using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        // Print all of the integers from 1 to 255
        public static void PrintNumbers(){
            for (int i=1; i<=225; i++)
                Console.WriteLine(i);
        }
        // Print all of the odd integers from 1 to 255.
        public static void PrintOdds(){
            for (int i=1; i<=255; i+=2)
                Console.WriteLine(i);
        }
        // Print all of the numbers from 0 to 255, 
        // but this time, also print the sum as you go.
        public static void PrintSum(){
            int sum = 0; 
            for (int i=1; i<=255; i++){
                sum += i;
                Console.WriteLine($"New number: {i}, Sum: {sum}"); 
            }
        }
        // Write a function that would iterate through each item of the given integer array and 
        // print each value to the console. ***
        public static void LoopArray(params int[] numbers){
            foreach (int value in numbers){
                Console.WriteLine(value);
            }
        }
        // Write a function that takes an integer array and prints and returns the maximum value in the array. 
        // Your program should also work with a mix of positive numbers, negative numbers and zero.
        public static void FindMax(params int[] numbers)
        {
            int max = numbers[0];
            for(int i=0; i<numbers.Length; i++)
            {
                if(max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
        }
        // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
        // For example, with an array [2, 10, 3], your program should write 5 to the console.
        public static void GetAverage(params double[] numbers)
        {
            double sum = 0, avg = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine(avg);
        }
        // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
        // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
        public static void OddArray()
        {
            var arr = new List<int>();
            for (int i=1; i<=255; i+=2)
            {
                arr.Add(i);
            }
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
        // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
        // That are greater than the "y" value. 
        // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
        // (since there are two values in the array that are greater than 3).
        public static void GreaterThanY (int[] numbers, int y)
        {
            int count = 0;
            foreach (int num in numbers)
            {
                if(num>y)
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} number(s) that are bigger than {y} ");
        }
        

        // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
        // For example, [1,5,10,-10] should become [1,25,100,100]
        public static void SquareArrayValues(params int[] numbers)
        {
            for (int i=0; i<numbers.Length; i++)
            {
                numbers[i] *= numbers[i];
                Console.WriteLine(numbers[i]);
            }
        }

        // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
        // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
        public static void EliminateNegatives(params int[] numbers)
        {
            for (int i=0; i<numbers.Length; i++)
            {
                if(numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            }
        }

        // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
        // the minimum value in the array, and the average of the values in the array.
        public static void MinMaxAverage(params double[] numbers)
        {
            
            double max = numbers[0], min = numbers[0], sum = 0, avg = 0;
            for (int i=0; i<numbers.Length; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Average: {avg}");
        }

        // Given an integer array, say [1, 5, 10, 7, -2], 
        // Write a function that shifts each number by one to the front and adds '0' to the end. 
        // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
        // it should become [5, 10, 7, -2, 0].
        public static void ShiftValues(params int[] numbers)
       {
            
            string Num = "";
            for(int i=0; i<numbers.Length-1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length-1] = 0;
            foreach(int num in numbers)
            {
                Num += num + " ";
            }
            Console.WriteLine(Num);
        }

        // Write a function that takes an integer array and returns an object array 
        // that replaces any negative number with the string 'Dojo'.
        // For example, if array "numbers" is initially [-1, -3, 2] 
        // your function should return an array with values ['Dojo', 'Dojo', 2].
        public static object[] NumToString(params object[] numbers)
        {
            
            for(var i=0; i<numbers.Length; i++)
            {
                if ((int)numbers[i]<0)
                {
                    numbers[i] = "Dojo";
                }
                Console.WriteLine(numbers[i]);
            }
            return numbers;
        }

        static void Main(string[] args){
            //PrintNumbers();
            //PrintOdds();
            // PrintSum();
            // LoopArray(-2,-3,7,3);
            // FindMax(-2,6,9,3);
            // GetAverage(7,-1,2,5);
            // OddArray();
            // GreaterThanY(new int[] {2,5,3}, 1);
            // SquareArrayValues(3,6,2,8);
            // EliminateNegatives(3,-10,5,-1);
            // MinMaxAverage(-1,5,3,6);
            // ShiftValues(2,5,8,);
            // NumToString(1,1,-1,0);

        }

    }
}
