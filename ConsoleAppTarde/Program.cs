using ConsoleAppTarde;

Product p1 = new Product(1, "Mouse xing ling", 10.90M);
Product p2 = new Product(2, "Teclado multlaser", 20.90M);

Console.WriteLine(p1.GetName() + " " + p1.GetValue());

p1.SetValue(29.90M);
p1.SetName("Mouse Razer");

Console.WriteLine(p1.GetName() + " " + p1.GetValue());