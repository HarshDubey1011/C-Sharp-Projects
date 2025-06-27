using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Code
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            //aList.Add(40);
            Console.WriteLine("Count: {0}",aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });
            aList.AddRange(aList2);
            aList2.Sort();
            aList2.Reverse();
            aList.Insert(1, "Turkey");
            //aList2.RemoveAt(0);
            //aList2.RemoveRange(0, 1);
            Console.WriteLine("Turkey Index: {0}", aList2.IndexOf("Turkey", 0));

            foreach(object o in aList)
            {
                Console.WriteLine(o);
            }

            string[] myArray = (string[])aList.ToArray(typeof(string));
            string[] costumers = { "Bob", "Sally", "Sue" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(costumers);
            foreach(object o in custArrayList)
            {
                Console.WriteLine(o);
            }
            #endregion
        }
    }
}
