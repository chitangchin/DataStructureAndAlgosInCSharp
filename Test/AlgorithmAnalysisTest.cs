using Exercises;

namespace AlgorithmAnalysisTests
{
    [TestFixture]
    public class AlgorithmAnalysisTests
    {
        [Test]
        public void TestingTimeComplexityOne()
        {
            Assert.That(AlgorithmAnalysis.TimeComplexityOne(), Is.EqualTo(55));
        }
        [Test]
        public void TestingTimeComplexityTwo()
        {
            Assert.That(AlgorithmAnalysis.TimeComplexityTwo(), Is.EqualTo(29));
        }
        public void TestingTimeComplexityThree()
        {
            Assert.That(AlgorithmAnalysis.TimeComplexityThree([1,2,3,4,5,6,7,8], 7), Is.EqualTo(1));
            Assert.That(AlgorithmAnalysis.TimeComplexityThree([1, 2, 3, 4, 5, 6, 7, 8], 10), Is.EqualTo(0));
            Assert.That(AlgorithmAnalysis.TimeComplexityThree([1, 2, 3, 4, 5, 6, 7, 8, 100, 200], 100), Is.EqualTo(1));
        }
    }
}