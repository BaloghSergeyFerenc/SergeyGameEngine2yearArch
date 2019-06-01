using GameEngine.CtxLay.CtxItf;
using System;
using System.Runtime.CompilerServices;

namespace GameEngine.LayB.ModB
{
    internal class PerimeterCalc : IPerimeterCalc
    {
        public int Calc(IRectangle rectangle)
        {
            if (rectangle == null)
            {
                throw new ArgumentNullException();
            }
            return (rectangle.SideA + rectangle.SideB) * 2;
        }
    }
}
