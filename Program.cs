using System;

namespace module03practice
{
    class practice1
    {
        static void Main()
        {
            double[] A = new double[5];
            Console.WriteLine("массив A:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = double.Parse(Console.ReadLine());
            }

            double[,] B = new double[3, 4];
            Random random = new Random();
            Console.WriteLine("Массив B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = random.NextDouble();
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }

            double maxA = A[0];
            double minA = A[0];
            double maxB = B[0, 0];
            double minB = B[0, 0];

            foreach (double num in A)
            {
                if (num > maxA)
                {
                    maxA = num;
                }
                if (num < minA)
                {
                    minA = num;
                }
            }

            foreach (double num in B)
            {
                if (num > maxB)
                {
                    maxB = num;
                }
                if (num < minB)
                {
                    minB = num;
                }
            }

            double sumA = 0;
            double productA = 1;
            double sumB = 0;
            double productB = 1;

            foreach (double num in A)
            {
                sumA += num;
                productA *= num;
            }

            foreach (double num in B)
            {
                sumB += num;
                productB *= num;
            }

            double sumEvenA = 0;
            foreach (double num in A)
            {
                if (num % 2 == 0)
                {
                    sumEvenA += num;
                }
            }

            double sumOddColumnsB = 0;
            for (int j = 0; j < 4; j += 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    sumOddColumnsB += B[i, j];
                }
            }

            Console.WriteLine($"Мах элемент в массиве A: {maxA}");
            Console.WriteLine($"Мин элемент в массиве A: {minA}");
            Console.WriteLine($"Мах элемент в массиве B: {maxB}");
            Console.WriteLine($"Мин элемент в массиве B: {minB}");
            Console.WriteLine($"сумма всех элементов в массиве A: {sumA}");
            Console.WriteLine($"произведение всех элементов в массиве A: {productA}");
            Console.WriteLine($"сумма всех элементов в массиве B: {sumB}");
            Console.WriteLine($"произведение всех элементов в массиве B: {productB}");
            Console.WriteLine($"Сумма четных элементов в массиве A: {sumEvenA}");
            Console.WriteLine($"Сумма нечетных столбцов в массиве B: {sumOddColumnsB}");
            Console.ReadKey();
        }
    }
}
using System;

namespace module03practice
{
    class Practice2
    {
        static void Main()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 3, 4, 5, 6, 7 };

            int[] c = new int[Math.Min(a.Length, b.Length)];

            int resultIndex = 0;

            foreach (int element in a)
            {
                if (Array.Exists(b, e => e == element) && !Array.Exists(c, e => e == element))
                {
                    c[resultIndex] = element;
                    resultIndex++;
                }
            }

            int[] result = new int[resultIndex];
            Array.Copy(c, result, resultIndex);

            Console.WriteLine("Общие элементы двух массивов без повторений:");
            foreach (int element in result)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }
    }
}

namespace module03practice
{
    internal class practice6
    {
        static void Main()
        {
            string text = Console.ReadLine();

            char ch = '\0';
            int count = 0;
            int maxCount = 0;

            foreach (char i in text)
            {
                if (i == ch)
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }

                    ch = i;
                    count = 1;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
            }

            if (maxCount > 1)
            {
                Console.WriteLine($"Наибольшее количество идущих подряд одинаковых символов: {maxCount}");
            }
            else
            {
                Console.WriteLine("error");
            }

            Console.ReadKey();
        }
    }
}

namespace module03practice
{
    internal class practice7
    {
        static void Main()
        {
            Console.WriteLine("Введите строку длиной 20 символов:");
            string input = Console.ReadLine();

            if (input.Length != 20)
            {
                Console.WriteLine("не имеет длину 20 символов.");
            }
            else
            {
                int digitCount = CountDigits(input);
                Console.WriteLine($"Количество цифр в строке: {digitCount}");
            }

            Console.ReadKey();
        }

        static int CountDigits(string input)
        {
            int digitCount = 0;

            foreach (char character in input)
            {
                if (char.IsDigit(character))
                {
                    digitCount++;
                }
            }

            return digitCount;
        }
    }
}
using System;

class practice9
{
    static void Main()
    {
        string input = Console.ReadLine();

        int wordCount = count(input);

        Console.WriteLine(wordCount);

        Console.ReadKey();
    }

    static int count(string input)
    {
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;

        foreach (string word in words)
        {
            if (word.Length >= 2 && word[0] == word[word.Length - 1])
            {
                count++;
            }
        }

        return count;
    }
}