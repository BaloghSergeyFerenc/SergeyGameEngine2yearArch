using GameEngine.CtxLay.CtxItf;
using System.Collections.Generic;

namespace GameEngine.LayA.ModA
{
    internal class RectangleHandler : IRectangleHandler
    {
        private IDictionary<string, IRectangle> Rectangles;
        public RectangleHandler(ICtx ctx)
        {
            GetContext = ctx;
            Rectangles = new Dictionary<string, IRectangle>();
        }

        #region IRectangleHandler

        public ICtx GetContext { get; }

        public void Add(string name, int a, int b)
        {
            IRectangle rectangle;
            if(Rectangles.TryGetValue(name, out rectangle))
            {
                rectangle.Init(a, b);
            }
            else
            {
                rectangle = new Rectangle();
                rectangle.Init(a, b);
                Rectangles.Add(name, rectangle);
            }
        }

        public IRectangle Get(string name)
        {
            IRectangle rectangle;
            Rectangles.TryGetValue(name, out rectangle);
            return rectangle;
        }

        public int GetArea(string name)
        {
            IRectangle rectangle;
            if (Rectangles.TryGetValue(name, out rectangle))
            {
                return GetContext.GetAreaCalc.Calc(rectangle);
            }
            return 0;
        }

        public int GetPerimeter(string name)
        {
            IRectangle rectangle;
            if (Rectangles.TryGetValue(name, out rectangle))
            {
                return GetContext.GetPerimeterCalc.Calc(rectangle);
            }
            return 0;
        }
        #endregion IRectangleHandler
    }
}
