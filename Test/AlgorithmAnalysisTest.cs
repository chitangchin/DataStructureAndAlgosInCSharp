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
    }
}