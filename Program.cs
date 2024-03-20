using System;
class Program
{
    static void Main()
    {
        

        Console.WriteLine("Хотите ввести свой массив строк? (y/n)");
        string choice = Console.ReadLine();

        string[] originalArray;

        do
        {
            if (choice.ToLower() == "y")
            {
                Console.WriteLine("Введите строки. Для завершения ввода введите пустую строку:");

                string[] tempArray = new string[100]; // Предположим, что пользователь не введет более 100 строк

                int currentIndex = 0;

                while (true)
                {
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        break;
                    }

                    tempArray[currentIndex] = input;
                    currentIndex++;
                }

                originalArray = new string[currentIndex];
                Array.Copy(tempArray, originalArray, currentIndex);
                break;
            }
            else if (choice.ToLower() == "n")
            {
                originalArray = new string[] { "Hello", "2", "world", ":-)" };
                Console.WriteLine("Используется массив по умолчанию.");
                break;
            }
            else
            {
                Console.WriteLine("Неверный ввод. Введите 'y' или 'n'.");
            }

            Console.WriteLine("Хотите ввести свой массив строк? (y/n)");
            choice = Console.ReadLine();

        } while (true);

        Console.WriteLine($"[{string.Join(", ", originalArray.Select(s => $"\"{s}\""))}] → [{string.Join(", ", FormatArray(originalArray))}]");
    }

    static string[] FormatArray(string[] inputArray)
    {
        string[] resultArray = new string[inputArray.Length];
        int newSize = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[newSize] = $"\"{inputArray[i]}\"";
                newSize++;
            }
        }

        Array.Resize(ref resultArray, newSize);

        return resultArray;
    }



    
}