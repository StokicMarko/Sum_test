using Sum_test;

namespace Sum_test_xUnit
{
    public class UnitTest1
    {
        private readonly Sum sum ;
        
        public UnitTest1()
        {
            sum = new Sum();
        }
        [Fact]
        public void Should_Return_Sum_Of_Two_Input_Numbers()
        {
            Assert.Equal(8, sum.SumOperation(6,2));
        }
    }
}