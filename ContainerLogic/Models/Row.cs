using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public class Row
    {
        private List<Stack> stacks;

        public Row(List<Stack> stacks)
        {
            this.stacks = stacks;
        }

        public int TotalWeight()
        {
            int totalWeight = 0;
            foreach(Stack s in stacks)
            {
                totalWeight += s.TotalWeight();
            }
            return totalWeight;
        }
    }
}
