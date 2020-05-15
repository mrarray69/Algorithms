using System;

namespace Recursion
{
    public static class Countdown
    {
        public static void fncCountdown(int i)
        {
            Console.WriteLine(i);

            // base case
            if (i <= 0) return;

            // recursive case
            fncCountdown(i - 1);
        }

    }
}