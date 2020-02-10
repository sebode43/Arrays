using System;

namespace Arrays {
    class Program {
        static void Main(string[] args) {

            var randomNumbers = new int[5];
            randomNumbers[0] = 123;
            randomNumbers[1] = 456;
            randomNumbers[2] = 789;
            randomNumbers[3] = 1;
            randomNumbers[4] = 0;

           var add = randomNumbers[0] + randomNumbers[1] + randomNumbers[2];


            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
            int total = 0;
            foreach (var number in numbers) {
                total += number * 3;
            }
               Console.WriteLine($"Total is {total}");

            int sum = 0;
            foreach (var number in numbers) {
                if ((number %3 == 0) || (number %5 == 0)) {
                    continue; //skip it 
                }
                sum += number * 3;
            }
            Console.WriteLine($"Total is {sum}");


        }
    }
}
