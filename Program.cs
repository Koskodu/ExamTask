string[] array1 = new string[10] { "76", "15125", "johnny", "old", "rest", "for", "redish", "cook", "ok", "do" };
string[] array2 = new string[array1.Length];

int maxWordLength = 3;

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= maxWordLength)
        {
            array2[count] = array1[i];
            count++;
        }
    } 
}


void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + " | ");
        else Console.Write(array[i]);
    }
    Console.WriteLine(" ]");
    
}


SecondArrayWithIF(array1, array2);
PrintArray(array2);