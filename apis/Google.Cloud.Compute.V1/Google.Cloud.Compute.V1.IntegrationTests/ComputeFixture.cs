// Copyright 2021 Google LLC
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
using System;
using Xunit;

namespace Google.Cloud.Compute.V1.IntegrationTests
{
    [CollectionDefinition(nameof(ComputeFixture))]
    public class ComputeFixture : CloudProjectFixtureBase, ICollectionFixture<ComputeFixture>
    {
        // Note: this would more naturally be called COMPUTE_TEST_REGION, but this
        // environment variable already exists for App Engine testing, so it's handy to
        // avoid requiring another one.
        private const string TestRegionEnvironmentVariable = "TEST_PROJECT_LOCATION";

        /// <summary>
        /// Region to use for testing.
        /// </summary>
        public string Region { get; }

        public ComputeFixture()
        {
            Region = Environment.GetEnvironmentVariable(TestRegionEnvironmentVariable);
            if (string.IsNullOrEmpty(Region))
            {
                throw new InvalidOperationException($"Environment variable {TestRegionEnvironmentVariable} must be set");
            }
        }
    }
}
