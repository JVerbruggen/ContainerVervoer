using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public abstract class BaseShip : IShip
    {
        public static readonly int MinLength = 4;
        public static readonly int MaxLength = 16;
        public static readonly int MinWidth = 2;
        public static readonly int MaxWidth = 11;

        public string Name { get; private set; }
        public int MaxWeight { get; private set; }
        public int Length { get; private set; }
        public int Width { get; private set; }

        public IReadOnlyList<IRow> Rows => rows;
        public IReadOnlyList<IContainer> Containers => containers;

        private List<IRow> rows;
        private List<IContainer> containers;
        private int pivot;

        public BaseShip(string name, int length, int width, int maxWeight)
        {
            if (ValidDimensions(length, width))
            {
                MaxWeight = maxWeight;
                Length = length;
                Width = width;
                Name = name;

                rows = GetNewRows(Length, Width);
                containers = new List<IContainer>();

                LoadAllContainers();
            }
            else
            {
                MaxWeight = -1;
                Length = -1;
                Width = -1;
            }
        }

        protected bool ValidDimensions(int length, int width)
        {
            bool validLength = length >= MinLength && length <= MaxLength;
            bool validWidth = width >= MinWidth && width <= MaxWidth;
            return validLength && validWidth;
        }

        public int GetTotalWeight()
        {
            int totalWeight = 0;
            foreach (IContainer c in containers)
            {
                totalWeight += c.TotalWeight;
            }
            return totalWeight;
        }

        private bool CanAddWeight(IContainer container)
        {
            int totalWeight = GetTotalWeight();
            int containerWeight = container.TotalWeight;

            return totalWeight + containerWeight <= MaxWeight;
        }

        /// <summary>
        /// Gets the pivot point of boat width
        /// </summary>
        /// <returns> 
        /// If width even, returns middle-left index of boat width
        /// If width uneven, returns middle index of boat width
        /// </returns>
        private int GetPivotIndex()
        {
            int pivot = rows[0].GetPivotIndex();
            return pivot;
        }

        /// <summary>
        /// Get the distribution of weight on a ship
        /// A very inefficient and stupid solution
        /// </summary>
        /// <returns>A number between -1 and 1, -1 being left, 1 being right</returns>
        public double GetWeightDistribution()
        {
            double weightDistribution = 0;

            if (rows.Count > 0)
            {
                int count = 0;
                foreach (IRow row in rows)
                {
                    weightDistribution += row.GetWeightDistribution();
                    count++;
                }

                //weightDistribution /= count;
            }


            return weightDistribution;
        }

        protected abstract List<IRow> GetNewRows(int length, int width);

        public IRow GetNextRow(IContainer toHold)
        {
            IRow row = null;
            foreach (IRow r in rows)
            {
                if (row == null)
                {
                    row = r;
                }
                else if (r.TotalWeight() < row.TotalWeight())
                {
                    double weightDistribution = GetWeightDistribution();
                    if (r.GetNextStack(weightDistribution, toHold) != null)
                    {
                        row = r;
                    }
                }
            }
            return row;
        }


        public bool Add(IContainer container)
        {
            bool added = false;

            if (CanAddWeight(container)) // Add check if can add cooled and valuable, not only weight
            {
                bool canHold = container.CanBeHeld(this);

                if (canHold)
                {
                    containers.Add(container);
                    added = true;
                }
            }

            return added;
        }

        public void Reset()
        {
            foreach (IRow r in rows)
            {
                r.Reset();
            }
        }

        public void Sort()
        {
            SortingHelper.SortToBeginning<CooledContainer>(containers);
            SortingHelper.SortToEnd<ValuableContainer>(containers);
        }

        public bool LoadAllContainers()
        {
            bool loaded = true;
            Reset();
            Sort();
            pivot = GetPivotIndex();

            if (containers != null)
            {
                for (int i = 0; i < containers.Count && loaded; i++)
                {
                    IContainer c = containers[i];

                    Stack stack = c.GetPosition(this);

                    stack.Add(c);
                }
            }

            return loaded;
        }
    }
}
