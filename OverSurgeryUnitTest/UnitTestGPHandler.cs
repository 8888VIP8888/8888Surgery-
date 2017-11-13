using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using OverSurgery;

namespace OverSurgeryUnitTest
{
    [TestClass]
    public class UnitTestGPHandler
    {
        [TestMethod]
        public void TestAddNewGP()
        {
            DBConnector dbC = new DBConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            GeneralPractitioner gp = new GeneralPractitioner();

            gp.Name = "Hector Barbossa";
            gp.Status = 1;
            gp.DateJoined = new DateTime (2017, 1, 15, 0, 0, 0);
            gp.LoginName = "hector";
            gp.Password = "hector123";

            GPHandler gpHnd = new GPHandler();
            int resp2 = gpHnd.addNewGP(dbC.getConn(), gp);

        }

       
    }
}
