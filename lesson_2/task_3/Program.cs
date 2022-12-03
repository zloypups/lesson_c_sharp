/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.Clear();
Console.Write("Введите число дня недели: ");
int x = int.Parse(Console.WriteLine());

if (x = 1)
{
    Console.WriteLine($"Вашу значение {x}, это Понедельник");
}
else if (x = 2)
{
    Console.WriteLine($"Вашу значение {x}, это Вторник");
}
else if (x = 3)
{
    Console.WriteLine($"Вашу значение {x}, это Среда");
}
else if (x = 4)
{
    Console.WriteLine($"Вашу значение {x}, это Четверг");
}
else if (x = 5)
{
    Console.WriteLine($"Вашу значение {x}, это Пятница");
}
else if (x = 6)
{
    Console.WriteLine($"Вашу значение {x}, это Суббота и это выходной день");
}
else if (x = 7)
{
    Console.WriteLine($"Вашу значение {x}, это Воскресенье и это выходной день");
}
else
    Console.WriteLine("Введите корректный номер дня недели. их не больше 7-ми");
