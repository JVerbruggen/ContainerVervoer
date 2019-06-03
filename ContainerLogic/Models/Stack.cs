using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public class Stack
    {
        private List<IContainer> containers;
        public IReadOnlyList<IContainer> Containers => containers;

        public Stack()
        {
            containers = new List<IContainer>();
        }

        public bool CanHoldWeight(IContainer container)
        {
            bool canHoldWeight = true;

            if (containers.Count > 0)
            {
                IContainer bottomContainer = containers[0];
                int stackWeight = TotalWeight();
                int shouldHold = stackWeight - bottomContainer.TotalWeight + container.TotalWeight;

                canHoldWeight = bottomContainer.CanHoldWeight(shouldHold);

                if (canHoldWeight)
                {
                    IContainer top = containers[Containers.Count - 1];
                    canHoldWeight = top.CanHoldWeight(container.TotalWeight);
                }
            }

            return canHoldWeight;
        }

        public void Add(IContainer container)
        {
            containers.Add(container);
        }

        public void Reset()
        {
            containers.Clear();
        }

        public int TotalWeight()
        {
            int totalWeight = 0;
            foreach (IContainer c in containers)
            {
                totalWeight += c.TotalWeight;
            }
            return totalWeight;
        }

        public bool IsBetterFitThan(Stack s)
        {
            bool better = true;
            if (s != null && s.TotalWeight() < this.TotalWeight())
            {
                better = false;
            }
            return better;
        }
    }
}
