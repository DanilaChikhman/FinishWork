//Задача к проверочной работе

Console.Write("введите массив через запятую и пробел:  ");
String firstStr = System.Convert.ToString(Console.ReadLine());
firstStr = firstStr.Replace(" ", ""); //удаляем пробелы
string[] arr1 = firstStr.Split(","); // сплит по ,
string[] arr2 = new string[arr1.Length];

void SecondArr(string[] arr1, string[] arr2)  //переписываем  строки с длинной <=3 в новый массив
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArray(string[] array) // печать нового массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} "); 
    }
    
}
SecondArr(arr1, arr2);
PrintArray(arr2);

