using System;

class Program
{
    static void Main()
    {
        string[] array = { "Hello", "de", "123", "close", ".", "cat", "goodbye" };

        string result = FilterThreeStrings(array, 3);

        Console.WriteLine(result);
    }

    static string FilterThreeStrings(string[] array, int maxLength)
    {
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= maxLength)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;
        foreach (string str in array)
        {
            if (str.Length <= maxLength)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return string.Join(", ", resultArray);
    }
}