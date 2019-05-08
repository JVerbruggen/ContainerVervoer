using ContainerLogic.Enums;

namespace ContainerLogic.Models
{
    public class Container : IContainer
    {
        public int EmptyWeight { get; }
        public int MaxWeight { get; }
        public int MaxHoldWeight { get; }
        public int LoadWeight { get; }
        public int TotalWeight { get => EmptyWeight + LoadWeight; }
        public ContainerType Type { get; }

        public Container(int loadWeight, ContainerType type)
        {
            LoadWeight = loadWeight;
            EmptyWeight = 4000;
            MaxWeight = 30000;
            MaxHoldWeight = 120000;
            Type = type;
        }
    }
}
