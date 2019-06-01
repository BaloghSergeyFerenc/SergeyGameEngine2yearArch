using GameEngine.CtxLay.CtxImpl;
using GameEngine.CtxLay.CtxItf;
using Xunit;

namespace UnitTest.CtxImpl
{
    public class CtxTest
    {
        [Fact]
        public void ConstructorTest()
        {
            ICtx ctx = new Ctx();
            Assert.NotNull(ctx.GetAreaCalc);
            Assert.NotNull(ctx.GetPerimeterCalc);
            Assert.NotNull(ctx.GetRectangleHandler);
        }
    }
}
