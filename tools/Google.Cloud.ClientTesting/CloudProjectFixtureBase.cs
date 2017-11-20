// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// Base class for fixtures in integration and snippet tests which rely on Google Cloud projects.
    /// </summary>
    public abstract class CloudProjectFixtureBase : IDisposable
    {
        public const string TestProjectEnvironmentVariable = "TEST_PROJECT";

        /// <summary>
        /// The Google Cloud Project ID to use for tests.
        /// </summary>
        public string ProjectId { get; }

        protected CloudProjectFixtureBase(string testProjectEnvironmentVariable = TestProjectEnvironmentVariable)
        {
            ProjectId = Environment.GetEnvironmentVariable(testProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(ProjectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {testProjectEnvironmentVariable} environment variable to your test project ID before running tests");
            }
        }

        /// <summary>
        /// No-op disposal. Override this to provide cleanup (usually of data created for tests)
        /// at the end of the test run. 
        /// </summary>
        public virtual void Dispose()
        {
        }
    }
}
