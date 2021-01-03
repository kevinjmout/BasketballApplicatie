using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainterVervoer;
namespace ContainerVervoerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Container container1 = new Container
            {
                Weight = 30,
                IsRefrigerated = false,
                IsValuable = false
            };
            

            ContainerCollection containerCollection = new ContainerCollection();
            for (int i = 0; i < 21; i++)
            {
                containerCollection.Add(container1);
            }

            containerCollection.OrderByWeight();
            Deck deck = new Deck();

            //Act
            deck.Add(containerCollection.GetContainers(), 4);

            //Assert
            Assert.AreEqual(2, deck.GetRows().Count);
        }
    }
}
