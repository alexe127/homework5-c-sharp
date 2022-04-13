// Показать числа Фибоначчи

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine() ?? " ");
int a1 = 0;
int a2 = 1;
if (n > 0)
    Console.Write(a1 + " " + a2 + " ");
else
    Console.Write("таких чисел Фибоначчи не существует");

int temp = 0;
int i = 0;
while (i < n)
{
    Console.Write((a1 + a2) + " ");
    temp = a2;
    a2 = a2 + a1;
    a1 = temp;
    i++;    
}
