using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public abstract class BaseRow : IRow
    {
        private List<Stack> stacks;

        public IReadOnlyList<Stack> Stacks => stacks;
        public int Pivot;

        public BaseRow(int length)
        {
            Load(length);
        }

        private void Load(int length)
        {
            stacks = GetNewStacks(length);
            Pivot = GetPivotIndex();
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

        protected virtual int GetRightWeight()
        {
            int rightWeight = 0;
            int stacksCount = Stacks.Count;

            for (int i = Pivot; i < stacksCount; i++)
            {
                Stack s = stacks[i];
                int j = i + 1;

                rightWeight += s.TotalWeight();
            }

            return rightWeight;
        }

        public double GetWeightDistribution()
        {
            int leftWeight = 0;
            for (int i = 0; i < Pivot; i++)
            {
                Stack s = stacks[i];
                int j = i + 1;

                leftWeight += s.TotalWeight();
            }

            int rightWeight = GetRightWeight();

            return leftWeight - rightWeight;
        }

        public abstract Stack GetNextStack(double weightDistribution, IContainer toHold);
    }
}
