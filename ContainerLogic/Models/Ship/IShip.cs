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
        int MinLength { get; }
        int MaxLength { get; }
        int MinWidth { get; }
        int MaxWidth { get; }

        bool Add(IContainer container);
        IRow GetNextRow(IContainer toHold);
        int GetTotalWeight();
        double GetWeightDistribution();
        bool Init(string name, int length, int width, int maxWeight);
        bool LoadAllContainers();
        void Reset();
        void Sort();
    }
}