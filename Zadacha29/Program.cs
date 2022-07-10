/*

Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
6, 1, -33 -> [1, 6, -33]

*/

Random random = new Random(); //рандомное число
int size = 8;
int[] array = new int[size];

int firstNumber = -10;
int lastNumber = 10;

fillArray(array, firstNumber, lastNumber);
printArray(array);
sortArray(array);
printArray(array);

//Заполнение массива случайными числами от -10 до 10
static void fillArray(int[] A, int First, int Last)
{
    Random random = new Random();
    for (int i = 0; i < A.Length; i ++)
    {
        A[i] = random.Next(First, Last);
    }
}

//Вывод массива
static void printArray(int[] A)
{
    for (int i = 0; i < A.Length; i ++)
    {
        Console.Write(A[i] + "  ");
    }
    Console.WriteLine();
}

//Сортировка массива по модулю
static void sortArray (int[] A)
{
    for (int i = 0; i < A.Length - 1; i++)
    {
        int temp;
        for (int j = i + 1; j < A.Length; j++)
        {
            if (Math.Abs(A[i]) > Math.Abs(A[j])) //Сравниваем первый элемент массива со вторым элементом массива. Операцию модуля применяем во время сравнения.
            {            
                temp = A[i]; // Если первый элемент больше второго, то присваеваем временной переменной первый элемент массива
                A[i] = A[j]; // И меняем первый элемент массива на второй
                A[j] = temp; // А второй на первый (временная переменная temp)
            }
        }
    }
}
