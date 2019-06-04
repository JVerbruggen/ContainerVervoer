namespace ContainerLogic.Models
{
    public class ValuableContainer : BaseContainer
    {
        public ValuableContainer(int loadWeight) : base(loadWeight)
        {

        }

        public override bool CanHoldWeight(int weight)
        {
            return false;
        }

        public override bool CanBeHeld(IShip ship)
        {
            bool canBeHeld = false;
            for (int i = 0; i < ship.Rows.Count && !canBeHeld; i++)
            {
                IRow row = ship.Rows[i];
                for (int j = 0; j < row.Stacks.Count && !canBeHeld; j++)
                {
                    Stack stack = row.Stacks[j];

                    if (stack.Containers.Count > 0 && stack.Containers[0] is ValuableContainer)
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
