namespace ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> lst = new List<Animal>();
            lst.Add(new Lion());
            lst.Add(new Elephant());
            lst.Add(new Lion());
            lst.Add(new Elephant());
            lst.Add(new Lion());
            lst.Add(new Elephant());
            int lionCount = lst.Count(a=>a is Lion);
            int elephantCount = lst.Count(a=> a is Elephant);
            Console.WriteLine($"Total Lions: {lionCount}, Total Elephant: {elephantCount}");
            foreach (var item in lst) {
                item.MakeSound();
                item.Eat();
                item.DisplayInfo();
            }

            ZooCage<Animal> zooCage = new ZooCage<Animal>();
            zooCage.addAnimals(new Lion("Simba"));
            zooCage.addAnimals(new Elephant("Jumbo"));
            zooCage.addAnimals(new Lion("Mufasa"));
            zooCage.addAnimals(new Elephant("Sonny"));

            zooCage.displayAllAnimals();
            Console.WriteLine("I am in Zoo thats why u r able to write code ${0}",zooCage.getAnimal(2));
        }
    }
}
