using GameEngine.CtxLay.CtxItf;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GameEngine.CtxLay.CtxImpl")]
[assembly: InternalsVisibleTo("UnitTest.ModA")]
namespace GameEngine.LayA.ModA
{
    internal class Rectangle : IRectangle
    {
        public void Init(int a, int b)
        {
            if (a < 1 || b < 1)
            {
                throw new ArgumentException();
            }

            SideA = a;
            SideB = b;
        }

        public int SideA { get; private set; } 
        public int SideB { get; private set; }
    }
}
