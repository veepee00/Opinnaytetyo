using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toikka.Oppari.UnitTests
{

    

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var files = CheckOldFilesFromDirectory(@"C:\Temp", "*.txt");

            Assert.IsTrue(files.Count == 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.ThrowsException<ArgumentNullException>(() => CheckOldFilesFromDirectory(@"C:\Temp", null));
            Assert.ThrowsException<ArgumentNullException>(() => CheckOldFilesFromDirectory(null, "*."));
            Assert.ThrowsException<ArgumentNullException>(() => CheckOldFilesFromDirectory(@"C:\Temp", ""));
            Assert.ThrowsException<ArgumentNullException>(() => CheckOldFilesFromDirectory("", "*."));
        }

        private List<String> CheckOldFilesFromDirectory(string folder, string mask)
        {
            throw new NotImplementedException();
        }
    }
}
