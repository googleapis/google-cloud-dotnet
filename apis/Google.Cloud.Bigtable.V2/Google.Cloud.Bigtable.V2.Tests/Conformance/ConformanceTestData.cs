// Copyright 2019 Google LLC
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
using Google.Protobuf.Collections;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests.Conformance
{
    // Note: we may want to move some of this logic into ClientTesting over time.
    // (We now have similar code in Storage and Bigtable.)
    internal static class ConformanceTestData
    {
        internal static ReadOnlyCollection<TestFile> TestFiles { get; } =
            Directory.GetFiles(DataPath, "*.json")
                .Select(path => TestFile.Parser.ParseJson(File.ReadAllText(path)))
                .ToList()
                .AsReadOnly();

        private static string DataPath => Path.Combine(TestEnvironment.FindConformanceTestsDirectory(), "bigtable", "v2");

        internal static TheoryData<T> GetTheoryData<T>(Func<TestFile, RepeatedField<T>> testExtractor)
        {
            var ret = new TheoryData<T>();
            foreach (var file in TestFiles)
            {
                foreach (var test in testExtractor(file))
                {
                    ret.Add(test);
                }
            }
            return ret;
        }
    }
}