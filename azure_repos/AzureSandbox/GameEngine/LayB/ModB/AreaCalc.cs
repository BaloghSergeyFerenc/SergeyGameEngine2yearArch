using GameEngine.CtxLay.CtxItf;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTest.ModB")]
[assembly: InternalsVisibleTo("GameEngine.CtxLay.CtxImpl")]
namespace GameEngine.LayB.ModB
{
    internal class AreaCalc : IAreaCalc
    {
        public int Calc(IRectangle rectangle)
        {
            if (rectangle == null)
            {
                throw new ArgumentNullException();
            }
            return rectangle.SideA * rectangle.SideB;
        }
    }
}
