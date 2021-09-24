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

using Google.Cloud.Tools.Common;
using Google.Cloud.Tools.VersionCompat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Cloud.Tools.ReleaseManager.Tests
{
    public class CheckVersionCompatibilityCommandTest
    {
        public class TestCase : IEnumerable
        {
            public StructuredVersion NewVersion { get; }
            public List<StructuredVersion> TaggedVersions { get; }

            public List<(StructuredVersion version, Level requiredLevel)> ExpectedComparisons { get; } = new List<(StructuredVersion, Level)>();

            public TestCase(string newVersion, params string[] taggedVersions) =>
                (NewVersion, TaggedVersions) =
                (StructuredVersion.FromString(newVersion), taggedVersions.Select(StructuredVersion.FromString).ToList());

            public void Add(string version, Level requiredLevel) =>
                ExpectedComparisons.Add((StructuredVersion.FromString(version), requiredLevel));

            // We only implement GetEnumerator for the sake of the collection initializer
            public IEnumerator GetEnumerator() => throw new NotImplementedException();

            public override string ToString() => $"{NewVersion} from {string.Join(", ", TaggedVersions)}";
        }

        // Release PRs will have a version which doesn't exist in tags.
        public static TheoryData<TestCase> ReleasePrTestData { get; } = new TheoryData<TestCase>
        {
            // The first constructor argument is the new version.
            // The remaining constructor arguments are tagged versions.
            // The collection initializer is used to add expected comparisons.

            // First release: no comparisons
            new TestCase("1.0.0-beta01"),
            // Straight to 1.0.0 is pretty bold, but if we don't have any previous releases, we don't have anything to compare it to.
            new TestCase("1.0.0"),
            // Beta to first stable release
            // We perform the comparison with the beta even though we allow anything to change. It's still useful to see those changes.
            new TestCase("1.0.0", "1.0.0-beta01") { { "1.0.0-beta01", Level.Major } },

            // First beta of a new minor
            new TestCase("1.1.0-beta01", "1.0.0-beta01", "1.0.0") { { "1.0.0", Level.Minor } },

            // Second beta of a new minor
            new TestCase("1.1.0-beta02", "1.0.0-beta01", "1.0.0", "1.1.0-beta01")
            {
                { "1.0.0", Level.Minor },       // We're aiming for 1.1.0, and there can't be breaking changes there
                { "1.1.0-beta01", Level.Major } // We can break beta-only features, but we'd like to know that.
            },

            // Release of a new minor
            new TestCase("1.1.0", "1.0.0-beta01", "1.0.0", "1.1.0-beta01")
            {
                { "1.0.0", Level.Minor },       // We're aiming for 1.1.0, and there can't be breaking changes there
                { "1.1.0-beta01", Level.Major } // We can break beta-only features, but we'd like to know that.
            },

            // First beta of a new major
            new TestCase("2.0.0-beta01", "1.0.0", "1.1.0") // Any beta releases in 1.x are irrelevant now
            {
                { "1.1.0", Level.Major }
            },

            // Second beta of a new major
            new TestCase("2.0.0-beta02", "1.0.0-beta01", "1.0.0", "1.1.0-beta01", "1.1.0", "2.0.0-beta01")
            {
                { "1.1.0", Level.Major },        // So we know what we've broken compared with last GA
                { "2.0.0-beta01", Level.Major }, // So we know what we've broken compared with last beta
            },

            // First stable release of a new major after a beta
            new TestCase("2.0.0", "1.0.0-beta01", "1.0.0", "1.1.0-beta01", "1.1.0", "2.0.0-beta01")
            {
                { "1.1.0", Level.Major },        // So we know what we've broken compared with last GA
                { "2.0.0-beta01", Level.Major }, // So we know what we've broken compared with last beta
            },

            // New major with no betas
            new TestCase("2.0.0", "1.0.0-beta01", "1.0.0", "1.1.0-beta01", "1.1.0")
            {
                { "1.1.0", Level.Major },        // So we know what we've broken compared with last GA
            },

            // New patch (no prerelease)
            new TestCase("1.1.1", "1.0.0", "1.1.0")
            {
                { "1.1.0", Level.Identical }
            },

            // New patch (with prerelease)
            new TestCase("1.1.1-beta01", "1.0.0", "1.1.0")
            {
                { "1.1.0", Level.Identical }
            },

            // Second prerelease for a new patch
            new TestCase("1.1.1-beta02", "1.0.0", "1.1.0", "1.1.1-beta01")
            {
                { "1.1.0", Level.Identical },
                // In reality, the second beta has to be identical to the first beta anyway,
                // unless we messed up the first beta. But it's simplest to express it this
                // way, and it's still checking what we really care about.
                { "1.1.1-beta01", Level.Major }
            },
        };

        // Non-release PRs will have a version that is already tagged (and published)
        public static TheoryData<TestCase> NonReleasePrTestData = new TheoryData<TestCase>
        {
            // Default starting point; no releases, and we're not releasing yet. We don't need to compare with anything.
            new TestCase("1.0.0-beta00"),

            // 2.0.0-beta00 is just a placeholder which won't be released - but compare with last release.
            new TestCase("2.0.0-beta00", "1.0.0", "1.1.0") { { "1.1.0", Level.Major } },

            // Continuing to make changes on a stable minor. Compare against the released stable minor.
            new TestCase("1.0.0-beta01", "1.0.0-beta01") { { "1.0.0-beta01", Level.Major } },

            // Continuing to make changes on a first pre-release minor. Compare against that, allowing breaking changes.
            new TestCase("1.0.0-beta01", "1.0.0-beta01") { { "1.0.0-beta01", Level.Major } },

            // Continuing to make changes on a second pre-release minor. Compare against that, allowing breaking changes.
            new TestCase("1.0.0-beta02", "1.0.0-beta01", "1.0.0-beta02") { { "1.0.0-beta02", Level.Major } },

            // Continuing to make changes on a pre-release minor after a stable version. Compare against the pre-release
            // allowing anything, but against the previous stable only allowing minor changes.
            new TestCase("1.1.0-beta01", "1.0.0-beta01", "1.0.0", "1.1.0-beta01")
            {
                { "1.0.0", Level.Minor },
                { "1.1.0-beta01", Level.Major }
            },

            // Continuing to work on the prerelease of a patch
            new TestCase("1.1.1-beta01", "1.0.0", "1.1.0", "1.1.1-beta01")
            {
                { "1.1.0", Level.Identical },
                { "1.1.1-beta01", Level.Major }
            },

            // And the above two test cases beyond the first major release.
            new TestCase("2.0.0-beta01", "1.0.0", "2.0.0-beta01")
            { 
                { "1.0.0", Level.Major },
                { "2.0.0-beta01", Level.Major }
            },

            new TestCase("2.1.0-beta01", "1.0.0-beta01", "1.0.0", "1.1.0-beta01", "2.0.0", "2.1.0-beta01")
            {
                // No need to test against 1.0.0 any more
                { "2.0.0", Level.Minor },
                { "2.1.0-beta01", Level.Major }
            },
        };

        [Theory]
        [MemberData(nameof(ReleasePrTestData))]
        [MemberData(nameof(NonReleasePrTestData))]
        public void GetComparisons(TestCase test)
        {
            var actual = CheckVersionCompatibilityCommand.GetComparisons(test.NewVersion, test.TaggedVersions);
            Assert.Equal(test.ExpectedComparisons, actual.ToList());
        }
    }
}
