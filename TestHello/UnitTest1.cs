using HelloWoldClasses;

namespace TestHello
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Given_4_Then_Hello()
        {
            //arrage
            int a = 8;
            string expected = "Hello";
            Calculator calculator = new Calculator();
            //act
            string output = calculator.divideby4(a);

            //assert
            Assert.Equal(output, expected);
        }
        [Fact]
        public void Test_Given_6_Then_Hello()
        {
            //arrage
            int a = 6;
            string expected = "World";
            Calculator calculator = new Calculator();
            //act
            string output = calculator.divideby6(a);

            //assert
            Assert.Equal(output, expected);
        }
        [Fact]
        public void Test_4_and_6()
        {
            //arrage
            int a = 24;
            string expected = "HelloWorld";
            Calculator calculator = new Calculator();
            //act
            string output = calculator.dividebyboth(a);

            //assert
            Assert.Equal(output, expected);
        }
        [Fact]
        public void Test_4_and_6_is_neither()
        {
            //arrage
            int a = 5;
            int expected = 5;
            Calculator calculator = new Calculator();
            //act
            int output = calculator.dividewrong(a);

            //assert
            Assert.Equal(output, expected);
        }
    }
}