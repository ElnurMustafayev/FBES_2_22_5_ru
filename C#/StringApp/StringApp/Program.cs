namespace StringApp {
    class Program {
        static void Main() {
            //short num = 32760;
            //short inputNum = Convert.ToInt16(Console.ReadLine());

            //if(num + inputNum <= short.MaxValue) {
            //    num += inputNum;
            //}

            //Console.WriteLine(num);


            //bool isDigit = char.IsDigit('0');
            //bool isLetter = char.IsLetter('a');
            //char lowLetter = char.ToLower('A');
            //char upLetter = char.ToUpper('a');
            //char result = char.ToLower(char.ToUpper('a'));
            //char unicodeSymbol = '\u2558';
            //Console.WriteLine(unicodeSymbol);



            //string empty = string.Empty;
            //string result = string.Concat("test", "one", "hello");

            //int compare = string.Compare("twoz", "twoaa");
            //Console.WriteLine(compare);



            //string str = "    ";

            //Console.WriteLine($"IsNullOrWhiteSpace: {string.IsNullOrWhiteSpace(str)}");
            //Console.WriteLine($"IsNullOrEmpty: {string.IsNullOrEmpty(str)}");
            //Console.WriteLine($"Condition: {str == null || str == string.Empty}");




            // loop:

            // Input you name: 
            // "" => name can not be empty
            // "   " => incorrect name



            //while(true) {
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    if (string.IsNullOrEmpty(name)) {
            //        Console.WriteLine("Error: Name can not be empty");
            //    }
            //    else if (string.IsNullOrWhiteSpace(name)) {
            //        Console.WriteLine("Error: Incorrect name");
            //    }
            //    else {
            //        break;
            //    }
            //}



            //string name = string.Empty;

            //do {
            //    Console.Write("Name: ");
            //    name = Console.ReadLine();

            //    if (string.IsNullOrEmpty(name)) {
            //        Console.WriteLine("Error: Name can not be empty");
            //    }
            //    else if (string.IsNullOrWhiteSpace(name)) {
            //        Console.WriteLine("Error: Incorrect name");
            //    }
            //} while (string.IsNullOrWhiteSpace(name));





            //string str = "qwerty";

            //char symbolToSearch = 'x';
            //bool containsSymbol = str.Contains(symbolToSearch);

            //string stringToSearch = "rtY";
            //bool containsString = str.Contains(stringToSearch);

            //Console.WriteLine($"'{str}' contains '{symbolToSearch}': {(containsSymbol ? "YES" : "NO")}");
            //Console.WriteLine($"'{str}' contains '{stringToSearch}': {(containsString ? "YES" : "NO")}");



            //string fullname = "Elnur Mustafayev";
            //string toSearch = "ELNUR";

            // bool contains = fullname.ToUpper().Contains(toSearch.ToUpper());
            // Console.WriteLine(contains);

            //string fullnameUp = fullname.ToUpper().ToUpper().ToUpper().ToUpper();

            //Console.WriteLine("Orignal: " + fullname);
            //Console.WriteLine("Result of ToUpper(): " + fullnameUp);


            //string str = "Hello World!";
            //Console.WriteLine(str.StartsWith("qw2"));
            //Console.WriteLine(str.EndsWith('y'));
            //Console.WriteLine("qwerty".ToUpper());

            //int index = str.LastIndexOf('l');
            //int index = str.IndexOf('l', 4);
            //string result = str.Insert(5, "    ");
            //Console.WriteLine(str);
            //Console.WriteLine(result);

            //Console.WriteLine($"*{str.PadRight(20)}*");
            //Console.WriteLine($"*{str.PadLeft(20)}*");

            //string result = str.Remove(4, 5);
            //Console.WriteLine(result);

            //string str = "Hello World!";
            //string result = str.Replace('l', '%');
            //result = result.Replace("l", " ");
            //Console.WriteLine(result);




            //string str = "Hello World!";
            //string result = str.Substring(str.IndexOf(' ') + 1);
            //result = str.Substring(0, str.IndexOf(' '));

            //str = str.Replace("H", "Hwllo");
            //str[1] = 'w';

            //Console.WriteLine(str[6]);
            //Console.WriteLine(str[6..]);
            //Console.WriteLine(str[..6]);
            //Console.WriteLine(str[3..8]);
            //Console.WriteLine(str[^3]);

            //string firstWord = str[..str.IndexOf(' ')];
            //Console.WriteLine(firstWord);


            //string str = "    Hello World!  ";
            //
            //Console.WriteLine($"Original:\t *{str}*");
            //Console.WriteLine($"TrimEnd:\t *{str.TrimEnd()}*");
            //Console.WriteLine($"TrimStart:\t *{str.TrimStart()}*");
            //Console.WriteLine($"Trim:\t\t *{str.Trim()}*");


            //string str = "==+==12=3+=";
            //Console.WriteLine(str.Trim('=').IndexOf('2'));


            //string str = "qwerty";
            //var result = str.TrimEnd('q')
            //    .Replace("e", "test")
            //    .ToUpper()
            //    [..1]
            //    .Length;

            //Console.WriteLine(result);



            //string str = "qwerty";

            //for (int i = str.Length - 1; i >= 0 ; i--) {
            //    Console.Write(str[i] + " ");
            //}
        }
    }
}