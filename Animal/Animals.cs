namespace NCSafari
{
    public abstract class Animals
    {
        public float WeightInKG { get; set; }

       public Animals(float weightInKG)
        {
            WeightInKG = weightInKG;
        }

        public abstract void MakeSound();
    }
}
