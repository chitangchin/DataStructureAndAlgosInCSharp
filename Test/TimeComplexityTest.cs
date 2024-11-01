using Exercises;

namespace Test
{
    [TestFixture]
    public class TimeComplexityTests
    {
        [Test]
        public void TestingTimeComplexityOne()
        {
            Assert.That(TimeComplexity.TimeComplexityOne(), Is.EqualTo(55));
        }
        [Test]
        public void TestingTimeComplexityTwo()
        {
            Assert.That(TimeComplexity.TimeComplexityTwo(), Is.EqualTo(29));
        }
        public void TestingTimeComplexityThree()
        {
            Assert.That(TimeComplexity.TimeComplexityThree([1, 2, 3, 4, 5, 6, 7, 8], 7), Is.EqualTo(1));
            Assert.That(TimeComplexity.TimeComplexityThree([1, 2, 3, 4, 5, 6, 7, 8], 10), Is.EqualTo(0));
            Assert.That(TimeComplexity.TimeComplexityThree([1, 2, 3, 4, 5, 6, 7, 8, 100, 200], 100), Is.EqualTo(1));
        }
    }
}