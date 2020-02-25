using System;

namespace _01._Biscuits_Factory
{
    class Program
    {
        static void Main()
        {
            int biscPerDayOneWorker = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());
            int compFactoryBisc = int.Parse(Console.ReadLine());

            int sumBiscuits = 0;
            for (int i = 1; i <= 30; i++)
            {
                double currDayBisc = biscPerDayOneWorker * countWorkers;
                if (i % 3 ==0)
                {
                    currDayBisc = Math.Floor(currDayBisc * 0.75);
                }
                sumBiscuits += (int)currDayBisc;
            }
            Console.WriteLine($"You have produced {sumBiscuits} biscuits for the past month.");

            double diff = sumBiscuits - compFactoryBisc;
            double percentage = diff / compFactoryBisc * 100;

            if (diff > 0)
            {
                Console.WriteLine($"You produce {percentage:F2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {Math.Abs(percentage):F2} percent less biscuits.");
            }
        }
    }
}
