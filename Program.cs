
menu();

return;

void menu()
{
    Console.WriteLine("=====МЕНЮ=====");
    Console.WriteLine("Задание 1. Fizz, Buzz, Fizz Buzz и число.");
    Console.WriteLine("Задание 2. Поиск процента от числа.");
    Console.WriteLine("Задание 3. Создание числа из цифр.");
    Console.WriteLine("Задание 4. Свап цифр в числе.");
    Console.WriteLine("Задание 5. Отображение календаря.");
    Console.WriteLine("Задание 6. Конвертация температуры.");
    Console.WriteLine("Задание 7. Чётные числа в диапазоне.");

    Console.WriteLine("\nВыберете задание: ");
    var enter = Convert.ToInt32(Console.ReadLine());

    switch (enter)
    {
        case 1:
            task_1();
            break;
        case 2:
            task_2();
            break;
        case 3:
            task_3();
            break;
        case 4:
            task_4();
            break;
        case 5:
            task_5();
            break;
        case 6:
            task_6();
            break;
        default:
            Console.WriteLine("Неверный выбор!");
            break;
    }
}

/*Задание 1
Объявить одномерный (5 элементов) массив с именем A
и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B.
Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, 
а двумерный массив В случайными числами с помощью
циклов. Вывести на экран значения массивов: массива
А в одну строку, массива В — в виде матрицы. 
*Найти в данных массивах общий максимальный элемент,
*минимальный элемент,
*общую сумму всех элементов,
общее произведение всех элементов,
сумму четных элементов массива А,
сумму нечетных столбцов массива В.*/
void task_1()
{
    int[] arrayA = new int[5];
    InputArrayA(arrayA);

    double[,] arrayB = new double[3,4];
    RandomFracArrayB(arrayB);

    MaxValueArrays(arrayA, arrayB);
    MinValueArrays(arrayA, arrayB);
    SummArrays(arrayA, arrayB);
    ResultArrays(arrayA, arrayB);
    EvenResultArrayA(arrayA);
    OddResultArrayB(arrayB);

    
    void InputArrayA(int[] arrayA)
    {
        Console.Write($"Заполните элементами массив A: ");
        for (int i = 0; i < 5; i++)
        {
            arrayA[i] = Convert.ToInt32(Console.ReadLine());
        }
    
        var str = string.Join(" ", arrayA);
        Console.WriteLine($"Одномерный массив: {str}");
    }
    void RandomFracArrayB(double[,] arrayB)
    {
        var random = new Random();
        for (int i = 0; i < arrayB.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                arrayB[i, j] = random.NextDouble();
            }
        }
    
        Console.WriteLine($"\nДвумерный массив: ");
        for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{arrayB[i, j]}\t");
        }
        Console.WriteLine();
    }
    }
    void MaxValueArrays(int[] arrayA, double[,] arrayB )
    {
        double maxValueArrays = Math.Max(arrayA.Max(), arrayB.Cast<double>().Max());
        Console.WriteLine($"\nОбщий максимальный размер массивов A и B: {maxValueArrays}");
    }
    void MinValueArrays(int[] arrayA, double[,] arrayB)
    {
        double minValueArrays = Math.Min(arrayA.Min(), arrayB.Cast<double>().Min());
        Console.WriteLine($"\nОбщий максимальный размер массивов A и B: {minValueArrays}");
    }
    void SummArrays(int[] arrayA, double[,] arrayB)
    {
        double summArrays = arrayA.Sum() + arrayB.Cast<double>().Sum();
        Console.WriteLine($"\nСумма массивов A и B: {summArrays}");
    }
    void ResultArrays(int[] arrayA, double[,] arrayB)
    {
        double resultArrays = 1;
    
        for (int i = 0; i < arrayA.Length; i++)
        {
            resultArrays *= arrayA[i];
        }
        for (int i = 0; i < arrayB.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                resultArrays *= arrayB[i, j];
            }
        }
        Console.WriteLine($"\nПроизведение массивов A и B: {resultArrays}");
    }
    void EvenResultArrayA(int[] arrayA)
    {
        int evenResultArrayA = 0;
        for (int i = 0; i < arrayA.Length; i++)
        {
            if (arrayA[i] % 2 == 0)
                evenResultArrayA += arrayA[i];
        }
        Console.WriteLine($"\nСумма чётных элементов массива A: {evenResultArrayA}");
    }
    void OddResultArrayB(double[,] arrayB)
    {
        double oddResultArrayB = 0;
        for (int i = 0; i < arrayB.GetLength(0); i++)
        {
            for (int j = 1; j < arrayB.GetLength(1); j += 2)
            {
                oddResultArrayB += arrayB[i, j];
            }
        }
        Console.WriteLine($"\nСумма нечётных элементов массива B: {oddResultArrayB}");
    }
}



