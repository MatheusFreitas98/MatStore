using MatStore.Domain.StoreContext.Entities;
using MatStore.Domain.StoreContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatStore.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        private Document validDocument;
        private Document invalidDocument;

        public DocumentTests()
        {
            validDocument = new Document("28659170377");
            invalidDocument = new Document("12345678910");
        }

        [TestMethod]
        public void ShouldReturnFalseWhenDocumentIsNotValid()
        {
            Assert.IsFalse(invalidDocument.IsValid);
        }

        [TestMethod]
        public void ShouldReturnTrueWhenDocumentIsValid()
        {
            Assert.IsTrue(validDocument.IsValid);
        }
    }
}
