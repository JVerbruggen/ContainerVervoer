using System;
using ContainerLogic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerLogicTests.Tests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void CanHoldWeightSuccessfully()
        {
            //Arrange
            Stack stack = new Stack();
            IContainer firstContainer = new Container(1000);
            int toHold = firstContainer.MaxHoldWeight - firstContainer.EmptyWeight;

            IContainer secondContainer = new Container(toHold);
            stack.Add(firstContainer);

            //Act
            bool canHoldWeight = stack.CanHoldWeight(secondContainer);

            //Assert
            Assert.IsTrue(canHoldWeight);
        }

        [TestMethod]
        public void CanHoldWeightTooHeavy()
        {
            //Arrange
            Stack stack = new Stack();
            IContainer firstContainer = new Container(1000);
            int toHold = firstContainer.MaxHoldWeight + 1;

            IContainer secondContainer = new SuperContainer(toHold);
            stack.Add(firstContainer);

            //Act
            bool canHoldWeight = stack.CanHoldWeight(secondContainer);

            //Assert
            Assert.IsFalse(canHoldWeight);
        }

        [TestMethod]
        public void CanHoldWeightValuableOnTop()
        {
            //Arrange
            Stack stack = new Stack();
            IContainer valuable = new ValuableContainer(1000);
            IContainer toAdd = new Container(1000);
            stack.Add(valuable);

            //Act
            bool canHoldWeight = stack.CanHoldWeight(toAdd);

            //Assert
            Assert.IsFalse(canHoldWeight);
        }

        [TestMethod]
        public void CanHoldWeightAddingValuableOnRegulars()
        {
            //Arrange
            Stack stack = new Stack();
            IContainer container = new Container(1000);
            IContainer toAdd = new ValuableContainer(1000);
            stack.Add(container);

            //Act
            bool canHoldWeight = stack.CanHoldWeight(toAdd);

            //Assert
            Assert.IsTrue(canHoldWeight);
        }

        [TestMethod]
        public void AddSuccessfully()
        {
            //Arrange
            Stack stack = new Stack();
            IContainer container = new Container(1000);

            //Act
            stack.Add(container);

            //Assert
            Assert.AreEqual(1, stack.Containers.Count);
        }

        [TestMethod]
        public void ResetSuccessfully()
        {
            //Arrange
            Stack stack = new Stack();
            IContainer container = new Container(1000);
            stack.Add(container);

            //Act
            stack.Reset();

            //Assert
            Assert.AreEqual(0, stack.Containers.Count);
        }

        [TestMethod]
        public void TotalWeightCorrect()
        {
            //Arrange
            Stack stack = new Stack();
            IContainer container = new Container(1000);
            stack.Add(container);
            int expectedWeight = container.TotalWeight;

            //Act
            int actualWeight = stack.TotalWeight();

            //Assert
            Assert.AreEqual(expectedWeight, actualWeight);
        }

        [TestMethod]
        public void IsWorseFitThan()
        {
            //Arrange
            Stack stack = new Stack();
            Stack betterStack = new Stack();
            stack.Add(new Container(2000));
            betterStack.Add(new Container(1000));
            IContainer container = new Container(5000);

            //Act
            bool isBetter = stack.IsBetterFitThan(betterStack);

            //Assert
            Assert.IsFalse(isBetter);
        }

        [TestMethod]
        public void IsBetterFitThan()
        {
            //Arrange
            Stack stack = new Stack();
            Stack betterStack = new Stack();
            stack.Add(new Container(2000));
            betterStack.Add(new Container(1000));
            IContainer container = new Container(5000);

            //Act
            bool isBetter = betterStack.IsBetterFitThan(stack);

            //Assert
            Assert.IsTrue(isBetter);
        }
    }
}
