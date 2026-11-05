/*
Chap 4 Summary Console Input and Output)
-This chapter introduced me to the Console class and its method for reading input and writing output.
-The main things i learned in this chapter:
1. What the Console is:
    I learned that the console is a class in the system namespace that provides methods for reading and writing data to the console window. It allows for interaction with the user through input and output operations.
2. I was also reminded of the windows console and how it is a command-line interface that allows users to interact with the operating system by typing commands and receiving text-based output.
3. Console Output and its methods:
    I learned about the different methods available in the Console class for writing output to the console window. These methods include Write, WriteLine, and WriteLine with formatting options. I also learned about the importance of using appropriate formatting to enhance the readability of the output.
4. Console Input and its methods:
    I learned about the different methods available in the Console class for reading input from the console window. These methods include Read, ReadLine, and ReadKey. I also learned about the importance of validating user input to ensure that it meets the expected format and requirements.
*/

//Chap 4 Summary (Console Input and Output

//This code summary consist of the application of what i have learned from chap 1 with console in put and output.

//1. Hypotenuse calculator

using System;

class Program
{
    static void Main(string[] args)
    {//Hypotenuse Calculator Program
        Console.WriteLine("Hypotenuse Calculator");
        Console.WriteLine("What is the length of the first side in CM?: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What is the length of the second side in CM?: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Your First side is " + num1 + "cm");
        Console.WriteLine("Your Second side is " + num2 + "cm");
        double hypotenuse = Math.Sqrt(Math.Pow(num1, 2) + Math.Pow(num2, 2));
        Console.WriteLine("The Hypotenuse is " + hypotenuse + "cm");

        Console.ReadKey();
    }
}

// 2. Shopping Cart Program

class ShoppingCart
{
    static void Main(string[] args)
    {
        Console.WriteLine("*********************");
        Console.WriteLine("Shopping Cart Program");
        Console.WriteLine("*********************");
        Console.WriteLine();
        Console.WriteLine("What item would you like to add? ");
        String item1 = Console.ReadLine();
        Console.WriteLine(item1 + " added to cart");
        Console.WriteLine();
        Console.WriteLine("What is the price of " + item1 + "? ");
        double price1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(item1 + " is $" + price1);
        Console.WriteLine("What item would you like to add again? ");
        String item2 = Console.ReadLine();
        Console.WriteLine(item2 + " added to cart");
        Console.WriteLine();
        Console.WriteLine("What is the price of " + item2 + "? ");
        double price2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(item2 + " is $" + price2);
        double total = (price1 + price2);
        Console.WriteLine("Your total for " + item1 + " and " + item2 + " is $" + total);

        Console.ReadKey();
    }
}
