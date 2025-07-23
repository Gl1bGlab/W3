using System;
using System.IO;
using System.IO.Enumeration;

namespace w3
{
    

    class W3Notes
    {
        static public void Nerd()
        {
            File.Delete("filename.txt");
            bool fileExist = File.Exists("filename.txt");
            Console.WriteLine(fileExist);
            string writeText = "Hello World!";
            File.WriteAllText("filename.txt", writeText);
            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);
            fileExist = File.Exists("filename.txt");
            Console.WriteLine(fileExist);
        }
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            //Nerd();


            //                                                                                          Auto Casting
            /*int myInt = 9;
            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);


            //                                                                                          Manual Casting
            /*float myNum = 35e-3f;
            int myNums = (int) myNum;
            Console.WriteLine(myNum);
            Console.WriteLine(myNums);*/


            //                                                                                          Type Conversion
            /*int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string*/


            //                                                                                          User Input
            /*Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);*/


            //                                                                                          Math Class
            /*Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Round(9.99));*/


            //                                                                                          String Properties/Methods
            /*string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());*/


            //                                                                                          String Cocatenation
            /*string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);

            or

            string firstName = "John ";
            string lastName = "Doe";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            or

            //String Interpolation
            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);*/


            //                                                                                          Access Strings
            /*string myString = "Hello";
            Console.WriteLine(myString[0]);

            string myString = "Hello";
            Console.WriteLine(myString[1]);

            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));

            string name = "John Doe";
            // Location of the letter D
            int charPos = name.IndexOf("D");
            // Get last name
            string lastName = name.Substring(charPos);
            // Print the result
            Console.WriteLine(lastName);*/


            //String Special Characters
            /*"\\"
            "\""
            "\'"
            "\n" (new line)
            "\b" (backspace)
            "\t" (tab)*/


            //                                                                                          Conditionals
            /*else if - Specifies a new condition if the previous was false
            

            Shorthand if else - Used to write an if else statement in one line

            Syntax - variable = (condition) ? expressionTrue :  expressionFalse;

            ex: int time = 20;
            if (time < 18) 
            {
              Console.WriteLine("Good day.");
            } 
            else 
            {
              Console.WriteLine("Good evening.");
            }
            Becomes
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);


            switch - Used to select one of many cases to be executed

            default - Runs if none of the cases did, basically an else

            Syntax - switch(expression) 
            {
              case x:
                // code block
                break;
              case y:
                // code block
                break;
              default:
                // code block
                break;
            }

            ex: int day = 4;
            switch (day) 
            {
              case 6:
                Console.WriteLine("Today is Saturday.");
                break;
              case 7:
                Console.WriteLine("Today is Sunday.");
                break;
              default:
                Console.WriteLine("Looking forward to the Weekend.");
                break;
            }*/


            //                                                                                          Loops
            /*while - Loops as long as a condition is true
            
            Syntax - while (condition) {
              // code block
            }

            ex - int i = 0;
            while (i < 5) 
            {
              Console.WriteLine(i);
              i++;
            }


            do/while - While loop that executes once before the condition

            Syntax - do 
            {
              // code block
            }
            while (condition)

            ex - int i = 0;
            do 
            {
              Console.WriteLine(i);
              i++;
            }
            while (i < 5);


            for - Loop that executes a predetermined amount of times

            Syntax - for (statment 1; statment 2; statment 3;)
            {
              // code block
            }

            statment 1 - Executed once before the code
            statment 2 - Condition for the code block to stop looping
            statment 3 - Executed once every time the block loops

            ex - for (int i = 0; i < 5; i++) 
            {
              Console.WriteLine(i);
            }


            foreach - Loops through elements in a data set

            Syntax - foreach (type variableName in arrayName) 
            {
              // code block
            }

            ex - string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string i in cars) 
            {
              Console.WriteLine(i);
            }


            break - Skips the rest of the switch block or loop
            continue - Skips the rest of the iteration of a loop*/


            //                                                                                          Arrays
            /*string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);

            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            Console.WriteLine(cars.Length);
            
            //Instantiation Methods
            string[] cars = new string[4];
            string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};
            string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

            //Array Sorting
            Array.Sort(cars);
            foreach (string i in cars)
            {
              Console.WriteLine(i);
            }

            int[] myNumbers = {5, 1, 8, 9};
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
              Console.WriteLine(i);
            }

            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            //Multi - Dimentional
            int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
            Console.WriteLine(numbers[0, 2]);

            int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
            numbers[0, 0] = 5;
            Console.WriteLine(numbers[0, 0]);

            int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
            for (int i = 0; i < numbers.GetLength(0); i++) 
            { 
              for (int j = 0; j < numbers.GetLength(1); j++) 
              { 
                Console.WriteLine(numbers[i, j]); 
              } 
            }*/


