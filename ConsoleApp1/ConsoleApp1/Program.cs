using System;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {

        // -----------Functions-----------
        //<Access Specifier> <Return Type> <Method Name>(Parameter)
        // { <Body> }
        // public : Can be accessed from another class
        // private: cannot be accessed from another class
        // protected: cannot be accessed by class and derived classes

        // ----------- Functional OverLoading -----------
        //static double GetSum2(double x = 1,double y = 1)
        //{
        //    Console.WriteLine("Double called");
        //    double sum = 0; 
        //    return sum + x * y;
        //}

        //static double GetSum2(string x = "1",string y = "1")
        //{
        //    Console.WriteLine("String called");
        //    double dblX = Convert.ToDouble(x);
        //    double dblY = Convert.ToDouble(y);
        //    return dblX * dblY;
        //}

        // ---------- Use of the Named Parameter ----------
        //public static void namedParameter(String name, String zipCode)
        //{
        //    Console.WriteLine("Name: "+ name+ " ZipCode: "+zipCode);
        //}

        // -------- Params(If you don't know how many parameters are there) ---------
        //static double GetSumMore(params double[] nums)
        //{
        //    double sum = 0;
        //    foreach(int i in nums)
        //    {
        //        sum += i;
        //    }

        //    return sum;
        //}

        // ------- Using Pass By Reference in Dot Net -----------
        //public static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        // ----- Using the Out in the arugments --------
        //static void DoubleIt(int x, out int solution)
        //{
        //    solution = x * 2;   
        //}

        // -------- Simple Function-----------
        //private static void SayHello()
        //{
        //    String name = "";
        //    Console.WriteLine("What is your name ? :");
        //    name = Console.ReadLine();
        //    Console.WriteLine("What is your name : {0}",name);


        //}
        // ----------Addition of two numbers --------
        //private static double GetSum(double x = 1, double y = 1)
        //{
        //    return x + y;
        //}

        // -------- Taking array as arguments and printing it --------
        //static void PrintArray(int[] intArray, string message)
        //{
        //    foreach(int k in intArray)
        //    {
        //        Console.WriteLine(k);
        //    }
        //}

        // --------- Exception Handling Custom Function ---------------
        //static double DoDivision(double num1, double num2) { 
        //    if(num2==0)
        //    {
        //        throw new System.DivideByZeroException();
        //    }else
        //    {
        //        return num1 / num2;
        //    }
        //}

        // ------------- Enumerated Type(Enum) -----------------

        //static void PaintCar(CarColor cc)
        //{
        //    Console.WriteLine("The car was painter {0} with the code {1}", cc,(int)cc);
        //}
        //enum CarColor : byte
        //{
        //    Orange = 1,
        //    Blue,
        //    Green,
        //    Yellow
        //}


        //--------------Struct---------------
        //struct Rectangle
        //{
        //    public double length;
        //    public double x;

        //    public Rectangle(double l = 1, double w = 1)
        //    {
        //        this.length = l;
        //        this.x = w;
        //    }
        //    public double Area()
        //    {
        //        return length * x;
        //    }
        //}
        static void Main(string[] args)
        {
            // ---------Changing the color of the console and text----------
            //Console.WriteLine("Hello World!");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();

            // ----------Taking input from the User and Printing it----------
            //Console.WriteLine("What is your name? ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}");


            //-----------Max and Min value of the data type---------
            //bool canIVote = true;
            //Console.WriteLine("Biggest Integer: {0}", int.MaxValue);
            //Console.WriteLine("Smallest Integer: {0}", int.MinValue);
            //Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            //Console.WriteLine("Smallest Long: {0}", long.MinValue);

            //decimal decPiValue = 3.1434343234274032734033M;
            //decimal decBigNum = 3.000000000000000000000011M;
            //Console.WriteLine("DEC: PI + BigNum: {0}", decPiValue + decBigNum);
            //int a = 10;
            //int b = 20;
            //Console.WriteLine("The sum of a: {0} and b: {1} is Total: {2}", a, b, a + b);
            //Console.WriteLine("Decimal Max Value: {0}", Decimal.MaxValue);


            // Double precision is 14 decimal places
            // Whereas the float precision is for 4 or 6 decimal places
            //Console.WriteLine("Biggest Double: {0}", Double.MaxValue);
            //Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            //Console.WriteLine("Decimal {0}",Decimal.MaxValue);

            // ----------Other Data Types--------
            // byte: 8-Bit unsigned int 0 to 255
            // char: 16-Bit unicode character
            // sbyte: 8-bit signer to 128 to 127
            // short: 16-bit signer int -32,768 to 32,767
            // uint: 32-bit unsigner int 0 4,294,967,295
            // ulong: 64-bit unsigner int 0 to 18,446,744,073,709,551,615
            // ushort: 16-bit unsigner int 0 to 65,535


            // Data Type Conversions
            //bool boolFromStr = bool.Parse("true");
            //int intFromStr = int.Parse("100");
            //double dblFromStr = double.Parse("34.3434");
            //string strVal = dblFromStr.ToString();
            //Console.WriteLine(strVal);
            //Console.WriteLine($"Data Type : {strVal.GetType()}");
            //double dblVal = 12.34;
            //Console.WriteLine($"Integer: {(int)dblVal}");
            //int intNum = 10;
            //long longNum = intNum;
            //Console.WriteLine(longNum);

            ////String 
            //string randString = "this is a randString";
            //Console.WriteLine("String Length: {0}", randString.Length);
            //Console.WriteLine("String  Contains: {0}",randString.Contains("is"));
            //Console.WriteLine("String Index Of: {0}", randString.IndexOf("is"));
            //Console.WriteLine("Remove: {0}",randString.Remove(10,6));

            // Arrays
            //int[] favNums = new int[3];
            //favNums[0] = 1;
            //Console.WriteLine("favNum 0: {0}", favNums[0]);
            //string[] customers = { "Bob", "Sally", "Sue" };
            //var employees = new[] { "Mike", "paul", "rick" };
            //object[] randomarray = { "paul", 45, 1.234 };
            //Console.WriteLine("Random Array 0 : {0}", randomarray[0].GetType());
            //Console.WriteLine("Array Size: {0}",randomarray.Length);
            //for (int j = 0; j < customers.Length; j++)
            //{
            //    Console.WriteLine(customers[j] + " ");
            //}
            //string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Smith" } };
            //Console.WriteLine("MD Value: {0}", custNames.GetValue(0, 1));
            //for(int j = 0; j <  custNames.GetLength(0);j++)
            //{
            //    for(int k = 0;k < custNames.GetLength(0);k++)
            //    {
            //        Console.WriteLine(custNames[j,k] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // Function Call
            //int[] newArr = { 200, 400, 600, 500 };
            //string message = "Hello how r u there?";
            //PrintArray(newArr,message);
            //Array.Sort(newArr);
            //foreach (var item in newArr)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] newArrays = { 1, 1, 11, 11, 23 };
            //Console.WriteLine(Array.Find(newArrays,(x) => x > 10)) ;

            // Stirng comparison
            //string name2 = "Derek";
            //string name3 = "DeRek";
            //if (name2.Equals(name3, StringComparison.OrdinalIgnoreCase)) {
            //    Console.WriteLine("Names are equal");
            //}else
            //{
            //    Console.WriteLine("Names are not equal");
            //}
            // Simple Program
            //Random rnd = new Random();
            //int secretNumber = rnd.Next(1,11);
            //int numberGuessed = 0;
            //Console.WriteLine("Secret Number: ", secretNumber);
            //int chancesTryToGuessTheNumber = 0;
            //do
            //{
            //    Console.WriteLine("Enter the Number between 1 to 10");
            //    numberGuessed = Convert.ToInt32(Console.ReadLine());
            //    chancesTryToGuessTheNumber++;
            //} while(secretNumber!=numberGuessed);

            //Console.WriteLine("You guessed the number in {0} tries", chancesTryToGuessTheNumber);

            // ----------- Exception Handling ------------
            //double num1 = 5;
            //double num2 = 0;
            //try
            //{
            //    Console.WriteLine("Error", DoDivision(num1, num2));
            //}catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("You can dived by zero");
            //    Console.WriteLine("Name: {0}",ex.GetType().Name);
            //    Console.WriteLine(ex.Message);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("An erro occured!");
            //    Console.WriteLine(ex.GetType().Name);
            //    Console.WriteLine(ex.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("Everytime is run");
            //}

            //  --------- String Builder ----------

            //StringBuilder sb = new StringBuilder("Random Text");
            //StringBuilder sb2 = new StringBuilder("More stuff that is very important!");
            //Console.WriteLine("Capacity: {0}", sb2.Capacity);
            //Console.WriteLine("Length: {0}",sb2.Length);
            //Console.WriteLine(sb.GetType());
            //Console.WriteLine(sb.ToString());
            //sb2.Clear();
            //sb2.Append("Random Text");
            //Console.WriteLine(sb2.ToString().Equals(sb.ToString()));
            //Console.WriteLine(sb.Equals(sb2));

            //SayHello();
            //double result = GetSum(12.2, 232);
            //Console.WriteLine(result);
            // ---------------- Function Calls ---------------- 

            //int solution;
            //DoubleIt(15, out solution);
            //Console.WriteLine(solution);
            //int a = 10;
            //int b = 20;
            //Console.WriteLine("Before the Swap: {0} and {1}: ", a, b);
            //Swap(ref a, ref b);
            //Console.WriteLine("After the Swap: {0} and {1}",a,b);
            //Console.WriteLine("Using the params");
            //double outputParams = GetSumMore(1,2,3,4,5,6);
            //Console.WriteLine(outputParams);
            //namedParameter(zipCode: "484224", name: "harsh");
            //Console.WriteLine("The Sum of Two Double Values are: {0}: ", GetSum2(25.50,25.50));
            //Console.WriteLine("The Sum of Two String  Values  are: {0}: ",GetSum2("25.50","35.50"));

            // ------------ Date --------------- 
            //DateTime awesomeDate = new DateTime(2000, 10, 11);
            //Console.WriteLine(awesomeDate.DayOfWeek);
            //awesomeDate = awesomeDate.AddDays(1);
            //awesomeDate = awesomeDate.AddMonths(2);
            //awesomeDate = awesomeDate.AddYears(5);
            //Console.WriteLine(awesomeDate.Date);
            //TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            //lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            //Console.WriteLine(lunchTime.ToString());


            // ------ Enumerated Type Call ---------
            //CarColor cc = CarColor.Blue;
            //PaintCar(cc);

            //-------------- Struct ---------------------
            //Rectangle rect1;
            //rect1.length = 200;
            //rect1.x = 50;
            //Console.WriteLine("Area of rect1: {0}", rect1.Area());
            //Rectangle rect2 = new Rectangle(100, 40);
            //rect2 = rect1;
            //rect1.length = 33;
            //Console.WriteLine("Rect2.length: {0}", rect2.length);
            // ----------New Code -------------
            //Animal fox = new Animal()
            //{
            //    name = "Red",
            //    sound = "Raaw"
            //};

            //Animal fox2 = new Animal(name: "new fox", sound: "raaaaw");
            //Console.WriteLine("# of Animals {0}", Animal.getNumAnimals());
            //fox.makeSound();
            //fox2.makeSound();
            //Console.WriteLine("# of Animals {0}",Animal.getNumAnimals());
            //Console.WriteLine("Area of Rectangle: {0}", ShapeMath.GetArea("rectangle", 5, 10));
            //Console.WriteLine("Area of Circle: {0}", ShapeMath.GetArea("circle", 10));
            //Console.WriteLine("Area of Traingle: {0}", ShapeMath.GetArea("triangle", 20,10));

            //// Creating the nullable type values;
            //int? randNum = null;
            //if(randNum == null)
            //{
            //    Console.WriteLine("randNum is null");
            //}

            //if(!randNum.HasValue)
            //{
            //    Console.WriteLine("randNum is null");
            //}
            // ----------New Code -------------
            //Animal cat = new Animal();
            //cat.SetName("Whiskers");
            //cat.Sound = "Meow";
            //Console.WriteLine("The cast is name {0} and says {1}", cat.GetName(),cat.Sound);
            //cat.Owner = "Harsh";
            //Console.WriteLine("{0} owner is {1}",cat.GetName(),cat.Owner);
            //Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);
            //Console.WriteLine("# of Animals : {0}", Animal.NumOfAnimals);
            //Console.WriteLine("The id number is : {0}",cat.IdNum);
            // ----------New Code -------------
            //Animal whiskers = new Animal()
            //{
            //    Name =  "Whiskers",
            //    Sound = "Meow"
            //};

            //Dog grover = new Dog()
            //{
            //    Name = "Grover",
            //    Sound = "Woof",
            //    Sound2 = "Grrrrrr"
            //};
            //grover.Sound = "woooooooooof";
            //whiskers.MakeSound();
            //grover.MakeSound();

            //whiskers.SetAnimalIdInfo(123345, "Harsh Dubey");
            //grover.SetAnimalIdInfo(23242, "Virat Kohli");
            //whiskers.GetAnimalIdInfo();
            //grover.GetAnimalIdInfo();

            // ----------New Code -------------
            // ---------------- Use Abstract Class -----------------------
            //Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };
            //foreach(Shape shape in shapes)
            //{
            //    shape.GetInfo();
            //    Console.WriteLine("{0} Area: {1:f2}", shape.Name, shape.Area());

            //    Circle testCirc = shape as Circle;
            //    if(testCirc == null)
            //    {
            //        Console.WriteLine("This is not a circle");
            //    }

            //    if(shape is Circle)
            //    {
            //        Console.WriteLine("This is not a rectangle");
            //    }

            //    object circ1 = new Circle(4);
            //    Circle circ2 = (Circle) circ1;
            //    Console.WriteLine("The {0} Area is {1:f2}",circ2.Name,circ2
            //        .Area());
            //}

            // ----------------- Using the Interface-------------
            Vehicle buick = new Vehicle("Buick",4,160);

            if(buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }else
            {
                Console.WriteLine("This {0} can't be driven",buick.Brand);
            }
        }
    }
}