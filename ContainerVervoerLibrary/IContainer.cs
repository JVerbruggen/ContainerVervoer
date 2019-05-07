namespace ContainerVervoerLibrary
{
    public interface IContainer
    {
        int minWeight { get; }
        int maxWeight { get; }
        int maxHoldingWeight { get; }
        bool valuable { get; set; }
        int weight { get; set; }
    }
}