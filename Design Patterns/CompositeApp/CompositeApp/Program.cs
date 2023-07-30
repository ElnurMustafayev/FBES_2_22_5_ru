using CompositeApp.Containers;
using CompositeApp.Items;
using CompositeApp.Items.Base;



var el1 = new Product("IPhone", 1200);
var el2 = new Product("Tv", 800);
var box1 = new Box();
box1.Items.Add(el1);
box1.Items.Add(el2);


var box2 = new Box();
box2.Items.Add(new Product("Car toy", 15));
box2.Items.Add(new Product("Dirol", 1));
box2.Items.Add(new Product("Apples", 3));


var box3 = new Box();
box3.Items.Add(box1);
box3.Items.Add(box2);
box3.Items.Add(new Item("Ticket"));


//Console.WriteLine($"{box3.SerailNumber} box price: {box3.Price} $");
//Console.WriteLine(box3);

Console.WriteLine($"{box2.SerailNumber} box price: {box2.Price} $");
Console.WriteLine(box2);


//Console.WriteLine(box3.Items[1].Price);
//Console.WriteLine(box2.Price);
//var secondBox = box3.Items.First(component => {
//    if (component is Box box) {
//        return box.SerailNumber == "1";
//    }
//    return false;
//});
//Console.WriteLine(secondBox.Price);