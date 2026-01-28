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
using System;
using System.Reflection;
using Xunit.Sdk;

namespace Google.Cloud.Spanner.Data.CommonTesting
{
    /// <summary>
    /// When applied to a class or method, the state of the client, session and transaction pools is summarized
    /// at the start and end of each test is with <see cref="FileLogger"/>.
    /// </summary>
    [Obsolete("The session pool now relies on multiplexed sessions, which support multiple transactions. " +
            "There's no need for session pooling and these statistics are meaningless.")]
    public class DumpPoolSummariesBeforeAfterTestAttribute : BeforeAfterTestAttribute
    {
        public override void Before(MethodInfo methodUnderTest) => DumpPoolSummaries(methodUnderTest, "before");

        public override void After(MethodInfo methodUnderTest) => DumpPoolSummaries(methodUnderTest, "after");

        private void DumpPoolSummaries(MethodInfo method, string description)
        {
            FileLogger.Log($"Pool summaries {description} {method.DeclaringType.Name}.{method.Name}");
            FileLogger.Log(SessionPoolManager.Default.ToDiagnosticSummary());
            FileLogger.Log("");
        }
    }
}
