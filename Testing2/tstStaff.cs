using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            //creating a new instance for the class we want to create
            clsStaff AStaff = new clsStaff();
            //testing to see if the class actually exists
            Assert.IsNotNull(AStaff);
        }
    }
}
