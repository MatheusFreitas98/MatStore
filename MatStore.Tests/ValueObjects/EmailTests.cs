using MatStore.Domain.StoreContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatStore.Tests.ValueObjects
{
    [TestClass]
    public class EmailTests
    {
        public Email ValidAddress { get; set; }
        public Email InvalidAddress { get; set; }

        public EmailTests()
        {
            ValidAddress = new Email("matheus@gmail.com");
            InvalidAddress = new Email("matheus#gmail.com");
        }

        [TestMethod]
        public void ShouldReturnTrueIfEmailIsValid()
        {
            Assert.IsTrue(ValidAddress.IsValid);
        }

        [TestMethod]
        public void ShouldReturnFalseIfEmailIsInvalid()
        {
            Assert.IsFalse(InvalidAddress.IsValid);
        }

    }
}
