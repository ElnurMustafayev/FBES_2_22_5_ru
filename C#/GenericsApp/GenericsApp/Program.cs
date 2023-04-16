namespace GenericsApp {
    class Program {
        static void Method<T>(T num1, T num2) {
            Console.WriteLine($"{num1},{num2}");
            Console.WriteLine(typeof(T));
        }

        static void Method<T1, T2>() {
            Console.WriteLine($"{typeof(T1)}-{typeof(T2)}");
        }

        static void Method<T>() => Console.WriteLine(typeof(T));
        static void Method(in Type type) => Console.WriteLine(type);

        static (int, long) GetNumbers() => (Func(123), 45L);

        static T Func<T>(T obj) {
            T temp = default;
            Method<T>();
            Method(typeof(T));

            return temp;
        }


        static void Main() {
            //Method(10, 20);
            //Method<char>();
            //Method<int[]>();

            //Method<Program, string[]>();

            //Method(typeof(int));
            //Method<decimal>();

            //Console.WriteLine(Func<int>(123));

            //Func<long>(15);
            //Func<long>(15L);
            //Func<int>(15);
            //Method<int>();

            //_ = Func(15);

            //(int num, _) = GetNumbers();


            //PrintArray(new int[] { 'a', 'b', 'c' });
            //PrintParams(1, 2, 3);
            //PrintParams(1, 2, 3, '$');


            //PrintParams<char>(1, 2, 3);
            //PrintParams<int>('a', 'b', 'c');





            // [1,2,3,4,5,6,7,8,9]

            // input: 2
            // output: 1 3 5 7 9

            // input: 3
            // output: 1 2 4 5 7 8 

            //PrintArray(
            //    index: 3,
            //    arr: new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });



            // array = Push(array, newEl);
            // array = Pop(array);


            //string[] names = new string[] {
            //    "Eldaniz",
            //    "Raul",
            //    "Jafar",
            //};

            //names = Pop(names);
            //names = Pop(new string[0]);
            //names = Push(names, "Sadiq");

            //PrintArray(names);
        }


        static T[] Pop<T>(T[] arr) {
            if (arr == null)
                return new T[0];

            if (arr.Length == 0)
                return arr;

            T[] newArr = new T[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++) {
                newArr[i] = arr[i];
            }

            return newArr;
        }


        static T[] Push<T>(T[] arr, T newEl) {
            if(arr == null)
                return new T[] { newEl };

            T[] newArr = new T[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++) {
                newArr[i] = arr[i];
            }

            newArr[arr.Length] = newEl;

            return newArr;
        }

        static void PrintArray<T>(T[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
        }




        static T[] CreateArr<T>(int length) {
            T[] arr = new T[length];
            return arr;
        }


        static void PrintArray<T>(int index, params T[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                if(i != 0 && i % index == 0)
                    continue;

                Console.WriteLine(arr[i]);
            }
        }

        static void PrintParams<T>(params T[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine(nums[i]);
            }
        }

        static void PrintParams<T>(params int[] nums) {
            Console.WriteLine("INT");
            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine(nums[i]);
            }
        }

        static void PrintParams(char prefixSymbol, params int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine($"{prefixSymbol}. {nums[i]}");
            }
        }
    }
}