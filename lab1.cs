using System;
namespace ConsoleApp1
{
    class Program
    {
        public class HW1
        {
            public static long QueueTime(int[] customers,int n)
            {
                int[] A = new int[n];
                for (int i = 0; i <n; i++)
                {
                    A[i] = customers[i];
                }
                
                for (int i=n;i<customers.Length;i++)
                {
                    int minValue = A[0];
                    int k=0;
                    for ( int j=0 ; j < n; j++)
                    {
                        if(A[j]<minValue)
                        {
                            minValue = A[j];
                            k = j;
                        }
                        
                    }
                    A[k] += customers[i];
                }
                int maxValue = A[0];
                for (int j = 0; j < n; j++)
                {
                    if (A[j] > maxValue)
                    {
                        maxValue = A[j];
                    }
            
                }
                Console.WriteLine(maxValue);
                return 0;
            }
        }

        static void Main(string[] args)
        {
            int[] Array = { 5, 3, 4 };
            HW1.QueueTime(Array, 1);

            int[] Array2= {10,2,3,3 };
            HW1.QueueTime( Array2,2);

            int[] Array3 = { 2,3, 10 };
            HW1.QueueTime(Array3, 2);
        }
    }
}
