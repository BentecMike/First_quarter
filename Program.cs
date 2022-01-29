
string[] mass = {"hello", "2", "world", ":-)"};              // массив из строк
//string[] mass = {"1234", "1567", "-2", "computer science"};  // массив из строк
//string[] mass = { "Russia", "Denmark", "Kazan" };            // массив из строк
//string[] mass = {" ", " ", " ", "qwe"};

int w = 3;                                                     // максимальная длина строки по условию

void PrintArray(string[] arr)                                  // метод для печати массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        if (i == arr.Length - 1)                                
            Console.Write($"{arr[i]}");
    }
}

string[] Choiseelem(string[] mass)                            // метод для выбора из имеющегося массива строк с заданной длиной 
{                                                              // и создания нового массива со строками заданной длины
    string[] massNew = new string[mass.Length];
    for (int i = 0; i < mass.Length; i++)
    {
        string a = mass[i];                                    // присваиваем строке а значение из массива mass с индексом [i]
        char[] b = a.ToCharArray();                            // разделяем элемент массива на символы
        int m = 0;                                             // вводим переменную m для посчета циклов(символов) в элементе массива
        foreach (char x in b) m++;                             // проверяем сколько символов в элементе массива
        if (m <= w)                                            // если количество символов меньше или равно 3 
        {
            massNew[i] = mass[i];                              // записываем строку в новый массив massNew с тем же индексом
        }
    }
    return massNew;                                            // после выполнения циклов foreach и for возвращаем массив massNew
}

Console.Write("[");
PrintArray(mass);                                              // вызов метода для печати заданного массива mass
Console.Write("]" + "  ->  " + "[");
string[] massNew = Choiseelem(mass);                           // создание массива massNew через вызов метода для выбора из имеющегося массива с заданной длиной строки
massNew = massNew.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();      // удаление пустых ячеек массива massNew
PrintArray(massNew);                                           // вызов метода для печати заданного массива massNew
Console.Write("]");
