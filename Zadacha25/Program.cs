/*

Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

Result();
void Result()
{
        Console.Write("Введите первое число: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число число: ");
        int temp = x;
        x = Convert.ToInt32(Console.ReadLine());

        void Rank()
        {
            if( x % 1 == 0)
            {
                double result = Math.Pow(temp, x);
                Console.WriteLine($"Результат возведения {temp} в степень {x} равно: {result}");
            }
            else Console.WriteLine($"Число-степень {x} не является натуральным числом, введите другие числа");
        }
        Rank();
}
