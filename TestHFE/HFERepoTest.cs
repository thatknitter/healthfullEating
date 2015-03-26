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
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Recipe("pb&j", "foo", 4, 2, 8, 6, 10, 4));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestFreshIngAddToDB()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new FreshIng("PB", "2 tbsp", "crunchy", "foo"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestPanFreshAddToDB()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new PanFresh("Pb", "2 tbsp", "crunchy", "foo"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestPanDryAddToDB()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new PanDry("Pb", "2 tbsp", "crunchy", "foo"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestCSLessonAddToDB()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new CSLesson("foo", "bar"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestDirectionsAddToDB()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Direction("foo"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestEquipmentAddToDB()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Equipment("bar"));
            Assert.AreEqual(1, repo.GetCount());
        }
    }
}
