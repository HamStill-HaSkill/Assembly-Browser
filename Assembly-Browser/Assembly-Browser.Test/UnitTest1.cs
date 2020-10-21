using Assembly_BrowserLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Browser.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NamespaceTest()
        {
            string expected = "EXEProject";

            string path = @"C:\Users\Xiaomi\source\repos\Assembly-Browser\Assembly-Browser\EXEProject\bin\Debug\EXEProject.exe";
            var asm = new AssemblyBrowser().GetAssemblyInfo(path);

            string actual = asm[0].Name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ClassNameTest()
        {
            string expected = "Program";

            string path = @"C:\Users\Xiaomi\source\repos\Assembly-Browser\Assembly-Browser\EXEProject\bin\Debug\EXEProject.exe";
            var asm = new AssemblyBrowser().GetAssemblyInfo(path);

            string actual = asm[0].Classes[0].Name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BadFilePathTest()
        {
            string path = "";
            var asm = new AssemblyBrowser().GetAssemblyInfo(path);

            Assert.AreEqual(0, asm.Count);
        }
    }
}
