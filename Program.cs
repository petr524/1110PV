namespace _1110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateRandomNumbers(10, 1, 100);

            double average = CalculateAverage(numbers);
            Console.WriteLine($"Aritmetický průměr: {average}");

            int min = FindMinimum(numbers);
            Console.WriteLine($"Nejmenší číslo: {min}");

            int divisor = 5;
            int divisibleCount = CountDivisibleBy(numbers, divisor);
            Console.WriteLine($"Počet čísel dělitelných {divisor}: {divisibleCount}");
        }

        static int[] GenerateRandomNumbers(int count, int min, int max)
        {
            Random random = new Random();
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(min, max + 1);
            }
            return numbers;
        }

        public static double CalculateAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return (double)sum / numbers.Length;
        }

        public static int FindMinimum(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        public static int CountDivisibleBy(int[] numbers, int divisor)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number % divisor == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}