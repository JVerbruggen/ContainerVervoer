using ContainerLogic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerLogicTests.Tests
{
    [TestClass]
    public class RowTest
    {
        [TestMethod]
        public void GetWeightDistributionWithZeroContainers()
        {
            //Arrange
            EvenRow evenRow = new EvenRow(4);

            //Act
            double weightDistribution = evenRow.GetWeightDistribution();

            //Assert
            Assert.AreEqual(0, weightDistribution);
        }

        [TestMethod]
        public void GetWeightDistributionWithOneContainer()
        {
            //Arrange
            int containerLoad = 10000;
            EvenRow evenRow = new EvenRow(4);
            IContainer container = new Container(containerLoad);
            int containerWeight = container.EmptyWeight;
            Stack stack = evenRow.GetNextStack(0, container);
            stack.Add(container);

            //Act
            double weightDistribution = evenRow.GetWeightDistribution();

            //Assert
            Assert.AreEqual(containerLoad + containerWeight, weightDistribution);
        }

        [TestMethod]
        public void GetWeightDistributionWithTwoContainers()
        {
            int containerLoad = 0;
            int containerWeight = 0;
            EvenRow evenRow = new EvenRow(4);
            for (int i = 0; i < 2; i++)
            {
                IContainer container = new Container(10000);
                containerWeight += container.EmptyWeight;
                containerLoad += container.LoadWeight;
                Stack stack = evenRow.GetNextStack(evenRow.GetWeightDistribution(), container);
                stack.Add(container);
            }

            //Act
            double weightDistribution = evenRow.GetWeightDistribution();

            //Assert
            Assert.AreEqual(0, weightDistribution);
        }

        [TestMethod]
        public void GetWeightDistributionWithTwoUnevenContainers()
        {
            int containerLoad = 0;
            int containerWeight = 0;
            EvenRow evenRow = new EvenRow(4);
            for (int i = 0; i < 2; i++)
            {
                IContainer container = new Container(10000 * i);
                containerWeight += container.EmptyWeight;
                containerLoad += container.LoadWeight;
                double wd = evenRow.GetWeightDistribution();
                Stack stack = evenRow.GetNextStack(wd, container);
                stack.Add(container);
            }

            //Act
            double weightDistribution = evenRow.GetWeightDistribution();

            //Assert
            Assert.AreEqual(-10000, weightDistribution);
        }


    }
}
