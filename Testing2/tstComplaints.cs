using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstComplaints
    {
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnAddress.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Active, TestData);
        }

    }
}
