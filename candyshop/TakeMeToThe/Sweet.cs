namespace TakeMeToThe
{
    public abstract class Sweet
    {
        private int price;
        private int sugarRequired;

        public  int Price { get => price; set => price = value; }
        public int SugarRequired { get => sugarRequired; protected set => sugarRequired = value; }
    }
}