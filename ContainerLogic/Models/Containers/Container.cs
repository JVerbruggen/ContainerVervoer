namespace ContainerLogic.Models
{
    public class Container : IContainer
    {
        public int EmptyWeight { get; }
        public int MaxWeight { get; }
        public int MaxHoldWeight { get; }
        public int LoadWeight { get; }
        public int TotalWeight { get => EmptyWeight + LoadWeight; }

        public Container(int loadWeight)
        {
            LoadWeight = loadWeight;
            EmptyWeight = 4000;
            MaxWeight = 30000;
            MaxHoldWeight = 120000;
        }

        public Stack GetPosition(Ship ship)
        {
            Row row = ship.GetNextRow();
            double weightDistribution = ship.GetWeightDistribution();
            Stack stack = row.GetNextStack(weightDistribution, this);

            return stack;
        }

        public bool CanHoldWeight(int shouldHold)
        {
            return shouldHold <= MaxHoldWeight;
        }
    }
}
