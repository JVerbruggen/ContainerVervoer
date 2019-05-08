using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public class Row
    {
        private int pivot;

        private List<Stack> stacks;
        public IReadOnlyList<Stack> Stacks => stacks;

        public Row(int length)
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
            foreach(Stack s in stacks)
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
            //if (pivotDouble % 1 != 0) // even
            //{
            //    pivot = ((int)pivotDouble) - 1;
            //}
            //else // uneven
            //{
            //    pivot = (int)pivotDouble;
            //}
            return pivot;
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

            int rowWeight = TotalWeight();
            double distribution;
            if (rowWeight != 0)
            {
                distribution = (double)leftWeight / rowWeight * 2 - 1;
            }
            else
            {
                distribution = 0;
            }

            return distribution;
        }

        public Stack GetNextStack(double weightDistribution, IContainer toHold)
        {
            Stack stack;

            if (stacks.Count % 2 == 0) // even
            {
                stack = GetNextStackEven(weightDistribution, toHold);
            }
            else
            {
                stack = GetNextStackUneven(weightDistribution, toHold);
            }

            return stack;
        }

        private Stack GetNextStackEven(double weightDistribution, IContainer toHold)
        {
            Stack stack = null;
            if (weightDistribution >= 0)
            {
                for (int i = 0; i < pivot; i++)
                {
                    Stack s = stacks[i]; // SAME (dry???)
                    if (s.CanHoldWeight(toHold))
                    {
                        if (stack == null)
                        {
                            stack = s;
                        }
                        else if (s.TotalWeight() < stack.TotalWeight())
                        {
                            stack = s;
                        }
                    }
                }
            }
            else
            {
                for (int i = pivot; i < stacks.Count; i++)
                {
                    Stack s = stacks[i]; // SAME
                    if (s.CanHoldWeight(toHold))
                    {
                        if (stack == null)
                        {
                            stack = s;
                        }
                        else if (s.TotalWeight() < stack.TotalWeight())
                        {
                            stack = s;
                        }
                    }
                }
            }
            return stack;
        }

        private Stack GetNextStackUneven(double weightDistribution, IContainer toHold)
        {
            Stack stack = null;
            if (weightDistribution > 0)
            {
                for (int i = 0; i < pivot; i++) // the i<=pivot is the only different thing from the even method (dry????)
                {
                    Stack s = stacks[i]; // SAME (dry???)
                    if (s.CanHoldWeight(toHold))
                    {
                        if (stack == null)
                        {
                            stack = s;
                        }
                        else if (s.TotalWeight() < stack.TotalWeight())
                        {
                            stack = s;
                        }
                    }
                }
            }
            else
            {
                for (int i = pivot; i < stacks.Count; i++)
                {
                    Stack s = stacks[i]; // SAME
                    if (s.CanHoldWeight(toHold))
                    {
                        if (stack == null)
                        {
                            stack = s;
                        }
                        else if (s.TotalWeight() < stack.TotalWeight())
                        {
                            stack = s;
                        }
                    }
                }
            }
            return stack;
        }
    }
}
