using System.Diagnostics;

namespace LinqPractice
{
    internal class Program
    {

        static void Main(string[] args)
        {
      List<ZooAnimal> animals = new List<ZooAnimal>
{
    new ZooAnimal { Name = "Leo", Species = "Lion", Age = 8, IsCarnivore = true },
    new ZooAnimal { Name = "Manny", Species = "Elephant", Age = 12, IsCarnivore = false },
    new ZooAnimal { Name = "Diego", Species = "Tiger", Age = 6, IsCarnivore = true },
    new ZooAnimal { Name = "Ellie", Species = "Elephant", Age = 4, IsCarnivore = false },
    new ZooAnimal { Name = "Simba", Species = "Lion", Age = 3, IsCarnivore = true },
    new ZooAnimal { Name = "Dumbo", Species = "Elephant", Age = 2, IsCarnivore = false }
};

            var oldAnimals = from animal in animals
                             where animal.Age > 5
                             select animal;
            var oldAnimals2 = animals.Where(animal => animal.Age > 8);

            var carnivores = from animal in animals
                             where animal.IsCarnivore == true
                             select new {Name = animal.Name.ToUpper(), Species = animal.Species.ToLower(),Message = $"Watch out from {animal.Name.ToUpper()}"};

                
            var carnivores2 = animals.Where(animal=>animal.IsCarnivore).Select(animal=>animal.Name.ToUpper());

            var speciesGroup = from animal in animals
                               group animal by animal.Species into grouped
                               select new {Species = grouped.Key, Count = grouped.Count()};


            var hasHerbivores = from animal in animals
                                where !animal.IsCarnivore
                                select animal;


            bool hasHerbivores2 = animals.Any(animal => animal.IsCarnivore == false);



            //var stopWatch = Stopwatch.StartNew();
            //var youngest = animals.OrderBy(animal => animal.Age)
            //    .First();
            //stopWatch.Stop();

            //Console.WriteLine($"LINQ took: {stopWatch.ElapsedMilliseconds}ms");

            //var stopWatch2 = Stopwatch.StartNew();
            //var youngest2 = animals.AsParallel().OrderBy(animal => animal.Age).First();
            //stopWatch2.Stop();

            //Console.WriteLine($"PLINQ took: {stopWatch2.ElapsedMilliseconds}ms");

 

   



            // Console.WriteLine($"Youngset Animal is: {youngest}");

            //Console.WriteLine("Method 1");
            // foreach( var animal in oldAnimals )
            // {
            //     Console.WriteLine( animal);
            // }
            // Console.WriteLine("Method 2");
            // foreach( var animal in oldAnimals2 )
            // {
            //     Console.WriteLine( animal);
            // }

            // Console.WriteLine("Carnivores 1");
            // foreach(var  animal in carnivores )
            // {
            //     Console.WriteLine(animal);
            // }

            // Console.WriteLine("Carnivores 2");
            // foreach(var animal in carnivores2)
            // {
            //     Console.WriteLine(animal);
            // }

            // foreach(var animal in speciesGroup) {
            //     Console.WriteLine(animal);
            // }

            // foreach(var animal in hasHerbivores)
            // {
            //     Console.WriteLine(animal);
            // }

            // Console.WriteLine(hasHerbivores2);
        }
       
    }
}
