using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Collections.Generic;
using healthfullEating;

namespace TestHFE
{
    [TestClass]
    public class HFERepoTest
    {
        private static RecipeRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new RecipeRepository("Name=TestDB");
            repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            repo.Clear();
        }

        [TestCleanup]
        public void ClearDatabase()
        {
            repo.Clear();
        }

        [TestMethod]
        public void TestAddToDatabase()
        {
            Assert.AreEqual(0, repo.GetCount);
            repo.Add(new Recipe("PB&J"));
            Assert.AreEqual(1, repo.GetCount);
        }
    }
}
