namespace GameEngine.CtxLay.CtxItf
{
    public interface ICtx
    {
        IRectangleHandler GetRectangleHandler { get; }
        IPerimeterCalc GetPerimeterCalc { get; }
        IAreaCalc GetAreaCalc { get; }
    }
}
