using System;


class DataType  //DataType vaneko (class ho)
{
    void LearnDataTypes()  // 
    {
        
// Numbers (Signed(+/-) and unsigned(+))
        // 1. Intrgrals
        byte a = 34;
        short b = -4235;
        ushort b1 = 63453;
        int c = 32452542;
        uint c1 = 3253225;
        long d = 3452345235325645623;
        ulong d1 = 252352353252454533;

        // 2. Floating point numbers (Prcession)
        float e = 45.56879037493275928375297509f;
        double f = 3435.5672979879888667565645653;
        decimal g = 3245.454734987538957398773598798798357m;

        // 3. Text
        char h = 'F';
        string greet = "Hello!";

        // 4. Boolean
        bool isMale = true;

        // 5. Datetime
        DateTime updatedTimeInAirport;  //camel casing
        DateOnly dob;
        TimeOnly arrivalTime;

        // Variables naming - camel casing
        // pascal casing - folders, Files, classes, methods etc.

        // Nullables
        int? score = null;
        score = 343245;
        float? x = 3453;
        x = null;

        // var
        var age = 19;
        var name = "Ashok Dhakal";
     
    }
}


//using System;
//class DataType  //Here class datatype is class ie ( any thing , class (''''') inside () is class)
//{
//    static void Main() //  void LearnDataTypes() //  This Lines define new method named "LearnDataTypes"       
//    // void matra rakhyo vane print gardeina tara void to tahu ma static void  learnDataTypes garyo vaney print garxha
//    {
//    // Here we are going to learn about diffferent types of data we can use in c#.
//
//    // Numbers (signed(+/-) and unsigned(+))
//    // We can store different  types pf numbers in varibales, depending on how big or small they are.
//      byte a = 32; // This vaiable can store numbers between 0 to 255.
//      short b = -4235; // This varaiable can store numbers betewwn -32768 and 32767
//      ushort b1= 63453; //This cariable can store numbers between 0 and 65535.
//      int c = 32452542;  // This variable can store numbers between -2147483648 and 2147483647.
//      uint c1 = 3253225;  // This variable can store numbers between 0 and 4294967295.
//      long d = 3452345235325645623;  // This variable can store very big or very small numbers.
//      ulong d1 = 252352353252454533;  // This variable can store very big numbers.
//      
//
//
//    //2>. Floating point numbers (Precision)
//    // We can also store decimal nummbers in this variables, with varying levels of precision.
//      float e = 45.56879037493275928375297509f;  // This variable can store decimal numbers with 7 digits of precision.
//      double f = 3435.5672979879888667565645653;  // This variable can store decimal numbers with 15-16 digits of precision.
//      decimal g = 3245.454734987538957398773598798798357m;  // This variable can store decimal numbers with a lot of digits of precision.
//      
//    //3>. Text
//      char h ='F'; //This variable can store a single character , like a letter or a number.
//      string greet = "Hello!"; // This variable can store a bunch of charcters, like a word or a whole sentence.
//
//    //4>. Boolean 
//      bool isMale = true; // This variable is used to store a value of true or false.
//
//    //5>. DateTime
//      DateTime updatedTimeInAirort; // This variable can store  a date and time, like when a panes arrives and departure time at an airport
//      DateOnly dob; // This variable can store a date, like your birthday.
//      TimeOnly arrivalTime; // This variable can store a time, like when your favourite Tv show starts.
//
//    //Variable naming - camel casing
//    //pascal casing - folders, files classes, methoss, etc.
//
//    // Nullables
//       int? score = null;  // This variable can store a number or nothing at all.
//       score = 343245;  // Now the variable has a value.
//       float? x = 3453;  // This variable can store a decimal number or nothing at all.
//       x = null;  // Now the variable has no value.
//
//    // var
//        var age = 19;  // This variable can store a number, and C# will figure out what type of number it is.
//        var name = "Ashok Dhakal";  // This variable can store a bunch of characters, and C# will figure out that it's a string.
//     
//    // Printing the values of the variables to the console
//         Console.WriteLine("byte a = " + a); //The '+' sign is used to concatenate(=LOL!=) (join together) the text and the variable values into a single string that can be printed to the console.
//    //For example, the line Console.WriteLine("byte a = " + a); will print the text "byte a =" followed by the value of the variable a.
//         Console.WriteLine("short b = " + b);
//         Console.WriteLine("ushort b1 = " + b1);
//         Console.WriteLine("int c = " + c);
//         Console.WriteLine("uint c1 = " + c1);
//         Console.WriteLine("long d = " + d);
//         Console.WriteLine("ulong d1 = " + d1);
//         Console.WriteLine("Float e = " + e);
//         Console.WriteLine(" double f =" + f);
//         Console.WriteLine(" decimal g = "+ g);
//         Console.WriteLine("char h = " + h);
//         Console.WriteLine(" string greet = " + greet);
//         Console.WriteLine("bool isMale = " + isMale);
//         Console.WriteLine("int? score = " + score);
//         Console.WriteLine("float? x = " +x );
//         Console.WriteLine("var age = " + age);
//         Console.WriteLine(" var name = " + name);
//    }
//}
///////////////////////////////////////////-----------------------------------------------------------------------------\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
// // using System;
// //  class DataType
//  {
//     static void Main()
//     {
//         //The main method is the entry point of program and the first method to be executed when the program runs.
//         //We use 'Console.Writeline()' to print the text to the console.
//         Console.WriteLine("Hello, World!");

//         // We can also use variable to store data.
//         string  name = "Ishan";
//         int age = 20;
//         double height  = 1.75;
        
//         // We can use string interpolation to combine text and variables.
//         Console.WriteLine($"My name is {name}, I am {age} years old, and I am {height} in meters.");

//         // We can also perform calculations using variables.
//         int x= 5;
//         int y= 3;
//         int sum = x+y;
//         int difference =x-y;
//         int product = x*y;
//         int quotient = x/y;

//         // We can print the results of the various calcualtions using 'Console.Writeline()'.
//         Console.WriteLine($"The sum of {x} and {y} is {sum}.");
//         Console.WriteLine($"The difference between {x} and {y} is {difference}.");
//         Console.WriteLine($"The product of {x} and {y} is {product}.");
//         Console.WriteLine($"The quotient of {x} and {y} is {quotient}.");

//        // We can also use 'if' statment to consitionally execute code.
//        bool isRaining = true;
//        if (isRaining)
//        {
//            Console.WriteLine("Remember to bring an umbrella!");
//        } 
//        else
//        {
//            Console.WriteLine("Enjoy Sunshine!");
//        }

//         bool isFailed = false;
//         if (isFailed)
//         {
//             Console.WriteLine("Our experiemet has failed.");
//         }
//        else
//         {
//             Console.WriteLine("We have created something which will be one of the best invention for Human Mankind.");
//         }

//         // Finally, we can use 'Console.Readline()' to read input/or take input from the user.
//         Console.WriteLine("What is your name, buddy?");
//         string inputName = Console.ReadLine();
//         Console.WriteLine($"Hello, {inputName}!");
       
//        // This program will exit automitacially once it reaches the end of the  'Main()' method.


//     }
//  }