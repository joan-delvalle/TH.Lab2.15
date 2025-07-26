using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.Lab2._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sliding Window Sum Calculator ===");

                List<int> numbers = new List<int>();
                Console.WriteLine("Enter at least 10 integers:");
                while (numbers.Count < 10)
                {
                    Console.Write($"Number #{numbers.Count + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        numbers.Add(num);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                    }
                }

                int k;
                while (true)
                {
                    Console.Write("Enter sliding window size (k): ");
                    if (int.TryParse(Console.ReadLine(), out k) && k > 0 && k <= numbers.Count)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input. k must be a positive integer and ≤ number of elements.");
                }

                Console.WriteLine($"\n--- Sliding Window Sums (Window Size = {k}) ---");

                for (int i = 0; i <= numbers.Count - k; i++)
                {
                    int sum = 0;
                    Console.Write($"Window {i + 1} (");
                    for (int j = i; j < i + k; j++)
                    {
                        sum += numbers[j];
                        Console.Write(numbers[j]);
                        if (j < i + k - 1)
                            Console.Write(", ");
                    }
                    Console.WriteLine($") → Sum = {sum}");
                }
            
        }
    }

}
