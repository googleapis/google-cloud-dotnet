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
using Xunit;
using Xunit.Sdk;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// Base class for fixtures in integration and snippet tests which rely on Google Cloud projects.
    /// </summary>
    public abstract class CloudProjectFixtureBase : IDisposable
    {
        // We don't care about the value beyond whether it's absent/empty or non-empty.
        private static bool s_allowedToSkip = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MUST_NOT_SKIP_TESTS"));

        /// <summary>
        /// The Google Cloud Project ID to use for tests.
        /// </summary>
        public string ProjectId { get; }

        protected CloudProjectFixtureBase(string testProjectEnvironmentVariable = TestEnvironment.TestProjectEnvironmentVariable)
        {
            ProjectId = TestEnvironment.GetTestProjectId(testProjectEnvironmentVariable);
        }

        /// <summary>
        /// Like <see cref="Skip.If"/>, but first checks whether or not we're *allowed* to skip tests
        /// based on environment variables. The intention is that tests which require elaborate set-up
        /// may be skipped for local dev environments if developers aren't working on those features,
        /// but should always run in continuous integration - if the environemnt isn't set up appropriately,
        /// we should fail.
        /// </summary>
        /// <param name="condition">The condition under which the test is skipped.</param>
        public void SkipIf(bool condition)
        {
            if (!condition)
            {
                return;
            }
            if (!s_allowedToSkip)
            {
                throw new XunitException("Test is not allowed to be skipped in this environment.");
            }
            Skip.If(true);
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
