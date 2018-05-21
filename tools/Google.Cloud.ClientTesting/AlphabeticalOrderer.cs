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

using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// Alphabetical orderer for both test collections and test cases. To use, add the following to AssemblyInfo.cs:
    /// [assembly: TestCollectionOrderer(AlphabeticalOrderer.TypeName, AlphabeticalOrderer.AssemblyName)]
    /// [assembly: TestCaseOrderer(AlphabeticalOrderer.TypeName, AlphabeticalOrderer.AssemblyName)]
    /// </summary>
    public class AlphabeticalOrderer : ITestCollectionOrderer, ITestCaseOrderer
    {
        public const string TypeName = "Google.Cloud.ClientTesting." + nameof(AlphabeticalOrderer);
        public const string AssemblyName = "Google.Cloud.ClientTesting";

        public IEnumerable<TTestCase> OrderTestCases<TTestCase>(IEnumerable<TTestCase> testCases) where TTestCase : ITestCase =>
            testCases.OrderBy(test => test.DisplayName, StringComparer.Ordinal);

        public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections) =>
            testCollections.OrderBy(collection => collection.DisplayName, StringComparer.Ordinal);
    }
}
