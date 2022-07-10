/*
 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


  



Random random = new Random(); //Инициализирует новый экземпляр класса Random, используя начальное значение по умолчанию.
int size = random.Next(2, 10); //Размер массива
int [] number = new int[size]; //Создаем массивЮ число элементов size
int firstNumber = 0; // Указываем диапазон числе
int lastNumber = 10; // которые будут заполнять наш массив

Fillarray(number, firstNumber, lastNumber);
PrintArray(number);
Summary(number);

//Заполняем массив случайными числами от 1 до 10
static void Fillarray(int[] array, int First, int Last)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = random.Next(First, Last);
    }
}

//Выводим изначальный массив
static void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

//Накапливаем в сумму значения каждого элемента массива
static void Summary(int[] array)
{   
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        sum = sum + array[i];  
    }
    Console.Write($"Сумма чисел числа равна: {sum}");
}

