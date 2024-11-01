using Exercises;

namespace Test
{
    [TestFixture]
    public class OrderOfGrowthTest
    {
        [Test]
        public void ConstantTest()
        {
            Assert.That(OrderOfGrowth.ConstantGrowth(), Is.EqualTo(5));
        }
        [Test]
        public void LogarithmTest()
        {
            Assert.That(OrderOfGrowth.LogarithmGrowth([1, 2, 3, 4, 5, 6, 7], 2), Is.EqualTo(1));
            Assert.That(OrderOfGrowth.LogarithmGrowth([1, 2, 3, 4, 5, 6, 7], 8), Is.EqualTo(0));
        }
        [Test]
        public void LinearTest()
        {
            Assert.That(OrderOfGrowth.LinearGrowth(), Is.EqualTo(20));
        }

        private static readonly int[] expected = [1, 2, 3, 4, 6, 6, 7];

        [Test]
        public void NLogNTest()
        {
            Assert.That(OrderOfGrowth.NLogNGrowth([1,6,2,4,6,7,3]), Is.EqualTo(expected));
        }
        [Test]
        public void QuadraticTest()
        {
            Assert.That(OrderOfGrowth.QuadraticGrowth(), Is.EqualTo(100));
        }
        [Test]
        public void CubicTest()
        {
            Assert.That(OrderOfGrowth.CubicGrowth(), Is.EqualTo(1000));
        }
        [Test]
        public void ExponentialTest()
        {
            Assert.That(OrderOfGrowth.ExponentialGrowth(8), Is.EqualTo(21));
        }
    }
}
