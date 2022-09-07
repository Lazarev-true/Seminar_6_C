//  Найдите сумму произведений пар чисел в одномерном 
//  целочисленном массиве. Парой считаем первый и 
//  последний элемент, второй и предпоследний и т.д. 
//  Если кол-во элементов нечетное, то элемент 
//  посередине не учитывать.

int N = 5;
int[] array = new int[N];
int pr;
int sum = 0;

Random rnd = new Random();

for (int i = 0; i < N; i++)
{
    array[i] = rnd.Next(1, 10);
}
for (int i = 0; i < N / 2; i++)
{
    pr = array[i] * array[N - (i + 1)];
    sum += pr;
}

var str = string.Join(", ", array);
Console.WriteLine($"{str}  ->  {sum}");
