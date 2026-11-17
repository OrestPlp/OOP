namespace LAB_2;

class Program
{
    static void Main()
    {
        int[][] groups =
        {
            new int[] { 90, 85, 76, 92, 88 },
            new int[] { 70, 65, 80, 95, 75, 83 },
            new int[] { 60, 72, 89, 91 }
        };

        double totalSum = 0;
        double totalCount = 0;

        int totalMin = groups[0][0];
        int totalMax = groups[0][0];

        for (int i = 0; i < groups.Length; i++)
        {
            double sum = 0;
            int min = groups[i][0];
            int max = groups[i][0];

            foreach (int mark in groups[i])
            {
                sum += mark;

                if (mark < min)
                    min = mark;

                if (mark > max)
                    max = mark;
            }

            double average =  sum / groups[i].Length;

            Console.WriteLine($"Група {i + 1}:");
            Console.WriteLine($"Середній бал: {average}");
            Console.WriteLine($"Мінімальний бал: {min}");
            Console.WriteLine($"Максимальний бал: {max}");
            Console.WriteLine();

            totalSum += sum;
            totalCount += groups[i].Length;

            if (min < totalMin)
                totalMin = min;

            if (max > totalMax)
                totalMax = max;
        }

        double totalAverage = totalSum / totalCount;

        Console.WriteLine("Потік:");
        Console.WriteLine($"Середній бал: {totalAverage}");
        Console.WriteLine($"Мінімальний бал: {totalMin}");
        Console.WriteLine($"Максимальний бал: {totalMax}");
    }
}