/*Задание 2
Дан двумерный массив размерностью 5×5, 
заполненный случайными числами из диапазона от –100 до 100.
Определить сумму элементов массива, расположенных
между минимальным и максимальным элементами.*/
void task_2()
{
    int[,] array = new int [5,5];

    RandomInputArray(array, -100, 100);
    PrintArray(array);
    SumArray(array);

    void RandomInputArray(int[,] array, int begin, int end)
    {
        var random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(begin, end + 1);
            }
        }
    }
    void PrintArray(int[,] array)
    { 
        Console.WriteLine($"\nДвумерный массив: ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }  
    }
    void SumArray(int[,] array)
    {
        int sum = 0;
        int max = array.Cast<int>().Max();
        int min = array.Cast<int>().Min();
        for(int i = 0; i < array.GetLength(0); i++) 
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i != min && i != max)
                    sum += i;
            }
        }
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Сумма элементов двумерного массива: {sum}");
    }
}



/*Задание 3
Пользователь вводит строку с клавиатуры. 
Необходимо зашифровать данную строку используя шифр Цезаря.
Из Википедии:
Шифр Цезаря — это вид шифра подстановки,
в котором каждый символ в открытом тексте заменяется
символом, находящимся на некотором постоянном числе
позиций левее или правее него в алфавите. Например,
в шифре со сдвигом вправо на 3, A была бы заменена на
D, B станет E, и так далее.
Кроме механизма шифровки, реализуйте механизм
расшифрования.*/
void task_3()
{
    string txt = InputArray();
    char[] charArr = txt.ToCharArray();

    EncryptionArray(charArr);
    PrintArray(charArr);

    DecryptionArray(charArr);
    PrintArray(charArr);

    string InputArray()
    {
        Console.Write("Введите текст для шифрования: ");
        string text = Console.ReadLine();
        return text;
    }
    void PrintArray(char[] array)
    {
        var str = string.Join("", array);
        Console.WriteLine($"Одномерный массив: {str}");
    }
    void EncryptionArray(char[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (char)(array[i] + 3);
        }
    }
    void DecryptionArray(char[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (char)(array[i] - 3);
        }
    }
}



