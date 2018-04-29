using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class PreliminaryUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string className = "CarInvoice.Form1";
            var type = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                from x in assembly.GetTypes()
                where x.Name == className
                select x).FirstOrDefault();

            Assert.IsNotNull(type);
//            if (type == null) throw new InvalidOperationException("Valid type not found.");

//            object instance = Activator.CreateInstance(type);
        }
    }
}
