using System;
using ContainerLogic;
using ContainerLogic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerLogicTests.Tests
{
    [TestClass]
    public class BaseShipTest
    {
        [TestMethod]
        public void InitializeSuccess()
        {
            //Arrange
            EvenShip ship = new EvenShip("", 5, 5, 10000);

            //Act
            bool init = ship.MaxWeight != -1;

            //Assert
            Assert.IsTrue(init);
        }

        [TestMethod]
        public void InitializeLowLength()
        {
            //Arrange
            int minLength = EvenShip.MinLength;
            EvenShip ship = new EvenShip("", minLength - 1, 5, 10000);

            //Act
            bool init = ship.MaxWeight != -1;

            //Assert
            Assert.IsFalse(init);
        }

        [TestMethod]
        public void InitializeHighLength()
        {
            //Arrange
            int maxLength = EvenShip.MaxLength;
            EvenShip ship = new EvenShip("", maxLength + 1, 5, 10000);

            //Act
            bool init = ship.MaxWeight != -1;

            //Assert
            Assert.IsFalse(init);
        }

        [TestMethod]
        public void InitializeLowWith()
        {
            //Arrange
            int minWidth = EvenShip.MinWidth;
            EvenShip ship = new EvenShip("", 5, minWidth - 1, 10000);

            //Act
            bool init = ship.MaxWeight != -1;

            //Assert
            Assert.IsFalse(init);
        }

        [TestMethod]
        public void InitializeHighWidth()
        {
            //Arrange
            int maxWidth = EvenShip.MaxWidth;
            EvenShip ship = new EvenShip("", 5, maxWidth + 1, 10000);

            //Act
            bool init = ship.MaxWeight != -1;

            //Assert
            Assert.IsFalse(init);
        }


        [TestMethod]
        public void GetTotalWeightWithOneContainer()
        {
            //Arrange
            int containerLoad = 10000;
            ShipRepository shipRepository = new ShipRepository();
            EvenShip ship = shipRepository.NewEvenShip("", 4, 4, 100000);
            IContainer container = new Container(containerLoad);
            int containerWeight = container.EmptyWeight;
            ship.Add(container);

            //Act
            int totalWeight = ship.GetTotalWeight();

            //Assert
            Assert.AreEqual(containerLoad + containerWeight, totalWeight);
        }

        [TestMethod]
        public void GetTotalWeightWithMultipleContainers()
        {
            //Arrange
            int containerLoad = 0;
            int containerWeight = 0;
            ShipRepository shipRepository = new ShipRepository();
            EvenShip ship = shipRepository.NewEvenShip("", 4, 4, 100000);
            for (int i = 0; i < 5; i++)
            {
                IContainer container = new Container(10000);
                containerWeight += container.EmptyWeight;
                containerLoad += container.LoadWeight;
                ship.Add(container);
            }

            //Act
            int totalWeight = ship.GetTotalWeight();

            //Assert
            Assert.AreEqual(containerLoad + containerWeight, totalWeight);
        }

        [TestMethod]
        public void GetTotalWeightWithZeroContainers()
        {
            //Arrange
            ShipRepository shipRepository = new ShipRepository();
            EvenShip ship = shipRepository.NewEvenShip("", 4, 4, 100000);

            //Act
            int totalWeight = ship.GetTotalWeight();

            //Assert
            Assert.AreEqual(0, totalWeight);
        }

        [TestMethod]
        public void GetWeightDistributionWithZeroContainers()
        {
            //Arrange
            ShipRepository shipRepository = new ShipRepository();
            EvenShip ship = shipRepository.NewEvenShip("", 4, 4, 100000);

            //Act
            double weightDistribution = ship.GetWeightDistribution();

            //Assert
            Assert.AreEqual(0, weightDistribution);
        }

        [TestMethod]
        public void GetWeightDistributionWithOneContainer()
        {
            //Arrange
            int containerLoad = 10000;
            ShipRepository shipRepository = new ShipRepository();
            EvenShip ship = shipRepository.NewEvenShip("", 4, 4, 100000);
            IContainer container = new Container(containerLoad);
            int containerWeight = container.EmptyWeight;
            ship.Add(container);
            ship.LoadAllContainers();

            //Act
            double weightDistribution = ship.GetWeightDistribution();

            //Assert
            Assert.AreEqual(containerLoad + containerWeight, weightDistribution);
        }

        [TestMethod]
        public void GetWeightDistributionWithTwoContainers()
        {
            int containerLoad = 0;
            int containerWeight = 0;
            ShipRepository shipRepository = new ShipRepository();
            EvenShip ship = shipRepository.NewEvenShip("", 4, 4, 100000);
            for (int i = 0; i < 2; i++)
            {
                IContainer container = new Container(10000);
                containerWeight += container.EmptyWeight;
                containerLoad += container.LoadWeight;
                ship.Add(container);
            }
            ship.LoadAllContainers();

            //Act
            double weightDistribution = ship.GetWeightDistribution();

            //Assert
            Assert.AreEqual(0, weightDistribution);
        }

        [TestMethod]
        public void GetNextRowFirstContainer()
        {
            //Arrange
            ShipRepository shipRepository = new ShipRepository();
            EvenShip ship = shipRepository.NewEvenShip("", 4, 4, 100000);
            IContainer container = new Container(10000);
            IRow expectedRow = ship.Rows[0];

            //Act
            IRow nextRow = ship.GetNextRow(container);

            //Assert
            Assert.AreEqual(expectedRow, nextRow);
        }

        [TestMethod]
        public void GetNextRowSecondContainer()
        {
            //Arrange
            ShipRepository shipRepository = new ShipRepository();
            EvenShip ship = shipRepository.NewEvenShip("", 4, 4, 100000);
            IContainer firstContainer = new Container(10000);
            IContainer secondContainer = new Container(10000);
            ship.Add(firstContainer);
            ship.LoadAllContainers();

            IRow expectedRow = ship.Rows[1];

            //Act
            IRow nextRow = ship.GetNextRow(secondContainer);

            //Assert
            Assert.AreEqual(expectedRow, nextRow);
        }

        [TestMethod]
        public void AddSuccessfully()
        {
            //Arrange
            ShipRepository shipRepository = new ShipRepository();
            EvenShip ship = shipRepository.NewEvenShip("", 4, 4, 100000);
            IContainer container = new Container(10000);

            //Act
            bool added = ship.Add(container);

            //Assert
            Assert.IsTrue(added);
        }

        [TestMethod]
        public void AddFailedShipCantHold()
        {
            //Arrange
            ShipRepository shipRepository = new ShipRepository();
            EvenShip ship = shipRepository.NewEvenShip("", 4, 4, 5000);
            IContainer container = new Container(10000);

            //Act
            bool added = ship.Add(container);

            //Assert
            Assert.IsFalse(added);
        }

        [TestMethod]
        public void ResetSuccessfully()
        {
            //Arrange
            ShipRepository shipRepository = new ShipRepository();
            EvenShip ship = shipRepository.NewEvenShip("", 4, 4, 100000);
            IContainer container = new Container(10000);
            IRow expectedRow = ship.Rows[0];
            Stack expectedStack = expectedRow.GetNextStack(0, container);
            ship.Add(container);
            ship.LoadAllContainers();

            //Act Assert
            if (expectedStack.Containers.Count == 0)
            {
                Assert.Fail();
            }

            ship.Reset();

            Assert.AreEqual(0, expectedStack.Containers.Count);
        }

    }
}
