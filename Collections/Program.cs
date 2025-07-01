using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region ArrayList Code
            //ArrayList aList = new ArrayList();
            //aList.Add("Bob");
            ////aList.Add(40);
            //Console.WriteLine("Count: {0}",aList.Count);
            //Console.WriteLine("Capacity: {0}", aList.Capacity);

            //ArrayList aList2 = new ArrayList();
            //aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });
            //aList.AddRange(aList2);
            //aList2.Sort();
            //aList2.Reverse();
            //aList.Insert(1, "Turkey");
            ////aList2.RemoveAt(0);
            ////aList2.RemoveRange(0, 1);
            //Console.WriteLine("Turkey Index: {0}", aList2.IndexOf("Turkey", 0));

            //foreach(object o in aList)
            //{
            //    Console.WriteLine(o);
            //}

            //string[] myArray = (string[])aList.ToArray(typeof(string));
            //string[] costumers = { "Bob", "Sally", "Sue" };
            //ArrayList custArrayList = new ArrayList();
            //custArrayList.AddRange(costumers);
            //foreach(object o in custArrayList)
            //{
            //    Console.WriteLine(o);
            //}
            //#endregion

            #region Dictionary Code
            //    Dictionary<string,string> dict = new Dictionary<string, string> ();
            //dict.Add("Harsh", "2025");
            //dict.Add("Virat", "2026");
            //dict.Add("Sanju", "2025");
            //dict.Add("Neha", "2026");
            //Console.WriteLine("{0}", dict.ContainsKey("Virat"));
            //Console.WriteLine("The length of the dictionary is: {0}", dict.Count);
            //dict.TryGetValue("Sanju", out string val);
            //Console.WriteLine("The value of the key {0} is {1}", "Sanju", val);
            //dict.Remove("Neha");
            //foreach(KeyValuePair<string,string> item in dict)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}
            //dict.Clear();
            //Console.WriteLine("The length of the dictionary is: {0}", dict.Count);
            #endregion


            //#region List Code
            //List<Animal> list = new List<Animal>();
            //List<int> numList = new List<int>();
            //numList.Add(24);


            //list.Add(new Animal() { Name = "Doug" });
            //list.Add(new Animal() { Name = "Paul" });
            //list.Add(new Animal() { Name = "Sally" });
            //list.Insert(1, new Animal() { Name = "Steve" });
            //list.RemoveAt(1);
            //Console.WriteLine("Num of Animals: {0}", list.Count());
            //foreach (Animal a in list)
            //{
            //    Console.WriteLine(a.Name);
            //}

            //#endregion
            //#region Generics
            //int x = 5, y = 4;
            //Animal.GetSum<int>(ref x, ref y);
            //string strX = "5", strY = "4";
            //Animal.GetSum<string>(ref strX, ref strY);
            //#endregion

            //#region Delegates And Lambda Code
            //// ----------- Delegates ------------
            //Arithmetic add, sub, addSub;
            //add = new Arithmetic(Add);
            //sub = new Arithmetic(Subtract);
            //addSub = add + sub;

            //Console.WriteLine($"Add {6} & {10}");
            //add(6, 10);
            //Console.WriteLine($"Add & Subtract {10} & {4}");
            //addSub(10, 4);
            //// ---------------- Predicate Lambda Functions ------------
            //doubleIt dblIt = x => x * 2;
            //Console.WriteLine($"5 * 2 = {dblIt(5)}");
            //List<int> numList2 = new List<int> {1,9,10,12,15,20 };
            //var evenList = numList2.Where(a => a % 2 == 0).ToList();
            //foreach(var item in evenList)
            //{
            //    Console.WriteLine(item);
            //}
            //var rangeList = numList2.Where(x => (x > 2) || (x < 9)).ToList();
            //foreach(var item in rangeList)
            //{
            //    Console.WriteLine(item);
            //}

            // ------------- Head and Tail Random Number Generator---------
            //    List<int> flipList = new List<int>();
            //    int i = 0;
            //    Random rnd = new Random();
            //    while(i < 100)
            //    {
            //        flipList.Add(rnd.Next(1, 3));
            //        i++;
            //    }
            //    Console.WriteLine("Heads: {0}", flipList.Where(a => a == 1).ToList().Count());

            //    Console.WriteLine("Tails: {0}", flipList.Where(a => a == 2).ToList().Count());


            //    var nameList = new List<string> {"Doug","Sally","Sue" };
            //    var sNameList = nameList.Where(x => x.StartsWith("S"));
            //    foreach(var m in sNameList)
            //    {
            //        Console.WriteLine(m);
            //    }

            //    // ----------------- Enumerable && Select -------------------
            //    var oneTo10 = new List<int>();
            //    oneTo10.AddRange(Enumerable.Range(1, 10));
            //    var squares = oneTo10.Select(x => x * x);
            //    foreach(var m in squares)
            //    {
            //        Console.WriteLine(m);
            //    }
            //    #endregion
            //}

            //delegate double doubleIt(double val);
            //public delegate void Arithmetic(double num1, double num2);
            //public static void Add(double num1, double num2)
            //{
            //    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //}

            //public static void Subtract(double num1, double num2)
            //{
            //    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //}

            //List<int> listOne = new List<int>(new int[] { 1, 3, 4 });
            //List<int> listTwo = new List<int>(new int[] { 4, 6, 8 });

            //var SumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();
            //Console.WriteLine(SumList.GetType().Name);
            //foreach (var item in SumList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("The aggregate of the sum is: {0}", listOne.Aggregate((a, b) => a + b));
            //Console.WriteLine("Use Of All: {0}", listOne.All(x=>x <93));
            //#region animal farm
            ////AnimalFarm myAnimals = new AnimalFarm();
            ////myAnimals[0] = new Animal("Wilbur");
            ////myAnimals[1] = new Animal("Templeton");
            ////myAnimals[2] = new Animal("Gender");
            ////myAnimals[3] = new Animal("Charlotte");
            ////myAnimals[4] = new Animal("Yami");
            ////foreach(Animal i in myAnimals)
            ////{
            ////    Console.WriteLine(i.Name);
            ////}
            //#endregion

            //#region operator overloding
            //Box box1 = new Box(2, 3, 4); 
            //Box box2 = new Box(5, 6, 7);
            //Box box3 = box1 + box2;

            //Console.WriteLine($"Box 3: {box3}");
            //Console.WriteLine($"Box Int: {(int)box3}");
            //Box box4 = (Box)4;
            //#endregion

            //#region anonymous class

            //var shopkins = new { Name = "Shopkins", Price = 4.99 };
            //Console.WriteLine("{0} cost ${1}",shopkins.Name, shopkins.Price);

            //var toyArray = new[]
            //{
            //    new { Name = "HD",Price = 4.99 },
            //    new {Name = "DD",Price = 3.34}
            //};

            //foreach(var item in toyArray)
            //{
            //    Console.WriteLine("{0} cost ${1}", item.Name, item.Price);
            //}
            //#endregion

            //#region LINQ(Language Integrated Query (LINQ)
            //string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin", "Benji", "Charlie B. Barkin", "Lassie", "Snoopy"};

            //var dogSpaces = from dog in dogs
            //                where dog.Contains(" ")
            //                orderby dog descending
            //                select dog;

            //foreach (var dog in dogSpaces) { 
            //    Console.WriteLine(dog);
            //}
            //#endregion
           //int[] intArray =  QueryIntArray();
           // foreach (int i in intArray) { 
           //     Console.WriteLine(i);
            }
        }

        #region functions linq
        //static int[] QueryIntArray()
        //{
        //    int[] nums = { 5, 10, 15, 20, 30, 35 };
        //    var gt20 = from num in nums
        //               where num > 20
        //               orderby num
        //               select num;
        //    foreach (int num in gt20)
        //    {
        //        Console.WriteLine(num);
        //    }
        //    Console.WriteLine($"Get Type: {gt20.GetType()}");
        //    var listGT20 = gt20.ToList<int>();
        //    var arrayGT20 = gt20.ToArray();
        //    nums[0] = 40;
        //    foreach (int num in gt20)
        //    {
        //        Console.WriteLine(num);
        //    }
        //    return arrayGT20;
        //}
        #endregion
        
    }
}
