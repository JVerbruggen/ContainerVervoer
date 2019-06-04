using System;
using ContainerLogic;
using ContainerLogic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerLogicTests.Tests.Containers
{
    [TestClass]
    public class ContainerTest
    {
        [TestMethod]
        public void CanBeHeldTooHeavy()
        {
            ShipRepository shipRepository = new ShipRepository();
            IShip ship = shipRepository.NewEvenShip("", 4, 4, 10000);
            IContainer container = new SuperContainer(500000);

            bool canBeHeld = container.CanBeHeld(ship);

            Assert.IsFalse(canBeHeld);
        }

        [TestMethod]
        public void CanBeHeldSuccessfully()
        {
            ShipRepository shipRepository = new ShipRepository();
            IShip ship = shipRepository.NewEvenShip("", 4, 4, 10000);
            IContainer container = new SuperContainer(5000);

            bool canBeHeld = container.CanBeHeld(ship);

            Assert.IsTrue(canBeHeld);
        }
    }
}
