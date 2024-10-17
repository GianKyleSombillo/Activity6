using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a positive integer
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());

        // Initialize counters for odd and even numbers
        int oddCount = 0;
        int evenCount = 0;

        // Loop through numbers from 1 to n
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                evenCount++;  // It's even
            }
            else
            {
                oddCount++;   // It's odd
            }
        }

        // Display the counts
        Console.WriteLine($"Odd: {oddCount}, Even: {evenCount}");
    }
}
