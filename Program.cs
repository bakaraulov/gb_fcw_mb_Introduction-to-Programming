﻿// Итоговая контрольная работа по основному блоку. 
// Введение в программирование

// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

// Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
Console.WriteLine("Программа из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам...");

int PromptNumber (string msg)   // метод ввода цифр
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите: ");
        value = Console.ReadLine();
    }
    // Console.Clear();
    return val;
}

string PromptString (string msg)    // метод ввода строк
{
    Console.Write(msg);
    string value = Console.ReadLine();
    return value;
}

string[] CreateArray()  // ввод массива вручную
{
    string[] array = new string[] {};
    for (int i=0; i<=array.Length; i++)
    {         
        string key = PromptString("Введите значение или нажмите клавишу 'Q' -выход: ");
        if (key.ToLower() == "q")
        {
           i = array.Length; 
        }
        else
        {
            Array.Resize(ref array, array.Length + 1);
            array[i] = key;            
        }
    }  
    return array;
}

void PrintArray(string[] array) // печать массива
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array[i]+" ");
    }
    Console.WriteLine();
}

string[] ConditionArray(string[] array) // основной метод. создание массива, елементы которого не больше 3 символов
{
    string[] result = new string[] {};
    int j = 0;
    for(int i=0; i<array.Length; i++)
    {        
        if (array[i].Length <= 3)
        {  
            Array.Resize(ref result, result.Length + 1);
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

string question = PromptString("Вы хотите использовать готовые примеры массива? Иначе ввод вручну. (y-да, n- нет): ");
if (question.ToLower() == "y")
{
    Console.WriteLine("Пример №1: Hello, 2, world, :-)");
    Console.WriteLine("Пример №2: 1234, 1567, - 2, computer science");
    Console.WriteLine("Пример №3: Russia, Denmark, Kazan");

    int key = PromptNumber("Введите желаемый вариант: ");   // выбор массива из мариантов
    while (key !=1 && key !=2 && key !=3)   // проверка на правильность ввода нужного варианта
    {
        Console.Write("Введен неверный номер примера...");
        key = PromptNumber("Повторите попытку: ");
    }
    if (key == 1)
    {
    string[] newarray = { $"Hello", "2", "world", ":-)" };
    PrintArray(newarray);
    string[] conditionArray = ConditionArray(newarray);
    PrintArray(conditionArray);
    }
    else if (key == 2)
    {
        string[] newarray = { $"1234", "1567", "-2", "computer science" };
        PrintArray(newarray);
        string[] conditionArray = ConditionArray(newarray);
        PrintArray(conditionArray);
    }
    else if (key == 3)
    {
        string[] newarray = { $"Russia", "Denmark", "Kazan" };
        PrintArray(newarray);
        string[] conditionArray = ConditionArray(newarray);
        PrintArray(conditionArray);
    }
}
else
{
    question = PromptString("Вы хотите ввести текст как массив? (y-да, n- нет(текст будет вводится целой строкой)): "); // ввод массива вручную
    if (question.ToLower() == "y")
    {
       string[] newarray = CreateArray();
       PrintArray(newarray);
       string[] conditionArray = ConditionArray(newarray);
       PrintArray(conditionArray);
    }
    else
    {
        string text = PromptString("Введите собственный текст на Английском языке!!! : ");  // ввод текста, который будет преобразован в массив. Ввод требуется исполнить латинскими символами
        var date = text.Split(" ");
        date.ToArray();
        string[] conditionArray = ConditionArray(date);
        PrintArray(conditionArray);       
    }
}