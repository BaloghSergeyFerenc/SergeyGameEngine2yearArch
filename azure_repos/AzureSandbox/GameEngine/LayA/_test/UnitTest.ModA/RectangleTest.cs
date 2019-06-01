using GameEngine.LayA.ModA;
using System;
using Xunit;

namespace UnitTest.ModA
{
    public class RectangleTest
    {
        [Fact]
        public void InitTest()
        {
            Rectangle x = new Rectangle();
            x.Init(1, 2);
            Assert.True(x.SideA == 1, "Side A is not set.");
            Assert.True(x.SideB == 2, "Side B is not set.");
            Assert.Throws<ArgumentException>(() => x.Init(-1, 2));
            Assert.Throws<ArgumentException>(() => x.Init(1, 0));
        }
    }
}
