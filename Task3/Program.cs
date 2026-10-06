namespace Task3;

class Program
{
    static void Main()
    {
        // Declare variables of different data types

        byte byteValue = 10;
        short shortValue = 1000;
        int intValue = 42;

        long longValue = 100000L;

        float floatValue = 3.14f;

        double doubleValue = 3.14159;

        decimal decimalValue = 99.99m;

        char charValue = 'A';

        bool boolValue = true;
        
        
        //Convert the integer value 42 to a string
        string intToString = intValue.ToString();


            // Convert the string "3.14" to a double

            string numberString = "3.14";

            double stringToDouble = Convert.ToDouble(numberString);


            // Print all variables with their types and values

            Console.WriteLine("Data Types and Values");
            Console.WriteLine("---------------------");

            Console.WriteLine("byte    : Type = " + byteValue.GetType().Name +
                              ", Value = " + byteValue);

            Console.WriteLine("short   : Type = " + shortValue.GetType().Name +
                              ", Value = " + shortValue);

            Console.WriteLine("int     : Type = " + intValue.GetType().Name +
                              ", Value = " + intValue);

            Console.WriteLine("long    : Type = " + longValue.GetType().Name +
                              ", Value = " + longValue);

            Console.WriteLine("float   : Type = " + floatValue.GetType().Name +
                              ", Value = " + floatValue);

            Console.WriteLine("double  : Type = " + doubleValue.GetType().Name +
                              ", Value = " + doubleValue);

            Console.WriteLine("decimal : Type = " + decimalValue.GetType().Name +
                              ", Value = " + decimalValue);

            Console.WriteLine("char    : Type = " + charValue.GetType().Name +
                              ", Value = " + charValue);

            Console.WriteLine("bool    : Type = " + boolValue.GetType().Name +
                              ", Value = " + boolValue);


            // Print converted values

            Console.WriteLine();
            Console.WriteLine("Type Conversion");
            Console.WriteLine("----------------");

            Console.WriteLine("Integer 42 to String : Type = " +
                              intToString.GetType().Name +
                              ", Value = " + intToString);

            Console.WriteLine("String \"3.14\" to Double : Type = " +
                              stringToDouble.GetType().Name +
                              ", Value = " + stringToDouble);
        }
    }

