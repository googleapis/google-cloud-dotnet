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

using System.Linq;
using System.Reflection;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class NamespaceTests
    {
        [Fact]
        public void Library_OnlyAspNetCoreNamespace()
        {
            var diagApsNetCoreAssembly = Assembly.GetAssembly(typeof(GoogleDiagnosticsWebHostBuilderExtensions));

            // We have files organized in Logging, Trace and ErrorReporting folders
            // but we really only have one namespace Google.Cloud.Diagnostics.Common.
            // When using VisualStudio to add new files to these folders it's easy to
            // forget to remove the folder names from the generated namespace.
            // We have already merged some tests with the wrong namespace, which is not a problem.
            // But if we ever merge production code in the wrong namespace then we have to carry
            // that over until the next major version bump.

            string ns = Assert.Single(diagApsNetCoreAssembly.GetTypes().Select(t => t.Namespace).Distinct());
            Assert.Equal("Google.Cloud.Diagnostics.AspNetCore", ns);
        }
    }
}
