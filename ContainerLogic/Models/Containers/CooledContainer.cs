using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public class CooledContainer : BaseContainer
    {
        public CooledContainer(int loadWeight): base(loadWeight)
        {

        }

        public override Stack GetPosition(IShip ship)
        {
            IRow row = ship.Rows[0];
            double weightDistribution = ship.GetWeightDistribution();
            Stack stack = row.GetNextStack(weightDistribution, this);

            return stack;
        }

        public override bool CanBeHeld(IShip ship)
        {
            bool canHold = false;
            IRow row = ship.Rows[0];
            for (int j = 0; j < row.Stacks.Count && !canHold; j++)
            {
                Stack stack = row.Stacks[j];

                canHold = stack.CanHoldWeight(this);
            }
            return canHold;
        }
    }
}
