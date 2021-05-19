using CowboyCafe.Data;
using System;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class SideTests
    {

        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        public void TypeShouldBeASide(Type type)
        {
            var side = Activator.CreateInstance(type);
            Assert.IsAssignableFrom<Side>(side);
        }
    }
}

