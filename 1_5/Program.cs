Console.OutputEncoding = System.Text.Encoding.Unicode; // присваиваем консоле кодировку Unicode
Console.WriteLine("Нахождение расстояния, используя рандомные значения, по формуле: \u221a(x1 - x2)\xB2 + (y1 - y2)\xB2");
Random rnd = new Random(); //создание объекта класса Random
int x1 = rnd.Next(100); 
int x2 = rnd.Next(100); // присваиваем перменной случайное целое число до 100
int y1 = rnd.Next(100);
int y2 = rnd.Next(100);
Console.WriteLine($"Расстоние между двумя точками \u221a({x1} - {x2})\xB2 + ({y1} - {y2})\xB2 = {Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2))}"); // нахождение по формуле расстояния между двумя точками 


