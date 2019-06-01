using GameEngine.CtxLay.CtxItf;
using GameEngine.LayA.ModA;
using GameEngine.LayB.ModB;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTest.CtxImpl")]
namespace GameEngine.CtxLay.CtxImpl
{
    internal class Ctx : ICtx
    {
        public IRectangleHandler GetRectangleHandler { get; }
        public IPerimeterCalc GetPerimeterCalc { get; } = new PerimeterCalc();
        public IAreaCalc GetAreaCalc { get; } = new AreaCalc();

        public Ctx()
        {
            GetRectangleHandler =  new RectangleHandler(this);
        }
    }
}
