using GameEngine.CtxLay.CtxItf;
using GameEngine.LayB.ModB;
using Moq;
using System;
using Xunit;

namespace UnitTest.ModB
{
    public class AreaCalcTest
    {
        [Fact]
        public void CalcTest()
        {
            Mock<IRectangle> mockRectangle = new Mock<IRectangle>();
            mockRectangle.SetupGet(m => m.SideA).Returns(1);
            mockRectangle.SetupGet(m => m.SideB).Returns(2);
            AreaCalc areaCalc = new AreaCalc();
            Assert.True(areaCalc.Calc(mockRectangle.Object) == 2, "Area is incorrect.");
            Assert.Throws<ArgumentNullException>(() => areaCalc.Calc(null));
        }
    }
}
