using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_Komodo_Claims_Repository;

namespace _02_Komodo_Claims_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddClaimShouldReturnCorrectBoolean()
        {
            Claims newClaims = new Claims();
            Claims_Repo repository = new Claims_Repo();

            bool wasAdded = repository.AddClaimsToQueue(newClaims);

            Assert.IsTrue(wasAdded);


        }
    }
}
