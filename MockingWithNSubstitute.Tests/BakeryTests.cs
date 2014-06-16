using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingWithNSubstitute.Interfaces;
using MockingWithNSubstitute.Objects;
using NSubstitute;

namespace MockingWithNSubstitute.Tests
{
    [TestClass]
    public class BakeryTests
    {
        public Dough _fakeDough;
        public IDoughFactory _doughFactory;
        public IBakery _target;

        [TestInitialize]
        public void SetupTests()
        {
            //Creates a new substitute for the IDoughFactory interface
            _doughFactory = Substitute.For<IDoughFactory>(); 

            //Creates a substitute for the dough
            _fakeDough = Substitute.For<Dough>();
             
            _target = new Bakery(_doughFactory);
        }

        [TestMethod]
        public void MakeBread_ReturnsSomeBread()
        {
            //Arrange

            //Set the properties of the fake dough 
            _fakeDough.Flour = 12;
            _fakeDough.Water = 11;
            _fakeDough.Yeast = 3;

            //Set the behaviour for the getDough method to always return a fake dough for any integer
            _doughFactory.GetDough(Arg.Any<int>()).Returns(_fakeDough);
                
            //Act
            var result = _target.MakeBread(1);

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
