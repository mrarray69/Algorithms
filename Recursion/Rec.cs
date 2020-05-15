using System;

namespace Recursion
{
    public static class Rec
    {

        private static int totalDeff(int[] sensorA, int[] sensorB, int size)
        {

            int diff = 0;
            for (int i = 0; i < size; i++)
            {
                diff += sensorA[i] - sensorB[i];
            }

            return diff;
        }

        public static int totalDiffDispacher(int[] sensorA, int[] sensorB, int size)
        {
            if (size == 0) return 0;
            int lastElementDiff= sensorA[size-1] - sensorB[size-1];
            int diff = totalDeff(sensorA, sensorB, size - 1) + lastElementDiff;
            return diff;
            //return totalDiffDispacher(sensorA, sensorB, size - 1) + lastElementDiff; 

        }

        public static int PrintNumbers(int lastNum,int records,bool reverse)
        {
            if (!reverse)
            {
                if (lastNum == 0) return 0;

                lastNum--;
                    Console.WriteLine(records-lastNum);
                    

            }
            else
            {
                if (lastNum == 0) return 0;

                Console.WriteLine(lastNum);
                lastNum--;
            }


            return PrintNumbers(lastNum, records, reverse);
        }
    }
}