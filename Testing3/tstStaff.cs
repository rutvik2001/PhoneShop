using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
       // string First = "adam";
       // string Last = "khan";
       // string Dateofbirth = "12/05/2000";
       // string Sal = "2500";
       // string stat = "Yes";

        [TestMethod]
        public void InstancePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff staffinfo = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(staffinfo);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff staffinfo = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            staffinfo.Staffid = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staffinfo.Staffid, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff staffinfo = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Adam";
            //assign the data to the property
            staffinfo.Firstname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staffinfo.Firstname, TestData);
        }

        [TestMethod]
        public void SurnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff staffinfo = new clsStaff();
            //create some test data to assign to the property
            string TestData = "White";
            //assign the data to the property
            staffinfo.Lastname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staffinfo.Lastname, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff staffinfo = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Parse("13/04/1999");
            //assign the data to the property
            staffinfo.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staffinfo.DOB, TestData);
        }

        [TestMethod]
        public void MonthlySalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff staffinfo = new clsStaff();
            //create some test data to assign to the property
            double TestData = 1.0;
            //assign the data to the property
            staffinfo.salary= TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staffinfo.salary, TestData);
        }

        [TestMethod]
        public void MaritalStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff staffinfo = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            staffinfo.Status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staffinfo.Status, TestData);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff staffinfo = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = staffinfo.Find(StaffID);
            //check the address no
            if (staffinfo.Staffid != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff staffinfo = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID1 = 1;
            //invoke the method
            Found = staffinfo.Find(StaffID1);
            //check the address no
            if (staffinfo.Firstname != "Adam")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class we want to create
            clsStaff staffinfo = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID1 = 1;
            //invoke the method
            Found = staffinfo.Find(StaffID1);
            //check the address no
            if (staffinfo.Lastname != "White")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsStaff staffinfo = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID1 = 1;
            //invoke the method
            Found = staffinfo.Find(StaffID1);
            //check the address no
            if (staffinfo.DOB != Convert.ToDateTime("13/04/1995"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff staffinfo = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID1 = 1;
            //invoke the method
            Found = staffinfo.Find(StaffID1);
            //check the address no
            if (staffinfo.salary != 2500)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStatusFound()
        {
            //create an instance of the class we want to create
            clsStaff staffinfo = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID1 = 1;
            //invoke the method
            Found = staffinfo.Find(StaffID1);
            //check the property
            if (staffinfo.Status != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

       // [TestMethod]
       // public void ValidMethodOK()
       // {
            //create an instance of the class we want to create
          //  clsStaff staffinfo = new clsStaff();
          //  String Error = "";
            //Error = staffinfo.Valid(First,Last,Dateofbirth,Sal,stat)
      //  }
    }
}
