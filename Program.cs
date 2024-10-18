using System;

class Program
{
    static void Main()
    {
        const int daysInWeek = 7;
        double[] temperatures = new double[daysInWeek];
        double sum = 0;

        for (int i = 0; i < daysInWeek; i++)
        {
            Console.Write($"Adja meg a(z) {i + 1}. napi hőmérsékletet (°C): ");
            while (!double.TryParse(Console.ReadLine(), out temperatures[i]))
            {
                Console.WriteLine("Érvényes hőmérsékletet adj meg!");
            }
            sum += temperatures[i];
        }

        double averageTemperature = sum / daysInWeek;

        double maxTemperature = temperatures[0];
        double minTemperature = temperatures[0];
        bool hasFrostDay = false;

        for (int i = 1; i < daysInWeek; i++)
        {
            if (temperatures[i] > maxTemperature)
                maxTemperature = temperatures[i];

            if (temperatures[i] < minTemperature)
                minTemperature = temperatures[i];

            if (temperatures[i] < 0)
                hasFrostDay = true;
        }


        Console.WriteLine($"A hét átlaghőmérséklete: {averageTemperature:F2} °C");
        Console.WriteLine($"A legmelegebb nap hőmérséklete: {maxTemperature} °C");
        Console.WriteLine($"A leghidegebb nap hőmérséklete: {minTemperature} °C");

        if (hasFrostDay)
        {
            Console.WriteLine("Fagypont alatti nap is volt!");
        }
    }
}