using Parmeterized.UnitTests;

namespace TestProject.UnitTests
{
    public class UnitTest1
    {
        public static IEnumerable<object[]> TestData =>
        new List<object[]>()
        {
            new object[] { 1, 2, 3 },
            new object[] { 11, 22, 33 },
            new object[] { 111, 222, 333 },

        };

        [Theory]
        [ClassData(typeof(TestClassData))]
        public void Test_add_two_nerbers_using_memebr_ClassData(int x, int y, int expectedResult)
        {
            var calculator = new Calculator();

            var result = calculator.Add(x, y);

            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [MemberData(nameof(TestData))]       
        public void Test_add_two_nerbers_using_memebr_data(int x, int y, int expectedResult)
        {
            var calculator = new Calculator();

            var result = calculator.Add(x, y);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(11, 22, 33)]
        public void Test_add_two_nerbers(int x, int y, int expectedResult)
        {
            var calculator = new Calculator();

            var result = calculator.Add(x, y);

            Assert.Equal(expectedResult, result);
        }      

    }
}