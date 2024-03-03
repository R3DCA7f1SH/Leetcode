namespace LeetCode.Tests.Easy
{
    using LeetCode.SourceCode.Easy;
    public class AddBinaryTest
    {
        private readonly AddBinarySolution solution = new();
        [Fact]
        public void TestIsValid1()
        {
            Assert.Equal(solution.AddBinary("11", "1"), "100");
        }
        [Fact]
        public void TestIsValid2()
        {
            Assert.Equal(solution.AddBinary("1010", "1011"), "10101");
        }
    }
}
