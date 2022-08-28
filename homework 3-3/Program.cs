// Задача 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число x: ");
double x = Convert.ToInt32(Console.ReadLine());
int stepen = 3;
double i = 1;
double y; // x в степени

while (i<=x)
{
   y = Math.Pow(i, stepen);
   Console.Write("Число " +  i + " в кубе = ");
   Console.WriteLine(y);
   i++;
}

