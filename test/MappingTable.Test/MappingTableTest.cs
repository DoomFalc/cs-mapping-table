using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Gen = System.Collections.Generic;

namespace MappingTable.Test
{
    [TestClass]
    public class MappingTableTest
    {
        [TestMethod]
        public void TestKeyNotFound()
        {
            TestKey("any-unexisting-key", "default-value");   
        }

        [TestMethod]
        public void TestKeyFound()
        {
            TestKey("arbitrary-key", "arbitrary-value");
        }

        private void TestKey(string key, string expected)
        {
            var mapping = GetMapping();
            var func = mapping[key];

            Assert.AreEqual(expected, func()); 
        }

        private Gen.MappingTable<string, Func<string>> GetMapping() => new Gen.MappingTable<string, Func<string>>()
        {
            Mapping =
            {
                { "arbitrary-key", () => "arbitrary-value" }
            },
            Default = () => "default-value"
        };
    }
}
