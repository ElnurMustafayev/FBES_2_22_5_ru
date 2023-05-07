namespace RandomApp {
    class Dice {
        private static Random random;

        static Dice() {
            Dice.random = new Random();
        }

        public int Score => Dice.random.Next(1, 7);
    }

    class Program {
        static void Main() {
            //Random
            //Dice[] dices = {
            //    new Dice(),
            //    new Dice(),
            //};

            //for (int i = 0; i < dices.Length; i++) {
            //    Console.WriteLine($"Dice {i + 1}: {dices[i].Score}");
            //}


            //Random random = new Random();

            //for (int i = 0; i < 100; i++) {
            //    int rand = random.Next(5);
            //    rand = random.Next(minValue: -100, maxValue: 100);
            //    Console.Write($"{rand} ");
            //}

            //Random random = new Random();

            //double num = 12.55;
            //Console.WriteLine($"Floor: {Math.Floor(num)}");
            //Console.WriteLine($"Round: {Math.Round(num)}");
            //Console.WriteLine($"Ceiling: {Math.Ceiling(num)}");
            //double num = random.NextDouble() * 1000;

            //Console.WriteLine(num);
        }
    }
}