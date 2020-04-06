using System;

namespace Basic_13 {

    class Program {
        public static void Print1to255 () {
            for (var i = 0; i < 256; i++) {
                Console.WriteLine (i);
            }
        }
        public static void PrintOdds () {
            // Print all of the odd integers from 1 to 255.
            for (int i = 0; i < 256; i++) {
                if (i % 2 == 1)
                    Console.WriteLine (i);
            }
        }
        public static void PrintSum () {
            int sum = 0;
            for (int i = 0; i < 256; i++) {
                sum += i;
                Console.WriteLine ("New Number : " + i + " Sum : " + sum);
            }
        }
        public static void LoopArray (int[] numbers) {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine (numbers[i]);
            }
        }
        public static int findMax (int[] numbers) {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = 0;
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] > max) {
                    max = numbers[i];
                }
            }
            Console.WriteLine (max);
            return max;
        }
        public static void GetAverage (int[] numbers) {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            Console.WriteLine ("Sum : " + sum);
            int avg = sum / numbers.Length;
            Console.WriteLine ("Average : " + avg);
        }
        public static int[] OddArray () {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            int[] Oddarray = new int[255];
            for (int i = 0; i < Oddarray.Length; i++) {
                if (i % 2 == 1) {
                    Oddarray[i] = i;
                }
            }
            for (int j = 0; j < Oddarray.Length; j++) {
                if (j % 2 == 1) {
                    Console.WriteLine ("Odd Values are : " + Oddarray[j]);
                }
            }
            return Oddarray;
        }
        public static void SquareArrayValues (int[] numbers) {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            int square = 0;
            for (int i = 0; i < numbers.Length; i++) {
                square = numbers[i] * numbers[i];
                Console.WriteLine ("Square of Value in Array : " + square);
            }
        }

        public static int GreaterThanY (int[] numbers, int y) {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;

            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] > y) {
                    count++;
                }
            }
            Console.WriteLine ("Count of Values Greater than Y : " + count);
            return count;
        }
        public static void EliminateNegatives (int[] numbers) {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            int i = 0;
            while (i < numbers.Length) {
                if (numbers[i] < 0) {
                    numbers[i] = 0;
                }
                i++;
            }
            for (int j = 0; j < numbers.Length; j++) {
                Console.WriteLine ("EliminateNegatives : " + numbers[j]);
            }
        }
        public static void MinMaxAverage (int[] numbers) {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int max = 0;
            int min = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] > max) {
                    max = numbers[i];
                } else if (numbers[i] < min) {
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            int avg = sum / numbers.Length;
            Console.WriteLine ("Max Number : " + max);
            Console.WriteLine ("Min Number : " + min);
            Console.WriteLine ("Avg Number : " + avg);
        }
        public static void ShiftValues (int[] numbers) {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for (int i = 0; i < numbers.Length - 1; i++) {
                numbers[i] = numbers[i + 1];
                Console.WriteLine (numbers[i]);
            }
            numbers[numbers.Length - 1] = 0;
            for (int j = 0; j < numbers.Length; j++) {
                Console.WriteLine ("Shifted Array is " + numbers[j]);
            }
        }
        public static object[] NumToString (int[] numbers) {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] newArrray = new object[numbers.Length];
            for(int i = 0; i<numbers.Length;i++){
                if(numbers[i]<0){
                    newArrray[i] = "Dojo";
                }else{
                    newArrray[i]=numbers[i];
                }
                
            }
             for (int j = 0; j < newArrray.Length; j++) {
                Console.WriteLine ("Int TO String " + newArrray[j]);
            }
            return newArrray;
        }

        static void Main (string[] args) {
            Print1to255 ();
            PrintOdds ();
            PrintSum ();
            int[] Numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 7 };

            LoopArray (Numbers);
            int[] NegArray = new int[3] {-3, -5, -7 };
            findMax (NegArray);
            findMax (Numbers);
            int[] avgArr = new int[3] { 2, 10, 3 };
            GetAverage (avgArr);
            // Console.WriteLine("Hello World!");
            OddArray ();
            int[] gthanY = new int[4] { 1, 3, 5, 7 };
            int y = 3;
            GreaterThanY (gthanY, y);
            int[] array = new int[] { 1, 5, 10, -10 };
            SquareArrayValues (array);
            int[] negToZero = new int[] { 1, 5, 10, -2 };
            EliminateNegatives (negToZero);
            int[] MaxMinAvg = new int[] { 1, 5, 10, -2 };
            MinMaxAverage (MaxMinAvg);
            int[] ShiftArray = new int[] { 1, 5, 10, 7, -2 };
            ShiftValues (ShiftArray);
            int[] NumToSting = new int[] { 1, 5, 10, 7, -2 };
            NumToString(NumToSting);


        }
    }
}