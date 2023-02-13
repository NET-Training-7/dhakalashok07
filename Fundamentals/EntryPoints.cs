using System;

using EmployeeDetails;
// MethodLearning obj = new();
// obj.Display();

// MethodLearning obj1 = new();
// Console.WriteLine(obj1.SumOfSquare(12,34,12,33,4));


// obj.Display("Hello");
// obj.Display("Welcome");

// obj.Add(4.6f, 5.9f);
// obj.Add(43.6f, 75.9f);
// obj.Add(1214.6f, 55.49f);

// string s = obj.Greet();
// Console.WriteLine(s);

//Phone phone1 = new();
//phone1.Brand = "samsung";
//phone1.Model = "S 22";
//phone1.ReleaseDate = new DateTime(2022, 12, 12);
//
// string today = obj.GetDay();
// Console.WriteLine(today);

// float f = 12.3f, se = 45.5f, t = 234.4f;
// var sum = obj.Add(f, se, t);
// Console.WriteLine($"{f} + {se} + {t} = " + sum);

// var p = obj.Multiply(456.4, 23.22, 3456.45f);
// var p1 = obj.Multiply(456.4, 23.22f);
// Console.WriteLine("The use of Multiplying method." + p + "\n" + p1);

// var m2 = obj.SumOfSquare(123.32, 1243, 12.23);
// Console.WriteLine("The use of params arguments " + m2);

// //Named Arguments

// var p5 = obj.Multiply(z: 345.2, y: 234.2, x: 23.2);
// Console.WriteLine("The named arguments value: " + p5);
// var p6 = obj.Divide(23.55f, 2.1f);

// int mini = obj.CheckMinimum(12, 3, 4, 11, 1, 2, 4);
// Console.WriteLine(mini);

// (int, int) minmax = obj.CheckMinMax(12, 23, 2, 1, 56, 657, 43, 89, 2);
// Console.WriteLine("Tuple returned value " + minmax);

// Test test1 = new();

//Methods_Asssignments obj = new();

//double m1 = obj.CalculateProductOfSquare(2, 3);
//Console.WriteLine("The product of square of two supplied number is " + m1);

//double m2 = obj.CalculateCubeRoot(23);
//Console.WriteLine("The cuberoot of given number is " + m2);


//float m3 = obj.CalculateBMI(48, 5.6f);
//Console.WriteLine("The BMI index of a person by giving weight as 62 Kg and height of 1.7 m is " + m3);

//var car1 = new CombustionEngine("Car", "Nexon", "Tata", 4, "BA.33.PA 234", 1500f);

//car1.PrintDetails();
//var flight1 = new FirstClassFlight("AI-101", "New York", "London", new DateTime(2023, 2, 10, 9, 30, 0), "America");
//flight1.Book();

//var flight2 = new InternationalFlight("AI-102", "New York", "Paris", new DateTime(2023, 2, 11, 11, 0, 0), "Canada");
//flight2.DisplayFlightDetails();
            Employee employee = new Employee();
            employee.EmployeeId = "A001";
            employee.Name = "Ram Acharya";
            employee.Salary = 50000;
            employee.Department = "IT";

            Console.WriteLine("Employee Details: ");
            Console.WriteLine("Employee ID: " + employee.EmployeeId);
            Console.WriteLine("Name: " + employee.Name);
            Console.WriteLine("Salary: " + employee.Salary);
            Console.WriteLine("Department: " + employee.Department);

            Employee.PrintEmployeeDetails(employee);