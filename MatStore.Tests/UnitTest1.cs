using MatStore.Domain.StoreContext.Entities;
using MatStore.Domain.StoreContext.ValueObjects;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

namespace MatStore.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var name = new Name("Matheus", "Freitas");
        var document = new Document("12345678987");
        var address = new List<Address>();
        var email = new Email("matheus@gmail.com");
        var phone = new Phone("(41)99775-4631");

        var costumer = new Customer(name, document, email, phone); // Criando Costumer

        var mouse = new Product(123, "Mouse", "Alto DPI", 79.90M, 100, "https:img.com.br");
        var notebook = new Product(544, "Notebook Samsung", "Samsung foda", 2499.90M, 20, "https:img.com.br");
        var monitor = new Product(451, "Monitor LG", "LG foda", 640.90M, 70, "https:img.com.br");
        var teclado = new Product(471, "Teclado bom", "mt foda", 120.90M, 20, "https:img.com.br");

        var order = new Order(costumer); // Criando Order
        order.AddItem(new OrderItem(mouse, 5));
        order.AddItem(new OrderItem(notebook, 5));
        order.AddItem(new OrderItem(monitor, 5));
        order.AddItem(new OrderItem(teclado, 5));

        order.Place();
    }
}