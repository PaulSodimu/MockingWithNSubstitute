using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingWithNSubstitute.Interfaces;
using NSubstitute;

namespace MockingWithNSubstitute.Tests
{
    [TestClass]
    public class BakeryTests
    {
        public IDoughFactory _doughFactory;
        public IBakery _target;

        [TestInitialize]
        public void SetupTests()
        {

            _doughFactory = Substitute.For<IDoughFactory>();

            _target = new Bakery(_doughFactory);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
