using MatStore.Domain.StoreContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatStore.Tests.ValueObjects
{
    [TestClass]
    public class NameTests
    {
        public Name ValidFullName { get; set; }
        public Name InvalidFirstName { get; set; }
        public Name InvalidLastName { get; set; }

        public NameTests()
        {
            ValidFullName = new Name("Joaquim", "da Silva");
            InvalidFirstName = new Name("Jo", "Moreira");
            InvalidLastName = new Name("Lucas", "d");
        }

        [TestMethod]
        public void ShouldReturnTrueIfFullNameIsValid()
        {
            Assert.IsTrue(ValidFullName.IsValid);
        }

        [TestMethod]
        public void ShouldReturnFalseIfFirstNameIsInvalid()
        {
            Assert.IsFalse(InvalidFirstName.IsValid);
        }

        [TestMethod]
        public void ShouldReturnFalseIfLastNameIsInvalid()
        {
            Assert.IsFalse(InvalidLastName.IsValid);
        }
    }
}
