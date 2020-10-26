﻿using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Snapper.Nunit.Tests
{
    public class NUnitSnapperTests
    {
        [Test]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void TestIfStoredSnapshotIsMatching()
        {
            var actual = new JObject
            {
                {"TestProperty", "TestValue"}
            };
            Assert.That(actual, Matches.Snapshot());
        }

        [Test]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void TestIfNamedStoredSnapshotIsMatching()
        {
            var actual = new JObject
            {
                {"TestProperty2", "TestValue2"}
            };
            Assert.That(actual, Matches.ChildSnapshot("ChildSnapshot"));
        }
    }
}
