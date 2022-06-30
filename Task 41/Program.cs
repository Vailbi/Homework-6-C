// Задача 41: Пользователь вводит с клавиатуры числа через запятую. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через запятую");
string array = Console.ReadLine(); //ввод чисел через запятую в массив строк
int size = 1; // размер нового массива по кол-ву запятых

int SeachSize(string array) // метод поиска запятых
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]==',')
        {
            size++;
        }
    }
    return size;
}
SeachSize(array); // поиск запятой

int [] NewArr = new int[size]; // новый массив для вывод чисел

void AddNumberInArray(string array) // метод создания нового массива с числами
{
    
    int index = 0; // счетчик для нового массива
    for (int i = 0; i < array.Length; i++)
    {
        string temp = ""; // переменная для записи элементов из строки
        while (array[i]!= ',')
        {
           if (i != array.Length-1)
           {
            temp+=array[i].ToString();
            i++;
           }
           else
           {
            temp+=array[i].ToString();
            break;
           }
        }
        NewArr[index] =Convert.ToInt32(temp); // добавление инт значенией в новый массив
        index++;
    }
}
AddNumberInArray(array);

void PrintArray(int [] array) // метод печати массива
{
    for (int i = 0; i < array.Length; i++)
    {
     Console.Write(array[i] + " ");   
    }
}

int count = 0;

for (int i = 0; i < NewArr.Length; i++)
{
    if (NewArr[i]<0) count++;
}

PrintArray(NewArr);
Console.WriteLine();
Console.WriteLine($"Количество отрицательных чисел: {count}");
