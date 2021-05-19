using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class TexasTripleBurgerTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var burger = new TexasTripleBurger();
            Assert.Equal(6.45, burger.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var burger = new TexasTripleBurger();
            Assert.Equal<uint>(698, burger.Calories);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var burger = new TexasTripleBurger();
            Assert.Empty(burger.SpecialInstructions);
        }

        [Fact]
        public void HoldingBunShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Bun = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold bun", instruction);
            });
        }

        [Fact]
        public void HoldingKetchupShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Ketchup = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold ketchup", instruction);
            });
        }

        [Fact]
        public void HoldingMustardShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Mustard = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold mustard", instruction);
            });
        }

        [Fact]
        public void HoldingPickleShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Pickle = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold pickle", instruction);
            });
        }

        [Fact]
        public void HoldingCheeseShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Cheese = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold cheese", instruction);
            });
        }

        [Fact]
        public void HoldingMayoShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Mayo = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold mayo", instruction);
            });
        }

        [Fact]
        public void HoldingLettuceShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Lettuce = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold lettuce", instruction);
            });
        }

        [Fact]
        public void HoldingTomatoShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Tomato = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold tomato", instruction);
            });
        }

        [Fact]
        public void HoldingBaconShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Bacon = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold bacon", instruction);
            });
        }

        [Fact]
        public void HoldingEggShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Egg = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold egg", instruction);
            });
        }

        [Fact]
        public void HoldingKetchupAndMustardShouldAddTwoInstructions()
        {
            var burger = new TexasTripleBurger();
            burger.Ketchup = false;
            burger.Mustard = false;
            Assert.Contains("hold ketchup", burger.SpecialInstructions);
            Assert.Contains("hold mustard", burger.SpecialInstructions);
        }

        [Fact]
        public void HoldingBunCheeseAndPickleShouldAddThreeInstructions()
        {
            var burger = new TexasTripleBurger();
            burger.Bun = false;
            burger.Cheese = false;
            burger.Pickle = false;
            Assert.Contains("hold bun", burger.SpecialInstructions);
            Assert.Contains("hold cheese", burger.SpecialInstructions);
            Assert.Contains("hold pickle", burger.SpecialInstructions);
        }

        [Fact]
        public void TexasTripleBurgerImplementsINotifyPropertyChanged()
        {
            var triple = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(triple);
        }

        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Bun", () => { triple.Bun = false; });
        }

        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForBacon()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Bacon", () => { triple.Bacon = false; });
        }

        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForEgg()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Egg", () => { triple.Egg = false; });
        }

        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Ketchup", () => { triple.Ketchup = false; });
        }

        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Lettuce", () => { triple.Lettuce = false; });
        }

        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Tomato", () => { triple.Tomato = false; });
        }

        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Cheese", () => { triple.Cheese = false; });
        }

        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Mayo", () => { triple.Mayo = false; });
        }

        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Mustard", () => { triple.Mustard = false; });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Pickle", () => { triple.Pickle = false; });
        }

        [Fact]
        public void ChangingSpecialInstructionsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () => { triple.Bun = false; });
        }
    }
}