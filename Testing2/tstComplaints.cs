using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstComplaints
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsComplaints AComplaint = new clsComplaints();
            Assert.IsNotNull(AComplaint);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsComplaints AComplaint = new clsComplaints();
            //create some test data to assign to the property
            Boolean issueSolved = true;
            //assign the data to the property
            AComplaint.Active = issueSolved;
            //test to see that the two values are the same
            Assert.AreEqual(AComplaint.Active, issueSolved);



        }
        [TestMethod]
        public void ComplaintDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsComplaints AComplaint = new clsComplaints();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AComplaint.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AComplaint.DateAdded, TestData);

        }
        [TestMethod]
        public void AddressNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsComplaints AComplaint = new clsComplaints();
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
            clsComplaints AComplaint = new clsComplaints();
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
            clsComplaints AComplaint = new clsComplaints();
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
            clsComplaints AComplaint = new clsComplaints();
            //create some test data to assign to the property
            string TestData = "Phone screen damaged during shipping";
            //assign the data to the property
            AComplaint.ComplaintDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AComplaint.ComplaintDescription, TestData);
        }
    }
}
