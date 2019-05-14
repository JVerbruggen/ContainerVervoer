using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ContainerLogic.Models
{
    public class UnevenShip : IShip
    {
        private List<IRow> rows;
        private List<IContainer> containers;
        private int pivot;

        public IReadOnlyList<IRow> Rows => rows;
        public IReadOnlyList<IContainer> Containers => containers;

        public string Name { get; private set; }
        public int MaxWeight { get; private set; }
        public int Length { get; private set; }
        public int Width { get; private set; }

        public UnevenShip(string name, int length, int width, int maxWeight, List<IContainer> containers)
        {
            this.containers = containers;

            Init(name, length, width, maxWeight);
        }

        public UnevenShip(string name, int length, int width, int maxWeight)
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

                weightDistribution /= count;
            }

            
            return weightDistribution;
        }

        private List<IRow> GetNewRows(int length, int width)
        {
            List<IRow> newRows = new List<IRow>();
            if (length > 0 && length <= 20)
            {
                for (int i = 0; i < length; i++)
                {
                    IRow row = new UnevenRow(width);
                    newRows.Add(row);
                }
            }
            return newRows;
        }

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
                    if(r.GetNextStack(weightDistribution, toHold) != null)
                    {
                        row = r;
                    }
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

            if (CanAddWeight(container)) // Add check if can add cooled and valuable, not only weight
            {
                bool canHold = container.CanBeHeld(this);

                //for(int i = 0; i < rows.Count && !canHold; i++)
                //{
                //    Row row = rows[i];
                //    for(int j = 0; j < row.Stacks.Count && !canHold; j++)
                //    {
                //        Stack stack = row.Stacks[j];

                //        canHold = stack.CanHoldWeight(container);
                //    }
                //}
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

        private void SortToBeginning<T>(IList<IContainer> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                IContainer container = list[i];
                if (container is T)
                {
                    bool swapped = false;
                    for (int j = 0; j < i && !swapped; j++)
                    {
                        IContainer c = list[j];
                        if (!(c is T))
                        {
                            list[i] = c;
                            list[j] = container;
                            swapped = true;
                        }
                    }
                }
            }
        }

        private void SortToEnd<T>(IList<IContainer> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                IContainer container = list[i];
                if (container is T)
                {
                    bool swapped = false;
                    for (int j = list.Count - 1; j > i && !swapped; j--)
                    {
                        IContainer c = list[j];
                        if (!(c is T))
                        {
                            list[i] = c;
                            list[j] = container;
                            swapped = true;
                        }
                    }
                }
            } 
        }

        public void Sort()
        {
            SortToBeginning<CooledContainer>(containers);
            SortToEnd<ValuableContainer>(containers);
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

                    //Row row = GetNextRow();
                    //double weightDistribution = GetWeightDistribution();
                    //if(i > 5 && i == containers.Count - 1)
                    //{
                    //    int j = i;
                    //}

                    //Stack stack = row.GetNextStack(weightDistribution, c);

                    Stack stack = c.GetPosition(this);

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
