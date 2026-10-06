namespace Task5;

class Program
{
        static void Main()
        {
            // Create a DateTime variable for the birthdate
            // Change this date to your actual birthdate
            DateTime birthDate = new DateTime(2006, 4, 22);

            // Create a DateTime variable for the current date and time
            DateTime currentDate = DateTime.Now;

            // Calculate the difference between the current date and the birthdate using TimeSpan
            TimeSpan ageDifference = currentDate - birthDate;

            //  Calculate the age in years
            int age = (int)(ageDifference.TotalDays / 365.25);

            // Print the birthdate
            Console.WriteLine("Birthdate: " + birthDate.ToString("dd/MM/yyyy"));

            // Print the current date and time
            Console.WriteLine("Current Date and Time: " + currentDate);

            //  Print the age
            Console.WriteLine("Age: " + age + " years");

            // Add 10 days to the birthdate
            DateTime dateAfter10Days = birthDate.AddDays(10);

            // Print the resulting date
            Console.WriteLine(
                "Birthdate after adding 10 days: " +
                dateAfter10Days.ToString("dd/MM/yyyy")
            );
        }
    }
