using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace Mogle.PaintMixer.Algorithm.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void MixTest()
        {
            var calculator = new Calculator();
            var actualColor = calculator.Mix(new ColorRatio(Color.FromArgb(255, 255, 255), 2), new ColorRatio(Color.FromArgb(254, 254, 254), 2));
            Assert.AreEqual(Color.FromArgb(254, 254, 254), actualColor);
        }

        [TestMethod]
        public void MixTest2()
        {
            var calculator = new Calculator();
            var actualColor = calculator.Mix(new ColorRatio(Color.FromArgb(255, 255, 255), 1));
            Assert.AreEqual(Color.FromArgb(255, 255, 255), actualColor);
        }
    }
}
