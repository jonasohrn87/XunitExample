using XunitExample;

namespace XunitExampleTest
{
    public class MyMathTest
    {
        private MyMath myMath;

        public MyMathTest() { 
            myMath = new MyMath();
        }

        [Theory]
        [InlineData(1,false)]
        [InlineData(2,true)]
        [InlineData(11,false)]
        [InlineData(22,true)]
        public void EvenOrOdd(int nr, bool expected)
        {        
          
            //Assert
            Assert.Equal(myMath.EvenOrOdd(nr),expected);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(11, 5)]
        [InlineData(22, 5)]
        public void Add(int nr1, int nr2)
        {

            //Assert
            Assert.Equal(myMath.Add(nr1, nr2), nr1 + nr2);
        }
    }
}