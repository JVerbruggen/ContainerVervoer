using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerLogic.Models
{
    public class Ship
    {
        private List<Row> rows;
        private List<IContainer> containers;

        public Ship(List<Row> rows, List<IContainer> containers)
        {
            this.rows = rows;
            this.containers = containers;
        }

        private int GetTotalWeight()
        {
            int totalWeight = 0;
            foreach(IContainer c in containers)
            {
                totalWeight += c.TotalWeight;
            }
            return totalWeight;
        }

        /// <summary>
        /// Get the distribution of weight on a ship
        /// A very inefficient and stupid solution
        /// </summary>
        /// <returns>A number between 0 and 1, 0 being left, 1 being right</returns>
        private double GetWeightDistribution()
        {
            int totalWeight = GetTotalWeight();
            int leftWeight = 0;
            int pivot = rows.Count / 2;

            for(int i = 0; i < pivot; i++)
            {
                Row r = rows[i];
                int rWeight = r.TotalWeight();

                leftWeight += (rWeight / totalWeight);
            }
            return leftWeight;
        }

        public void Load()
        {
            rows = new List<Row>();

            if()
        }
    }
}
