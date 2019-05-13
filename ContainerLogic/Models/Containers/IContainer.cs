namespace ContainerLogic.Models
{
    public interface IContainer
    {
        int EmptyWeight { get; }
        int LoadWeight { get; }
        int MaxHoldWeight { get; }
        int MaxWeight { get; }
        int TotalWeight { get; }
        Stack GetPosition(Ship ship);
        bool CanHoldWeight(int weight);
    }
}