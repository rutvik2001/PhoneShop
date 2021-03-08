using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstComplaint
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsComplaint AComplaint = new clsComplaint();
            Assert.IsNotNull(AComplaint);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsComplaint AComplaint = new clsComplaint();
            //create some test data to assign to the property
            Boolean issueSolved = true;
            //assign the data to the property
            AComplaint.IssueSolved = issueSolved;
            //test to see that the two values are the same
            Assert.AreEqual(AComplaint.IssueSolved, issueSolved);



        }
        [TestMethod]
        public void ComplaintDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsComplaint AComplaint = new clsComplaint();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AComplaint.ComplaintDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AComplaint.ComplaintDate, TestData);

        }
        [TestMethod]
        public void AddressNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsComplaint AComplaint = new clsComplaint();
            //create some test data to assign to the property
            string TestData = "Rutvik";
            //assign the data to the property
            AComplaint.CustomerFullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AComplaint.CustomerFullName, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsComplaint AComplaint = new clsComplaint();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AComplaint.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AComplaint.CustomerID, TestData);
        }
        [TestMethod]
        public void ComplaintsIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsComplaint AComplaint = new clsComplaint();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AComplaint.ComplaintsID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AComplaint.ComplaintsID, TestData);
        }
        [TestMethod]
        public void ComplaintDescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsComplaint AComplaint = new clsComplaint();
            //create some test data to assign to the property
            string TestData = "Phone screen damaged during shipping";
            //assign the data to the property
            AComplaint.ComplaintDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AComplaint.ComplaintDescription, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsComplaint AComplaint = new clsComplaint();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ComplaintID = 1;
            //invoke the method
            Found = AComplaint.Find(ComplaintID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestComplaintIDFound()
        {
            //create an instance of the class we want to create
            clsComplaint AComplaint = new clsComplaint();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ComplaintIDs = 21;
            //invoke the method
            Found = AComplaint.Find(ComplaintIDs);
            //check the address no
            if (AComplaint.ComplaintsID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsComplaint AComplaint = new clsComplaint();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ComplaintIDs = 21;
            //invoke the method
            Found = AComplaint.Find(ComplaintIDs);
            //check the address no
            if (AComplaint.CustomerID != 555555)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerFullNameFound()
        {
            //create an instance of the class we want to create
            clsComplaint AComplaint = new clsComplaint();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ComplaintIDs = 21;
            //invoke the method
            Found = AComplaint.Find(ComplaintIDs);
            //check the address no
            if (AComplaint.CustomerFullName != "Rutvik Narendra")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestComplaintDescriptionFound()
        {
            //create an instance of the class we want to create
            clsComplaint AComplaint = new clsComplaint();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ComplaintIDs = 21;
            //invoke the method
            Found = AComplaint.Find(ComplaintIDs);
            //check the address no
            if (AComplaint.ComplaintDescription != "Damaged")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestComplaintDateFound()
        {
            //create an instance of the class we want to create
            clsComplaint AComplaint = new clsComplaint();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ComplaintDate = 21;
            //invoke the method
            Found = AComplaint.Find(ComplaintDate);
            //check the address no
            if (AComplaint.ComplaintDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsComplaint AComplaint = new clsComplaint();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IssueSolved = 21;
            //invoke the method
            Found = AComplaint.Find(IssueSolved);
            //check the property
            if (AComplaint.IssueSolved != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