            //                                                                                          Methods
            /*class Program
            {
              static void MyMethod() 
              {
                // code to be executed
              }
            }
            
            Perameters - Variables specific to methods
            Argument - The value assigned to the parameter
            Optional Perameter - If you set the value of the perameter in the method, you don't need an argument for it
            void - Indicates a method won't return any value
            return - Indicates what value a method will return

            Named Arguments - By declaring the name of each perameter in the argument, any order can be used
            ex: static void MyMethod(string child1, string child2, string child3) 
            {
              Console.WriteLine("The youngest child is: " + child3);
            }
            static void Main(string[] args)
            {
              MyMethod(child3: "John", child1: "Liam", child2: "Liam");
            }

            Method Overloading - Declaring multiple methods with the same name
            static int PlusMethod(int x, int y)
            {
              return x + y;
            }
            static double PlusMethod(double x, double y)
            {
              return x + y;
            }
            static void Main(string[] args)
            {
              int myNum1 = PlusMethod(8, 5);
              double myNum2 = PlusMethod(4.3, 6.26);
              Console.WriteLine("Int: " + myNum1);
              Console.WriteLine("Double: " + myNum2);
            }*/


            //                                                                                          OOP Basics
            /*
            Object-Oriented Programming is focused on making code more reuseable and clear
            Class - A template for an object
            ex: class Car 
            {
              string color = "red";
            }
            Variables declared in a class are called a field or attribute
            The file name and class name should match for readability
            Feilds and methods inside classes are called class members, they are called with .
            Feilds can be left blank in the class and initialized in the object, allowing more variation

            Object - A consistant block of data that has a class
            ex: Car myObj = new Car();

            public - An access modifier that allows objects of the class to call the method
            static - An access modifier that allows the method to be called without an object

            Using Multiple Classes - People usually make one class for feilds and methods and another for execution
            ex: class Car 
            {
              public string model;
              public string color;
              public int year;
              public void fullThrottle()
              {
                Console.WriteLine("The car is going as fast as it can!"); 
              }
            }

            class Program
            {
              static void Main(string[] args)
              {
                Car Ford = new Car();
                Ford.model = "Mustang";
                Ford.color = "red";
                Ford.year = 1969;

                Car Opel = new Car();
                Opel.model = "Astra";
                Opel.color = "white";
                Opel.year = 2005;

                Console.WriteLine(Ford.model);
                Console.WriteLine(Opel.model);
              }
            }*/


            //                                                                                          Constructors
            /*Constructors are methods that make object creation much more efficient
            These are created automatically, but can only be edited by creating one manually
            class Car
            {
              public string model;
              public string color;
              public int year;

              public Car(string modelName, string modelColor, int modelYear)
              {
                model = modelName;
                color = modelColor;
                year = modelYear;
              }

              static void Main(string[] args)
              {
                Car Ford = new Car("Mustang", "Red", 1969);
                Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
              }
            }


            */


            //                                                                                          Bubble Sort (Found online)
            /*int[] NumArray = {1, 2, 3, 3, 4, 5, -1, 0, 56, 12356, 10, -10};
            void SortArray()
            {
                var n = NumArray.Length;
                bool swapRequired;
                for (int i = 0; i < n - 1; i++) 
                {
                    swapRequired = false;
                    for (int j = 0; j < n - i - 1; j++)
                        if (NumArray[j] > NumArray[j + 1])
                        {
                            var tempVar = NumArray[j];
                            NumArray[j] = NumArray[j + 1];
                            NumArray[j + 1] = tempVar;
                            swapRequired = true;
                        }
                    if (swapRequired == false)
                        break;
                }
                foreach (int x in NumArray)
                    Console.WriteLine(x);
            }
            SortArray();*/


            //                                                                                              Access Modifiers
            /*Access Modifiers are used to set access level/visibility for classes, fields, methods and properties
            public - The code is accessible for all classes
            private	- The code is only accessible within the same class
            protected - The code is accessible within the same class, or in a class that is inherited from that class
            internal - The code is only accessible within its own assembly, but not from another assembly
            protected internal -  
            private protected - 
            All members are private by defualt

            Ecapsulation - The process of making sure sensitive data is hidded from users

            
            //Properties
            Like a combination of a feild and a method, used to access private variables
            get - Returns the value of a variable
            set - Sets the value of a variable
            If a property only has get, it is readonly
            If it only has set, it is writeonly
            class Person
            {
              private string name; // field
              public string Name   // property
              {
                get { return name; }   // get method
                set { name = value; }  // set method
              }
            }
            class Program
            {
              static void Main(string[] args)
              {
                Person myObj = new Person();
                myObj.Name = "Liam";
                Console.WriteLine(myObj.Name);
              }
            }
            Shorthand: 
            public string Name
             { get; set; }*/


