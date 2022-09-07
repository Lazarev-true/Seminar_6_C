// Программа запрашивает натуральное число M, 
// пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Введите количесво чисел");
int M = Convert.ToInt32(Console.ReadLine());

double[] array = new double[M];
int j = 0;

for (int i = 0; i < M; i++)
{
   array[i] = Convert.ToDouble(Console.ReadLine());
   if(array[i] > 0)
   {
        j++;
   }
}
var str = string.Join(", ", array);
Console.WriteLine($"[{str}]  ->  {j}");