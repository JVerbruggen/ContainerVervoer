using System.Collections.Generic;

namespace ContainerLogic.Models
{
    public interface IShip
    {
        IReadOnlyList<IContainer> Containers { get; }
        int Length { get; }
        int MaxWeight { get; }
        string Name { get; }
        IReadOnlyList<IRow> Rows { get; }
        int Width { get; }

        bool Add(IContainer container);
        IRow GetNextRow(IContainer toHold);
        int GetTotalWeight();
        double GetWeightDistribution();
        bool LoadAllContainers();
        void Reset();
        void Sort();
    }
}