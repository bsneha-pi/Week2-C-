
namespace Task6
{
    class Program
    {
        static void Main()
        {
            
            // Create a List<string> containing 3 favorite fruits
            List<string> fruits = new List<string>()
            {
                "Mango",
                "Apple",
                "Banana"
            };

            // Display the original list
            Console.WriteLine("Original Fruits:");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }


            
            // Add a new fruit to the list
            fruits.Add("Orange");

            Console.WriteLine();
            Console.WriteLine("After adding a new fruit:");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            

            // Remove one fruit from the list
            fruits.Remove("Banana");

            Console.WriteLine();
            Console.WriteLine("After removing Banana:");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }


            
            Console.WriteLine();
            Console.WriteLine("Final Fruit List:");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }


            

            // Create a Dictionary<int, string>
            // Key = Fruit ID
            // Value = Fruit Name

            Dictionary<int, string> fruitDictionary =
                new Dictionary<int, string>()
                {
                    { 1, "Mango" },
                    { 2, "Apple" },
                    { 3, "Banana" }
                };


            
            // Add a new fruit with ID 4
            fruitDictionary.Add(4, "Orange");


            
            // PRINT ALL KEY-VALUE PAIRS
            Console.WriteLine();
            Console.WriteLine("Fruit Dictionary:");

            foreach (KeyValuePair<int, string> item in fruitDictionary)
            {
                Console.WriteLine(
                    "Fruit ID: " + item.Key +
                    ", Fruit Name: " + item.Value
                );
            }
        }
    }
}