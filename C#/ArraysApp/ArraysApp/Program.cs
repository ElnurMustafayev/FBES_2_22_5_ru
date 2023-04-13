namespace ArraysApp {
    class Program {

        static int Method(int arg1, string arg2) {
            Console.WriteLine($"{arg1}-{arg2}");

            return arg1+1;
        }


        static int[] AddNumber(int[] numbers, int newNumber) {
            int[] newNumbers = new int[numbers.Length + 1];

            for (int i = 0; i < numbers.Length; i++) {
                newNumbers[i] = numbers[i];
            }

            newNumbers[numbers.Length] = newNumber;

            return newNumbers;
        }

        static void PrintArray(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]); 
            }
        }

        static void Main() {
            int[] numbers = { 1, 2, 3 };

            numbers = AddNumber(numbers, 4);
            numbers = AddNumber(numbers, 5);
            numbers = AddNumber(numbers, 6);

            PrintArray(numbers);



            //Console.WriteLine(Method(Method(100, "test"), "qwerty"));



            //int[,,,] nums = new int[3, 2, 5, 7];

            //Console.WriteLine(nums.GetLength(0));
            //Console.WriteLine(nums.GetLength(1));
            //Console.WriteLine(nums.GetLength(2));
            //Console.WriteLine(nums.GetLength(3));



            //int[,] nums = new int[3, 2] {
            //    { 00, 01 },
            //    { 10, 11 },
            //    { 20, 21 },
            //};

            //nums[0, 0] = 00;
            //nums[0, 1] = 01;
            //nums[0, 2] = 02;

            //nums[1, 0] = 10;
            //nums[1, 1] = 11;
            //nums[1, 2] = 12;

            //nums[2, 0] = 20;
            //nums[2, 1] = 21;
            //nums[2, 2] = 22;







            //string[] names = new string[] {
            //    "Timur",
            //    "Sadiq",
            //    "Ayxan",
            //};

            //for (int i = 0; i < names.Length; i++) {
            //    Console.WriteLine(names[i]);
            //}







            // 10,20,30

            // Input: 40
            // Output: 10,20,30,40

            if (false) {
                int[] arr = { };

                while(true) {
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input == -1)
                        break;

                    // create new array
                    int[] newArr = new int[arr.Length + 1];

                    // copy
                    for (int i = 0; i < arr.Length; i++) {
                        newArr[i] = arr[i];
                    }

                    // insert element
                    newArr[arr.Length] = input;

                    arr = newArr;
                }

                for (int i = 0; i < arr.Length; i++) {
                    if (i != 0)
                        Console.Write(',');

                    Console.Write(arr[i]);
                }
            }

            if(false) {
                int[] oldArr = { 10, 20, 30 };

                int newElement = Convert.ToInt32(Console.ReadLine());

                // create new arr
                int[] newArr = new int[oldArr.Length + 1];

                // copy
                for (int i = 0; i < oldArr.Length; i++) {
                    newArr[i] = oldArr[i];
                }

                // insert element
                newArr[oldArr.Length] = newElement;

                for (int i = 0; i < newArr.Length; i++) {
                    if (i != 0)
                        Console.Write(',');

                    Console.Write(newArr[i]);
                }
            }
            









            // while input != -1
            // 10,20,30

            // Input: 40
            // Output: 10,20,30,40







            //int num1 = 1;
            //short num2 = 2;
            //byte num3 = 3;
            //char num4 = 'a';

            //int[] nums = {num1, num2, num3, num4};


            //nums[1] = int.MaxValue;


            //decimal num = 12.6m;

            //decimal[] nums = {
            //    12.5m, (decimal)(27 / (double)2), num
            //};

            //Console.WriteLine(nums[1]);


            //char[] symbols = {
            //    'a', 'b', 'c'
            //};

            //Console.WriteLine(symbols);





            //int[] oldArr = {
            //    10, 20, 30,
            //};

            //int[] newArr = new int[oldArr.Length + 2];

            //for (int i = 0; i < oldArr.Length; i++) {
            //    newArr[i] = oldArr[i];
            //}

            //newArr[oldArr.Length] = 40;
            //newArr[oldArr.Length + 1] = 50;

            //for (int i = 0; i < newArr.Length; i++) {
            //    Console.WriteLine($"nums[{i}] = {newArr[i]}");
            //}


            //int[] nums1 = {
            //    10, 20, 30, 40, 50, 60, 70, 80
            //};

            //int[] nums2 = new int[] {
            //    10, 20, 30, 40, 50, 60, 70
            //};

            //int[] nums3 = new int[6] {
            //    10, 20, 30, 40, 50, 60
            //};

            //for (int i = 0; i < nums.Length; i++) {
            //    Console.WriteLine($"nums[{i}] = {nums[i]}");
            //}

            //nums[0] = 10;
            //nums[1] = 20;
            //nums[2] = 30;
            //nums[3] = 40;
            //nums[4] = 50;







            //nums[3] = 123;
            //nums[3] = 100;

            //Console.WriteLine(nums[3]);




            //nums[0] = 1;
            //nums[1] = 2;
            //nums[2] = 3;
            //nums[3] = 4;
            //nums[4] = 5;

            //for (int i = 0; i < nums.Length; i++) {
            //    Console.WriteLine($"nums[{i}] = {nums[i]}");
            //}
        }
    }
}