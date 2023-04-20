using System.Text;

class Program {

    static void SetEnAlphabet(StringBuilder sb) {
        for (char c = 'a'; c <= 'z'; c++) {
            sb.Append(c);
        }
    }

    static void SetRuAlphabet(StringBuilder sb) {
        for (char c = 'а'; c <= 'я'; c++) {
            sb.Append(c);
        }
    }

    static void Main() {
        //StringBuilder sb = new StringBuilder(('z' - 'a' + 1) + ('я' - 'а' + 1));
        //SetEnAlphabet(sb);
        //SetRuAlphabet(sb);

        //Console.WriteLine(sb.ToString());
        //Console.WriteLine(sb.Capacity);


        //string str = "one";
        //str = str + "two";
        //str += "three";

        //StringBuilder sb = new StringBuilder(capacity: 4);

        //sb.AppendLine("Hello");
        //sb.Append("World");
        //sb.AppendLine("!");

        //string resultStr = sb.ToString();

        //Console.WriteLine(resultStr);
        //Console.WriteLine($"Capacity: {sb.Capacity}");
        //Console.WriteLine($"Length: {sb.Length}");
        //return;



        //bool success = int.TryParse("123", out int resultNum);

        //if (success == false) {
        //    Console.WriteLine("Incorrect Number input!");
        //}
        //else {
        //    Console.WriteLine("Success: " + success);
        //    Console.WriteLine("Result: " + resultNum);
        //}

        string[] names = {
            "Eldaniz",
            "Ayxan",
            "Maxim",
            "Sadiq",
            "Emil",
        };

        StringBuilder sb = new StringBuilder(100);

        int select;
        do {
            Console.Clear();
            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine($"{i + 1}. {names[i]}");
            }

            do {
                Console.Write("Select index: ");
            } while (int.TryParse(Console.ReadLine(), out select) == false);

            //select = Convert.ToInt32(Console.ReadLine()) - 1;
            //select = int.Parse(Console.ReadLine()) - 1;


            if (select >= 0 && select < names.Length)
                sb.Append(names[select] + '\n');
        } while (select != -2);

        string[] resultNames = sb.ToString().Split('\n');
        //string[] resultNames = result.Split('\n', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
        
        Console.Clear();
        for (int i = 0; i < resultNames.Length; i++) {
            Console.WriteLine($"{i + 1}. *{resultNames[i]}*");
        }
    }
}