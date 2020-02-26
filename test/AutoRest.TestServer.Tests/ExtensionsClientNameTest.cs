// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Reflection;
using ExtensionClientName;
using ExtensionClientName.Models;
using NUnit.Framework;

namespace AutoRest.TestServer.Tests
{
    public class ExtensionsClientNameTest
    {
        [Test]
        public void ParametersAreRenamed()
        {
            var method = TypeAsserts.HasPublicInstanceMethod(typeof(AllOperations), "RenamedOperationAsync");
            // TODO: Add more tests here
            TypeAsserts.HasParameter(method, "renamedBodyParameter");
            TypeAsserts.HasParameter(method, "renamedPathParameter");
            TypeAsserts.HasParameter(method, "renamedQueryParameter");
        }

        [Test]
        public void PropertiesAreRenamed()
        {
            TypeAsserts.HasProperty(typeof(RenamedSchema), "RenamedProperty", BindingFlags.Instance | BindingFlags.Public);
            TypeAsserts.HasProperty(typeof(RenamedSchema), "RenamedPropertyString", BindingFlags.Instance | BindingFlags.Public);
        }

        [Test]
        public void HeaderTypesAreRenamed()
        {
            Assert.AreEqual("RenamedOperationHeaders", typeof(RenamedOperationHeaders).Name);
        }
    }
}