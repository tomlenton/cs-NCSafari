namespace NCSafariZOO;
using NCSafari;

internal class Program
{
    public static void Main()
    {
        //Tiger fluffy = new Tiger(80);
        //Penguin penny = new Penguin(20.4f);
        //Goose jeff = new Goose(3);
        //Bat betty = new Bat(0.7f);

        //Sky sky = new Sky();
        //sky.AddAnimalInEnvironment(betty);
        //sky.AddAnimalInEnvironment(jeff);

        //sky.CheckAnimalsInEnvironment();

        //HuntingGround hunting = new HuntingGround();
        //hunting.AddAnimalInEnvironment(betty);
        //hunting.AddAnimalInEnvironment(fluffy);
        //hunting.AddAnimalInEnvironment(penny);

        //hunting.CheckAnimalsInEnvironment();

        //List<Animals> animalsToSee = new List<Animals>
        //{
        //     new Tiger(70),
        //     new Goose(5.2f),
        //     new Bat(0.9f),
        //     new Goose(4),
        //     new Tiger(90),
        //     new Penguin(15.8f)
        //};
        //// Should sort ascending
        //animalsToSee.Sort(new CompareWeight(false));

        //animalsToSee.ForEach(animal => Console.WriteLine($" {animal.GetType().Name} - {animal.WeightInKG}kg"));

        // // Should sort descending
        //animalsToSee.Sort(new CompareWeight(true));

        //animalsToSee.ForEach(animal => Console.WriteLine($" {animal.GetType().Name} - {animal.WeightInKG}kg"));
        Tiger pumpkin = new Tiger(100.4f);
        WeightFormatter pumpkinWeightFormatter = new WeightFormatter(pumpkin);
    }
}

