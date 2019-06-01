namespace GameEngine.CtxLay.CtxItf
{
    public interface IRectangleHandler
    {
        ICtx GetContext { get; }
        void Add(string name, int a, int b);
        int GetArea(string name);
        int GetPerimeter(string name);
        IRectangle Get(string name);
    }
}
