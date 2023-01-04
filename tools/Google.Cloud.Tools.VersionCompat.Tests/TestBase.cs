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

using Mono.Cecil;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Xunit;

namespace Google.Cloud.Tools.VersionCompat.Tests
{
    public abstract class TestBase
    {
        private static readonly byte[] s_dllBytes = File.ReadAllBytes(typeof(TestBase).Assembly.Location);

        protected DiffResult RunTest([CallerMemberName] string callerMemberName = null)
        {
            var s = new MemoryStream(s_dllBytes);
            // Must be read twice, as each assembly definition will be independently mutated during the test.
            s.Position = 0;
            var older = AssemblyDefinition.ReadAssembly(s);
            s.Position = 0;
            var newer = AssemblyDefinition.ReadAssembly(s);
            // Use this convention for test namespaces:
            // Test namespace is the name of the test type (e.g. `ClassMethodTest`) without the `Test` suffix,
            // followed by the name of the test method (e.g. `MethodAdded`), followed by `A` or `B` for the
            // original or new version of the code.
            var typeName = GetType().Name;
            var testNamespace = $"{typeof(TestBase).Namespace}.{typeName.Substring(0, typeName.Length - "Test".Length)}.{callerMemberName}";
            // Run version compatibility checker.
            return Assemblies.Compare(older, newer, testNamespace);
        }

        protected void TestNone([CallerMemberName] string callerMemberName = null)
        {
            var result = RunTest(callerMemberName);
            Assert.Empty(result.All);
        }

        protected delegate void Expected(params (Level level, Cause cause)[] expected);

        protected Expected Test([CallerMemberName] string callerMemberName = null) => expected =>
        {
            var result = RunTest(callerMemberName);
            Assert.Equal(expected.Length, result.All.Count);
            Assert.Equal(expected.ToHashSet(), result.All.Select(x => (x.Level, x.Cause)).ToHashSet());
        };

        protected Diff Test(Level expectedLevel, Cause expectedCause, string diffContains = null, [CallerMemberName] string callerMemberName = null)
        {
            var result = RunTest(callerMemberName);
            var diffs = diffContains == null ? result.All : result.All.Where(x => x.ToString(FormatDetail.Full).Contains(diffContains)).ToImmutableList();
            Assert.Single(diffs);
            Assert.Equal(expectedLevel, diffs[0].Level);
            Assert.Equal(expectedCause, diffs[0].Cause);
            return result.All[0];
        }

        protected Diff TestMajor(Cause expectedCause, string diffContains = null, [CallerMemberName] string callerMemberName = null) =>
            Test(Level.Major, expectedCause, diffContains, callerMemberName);

        protected Diff TestMinor(Cause expectedCause, string diffContains = null, [CallerMemberName] string callerMemberName = null) =>
            Test(Level.Minor, expectedCause, diffContains, callerMemberName);
    }
}
