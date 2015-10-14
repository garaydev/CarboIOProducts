using System;
using CarboIOProducts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CarboIOVSUnitTests
{
    [TestClass]
    public class ProductTesting
    {
        [TestMethod]
        public void GetGenericListofProductsTest()
        {
            //Arrange
            List<Products> productList = new List<Products>();
            
            //Act
            productList = Products.getGenericProductList(true);
            //Assert

            Assert.AreNotEqual(0,productList.Count);
        }

        [TestMethod]
        public void ProductsConstructorTest()
        {
            //Arrange
            Products productConstruct = new Products();

            //Act
            productConstruct.ProductForSale = true;
            //Assert

            Assert.IsNotNull(productConstruct.ProductName);
        }
    }
}
