using CowboyCafe.Data;
using System;
using Xunit;

namespace CowboyCafe.DataTests
{

    public class DrinkTests
    {
        [Theory]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void TypeShouldBeADrink(Type type)
        {
            var drink = Activator.CreateInstance(type);
            Assert.IsAssignableFrom<Drink>(drink);
        }
    }
}