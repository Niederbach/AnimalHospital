namespace AnimalHospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new Animal();
            var ListOfAnimals = animals.GetAnimals().ToList();
            
            //=================================================================
            //A.
            var amountOfDog = ListOfAnimals.Count(x => x.AnimalType == "Hund");

            Console.WriteLine($"Antal hundar: {amountOfDog}");
            Console.WriteLine();

            //=================================================================
            //B.
            var oldestAnimal = ListOfAnimals.Max(x => x.AnimalAge);

            Console.WriteLine($"Äldsta djuret: {oldestAnimal}");
            Console.WriteLine();

            //=================================================================
            //C.
            var IsVaccinated = ListOfAnimals.Where(x => x.IsVaccinated == true).ToList();

            Console.WriteLine("Dem Här djuren är vaccinerade");
            Console.WriteLine();

            foreach (var animal in IsVaccinated)
            {
                Console.WriteLine($"Namn: {animal.AnimalName}");
                Console.WriteLine($"Typ: {animal.AnimalType}");
                Console.WriteLine($"Vaccinarad: {animal.IsVaccinated}");
                Console.WriteLine("-----------------");

            }

            //=================================================================
            //D.
            var filterAnimals = ListOfAnimals
                .Where(x => x.AmountOfLegs == 4 && x.AnimalAge > 3)
                .ToList();

            Console.WriteLine("Dem Här djuren är Filtrerade");
            Console.WriteLine();

            foreach (var animal in filterAnimals)
            {
                Console.WriteLine($"Namn: {animal.AnimalName}");
                Console.WriteLine($"Ålder: {animal.AnimalAge}");
                Console.WriteLine($"Antal ben: {animal.AmountOfLegs}");
                Console.WriteLine("-----------------");

            }
            Console.WriteLine();

            //=================================================================
            //E.
            var hasShadow = ListOfAnimals.Any(x => x.AnimalName == "Shadow");

            if (hasShadow)
                Console.WriteLine("Något djur heter shadow");
            else
                Console.WriteLine("Det finns inget djur som heter shadow");






        }
    }
}
