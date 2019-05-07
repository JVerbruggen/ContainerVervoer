using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogic.Models
{
    public class ColdContainer : IContainer
    {
        public int EmptyWeight { get; }
        public int LoadWeight { get; }
        public int MaxHoldWeight { get; }
        public int MaxWeight { get; }
        public int TotalWeight => EmptyWeight + LoadWeight;

        public ColdContainer(int loadWeight)
        {
            LoadWeight = loadWeight;
            EmptyWeight = 4000;
            MaxWeight = 30000;
            MaxHoldWeight = 120000;
        }
    }
}
