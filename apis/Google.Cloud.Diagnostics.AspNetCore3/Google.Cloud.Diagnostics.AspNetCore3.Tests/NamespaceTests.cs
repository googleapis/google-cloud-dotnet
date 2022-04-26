// Copyright 2020 Google LLC
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
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore3.Tests
{
    // We have files organized in Logging, Trace and ErrorReporting folders
    // but we really only have one namespace Google.Cloud.Diagnostics.Common.
    // When using VisualStudio to add new files to these folders it's easy to
    // forget to remove the folder names from the generated namespace.
    // We have already merged some tests with the wrong namespace, which is not a problem.
    // But if we ever merge production code in the wrong namespace then we have to carry
    // that over until the next major version bump.
    public class NamespaceTests
    {
        private const string BaseNamespace = "Google.Cloud.Diagnostics.AspNetCore3";

        [Fact]
        public void Library_OnlyAspNetCoreNamespace() =>
            CodeHealthTester.AssertOnlyAllowedNamespaces(
                typeof(AspNetCoreErrorReportingExtensions), BaseNamespace);

        [Fact]
        public void Library_NoComponentSpecificNamespaces() =>
            // Note: If this test fails, the other one in this file will fail as well
            // but let's have the double protection.
            CodeHealthTester.AssertNoDisallowedNamespaces(
                typeof(AspNetCoreErrorReportingExtensions),
                BaseNamespace + ".ErrorReporting",
                BaseNamespace + ".Logging",
                BaseNamespace + ".Trace");
    }
}
