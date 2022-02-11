using System;

namespace testTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gas = new int[5] { 1, 2, 3, 4, 5 };
            int[] cost = new int[5] { 3, 4, 5, 1, 2 };

            Console.WriteLine(GetStartPosition(gas, cost));
        }

        static int GetStartPosition(int[] gas, int[] cost)
        {
            if (gas.Length != cost.Length || gas.Length == 0)
                return -1;

            int n = gas.Length;
            int[] dif = new int[n];
            for (int i = 0; i < n; i++)
                dif[i] = gas[i] - cost[i];

            for (int start = 0; start < n; start++)
            {
                if (dif[start] >= 0)
                {
                    int tank = 0;
                    int i = 0;
                    for (; i < n; i++)
                    {
                        tank += dif[(start + i) % n];
                        if (tank < 0)
                            break;
                    }
                    if (i == n)
                        return start;
                }
            }
            return -1;
        }
    }
}
