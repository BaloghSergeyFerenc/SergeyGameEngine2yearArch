namespace GameEngine.CtxLay.CtxItf
{
    public interface IRectangle
    {
        void Init(int a, int b);
        int SideA { get; }
        int SideB { get; }
    }
}
