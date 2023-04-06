namespace ConsoleApp {
    class Program {
        static void Main() {
            //string str = "qwerty";
            //Console.WriteLine(str);

            //string result = Console.ReadLine();
            //Console.WriteLine((int)result + 27);

            //double num2 = 100.45;
            //int num1 = (int)num2;

            //bool symbol = true;
            //byte num = (byte)symbol;

            //string str = "1";
            //long l = (long)str;

            //// implicit
            //double d = 123;
            //// explicit
            //int i = (int)123.56;
            //// by method
            //bool b = Convert.ToBoolean(i);

            //string input = Console.ReadLine();

            //int result = Convert.ToInt32(input);

            //Console.WriteLine(result + 10);



            // Input the "first" num: 5
            // Input the "second" num: 8
            // Sum: 13

            //Console.Write("Input the \"first\" num: ");
            //int first = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input the \"second\" num: ");
            //int second = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Sum: ", (first + second));

            //            string str = @"1234
            //567
            //89";
            //            Console.WriteLine(str);


            //int num = 30;

            //string result = string.Format("q{0}w{1}e{2}r{3}t{4}y", 'z', 10 + 15, "qwe", num, 15.5);
            //string result = $"q{'z'}w{10 + 15}e{num}r{15.5}t{"qwe"}y";

            //Console.WriteLine(result);


            //Console.Write(@"Input the ""first"" num: ");
            //int first = Convert.ToInt32(Console.ReadLine());

            //Console.Write(@"Input the ""second"" num: ");
            //int second = Convert.ToInt32(Console.ReadLine());

            //string print = $"{first} + {second} = {first + second}";
            //Console.WriteLine(print);




            //bool result = false;

            //Console.WriteLine(!(result == true));



            // if visa / money >= 40k => success!
            // else => fail!

            // VISA
            //            Console.Write(@"Has Visa ('y' for ""yes""): ");
            //            char hasVisaSymbol = Convert.ToChar(Console.ReadLine());
            //            bool hasVisa = hasVisaSymbol == 'y' || hasVisaSymbol == 'Y';

            //            // MONEY
            //            Console.Write("Input your money: ");
            //            double money = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine($@"Info: 

            //Visa: {hasVisa}
            //Money: {money}");

            //if (hasVisa || money >= 40_000) {
            //    Console.WriteLine("Success!");
            //}
            //else {
            //    Console.WriteLine("Fail!");
            //}

            //Console.WriteLine(@$"Go to USA: ""{((hasVisa || money >= 40_000) ? "Success" : "Fail")}!""");


            // to 1000 - poor
            // from 1000 to 10000 - normal
            // from 10000 - rich

            //Console.Write("Input your money: ");
            //double money = Convert.ToDouble(Console.ReadLine());

            //string status;

            //if (money < 1_000) {
            //    status = "poor";
            //}
            //else if (1_000 <= money && money < 10_000) {
            //    status = "normal";
            //}
            //else {
            //    status = "rich";
            //}

            //Console.WriteLine(status);


            //int num = 3;

            //switch (num) {
            //    case 1:
            //        Console.WriteLine("ONE");
            //        break;
            //    case 3:
            //        Console.WriteLine("THREE");
            //        break;
            //    case 5:
            //        Console.WriteLine("FIVE");
            //        break;

            //    default:
            //        Console.WriteLine("DEFAULT");
            //        break;
            //}



            //while(true) {
            //    Console.WriteLine("ONE   ");

            //    Console.BackgroundColor = ConsoleColor.Magenta;
            //    Console.ForegroundColor = ConsoleColor.DarkBlue;
            //    Console.WriteLine("TWO   ");
            //    Console.ResetColor();

            //    Console.WriteLine("THREE ");

            //    ConsoleKeyInfo key = Console.ReadKey();
            //    switch (key.Key) {
            //        case ConsoleKey.W:
            //            // ...
            //            break;
            //    }

            //    Console.Clear();
            //}


        }
    }
}