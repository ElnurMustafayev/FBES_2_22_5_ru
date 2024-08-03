bool flag = false;
int counter = 0;

while (true) {
    flag = !flag;
    System.Console.WriteLine($"{++counter} - {(flag ? "Tick" : "Tack")}");
    Thread.Sleep(1000);
}