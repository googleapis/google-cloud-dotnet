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
using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    /// <summary>
    /// Simple way of turning on extra logging etc for all tests in this project. All tests
    /// need to have this attribute applied to them manually, but then changing the default behavior
    /// just amounts to editing this single file.
    /// </summary>
    public class CommonTestDiagnosticsAttribute : BeforeAfterTestAttribute
    {
        private static readonly List<BeforeAfterTestAttribute> s_attributes = new List<BeforeAfterTestAttribute>
        {
            new FileLoggerBeforeAfterTestAttribute()
        };

        public override void Before(MethodInfo methodUnderTest) =>
            s_attributes.ForEach(a => a.Before(methodUnderTest));

        public override void After(MethodInfo methodUnderTest) =>
            s_attributes.ForEach(a => a.After(methodUnderTest));
    }
}
