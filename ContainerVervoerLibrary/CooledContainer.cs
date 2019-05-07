using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoerLibrary
{
    public class CooledContainer : BaseContainer
    {
        public CooledContainer(int minWeight, int maxWeight, int maxHoldingWeight, bool valuable) : base(minWeight, maxWeight, maxHoldingWeight, valuable)
        {
        }
    }
}
