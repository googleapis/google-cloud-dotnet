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
using System.Reflection;
using Xunit;
using Xunit.Sdk;

namespace Google.Cloud.Spanner.Data.CommonTesting
{
    /// <summary>
    /// When applied to a class or method, each test has the state of the client and session pools checked
    /// before and after the test.
    /// </summary>
    [Obsolete("The session pool now relies on multiplexed sessions, which support multiple transactions. " +
            "There's no need for session pooling and these statistics are meaningless.")]
    public class ValidatePoolBeforeAfterTestAttribute : BeforeAfterTestAttribute
    {
        public override void Before(MethodInfo methodUnderTest) => ValidatePoolInfo("Before", methodUnderTest);

        public override void After(MethodInfo methodUnderTest) => ValidatePoolInfo("After", methodUnderTest);

        /// <summary>
        /// We can only validate the default session pool manager (we don't have any other context) but it should be
        /// effectively idle before and after each test. (There may be background operations such as replenishingly
        /// pools, but that's okay.)
        /// </summary>
        protected static void ValidatePoolInfo(string beforeOrAfter, MethodInfo method)
        {
            var statistics = SessionPoolManager.Default.GetStatistics();
            foreach (var statistic in statistics)
            {
                Assert.Equal(0, statistic.ActiveConnectionCount);
                Assert.Equal(0, statistic.SessionPoolStatistics.TotalActiveSessionCount);
            }
        }
    }
}