/*Задание 4
Создайте приложение, которое производит операции
над матрицами:
■* Умножение матрицы на число;
■* Сложение матриц;
■ Произведение матриц.*/
void task_4()
{
    int[,] matrixArray1 = new int[3, 4];
    int[,] matrixArray2 = new int[5, 5];

    RandomInputArray(matrixArray1, 1, 100);
    PrintArray(matrixArray1);

    Console.WriteLine();

    MatrixByNumber(matrixArray1);
    PrintArray(matrixArray1);

    Console.WriteLine();

    RandomInputArray(matrixArray2, 1, 100);
    PrintArray(matrixArray2);

    Console.WriteLine();

    MatrixByNumber(matrixArray2);
    PrintArray(matrixArray2);

    Console.WriteLine();

    MatrixSum(matrixArray1, matrixArray2);

    Console.WriteLine();

    MatrixProizv(matrixArray1, matrixArray2);

    void RandomInputArray(int[,] matrixArrays, int begin, int end)
    {
        var random = new Random();
        for (int i = 0; i < matrixArrays.GetLength(0); i++)
        {
            for (int j = 0; j < matrixArrays.GetLength(1); j++)
            {
                matrixArrays[i, j] = random.Next(begin, end);
            }
        }
    }
    void PrintArray(int[,] matrixArrays)
    {
        Console.WriteLine($"\nДвумерный массив: ");
        for (int i = 0; i < matrixArrays.GetLength(0); i++)
        {
            for (int j = 0; j < matrixArrays.GetLength(1); j++)
            {
                Console.Write($"{matrixArrays[i, j],5}");
            }
            Console.WriteLine();
        }
    }
    void MatrixByNumber(int[,] matrixArray)
    {
        var random = new Random();
        var randomNumber = random.Next(5, 10);
        Console.WriteLine($"Число для умножения: {randomNumber}");

        for (int i = 0; i < matrixArray.GetLength(0); i++)
        {
            for (int j = 0; j < matrixArray.GetLength(1); j++)
            {
                matrixArray[i, j] = matrixArray[i, j] * randomNumber;
            }
        }
    }
    void MatrixSum(int[,] matrixArray1, int[,] matrixArray2)
    {
        int rowsB = matrixArray2.GetLength(0);
        int colsB = matrixArray2.GetLength(1);

        int[,] matrixArrayResult = new int[matrixArray1.GetLength(0), matrixArray1.GetLength(1)];

        for (int i = 0; i < matrixArray1.GetLength(0); i++)
        {
            for (int j = 0; j < matrixArray1.GetLength(1); j++)
            {
                if (i < rowsB && j < colsB)
                    matrixArrayResult[i, j] = matrixArray1[i, j] + matrixArray2[i, j];
                else
                    break;
            }
        }
        Console.WriteLine($"\nРезультат суммы массивов: ");
        for (int k = 0; k < matrixArrayResult.GetLength(0); k++)
        {
            for (int l = 0; l < matrixArrayResult.GetLength(1); l++)
            {
                Console.Write($"{matrixArrayResult[k, l],5}");
            }
            Console.WriteLine();
        }
    }
    void MatrixProizv(int[,] matrixArray1, int[,] matrixArray2)
    {
        int rowsB = matrixArray2.GetLength(0);
        int colsB = matrixArray2.GetLength(1);

        int[,] matrixArrayResult = new int[matrixArray1.GetLength(0), matrixArray1.GetLength(1)];

        for (int i = 0; i < matrixArray1.GetLength(0); i++)
        {
            for (int j = 0; j < matrixArray1.GetLength(1); j++)
            {
                if (i < rowsB && j < colsB)
                    matrixArrayResult[i, j] = matrixArray1[i, j] * matrixArray2[i, j];
                else
                    break;
            }
        }
        Console.WriteLine($"\nРезультат произведения массивов: ");
        for (int k = 0; k < matrixArrayResult.GetLength(0); k++)
        {
            for (int l = 0; l < matrixArrayResult.GetLength(1); l++)
            {
                Console.Write($"{matrixArrayResult[k, l],10}");
            }
            Console.WriteLine();
        }
    }
}



/*Задание 5
Пользователь с клавиатуры вводит 
в строку арифметическое выражение.
Приложение должно посчитать
его результат. Необходимо поддерживать только две
операции: + и –.*/
void task_5()
{
    Console.Write("Введите арифметическое выражение (пример 2 + 2 (писать через пробел)) с \'+\' или \'-\': ");
    string? str = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(str))
    {
        Console.WriteLine("Ошибка: строка не введена.");
        return;
    }
    
    SplitArrayExample(str);

    void SplitArrayExample(string str)
    {
        string[] arrayOfString = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double result = 0, num1 = 0;
        bool plus = true;

        for (int i = 0; i < arrayOfString.Length; i++)
        {
            if (double.TryParse(arrayOfString[i], out num1))
            {
                if (plus)
                    result += num1;
                else
                    result -= num1;
            }
            else
            {
                if (arrayOfString[i] == "+")
                    plus = true;
                else if (arrayOfString[i] == "-")
                    plus = false;
                else
                {
                    Console.WriteLine($"Предупреждение: неизвестная лексема '{arrayOfString[i]}' пропущена.");
                    break;
                }
            }
        }
        Console.WriteLine("Результат: " + result);
    }
}



/*Задание 6
Пользователь с клавиатуры вводит некоторый текст.
Приложение должно изменять регистр первой буквы
каждого предложения на букву в верхнем регистре.

Например, если пользователь ввёл: «today is a good
day for walking. i will try to walk near the sea».

Результат работы приложения: «Today is a good day
for walking. I will try to walk near the sea».*/
void task_6()
{
    Console.Write("Введите текст:");
    string input = Console.ReadLine();

    string[] sentences = input.Split(new char[] { '.', '!', '?' });

    RegisterTextUpp(sentences);
    PrintText(sentences);


    void RegisterTextUpp(string[] sent)
    {
        for (int i = 0; i < sent.Length; i++)
        {
            string sentence = sent[i].Trim();

            if (sentence.Length > 0)
                sent[i] = char.ToUpper(sentence[0]) + sentence.Substring(1);
        }
    }
    void PrintText(string[] sent)
    {
        string result = string.Join(". ", sent);
        Console.WriteLine(result);
    }
}
