using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public class EvenRow : IRow
    {
        private int pivot;

        private List<Stack> stacks;
        public IReadOnlyList<Stack> Stacks => stacks;

        public EvenRow(int length)
        {
            Load(length);
        }

        private void Load(int length)
        {
            stacks = GetNewStacks(length);
            pivot = GetPivotIndex();
        }

        private List<Stack> GetNewStacks(int length)
        {
            List<Stack> stacks = new List<Stack>();

            for (int i = 0; i < length; i++)
            {
                Stack s = new Stack();
                stacks.Add(s);
            }

            return stacks;
        }

        public void Reset()
        {
            foreach (Stack s in stacks)
            {
                s.Reset();
            }
        }

        public int TotalWeight()
        {
            int totalWeight = 0;
            foreach (Stack s in stacks)
            {
                totalWeight += s.TotalWeight();
            }
            return totalWeight;
        }

        /// <summary>
        /// Gets the pivot point of row length
        /// </summary>
        /// <returns> 
        /// If width even, returns middle-right index of boat width
        /// If width uneven, returns middle index of boat width
        /// </returns>
        public int GetPivotIndex()
        {
            int pivot;
            double pivotDouble = Stacks.Count / 2;
            pivot = (int)pivotDouble;
            return pivot;
        }

        private int GetRightWeight()
        {
            int rightWeight = 0;
            int stacksCount = Stacks.Count;

            for (int i = pivot; i < pivot; i++)
            {
                Stack s = stacks[i];
                int j = i + 1;

                rightWeight += s.TotalWeight();
            }

            return rightWeight;
        }

        /// <summary>
        /// Get the distribution of weight on a row
        /// A very inefficient and stupid solution
        /// </summary>
        /// <returns>A number between -1 and 1, -1 being left, 1 being right</returns>
        public double GetWeightDistribution()
        {
            int leftWeight = 0;
            for (int i = 0; i < pivot; i++)
            {
                Stack s = stacks[i];
                int j = i + 1;

                leftWeight += s.TotalWeight();
            }

            int rightWeight = GetRightWeight();

            int leftRightWeight = leftWeight + rightWeight;

            return leftWeight - rightWeight;
        }

        public Stack GetNextStack(double weightDistribution, IContainer toHold)
        {
            Stack rightStack = null;
            Stack leftStack = null;
            if (weightDistribution >= 0)
            {
                for (int i = 0; i < pivot; i++)
                {
                    Stack s = stacks[i];
                    if (s.CanHoldWeight(toHold) && s.IsBetterFitThan(leftStack))
                    {
                        leftStack = s;
                    }
                }
            }
            else
            {
                for (int i = pivot; i < stacks.Count; i++)
                {
                    Stack s = stacks[i];
                    if (s.CanHoldWeight(toHold) && s.IsBetterFitThan(rightStack))
                    {
                        rightStack = s;
                    }
                }
            }
            return rightStack;
        }

        private Stack GetNextLeftStack(IContainer toHold)
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

        private Stack GetNextRightStack(IContainer toHold)
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
