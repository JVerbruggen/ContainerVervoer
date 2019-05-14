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

        public Stack GetPosition(IShip ship)
        {
            IRow row = ship.GetNextRow(this);
            double weightDistribution = ship.GetWeightDistribution();
            Stack stack = row.GetNextStack(weightDistribution, this);

            return stack;
        }

        public bool CanHoldWeight(int shouldHold)
        {
            return shouldHold <= MaxHoldWeight;
        }

        public bool CanBeHeld(IShip ship)
        {
            bool canHold = false;
            for (int i = 0; i < ship.Rows.Count && !canHold; i++)
            {
                IRow row = ship.Rows[i];
                for (int j = 0; j < row.Stacks.Count && !canHold; j++)
                {
                    Stack stack = row.Stacks[j];

                    canHold = stack.CanHoldWeight(this);
                }
            }
            return canHold;
        }
    }
}
