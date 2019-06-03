using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public static class SortingHelper
    {

        public static void SortToBeginning<T>(IList<IContainer> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                IContainer container = list[i];
                if (container is T)
                {
                    bool swapped = false;
                    for (int j = 0; j < i && !swapped; j++)
                    {
                        IContainer c = list[j];
                        if (!(c is T))
                        {
                            list[i] = c;
                            list[j] = container;
                            swapped = true;
                        }
                    }
                }
            }
        }

        public static void SortToEnd<T>(IList<IContainer> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                IContainer container = list[i];
                if (container is T)
                {
                    bool swapped = false;
                    for (int j = list.Count - 1; j > i && !swapped; j--)
                    {
                        IContainer c = list[j];
                        if (!(c is T))
                        {
                            list[i] = c;
                            list[j] = container;
                            swapped = true;
                        }
                    }
                }
            }
        }

    }
}
