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

using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// Factory methods for creating <see cref="ConformanceTestData{T}" /> instances.
    /// </summary>
    public static class ConformanceTestData
    {
        /// <summary>
        /// Loads the conformance tests for an API
        /// </summary>
        /// <typeparam name="T">The protobuf type that each JSON file is expected to conform to.</typeparam>
        /// <param name="pathElements">The path elements for the API, relative to the conformance test root, e.g. [ "firestore", "v1" ]</param>
        /// <returns>The conformance test data.</returns>
        public static ConformanceTestData<T> Load<T>(params string[] pathElements)
            where T : IMessage<T>, new()
        {
            pathElements = new[] { TestEnvironment.FindConformanceTestsDirectory() }.Concat(pathElements).ToArray();
            string dataPath = Path.Combine(pathElements);
            var mergedTests = LoadAndMergeTests<T>(dataPath);
            return new ConformanceTestData<T>(dataPath, mergedTests);
        }

        private static T LoadAndMergeTests<T>(string dataPath)
            where T : IMessage<T>, new()
        {
            var ret = new T();
            var parser = new MessageParser<T>(() => new T());
            var files = Directory.GetFiles(dataPath, "*.json")
                .Where(p => !Path.GetFileName(p).Contains("not-a-test"))
                // Order for consistency
                .OrderBy(x => x)
                .Select(path => parser.ParseJson(File.ReadAllText(path)));
            foreach (var file in files)
            {
                ret.MergeFrom(file);
            }
            return ret;
        }
    }

    /// <summary>
    /// Helper to access conformance test data.
    /// </summary>
    /// <typeparam name="T">The test file type that all JSON files conform to.</typeparam>
    public sealed class ConformanceTestData<T> where T : IMessage<T>, new()
    {
        /// <summary>
        /// The path containing the conformance data for this API.
        /// </summary>
        public string DataPath { get; }

        /// <summary>
        /// The complete merged set of tests, loaded in filename order.
        /// </summary>
        public T MergedTests { get; }

        /// <summary>
        /// Creates an instance for the layout of conformance tests for a specific API.
        /// </summary>
        /// <param name="dataPath">The data path</param>
        /// <param name="mergedTests">The merged set of tests</param>
        internal ConformanceTestData(string dataPath, T mergedTests)
        {
            DataPath = dataPath;
            MergedTests = mergedTests;
        }

        /// <summary>
        /// Convenience method to create a TheoryData for a given test subset.
        /// </summary>
        public TheoryData<TTest> GetTheoryData<TTest>(Func<T, IEnumerable<TTest>> testExtractor)
        {
            var ret = new TheoryData<TTest>();
            foreach (var test in testExtractor(MergedTests))
            {
                ret.Add(test);
            }
            return ret;
        }
    }
}
