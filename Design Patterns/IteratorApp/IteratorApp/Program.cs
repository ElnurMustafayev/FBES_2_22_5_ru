//List<int> nums = new List<int>() {
//    235,346,3457,32,74,568,4,84,34,7
//};

//foreach (var item in nums) {
//    Console.WriteLine(item);
//}

using IteratorApp;

House house = new House();
house.Add(new Person("Bob Marley"));
house.Add(new Person("Ann Brown"));
house.Add(new Person("Kate White"));



var houseIterator = house.GetEnumerator();

while(houseIterator.MoveNext()) {
    Console.WriteLine(houseIterator.Current);
}

while (houseIterator.MoveNext()) {
    Console.WriteLine(houseIterator.Current);
}






//foreach (var person in house) {
//    Console.WriteLine(person);
//}

//foreach (var person in house) {
//    Console.WriteLine(person);
//}