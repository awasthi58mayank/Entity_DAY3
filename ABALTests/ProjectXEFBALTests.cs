using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ado.net_EF_BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADTO;
using ABAL;

namespace Ado.net_EF_BAL.Tests
{
    [TestClass()]
    public class ProjectXEFBALTests
    {
        [TestMethod()]
        public void AddNewFacultyTest()
        {
            ProjectXEFBAL obj = new ProjectXEFBAL();
            FacultyDTO facObj = new FacultyDTO
            {
                PSNo = 99004951,
                EmailId = "pqr@gmail.com",
                NAME = "PQR"
            };

            int returnValue = obj.AddNewFaculty(facObj);
            int actual = returnValue;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void UpdateFacultyTest()
        {
            ProjectXEFBAL obj = new ProjectXEFBAL();
            FacultyDTO facObj = new FacultyDTO
            {
                PSNo = 99004923,
                NAME = "Purple"
            };

            int returnValue = obj.UpdateFaculty(facObj);
            int actual = returnValue;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DeleteFacultyTest()
        {
            ProjectXEFBAL obj = new ProjectXEFBAL();
            FacultyDTO facObj = new FacultyDTO
            {
                PSNo = 44004924
            };

            int returnValue = obj.DeleteFaculty(facObj);
            int actual = returnValue;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}