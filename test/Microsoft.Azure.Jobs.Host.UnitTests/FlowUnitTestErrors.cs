﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Azure.Jobs.Host.Indexers;
using Xunit;

namespace Microsoft.Azure.Jobs.Host.UnitTests
{
    // Test failure cases for indexing
    public class FlowUnitTestErrors
    {
        [Fact]
        public void TestFails()
        {
            foreach (var method in this.GetType().GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
            {
                Indexer indexer = new Indexer(null, null, null, null, null);
                Assert.Throws<IndexException>(() => indexer.CreateFunctionDefinition(method));
            }
        }

        private static void BadTableName([Table(@"#")] IDictionary<Tuple<string, string>, object> t) { }

        private static void MultipleQueueParams([QueueTrigger("p123")] int p123, [QueueTrigger("p234")] int p234) { }
    }
}
