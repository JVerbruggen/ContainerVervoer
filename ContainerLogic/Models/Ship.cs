using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerLogic.Models
{
    public class Ship
    {
        private List<Row> rows;
        private List<IContainer> containers;
        private int pivot;

        public IReadOnlyList<Row> Rows => rows;
        public IReadOnlyList<IContainer> Containers => containers;

        public string Name { get; private set; }
        public int MaxWeight { get; private set; }
        public int Length { get; private set; }
        public int Width { get; private set; }

        public Ship(string name, int length, int width, int maxWeight, List<IContainer> containers)
        {
            this.containers = containers;

            Init(name, length, width, maxWeight);
        }

        public Ship(string name, int length, int width, int maxWeight)
        {
            Init(name, length, width, maxWeight);
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
        private double GetWeightDistribution()
        {
            double weightDistribution = rows[0].GetWeightDistribution();
            return weightDistribution;
        }

        private List<Row> GetNewRows(int length, int width)
        {
            List<Row> newRows = new List<Row>();
            if (length > 0 && length <= 20)
            {
                for (int i = 0; i < length; i++)
                {
                    Row row = new Row(width);
                    newRows.Add(row);
                }
            }
            return newRows;
        }

        private Row GetNextRow()
        {
            Row row = null;
            foreach (Row r in rows)
            {
                if (row == null)
                {
                    row = r;
                }
                else if (r.TotalWeight() < row.TotalWeight())
                {
                    row = r;
                }
            }
            return row;
        }

        public void Init(string name, int length, int width, int maxWeight)
        {
            MaxWeight = maxWeight;
            Length = length;
            Width = width;
            Name = name;

            rows = GetNewRows(length, width);
            containers = new List<IContainer>();

            LoadAllContainers();
        }

        public bool Add(IContainer container)
        {
            bool added = false;

            if (CanAddWeight(container))
            {
                containers.Add(container);
                added = true;
            }

            return added;
        }

        public void Reset()
        {
            foreach (Row r in rows)
            {
                r.Reset();
            }
        }

        public bool LoadAllContainers()
        {
            bool loaded = true;
            Reset();
            pivot = GetPivotIndex();

            if (containers != null)
            {
                for (int i = 0; i < containers.Count && loaded; i++)
                {
                    IContainer c = containers[i];

                    Row row = GetNextRow();
                    double weightDistribution = GetWeightDistribution();
                    Stack stack = row.GetNextStack(weightDistribution, c);
                    if (stack != null)
                    {
                        stack.Add(c);
                    }
                    else
                    {
                        loaded = false;
                    }
                }
            }

            return loaded;
        }
    }
}
