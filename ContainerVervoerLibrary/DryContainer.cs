using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContainerVervoerLibrary
{
    public class DryContainer : BaseContainer
    {
        public DryContainer(int minWeight, int maxWeight, int maxHoldingWeight, bool valuable) : base(minWeight, maxWeight, maxHoldingWeight, valuable)
        {
        }
    }
}
