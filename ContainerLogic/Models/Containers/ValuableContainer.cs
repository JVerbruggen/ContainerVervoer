namespace ContainerLogic.Models
{
    public class ValuableContainer : IContainer
    {
        public int EmptyWeight { get; }
        public int MaxWeight { get; }
        public int MaxHoldWeight { get; }
        public int LoadWeight { get; }
        public int TotalWeight { get => EmptyWeight + LoadWeight; }

        public ValuableContainer(int loadWeight)
        {
            LoadWeight = loadWeight;
            EmptyWeight = 4000;
            MaxWeight = 30000;
            MaxHoldWeight = 120000;
        }

        public Stack GetPosition(Ship ship)
        {
            Row row = ship.GetNextRow(this);
            double weightDistribution = ship.GetWeightDistribution();
            Stack stack = row.GetNextStack(weightDistribution, this);

            return stack;
        }

        public bool CanHoldWeight(int weight)
        {
            return false;
        }

        public bool CanBeHeld(Ship ship)
        {
            bool canBeHeld = false;
            for (int i = 0; i < ship.Rows.Count && !canBeHeld; i++)
            {
                Row row = ship.Rows[i];
                for (int j = 0; j < row.Stacks.Count && !canBeHeld; j++)
                {
                    Stack stack = row.Stacks[j];

                    if(stack.Containers.Count > 0 && stack.Containers[0] is ValuableContainer)
                    {
                        canBeHeld = false;
                    }
                    else
                    {
                        canBeHeld = stack.CanHoldWeight(this);
                    }
                }
            }
            return canBeHeld;
        }
    }
}
