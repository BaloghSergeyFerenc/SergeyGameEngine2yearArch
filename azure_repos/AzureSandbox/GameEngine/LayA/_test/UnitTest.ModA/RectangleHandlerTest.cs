using GameEngine.CtxLay.CtxItf;
using GameEngine.LayA.ModA;
using Moq;
using Xunit;

namespace UnitTest.ModA
{
    public class RectangleHandlerTest
    {
        [Fact]
        public void AddTest()
        {
            Mock<ICtx> mockCtx = new Mock<ICtx>();
            RectangleHandler rectangleHandler = new RectangleHandler(mockCtx.Object);
            rectangleHandler.Add("NoName", 8, 5);
            rectangleHandler.Add("NoName", 4, 7);
        }

        [Fact]
        public void GetTest()
        {
            Mock<ICtx> mockCtx = new Mock<ICtx>();
            RectangleHandler rectangleHandler = new RectangleHandler(mockCtx.Object);
            rectangleHandler.Add("NoName", 8, 5);
            IRectangle rectangle = rectangleHandler.Get("NoName");
            Assert.NotNull(rectangle);
            Assert.True(rectangle.SideA == 8 && rectangle.SideB == 5);
            Assert.Null(rectangleHandler.Get("aaa"));
        }

        [Fact]
        public void GetAreaTest()
        {
            Mock<ICtx> mockCtx = new Mock<ICtx>();
            Mock<IAreaCalc> mockArea = new Mock<IAreaCalc>();
            mockCtx.SetupGet(a => a.GetAreaCalc).Returns(mockArea.Object);
            mockArea.Setup(f => f.Calc(It.IsAny<IRectangle>())).Returns<IRectangle>(
                g =>
                {
                    return g.SideA * g.SideB;
                });
            RectangleHandler rectangleHandler = new RectangleHandler(mockCtx.Object);
            rectangleHandler.Add("NoName", 8, 5);
            Assert.True(rectangleHandler.GetArea("NoName") == 40);
            Assert.True(rectangleHandler.GetArea("aaa") == 0);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            Mock<ICtx> mockCtx = new Mock<ICtx>();
            Mock<IPerimeterCalc> mockPerimeter = new Mock<IPerimeterCalc>();
            mockCtx.SetupGet(a => a.GetPerimeterCalc).Returns(mockPerimeter.Object);
            mockPerimeter.Setup(f => f.Calc(It.IsAny<IRectangle>())).Returns<IRectangle>(
                g =>
                {
                    return (g.SideA + g.SideB) * 2;
                });
            RectangleHandler rectangleHandler = new RectangleHandler(mockCtx.Object);
            rectangleHandler.Add("NoName", 8, 5);
            Assert.True(rectangleHandler.GetPerimeter("NoName") == 26);
            Assert.True(rectangleHandler.GetPerimeter("aaa") == 0);
        }
    }
}
