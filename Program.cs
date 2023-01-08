Console.Clear();

void ArrayElementEqualOrLessThree(string[] array)
{
    string[] temp = new string[0];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref temp, temp.Length + 1);
            temp[j] = array[i];
            j++;
        }
    }
    Console.WriteLine($"[{string.Join(", ", temp)}]");
}

string[] array1 = { "hello", "2", "world", ":-)" };
Console.Write($"[{string.Join(", ", array1)}] -> ");
ArrayElementEqualOrLessThree(array1);

string[] array2 = { "1234", "1567", "-2" };
Console.Write($"[{string.Join(", ", array2)}] -> ");
ArrayElementEqualOrLessThree(array2);

string[] array3 = { "Russia", "Denmark", "Kazan" };
Console.Write($"[{string.Join(", ", array3)}] -> ");
ArrayElementEqualOrLessThree(array3);