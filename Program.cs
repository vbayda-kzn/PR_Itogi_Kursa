// Итоговая проверочная работа по итогам изучения вводного блока. Байда Владимир. 

// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3-м символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше оботись исключительно массивами.

string [] array = {"hello", "2", "world", ":-)"}; // задаем исходный массив.
int K = 3; // задаем ограничение на число символов в строках нового массива.  
string [] newArray = {}; // создаем новый пустой массив для строковых значений. 

for (int i = 0; i < array.Length; i++) //устанавливаем цикл, в котором перебираем все элементы заданного массива
    if (array[i].Length <= K) // задаем условие записи элементов исходного массива в новый. 
    {
       Array.Resize(ref newArray, newArray.Length + 1); // увеличиваем размер нового массива на 1.
       newArray[newArray.Length - 1] = array[i]; // записываем значение, удовлетворяющее условию, в последнюю ячеку нового массива.
    }
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]"); // выводим исходный массив.
Console.WriteLine("Итоговый массив:  [" + string.Join(", ", newArray) + "]"); // выводим новый массив, отфильтрованный по заданному условию.
Console.WriteLine();