using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public class EvenRow : BaseRow
    {
        public EvenRow(int length): base(length)
        {
                
        }

        protected override int GetRightWeight()
        {
            int rightWeight = 0;
            int stacksCount = Stacks.Count;

            for (int i = Pivot; i < stacksCount; i++)
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
            Stack rightStack = StackHelper.GetNextRightStack(toHold, base.Pivot, Stacks);
            Stack leftStack = StackHelper.GetNextLeftStack(toHold, Pivot - 1, Stacks);

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
