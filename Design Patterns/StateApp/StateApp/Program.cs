using StateApp;

var human = new Human("Bob", "Marley");

//Console.WriteLine(human.State);

human.State = HumanStates.drunk;

human.Walk();