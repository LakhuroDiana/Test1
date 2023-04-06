void EnterMassive(string[] array, int SizeOfArray)
{
    for (int i = 0; i < SizeOfArray; ++i)
    {
        Console.WriteLine(array[i]);
    }
}

string[] initial_array = { "hello", "2", "world", ":-)" };
int number_of_rows_in_the_second_array = 0;

//подсчёт слов, длина которых меньше или равна 3 
Console.WriteLine(initial_array.Length);
for (int i = 0; i < initial_array.Length; ++i)
{
    if ((initial_array[i].Length < 3) || (initial_array[i].Length == 3))
    {
        number_of_rows_in_the_second_array += 1;
    }
}

string[] modified_array = new string[number_of_rows_in_the_second_array];

// запись этих слов в новый массив
int count = 0;
for (int i = 0; i < initial_array.Length; i++)
{
    if (initial_array[i].Length <= 3)
    {
        modified_array[count] = initial_array[i];
        count++;
    }
}

EnterMassive(initial_array, initial_array.Length);
EnterMassive(modified_array, modified_array.Length);