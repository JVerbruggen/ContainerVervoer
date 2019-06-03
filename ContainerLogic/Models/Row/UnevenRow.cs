using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public class UnevenRow : BaseRow
    {
        public UnevenRow(int length) : base(length)
        {

        }

        protected override int GetRightWeight()
        {
            int rightWeight = 0;
            int stacksCount = Stacks.Count;

            for (int i = Pivot + 1; i < stacksCount; i++)
            {
                Stack s = Stacks[i];
                int j = i + 1;

                rightWeight += s.TotalWeight();
            }

            return rightWeight;
        }


        public override Stack GetNextStack(double weightDistribution, IContainer toHold)
        {
            Stack finalStack = null;
            Stack rightStack = StackHelper.GetNextRightStack(toHold, Pivot, Stacks);
            Stack leftStack = StackHelper.GetNextLeftStack(toHold, Pivot, Stacks);

            if (weightDistribution <= 0 || rightStack == null)
            {
                finalStack = leftStack;
            }
            else if (weightDistribution > 0 || leftStack == null)
            {
                finalStack = rightStack;
            }

            return finalStack;
        }
    }
}
