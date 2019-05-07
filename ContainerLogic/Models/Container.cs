using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public class Container : IContainer
    {
        public int EmptyWeight { get; }
        public int MaxWeight { get; }
        public int MaxHoldWeight { get; }
        public int LoadWeight { get; }
        public int TotalWeight { get => EmptyWeight + LoadWeight; }

        public Container(int loadWeight)
        {
            LoadWeight = loadWeight;
            EmptyWeight = 4000;
            MaxWeight = 30000;
            MaxHoldWeight = 120000;
        }
    }
}
