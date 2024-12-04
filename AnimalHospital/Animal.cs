namespace AnimalHospital;

public class Animal
{
    public string AnimalType { get; set; }
    public string AnimalName { get; set; }
    public int AnimalAge { get; set; }
    public bool IsVaccinated { get; set; }
    public int AmountOfLegs { get; set; }
    public List<Animal> GetAnimals()
    {
        var animals = new List<Animal>();

        animals.Add(new Animal
        {
            AnimalName = "Stefan",
            AnimalType = "Katt",
            AnimalAge = 10,
            IsVaccinated = true,
            AmountOfLegs = 4
        });
        animals.Add(new Animal
        {
            AnimalName = "Alice",
            AnimalType = "Hund",
            AnimalAge = 5,
            IsVaccinated = true,
            AmountOfLegs = 4
        });
        animals.Add(new Animal
        {
            AnimalName = "Max",
            AnimalType = "Hund",
            AnimalAge = 6,
            IsVaccinated = true,
            AmountOfLegs = 4
        });
        animals.Add(new Animal
        {
            AnimalName = "Olivia",
            AnimalType = "Kanin",
            AnimalAge = 2,
            IsVaccinated = false,
            AmountOfLegs = 4
        });
        animals.Add(new Animal
        {
            AnimalName = "Liam",
            AnimalType = "Katt",
            AnimalAge = 12,
            IsVaccinated = true,
            AmountOfLegs = 4
        });
        animals.Add(new Animal
        {
            AnimalName = "Ella",
            AnimalType = "Skölpadda",
            AnimalAge = 20,
            IsVaccinated = true,
            AmountOfLegs = 4
        });
        animals.Add(new Animal
        {
            AnimalName = "Sofia",
            AnimalType = "Marsvin",
            AnimalAge = 1,
            IsVaccinated = false,
            AmountOfLegs = 4
        });
        animals.Add(new Animal
        {
            AnimalName = "Alice",
            AnimalType = "Hund",
            AnimalAge = 3,
            IsVaccinated = true,
            AmountOfLegs = 4
        });
        animals.Add(new Animal
        {
            AnimalName = "Max",
            AnimalType = "Katt",
            AnimalAge = 5,
            IsVaccinated = true,
            AmountOfLegs = 4
        });
        animals.Add(new Animal
        {
            AnimalName = "Stefan",
            AnimalType = "Marsvin",
            AnimalAge = 2,
            IsVaccinated = false,
            AmountOfLegs = 4
        });
        animals.Add(new Animal
        {
            AnimalName = "Emma",
            AnimalType = "Katt",
            AnimalAge = 10,
            IsVaccinated = true,
            AmountOfLegs = 4
        });

        return animals;
    }
}
