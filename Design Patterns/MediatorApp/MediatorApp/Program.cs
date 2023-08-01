using MediatorApp.Classes;
using MediatorApp.Messenger;

var messenger = new Messenger();

ClassA obj1 = new ClassA(messenger);
ClassB obj2 = new ClassB(messenger);
ClassC obj3 = new ClassC(messenger);

//Console.WriteLine(obj1.Num);
//obj2.Func();
//Console.WriteLine(obj1.Num);


obj3.Method();