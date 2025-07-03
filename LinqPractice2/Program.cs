namespace LinqPractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
{
                new Person(){Name = "john", Age = 5, City = "Rabat"},
                new Person(){Name = "Joe", Age = 54, City = "Madrid"},
                new Person(){Name = "Aladdin", Age = 40, City = "Madrid"},
                new Person(){Name = "Mohammed", Age = 60, City = "Paris"},
                new Person(){Name = "Alain", Age = 10, City = "Madrid"},
                new Person(){Name = "Josh", Age = 18, City = "Paris"}
};
            var myQuery = from person in people
                          select person;

            var myQuery2 = from person in people
                           where person.Name.Contains("i") && person.Age > 20
                           select person;

            var myQuery3 = from person in people
                           where person.Name.Length > 3
                           orderby person.Age ascending
                           select person;

            var myQuery4 = from person in people
                           where person.Name.Length > 3
                           orderby person.Age descending
                           select person;

            var myQuery5 = from person in people
                           group person by person.City;

            var myQuery6 = from person in people
                           group person by person.City into grouped
                           where grouped.Count() > 2
                           select grouped;

            Console.WriteLine("------MyQuery-------");

            foreach(var person in myQuery)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("------MyQuery2-------");
            foreach(var person in myQuery2)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("------MyQuery3-------");
            foreach (var person in myQuery3)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("------MyQuery4-------");
            foreach (var person in myQuery4)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("------MyQuery5-------");
            foreach (var person in myQuery5)
            {
                Console.WriteLine($"key: {person.Key}, Count: {person.Count()}");
            }


            Console.WriteLine("------MyQuery6-------");
            foreach (var person in myQuery6)
            {
                Console.WriteLine($"key: {person.Key}, Count: {person.Count()}");
            }
        }
    }
}
