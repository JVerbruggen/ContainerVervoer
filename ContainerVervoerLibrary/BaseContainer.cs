using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoerLibrary
{
    public abstract class BaseContainer: IContainer
    {
        public int minWeight { get; private set; }
        public int maxWeight { get; private set; }
        public int maxHoldingWeight { get; private set; }
        public bool valuable { get; set; }
        public int weight { get; set; }

        public BaseContainer(int minWeight, int maxWeight, int maxHoldingWeight, bool valuable)
        {
            this.minWeight = minWeight;
            this.maxWeight = maxWeight;
            this.maxHoldingWeight = maxHoldingWeight;
            this.valuable = valuable;
        }
    }
}
