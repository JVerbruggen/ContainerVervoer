using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public abstract class BaseContainer : IContainer
    {
        public int EmptyWeight { get; protected set; }
        public int MaxWeight { get; protected set; }
        public int MaxHoldWeight { get; protected set; }
        public int LoadWeight { get; protected set; }
        public int TotalWeight { get => EmptyWeight + LoadWeight; }

        public BaseContainer(int loadWeight)
        {
            MaxWeight = 30000;
            EmptyWeight = 4000;
            MaxHoldWeight = 120000;

            if (loadWeight >= MaxWeight || loadWeight < 0)
            {
                LoadWeight = -1;
            }
            else
            {
                LoadWeight = loadWeight;
            }
        }

        public BaseContainer(int loadWeight, int maxWeight)
        {
            MaxWeight = maxWeight;
            EmptyWeight = 4000;
            MaxHoldWeight = 120000;

            if (loadWeight >= MaxWeight || loadWeight < 0)
            {
                LoadWeight = -1;
            }
            else
            {
                LoadWeight = loadWeight;
            }
        }

        public virtual Stack GetPosition(IShip ship)
        {
            IRow row = ship.GetNextRow(this);
            double weightDistribution = ship.GetWeightDistribution();
            Stack stack = row.GetNextStack(weightDistribution, this);

            return stack;
        }

        public virtual bool CanHoldWeight(int shouldHold)
        {
            return shouldHold <= MaxHoldWeight;
        }

        public virtual bool CanBeHeld(IShip ship)
        {
            bool canHold = false;
            if (ship.MaxWeight >= this.TotalWeight + ship.GetTotalWeight())
            {
                for (int i = 0; i < ship.Rows.Count && !canHold; i++)
                {
                    IRow row = ship.Rows[i];
                    for (int j = 0; j < row.Stacks.Count && !canHold; j++)
                    {
                        Stack stack = row.Stacks[j];
                        canHold = stack.CanHoldWeight(this);
                    }
                }
            }
            return canHold;
        }
    }
}
