// принимает координаты двух точек и находит между ними расстояние в 3д пространстве
// принимает число N и выдаёт таблицу кубов чисел от 1 до N

double X1 = new Random().Next(-100,101);
double Y1 = new Random().Next(-100,101);
double Z1 = new Random().Next(-100,100);

double X2 = new Random().Next(-100,101);
double Y2 = new Random().Next(-100,101);
double Z2 = new Random().Next(-100,100);
Console.WriteLine($"Точка А1({X1},{Y1},{Z1}), точка А2({X2},{Y2},{Z2})");
Console.Write("Расстояние между точками А1 и А2 равно ");
double result = Math.Abs(Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1,2) + Math.Pow(Z2-Z1,2)));
Console.WriteLine(result);
