namespace VendingMachine.Tests
{
    public class VMTests
    {
        [Fact]

        public void UpdateSaldoTest()
        {
            //Arrange
            VM sut = new VM();
            sut.MoneyPool = 100;
            sut.IncreaseMoneyPool(100);

            //Act
            int expected = 200;
            //Assert
            Assert.Equal(expected, sut.MoneyPool);
        }

        [Fact]

        public void AddProductToPurchasedListTest()
        {
            //Arrange
            VM sut = new VM();
            sut.MoneyPool = 100;
            sut.IncreaseMoneyPool(100);

            //Act
            int expected = 200;
            //Assert
            Assert.Equal(expected, sut.MoneyPool);
        }
    }
}