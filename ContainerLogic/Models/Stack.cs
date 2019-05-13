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

            //int shouldHold = container.TotalWeight;

            //for (int i = containers.Count - 1; i >= 0 && canHoldWeight; i--)
            //{
            //    IContainer c = containers[i];

            //    // Currently cant stack a normal container if stack contains valuable container
            //    canHoldWeight = c.CanHoldWeight(shouldHold);
            //}

            if(containers.Count > 0)
            {
                IContainer bottomContainer = containers[0];
                canHoldWeight = bottomContainer.CanHoldWeight(TotalWeight() - bottomContainer.TotalWeight);

                if(container is ValuableContainer)
                {
                    if(containers[Containers.Count - 1] is ValuableContainer)
                    {
                        canHoldWeight = false;
                    }
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
            foreach(IContainer c in containers)
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
