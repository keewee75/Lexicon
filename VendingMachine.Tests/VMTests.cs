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
            int expected = 200;
            //Act

            //Assert
            Assert.Equal(expected, sut.MoneyPool);
        }

        [Fact]

        public void InitialPurchasedProductsShouldBeZeroTest()
        {
            //Arrange
            VM sut = new VM();
            int expected = 0;
            //Act

            //Assert
            Assert.Equal(expected, sut.TotalPurchasedItems());
        }

        [Fact]

        public void AllProductsShouldBeNineTest()
        {
            //Arrange
            VM sut = new VM();
            int expected = 9;
            sut.FillUppVendorMachine();
            //Act

            //Assert
            Assert.Equal(expected, sut.ShowAll());
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(5, true)]
        [InlineData(10, true)]
        [InlineData(20, true)]
        [InlineData(50, true)]
        [InlineData(100, true)]
        [InlineData(500, true)]
        [InlineData(1000, true)]
        [InlineData(1001, false)]

        public void InsertMoneyShouldBeCorrectDetominationTest(int money, bool expected)
        {
            //Arrange
            VM sut = new VM();
            //Act
            bool actual = sut.IsValidDenomination(money);
            //Assert
            Assert.Equal(expected, actual);
        }  
    }
}