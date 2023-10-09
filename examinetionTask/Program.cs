/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Clear();

string[] oldStringsArray;
string[] stringsArray;
string[] newArray;
int length = 0;
string str;
stringsArray = new string[length];

link1:
Console.WriteLine("Введите количество элементов массива:");
int n = int.Parse(Console.ReadLine()!);
if (n < 0)
{
    Console.WriteLine("Количество элементов массива должно быть больше нуля!");
    goto link1;
}

link2:
Console.WriteLine($"Введите {n} строк");
while (length != n)
{
    str = Console.ReadLine()!;
    if (str != "")
    {
        length++;
        oldStringsArray = new string[length];
        for (int i = 0; i < oldStringsArray.Length - 1; i++)
        {
            oldStringsArray[i] = stringsArray[i];
        }
        oldStringsArray[length - 1] = str;
        stringsArray = oldStringsArray;
    }
    else
    {
        Console.WriteLine("Пустая строка!");
        goto link2;
    }
}

Console.Write($"[{string.Join(", ", stringsArray)}] ->");

int countElementsWithMinString = 0;
for (int i = 0; i < stringsArray.Length; i++)
{
    if (stringsArray[i].Length <= 3) countElementsWithMinString++;
}
int count = 0;
newArray = new string[countElementsWithMinString];
for (int i = 0; i < stringsArray.Length; i++)
{

    if (stringsArray[i].Length <= 3)
    {
        newArray[count] = stringsArray[i];
        count++;
    }

}

Console.Write($" [{string.Join(", ", newArray)}]");