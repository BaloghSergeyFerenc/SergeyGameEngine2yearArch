using GameEngine.CtxLay.CtxItf;
using GameEngine.LayB.ModB;
using Moq;
using System;
using Xunit;

namespace UnitTest.ModB
{
    public class PerimeterCalcTest
    {
        [Fact]
        public void CalcTest()
        {
            Mock<IRectangle> mockRectangle = new Mock<IRectangle>();
            mockRectangle.SetupGet(m => m.SideA).Returns(1);
            mockRectangle.SetupGet(m => m.SideB).Returns(2);
            PerimeterCalc perimeterCalc = new PerimeterCalc();
            Assert.True(perimeterCalc.Calc(mockRectangle.Object) == 6, "Perimeter is incorrect.");
            Assert.Throws<ArgumentNullException>(() => perimeterCalc.Calc(null));

        }
    }
}
