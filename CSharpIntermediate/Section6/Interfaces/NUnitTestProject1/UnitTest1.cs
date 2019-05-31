using System;
using Interfaces;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class OrderProcessorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Process_OrderIsAlreadyShipped_ThrowAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            Assert.That(() => orderProcessor.Process(order), Throws.InvalidOperationException);
        }

        [Test]
        public void Process_ShouldRunSuccessfully()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}