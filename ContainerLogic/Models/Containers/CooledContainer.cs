using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public class CooledContainer : IContainer
    {
        public int EmptyWeight { get; }
        public int MaxWeight { get; }
        public int MaxHoldWeight { get; }
        public int LoadWeight { get; }
        public int TotalWeight { get => EmptyWeight + LoadWeight; }

        public CooledContainer(int loadWeight)
        {
            LoadWeight = loadWeight;
            EmptyWeight = 4000;
            MaxWeight = 30000;
            MaxHoldWeight = 120000;
        }

        public Stack GetPosition(Ship ship)
        {
            Row row = ship.Rows[0];
            double weightDistribution = ship.GetWeightDistribution();
            Stack stack = row.GetNextStack(weightDistribution, this);

            return stack;
        }

        public bool CanHoldWeight(int weight)
        {
            return weight <= MaxHoldWeight;
        }
    }
}
