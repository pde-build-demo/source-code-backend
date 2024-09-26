using Xunit;

namespace tests
{
    public class TestProgram
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var expected = 1;            

            // Act
            // Call the method to test here
            var actual = Add(1, 0);

            // Assert
            Assert.Equal(expected, actual);
        }

        int Add(int x, int y) => x + y;
    }
}