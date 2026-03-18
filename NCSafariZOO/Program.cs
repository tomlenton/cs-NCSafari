namespace NCSafariZOO;
    using NCSafari;

    internal class Program
    {
    public static void Main()
    {
        Tiger fluffy = new Tiger(70.5f);
        Penguin penny = new Penguin(21);
        Goose jeff = new Goose(5.5f);
        Bat betty = new Bat(0.7f);

        List<Animals> animals = new List<Animals>()
    { fluffy, penny, jeff, betty };

        foreach (Animals animal in animals)
        {
            if (animal is IFly flyingAnimal)
            {
                flyingAnimal.Fly();
            }
            if (animal is IHunt huntingAnimal)
            {
                huntingAnimal.Hunt();
            }
            if (animal is ISwim swimmingAnimal)
            {
                swimmingAnimal.Swim();
            }
        }
    }
}
