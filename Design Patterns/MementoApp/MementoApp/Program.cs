using MementoApp;

var blog = new Blog();
var caretaker = new BlogCaretaker(blog);

blog.Title = "one";
blog.Id = 111;

caretaker.Save();

blog.Title = "TWO";
blog.Content = "Something";
blog.Id = 2;

caretaker.Save();
caretaker.Save();

blog.Title = "!!!";
blog.Content = "    ";
blog.Id = 162134;

caretaker.Save();

blog.Title = "something";
blog.Content = "wrong";
blog.Id = -1;

caretaker.Load();
caretaker.Load();
caretaker.Load();
caretaker.Load();

Console.WriteLine(blog);