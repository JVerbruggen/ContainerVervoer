using System.Collections.Generic;

namespace ContainerVervoerLibrary
{
    public class Stack
    {
        private List<IContainer> containers;
        public int weight;

        public Stack(int weight)
        {
            this.weight = weight;
            containers = new List<IContainer>();
        }

        public void Add(IContainer baseContainer)
        {
            weight += baseContainer.weight;
            containers.Add(baseContainer);
        }

        public bool Remove(IContainer baseContainer)
        {
            bool removed = containers.Remove(baseContainer);
            if (removed)
            {
                weight -= baseContainer.weight;
            }
            return removed;
        }

        public IReadOnlyList<IContainer> GetContainers()
        {
            return containers;
        }

        private IContainer GetTopContainer()
        {
            IContainer baseContainer = null;
            int containersCount = containers.Count;
            if (containersCount > 0)
            {
                baseContainer = containers[containersCount - 1];
            }
            return baseContainer;
        }

        public bool CanHold(IContainer baseContainer)
        {
            bool canHold = true;

            IContainer topContainer = GetTopContainer();
            if (topContainer != null)
            {
                canHold = !topContainer.valuable;
            }

            if(canHold && containers.Count > 0)
            {
                int totalWeight = baseContainer.weight;

                int i = containers.Count - 1;
                while (canHold && i >= 0)
                {
                    IContainer potential = containers[i];
                    int potentialWeight = potential.weight;

                    if(totalWeight > potential.maxHoldingWeight)
                    {
                        canHold = false;
                    }

                    totalWeight += potentialWeight;
                    i--;
                }
            }

            return canHold;
        }


    }
}