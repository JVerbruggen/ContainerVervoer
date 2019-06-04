using ContainerLogic.Models;

namespace ContainerLogicTests
{
    public class SuperContainer : BaseContainer
    {
        public SuperContainer(int loadWeight): base(loadWeight, 10000000)
        {

        }
    }
}
