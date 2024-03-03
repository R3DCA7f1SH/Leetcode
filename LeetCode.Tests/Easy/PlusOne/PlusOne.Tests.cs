using LeetCode.SourceCode.Easy;

namespace LeetCode.Tests.Easy
{
    public class PlusOneTests
    {
        private readonly PlusOneSolution solution = new();
        
        [Fact]
        public void TestIsValid1()
        {
            Assert.Equal(solution.PlusOne([1, 2, 3]), [1, 2, 4]);
        }

        [Fact]
        public void TestIsValid2()
        {
            Assert.Equal(solution.PlusOne([4, 3, 2, 1]), [4, 3, 2, 2]);
        }

        [Fact]
        public void TestIsValid3()
        {
            Assert.Equal(solution.PlusOne([9]), [1,0]);
        }
    }
}
