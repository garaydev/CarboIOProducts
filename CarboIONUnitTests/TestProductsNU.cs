using NUnit.Framework;
using CarboIOProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarboIONUnitTests
{
    [TestFixture]
    public class TestProductsNU
    {
        [TestCase]
        public void NUGetGenericListofProductsTest()
        {
            //Arrange
            List<Products> productList = new List<Products>();

            //Act
            productList = Products.getGenericProductList(true);
            //Assert

            Assert.AreNotEqual(0, productList.Count);
        }
    }
}