            //                                                                                              Inheritance
            /*Derived Class (Child) - The class that inherits another
            Base Class (Parent) - The class that is inherited

            Classes are inherited with the : symbol
            class Vehicle
            {
              public string brand = "Ford";
              public void honk()
              {                    
                Console.WriteLine("Tuut, tuut!");
              }
            }
            class Car : Vehicle
            {
              public string modelName = "Mustang";
            }
            class Program
            {
              static void Main(string[] args)
              {
                Car myCar = new Car();
                myCar.honk();
                Console.WriteLine(myCar.brand + " " + myCar.modelName);
              }
            }

            Sealed - A class keyword that prevents it from being inherited


            //Polymorphism
            Polymorphism is the process of using parent methods for different tasks in multiple child classes

            virtual - Keyword allowing a method to be overwritten
            override - Overrides a virtal method of the same name

            class Animal
            {
              public virtual void animalSound() 
              {
                Console.WriteLine("The animal makes a sound");
              }
            }
            class Pig : Animal
            {
              public override void animalSound() 
              {
                Console.WriteLine("The pig says: wee wee");
              }
            }
            class Dog : Animal
            {
              public override void animalSound() 
              {
                Console.WriteLine("The dog says: bow wow");
              }
            }
            class Program 
            {
              static void Main(string[] args) 
              {
                Animal myAnimal = new Animal();
                Animal myPig = new Pig();
                Animal myDog = new Dog();
                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();
              }
            }

            //Abstraction
            The process of hiding certain detials from the user
            Abstract Class - A class that can't create objects
            Abstract Method - A method with no body that can only be declared in abstract classes

            abstract class Animal
            {
              public abstract void animalSound();
              public void sleep()
              {
                Console.WriteLine("Zzz");
              }
            }
            class Pig : Animal
            {
              public override void animalSound()
              {
                Console.WriteLine("The pig says: wee wee");
              }
            }
            class Program
            {
              static void Main(string[] args)
              {
                Pig myPig = new Pig();
                myPig.animalSound();
                myPig.sleep();
              }
            }

            //Interfaces
            Another type of abstraction
            Interfaces are like entirely abstract classes that cannot contain feilds, and should start with I
            Inheriting an interface is called implementing it, and can be done multiple times per class by separating interface names with commas

            interface IAnimal 
            {
              void animalSound();
            }
            class Pig : IAnimal 
            {
              public void animalSound() 
              {
                Console.WriteLine("The pig says: wee wee");
              }
            }
            class Program 
            {
              static void Main(string[] args) 
              {
                Pig myPig = new Pig();
                myPig.animalSound();
              }
            }*/


            //                                                                                                   Enums
            /*
            Enums are special classes that contain a group of constants

            class Program
            {
              enum Level
              {
                Low,
                Medium,
                High
              }
              static void Main(string[] args)
              {
                Level myVar = Level.Medium;
                Console.WriteLine(myVar);
              }
            }

            Each enum value has a number value that can be accessed by explicitly converting it to an integer
            These values can also be manually assigned

            enum Months
            {
              January,    // 0
              February,   // 1
              March=6,    // 6
              April,      // 7
              May,        // 8
              June,       // 9
              July        // 10
            }
            static void Main(string[] args)
            {
              int myNum = (int) Months.April;
              Console.WriteLine(myNum);
            }

            Enums are often used for switch statments to check for corresponding values

            enum Level 
            {
              Low,
              Medium,
              High
            }

            static void Main(string[] args) 
            {
              Level myVar = Level.Medium;
              switch(myVar) 
              {
                case Level.Low:
                  Console.WriteLine("Low level");
                  break;
                case Level.Medium:
                   Console.WriteLine("Medium level");
                  break;
                case Level.High:
                  Console.WriteLine("High level");
                  break;
              }
            }*/


            //                                                                                          Files
            /*The File class exists in the System.IO namespace
            
            Methods:
            AppendText()    Appends text at the end of an existing file
            Copy()          Copies a file
            Create()        Creates or overwrites a file
            Delete()        Deletes a file
            Exists()        Tests whether the file exists
            ReadAllText()   Reads the contents of a file
            Replace()       Replaces the contents of a file with the contents of another file
            WriteAllText()  Creates a new file and writes the contents to it and if the file already exists, it will be overwritten*/


            //                                                                                          Exceptions
            /*Exceptions are the C# equivilent of errors

            try         Runs a block of code to test for errors
            catch       Runs a block of code if there is an error in try
            throw       Allows you to create a custom error
            finally     Runs a block of code after try and catch are done

            try
            {
                int myNumbers = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(myNumbers);
                checkAge(myNumbers);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Done");
            }
            */

        }

    }
}
