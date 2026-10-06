namespace Task4;

class Program
{
        static void Main()
        {
            // Create a single-dimensional integer array containing 5 favorite numbers
            int[] favoriteNumbers = { 7, 3, 9, 2, 5 };

            // Display the original array
            Console.WriteLine("Original Array:");

            for (int i = 0; i < favoriteNumbers.Length; i++)
            {
                Console.WriteLine(favoriteNumbers[i]);
            }


            // 2. Sort the array in ascending order
            Array.Sort(favoriteNumbers);

            Console.WriteLine();
            Console.WriteLine("Array after sorting in ascending order:");

            for (int i = 0; i < favoriteNumbers.Length; i++)
            {
                Console.WriteLine(favoriteNumbers[i]);
            }


            // 3. Reverse the sorted array
            Array.Reverse(favoriteNumbers);

            Console.WriteLine();
            Console.WriteLine("Array after reversing:");

            for (int i = 0; i < favoriteNumbers.Length; i++)
            {
                Console.WriteLine(favoriteNumbers[i]);
            }


            // 4. Print each element using a for loop
            Console.WriteLine();
            Console.WriteLine("Elements of the final array:");

            for (int i = 0; i < favoriteNumbers.Length; i++)
            {
                Console.WriteLine("Element at index " + i + ": " + favoriteNumbers[i]);
            }


            // 5. Use Array.IndexOf() to find the position
            // of a specific number
            int numberToFind = 5;

            int position = Array.IndexOf(favoriteNumbers, numberToFind);

            Console.WriteLine();
            Console.WriteLine("Searching for number: " + numberToFind);

            if (position != -1)
            {
                Console.WriteLine(
                    "The number " + numberToFind +
                    " is found at index: " + position
                );
            }
            else
            {
                Console.WriteLine(
                    "The number " + numberToFind +
                    " was not found in the array."
                );
            }
        }
    }
