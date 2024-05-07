// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetEvenOrLessThree (string[] array) // наименование функции для решения задачи
{
    // Создаём переменную для размера будущего массива и в цикле определяем её значение.
    // Для этого считаем количество элементов в исходном массиве, равных или меньше 3 символам.
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count = count + 1;
        }
    }
    
    // Создаём будущий массив, указывая его размер в виде переменной, найденной в первом шаге,
    string[] newArray = new string[count];
    int index = 0; // создаём переменную для перечисления индекса элементов нового массива,
    for (int i = 0; i < array.Length; i++) // в цикле определяем наличие искомых элементов
    {
        if(array[i].Length <= 3)
        {
            newArray[index] = array[i]; // и помещаем их в новый массив
            index = index + 1;
        }
    }
    return newArray;
}

// Для проверки работоспособности функции добавим функцию вывода массива
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }

    }
    Console.Write("]");
}

// Вызов функции
string[] symbols = ["Hello", "2", "world", ":-)"];
string[] symbols1 = ["1234", "1567", "-2", "computer science"];
string[] symbols2 = ["Russia", "Denmark", "Kazan"];
string[] symbols3 = GetEvenOrLessThree(symbols);
string[] symbols4 = GetEvenOrLessThree(symbols1);
string[] symbols5 = GetEvenOrLessThree(symbols2);
// Вывод результата
PrintArray(symbols3);
Console.WriteLine();
PrintArray(symbols4);
Console.WriteLine();
PrintArray(symbols5);