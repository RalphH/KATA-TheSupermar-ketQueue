using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TheSupermarketQueue
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine(QueueTime(new int[] { 10, 2, 3, 3 }, 2).ToString());
            //Console.WriteLine(QueueTime(new int[] { 1, 2, 3, 4 }, 1).ToString());
        }

        public static long QueueTime(int[] customers, int n)
        {            
            // customers: an array of positive integers representing the queue. Each integer represents a customer, and its value is the amount of time they require to check out.
            // n: a positive integer, the number of checkout tills.

            // There is only ONE queue serving many tills, and
            // The order of the queue NEVER changes, and
            // The front person in the queue(i.e.the first element in the array/ list) proceeds to a till as soon as it becomes free.            

            List<int> tills = new List<int>();
            for (int i = 0; i < n; i++) {
                tills.Add(0);
            }

            foreach (int customer in customers)
            {
                Console.WriteLine(customer);
                Console.WriteLine(tills.Min());
                tills[tills.IndexOf(tills.Min())] = tills.Min() + customer;
                Console.WriteLine(tills.Min());
            }                  

            return tills.Max();
        }

    }
}
