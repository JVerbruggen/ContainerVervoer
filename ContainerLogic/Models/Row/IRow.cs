using System.Collections.Generic;

namespace ContainerLogic.Models
{
    public interface IRow
    {
        IReadOnlyList<Stack> Stacks { get; }

        Stack GetNextStack(double weightDistribution, IContainer toHold);
        int GetPivotIndex();
        double GetWeightDistribution();
        void Reset();
        int TotalWeight();
    }
}