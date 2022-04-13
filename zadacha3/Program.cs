// Написать программу масштабирования фигуры
Console.WriteLine("Введите колличество вершин фигуры: ");
int num = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите коэффициент масштабирования: ");
int k = int.Parse(Console.ReadLine() ?? "");
int [] coord = new int [num*2];

for (int count = 0; count < num*2; count+=2)
{
    Console.WriteLine("Введите x: ");
    coord[count] = int.Parse(Console.ReadLine()?? "");
    Console.WriteLine("Введите y: ");
    coord[count + 1] = int.Parse(Console.ReadLine()?? "");
}
    
for (int count = 0; count < num*2; count+=2)
{
        Console.WriteLine($"x = {coord[count] * k} y = {coord[count + 1] * k}");
}