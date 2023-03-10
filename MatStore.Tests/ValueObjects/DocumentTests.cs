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
        private Document validDocument; // propriedade do teste para passar
        private Document invalidDocument;   // propriedade do teste para reprovar

        public DocumentTests()  // Metodo Construtor
        {
            validDocument = new Document("28659170377");
            invalidDocument = new Document("12345678910");
        }

        [TestMethod]
        public void ShouldReturnFalseWhenDocumentIsNotValid() // Teste Reprovativo
        {
            Assert.IsFalse(invalidDocument.IsValid);
        }

        [TestMethod]
        public void ShouldReturnTrueWhenDocumentIsValid()   // Teste Aprovativo
        {
            Assert.IsTrue(validDocument.IsValid);
        }
    }
}
