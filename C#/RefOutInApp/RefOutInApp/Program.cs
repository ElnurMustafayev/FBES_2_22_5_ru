using System;

namespace RefOutInApp {
    class Program {
        static void Func(int x, int y, int length = 100, decimal money = 12.5m) { }

        //static void ChangeNumber(int num) => num += 10;
        static void ChangeNumbers(int[] nums) => nums[0] = 777;

        static void PrintArray(int[] arr) {
            Console.WriteLine("Numbers: \n");
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
            Console.WriteLine();
        }

        static void PrintArray(char[] arr) {
            Console.WriteLine("Symbols: \n");
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine($"arr[{i}] = '{arr[i]}'");
            }
            Console.WriteLine();
        }
        //static int GetNumber() => 123;
        static void ChangeNumber(ref int num, ref char symbol, decimal money = 12.5m) {
            num++;
            symbol = '%';
        }


        static int InitMaximum(int[] nums) {
            int max = nums[0];

            for (int i = 0; i < nums.Length; i++) {
                if(nums[i] > max) {
                    max = nums[i];
                }
            }

            return max;
        }

        //static void InitMaxAndMin(int[] nums, ref int min, ref int max) {
        //    for (int i = 0; i < nums.Length; i++) {
        //        if (nums[i] > max) {
        //            max = nums[i];
        //        }
        //        if(nums[i] < min) {
        //            min = nums[i];
        //        }
        //    }
        //}

        static void InitMaxAndMin(int[] nums, out int min, out int max) {
            min = nums[0];
            max = nums[0];

            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > max) {
                    max = nums[i];
                }
                if (nums[i] < min) {
                    min = nums[i];
                }
            }
        }

        static void ChangeNumber(int num) => num = 777;
        //static void ChangeNumber(ref int num) => num = 777;   // reference
        static void ChangeNumber(out int num) {
            num = 777;
        }



        static char GetLetter(char[] word, in uint index) {
            if (word == null || word.Length <= index)
                return default;

            return word[index];
        }

        static void Main() {
            // IN
            if(false) {
                char[] word = { 'a', 'b', 'c' };
                uint index = 1;
                char result = GetLetter(word, index);
                Console.WriteLine(GetLetter(word, 1));

                Console.WriteLine(result);
            }



            // OUT
            if(false) {
                //int num = 10;
                //ChangeNumber(out num);
                //Console.WriteLine(num);

                int[] nums = { 12, -64, 24, 789, 9, -36, 1, -45 };
                InitMaxAndMin(nums, out int min, out int max);

                Console.WriteLine($"Min: {min}");
                Console.WriteLine($"Min: {max}");
            }


            // REF
            if (false) {
                //int num = 100;
                //char character = 'a';

                //ChangeNumber(ref num, symbol: ref character);
                //Console.WriteLine(num);
                //Console.WriteLine(character);





                //int[] nums = { 12, -64, 24, 789, 9, -36, 1, -45 };

                //int max = InitMaximum(nums);
                //Console.WriteLine(max);

                //int min = nums[0], max = nums[0];
                //InitMaxAndMin(nums, ref min, ref max);

                //Console.WriteLine($"Min: {min}");
                //Console.WriteLine($"Min: {max}");
            }











            //Func(1, 2, 100, 150.55m);
            //Func(1, 2, length: 100, money: 150.55m);

            //ChangeNumber(num: 123);


            //int[] arr = new int[] { 55, 44, 33, 22, 11 };
            //PrintArray(arr);

            //PrintArray(new char[] { 'a', 'b', 'c' });


            //int num = 1;
            //ChangeNumber(num);
            //Console.WriteLine(num);

            //int[] numbers = {
            //    1,2,3,4,5
            //};
            //ChangeNumbers(numbers);
            //PrintArray(numbers);
        }
    }
}