using System;
using System.Collections.Generic;

namespace ContainerVervoerLibrary
{
    public class Ship
    {
        public int width { get; private set; }
        public int length { get; private set; }
        public Stack[,] stackMatrix { get; private set; }
        public int maxWeight { get; private set; }
        public int weight { get; private set; }
        public int leftWeight { get; private set; }
        public int rightWeight { get; private set; }
        public string name { get; private set; }
        public int minContainerWeight { get; set; }
        public int maxContainerWeight { get; set; }
        public List<IContainer> containers { get; set; }
        private enum Side { Left, Right }

        public Ship(string name, int width, int length, int maxWeight)
        {
            this.name = name;
            this.width = width;
            this.length = length;
            this.maxWeight = maxWeight;
            containers = new List<IContainer>();
            weight = 0;

            minContainerWeight = 4000;
            maxContainerWeight = 30000;

            stackMatrix = new Stack[width,length];
            FillWithStacks();
        }

        private void FillWithStacks()
        {
            for(int i = 0; i < stackMatrix.GetLength(0); i++)
            {
                for(int j = 0; j < stackMatrix.GetLength(1); j++)
                {
                    stackMatrix[i, j] = new Stack(0);
                }
            }
        }

        public Stack GetStack(int x, int y)
        {
            Stack stack = null;
            int xLength = stackMatrix.GetLength(0);
            int yLength = stackMatrix.GetLength(1);

            if (x < xLength && y < yLength)
            {
                stack = stackMatrix[x, y];
            }

            return stack;
        }

        private Side GetNotWeightedSide()
        {
            Side side = Side.Left;

            double dLeftRight = rightWeight - leftWeight;
            if (dLeftRight < 0) side = Side.Right;

            return side;
        }

        private int GetMid()
        {
            return (int)Math.Floor(((decimal)stackMatrix.GetLength(0)) / 2);
        }

        private int GetMinColumn(Side side)
        {
            int minColumn = 0;
            if (side == Side.Right)
            {
                int mid = GetMid();
                minColumn = mid + 1;
            }
            return minColumn;
        }

        private int GetMaxColumn(Side side)
        {
            int columnLength = stackMatrix.GetLength(0);
            int maxColumn = columnLength - 1;
            if(side == Side.Left)
            {
                int mid = GetMid();
                bool uneven = mid % 2 == 0;
                if (uneven)
                {
                    maxColumn = mid - 1;
                }
            }
            return maxColumn;
        }
        
        private Stack GetApplicableStack(IContainer baseContainer, Side side, int row)
        {
            Stack stack = null;

            int mid = GetMid();
            bool uneven = mid % 2 == 0;

            int columnMin = GetMinColumn(side);
            int columnMax = GetMaxColumn(side);
            int column = columnMin;

            while (stack == null && column <= columnMax) // For every containerstack in that row
            {
                Stack potentialStack = stackMatrix[column, row];
                if (potentialStack != null && potentialStack.CanHold(baseContainer))
                {
                    stack = potentialStack;
                }

                column++;
            }

            if (stack == null && uneven)
            {
                Stack potentialStack = stackMatrix[row, mid];
                if (potentialStack != null && potentialStack.CanHold(baseContainer))
                {
                    stack = potentialStack;
                }
            }

            return stack;
        }

        public void RefreshContainers()
        {
            FillWithStacks();
            foreach (IContainer container in containers)
            {
                LoadContainer(container);
            }
        }

        private Stack GetApplicableStack(IContainer baseContainer, Side side)
        {
            Stack stack = null;
            int rows = stackMatrix.GetLength(1);
            int row = rows - 1;

            if(baseContainer is CooledContainer)
            {
                stack = GetApplicableStack(baseContainer, side, 0);
            }
            else
            {
                while (stack == null && row >= 0) // For every row of containerstacks on the ship
                {
                    stack = GetApplicableStack(baseContainer, side, row);
                    row--;
                }
            }

            return stack;
        }

        public bool AddContainer(IContainer baseContainer)
        {
            bool loaded = false;
            int baseContainerWeight = baseContainer.weight;

            if (weight + baseContainerWeight <= maxWeight)
            {
                int i = 0;
                while (!loaded && i < containers.Count)
                {
                    IContainer potential = containers[i];
                    if(potential.weight > baseContainer.weight)
                    {
                        containers.Insert(i, baseContainer);
                        loaded = true;
                    }
                    i++;
                }
                if (!loaded)
                {
                    containers.Add(baseContainer);
                    loaded = true;
                }
            }
            return loaded;
        }

        public bool LoadContainer(IContainer baseContainer)
        {
            bool loaded = false;
            Side side = GetNotWeightedSide();
            int baseContainerWeight = baseContainer.weight;

            Stack stack = GetApplicableStack(baseContainer, side);
            if (stack != null && weight + baseContainerWeight <= maxWeight)
            {
                stack.Add(baseContainer);

                if (side == Side.Left)
                {
                    leftWeight += baseContainerWeight;
                }
                else rightWeight += baseContainerWeight;

                weight += baseContainerWeight;

                loaded = true;
            }

            return loaded;
        }

        public Stack[,] GetStacks()
        {
            return stackMatrix;
        }
    }
}