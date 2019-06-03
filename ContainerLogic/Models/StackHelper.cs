using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public static class StackHelper
    {

        public static Stack GetNextLeftStack(IContainer toHold, int pivot, IReadOnlyList<Stack> stacks)
        {
            Stack leftStack = null;
            for (int i = pivot; i >= 0; i--)
            {
                Stack s = stacks[i];
                if (s.CanHoldWeight(toHold) && s.IsBetterFitThan(leftStack))
                {
                    leftStack = s;
                }
            }
            return leftStack;
        }

        public static Stack GetNextRightStack(IContainer toHold, int pivot, IReadOnlyList<Stack> stacks)
        {
            Stack rightStack = null;
            for (int i = pivot; i < stacks.Count; i++)
            {
                Stack s = stacks[i];
                if (s.CanHoldWeight(toHold) && s.IsBetterFitThan(rightStack))
                {
                    rightStack = s;
                }
            }
            return rightStack;
        }

    }
}
