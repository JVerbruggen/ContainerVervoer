namespace ContainerLogic.Models
{
    public interface IContainer
    {
        int EmptyWeight { get; }
        int LoadWeight { get; }
        int MaxHoldWeight { get; }
        int MaxWeight { get; }
        int TotalWeight { get; }
        Stack GetPosition(IShip ship);
        bool CanHoldWeight(int weight);

        bool CanBeHeld(IShip ship);
    }
}