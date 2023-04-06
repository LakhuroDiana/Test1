string[] initial_array = { "hello", "2", "world", ":-)" };
int number_of_rows_in_the_second_array=0;

Console.WriteLine(initial_array.Length);
for (int i=0; i<initial_array.Length; ++i)
{
    if ((initial_array[i].Length<3) || (initial_array[i].Length==3))
    {
        number_of_rows_in_the_second_array+=1;
    }
}