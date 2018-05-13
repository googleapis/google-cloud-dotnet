// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.ClientTesting;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Google.Cloud.Firestore.Tests
{
    public class CodeHealthTest
    {
        [Fact]
        public void PrivateFields()
        {
            CodeHealthTester.AssertAllFieldsPrivate(typeof(FirestoreDb));
        }

        [Fact]
        public void SealedClasses()
        {
            // Query is neither sealed nor abstract, deliberately: CollectionReference derives from it, and
            // it creates new instances of itself.
            CodeHealthTester.AssertClassesAreSealedOrAbstract(typeof(FirestoreDb), new[] { typeof(Query) });
        }

        [Fact]
        public void NoOptionalParameters()
        {
            string[] allowedMethods = { "FirestoreDb.Create", "FirestoreDb.CreateAsync" };
            var methods = from type in typeof(FirestoreDb).GetTypeInfo().Assembly.GetTypes()
                          from method in type.GetTypeInfo().GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                          where method.GetParameters().Any(p => p.IsOptional)
                          select $"{type.Name}.{method.Name}";
            Assert.Empty(methods.Except(allowedMethods));
        }
    }
}
