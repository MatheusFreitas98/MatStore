using MatStore.Domain.StoreContext.Entities;

namespace MatStore.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var c = new Customer("Matheus", "Freitas", "123456", "matheus@gmail.com", "(41)99775-4631", "Francisco Rocha, 1750");

        var o = new Order(c);
    }
}