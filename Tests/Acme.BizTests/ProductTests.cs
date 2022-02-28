using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "Saw";
            currentProduct.Description = "15 inch steel blade saw";
            currentProduct.ProductId = 1;
            var expected = "Hello Saw (1): 15 inch steel blade saw";
            //Act
            var actual = currentProduct.SayHello();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}