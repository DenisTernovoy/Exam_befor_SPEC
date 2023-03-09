Console.Write("Введите колличество вводимых строк: ");

string num = Console.ReadLine();

if (int.TryParse(num, out int number))
{
    string[] array = new string[number];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} строку:");
        array[i] = Console.ReadLine();
    }
    
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) counter += 1;
    }

    string[] newArray = new string[counter];
    int helpCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) {
            newArray[helpCount] = array[i];
            helpCount += 1;
        }
    }
    Console.WriteLine();
    Console.Write("Массив со строками, длины которых меньше или равны 3: ");
    PrintArray(newArray);

} else Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");


void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


