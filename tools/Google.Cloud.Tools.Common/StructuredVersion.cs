// Copyright 2019 Google LLC.
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
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.Common
{
    /// <summary>
    /// A structured SemVer version.
    /// </summary>
    public class StructuredVersion : IEquatable<StructuredVersion>, IComparable<StructuredVersion>
    {
        private static readonly Regex s_pattern = new Regex(@"^(?<major>[0-9]\d*)\.(?<minor>\d+)\.(?<patch>\d+)(\.(?<build>\d+))?(-(?<prerelease>.*))?$");

        public int Major { get; }
        public int Minor { get; }
        public int Patch { get; }
        public int? Build { get; }
        public string Prerelease { get; }
        public bool IsStable => Major > 0 && Prerelease is null;

        /// <summary>
        /// A non-release version (in google-cloud-dotnet) is something like 1.0.0-beta00 or 2.0.0-beta00.
        /// It's where we start, and how we signal "we're going to have a major version bump but we're not ready
        /// for a release yet".
        /// </summary>
        public bool IsNonRelease => Prerelease?.EndsWith("00") == true;

        private StructuredVersion(int major, int minor, int patch, int? build, string prerelease)
        {
            Major = major;
            Minor = minor;
            Patch = patch;
            Build = build;
            Prerelease = prerelease;
        }

        public static StructuredVersion FromMajorMinorPatch(int major, int minor, int patch, string prerelease) =>
            new StructuredVersion(major, minor, patch, null, prerelease);

        public static StructuredVersion FromMajorMinorPatchBuild(int major, int minor, int patch, int? build, string prerelease) =>
            new StructuredVersion(major, minor, patch, build, prerelease);

        public static StructuredVersion FromString(string version)
        {
            var match = s_pattern.Match(version);
            if (!match.Success)
            {
                throw new ArgumentException($"Invalid version: {version}");
            }
            var major = int.Parse(match.Groups["major"].Value);
            var minor = int.Parse(match.Groups["minor"].Value);
            var patch = int.Parse(match.Groups["patch"].Value);
            var build = match.Groups["build"].Success ? int.Parse(match.Groups["build"].Value) : default(int?);
            var prerelease = match.Groups["prerelease"].Success ? match.Groups["prerelease"].Value : null;
            return new StructuredVersion(major, minor, patch, build, prerelease);
        }

        public int CompareTo(StructuredVersion other)
        {
            var majorDiff = Major.CompareTo(other.Major);
            if (majorDiff != 0)
            {
                return majorDiff;
            }
            var minorDiff = Minor.CompareTo(other.Minor);
            if (minorDiff != 0)
            {
                return minorDiff;
            }
            var patchDiff = Patch.CompareTo(other.Patch);
            if (patchDiff != 0)
            {
                return patchDiff;
            }
            if (Build != other.Build)
            {
                if (Build is null)
                {
                    return -1;
                }
                if (other.Build is null)
                {
                    return -1;
                }
                return Build.Value.CompareTo(other.Build.Value);
            }
            // Null comes *after* anything else when it comes to prereleases,
            // so we can't just use StringComparer.
            if (Prerelease is null && other.Prerelease is null)
            {
                return 0;
            }
            if (Prerelease is null)
            {
                return 1;
            }
            if (other.Prerelease is null)
            {
                return -1;
            }
            return string.CompareOrdinal(Prerelease, other.Prerelease);
        }

        public bool Equals(StructuredVersion other) =>
            other is object &&
            Major == other.Major &&
            Minor == other.Minor &&
            Patch == other.Patch &&
            Prerelease == other.Prerelease;

        // Not a brilliant hash code, but we're not expecting performance to
        // be an issue in our tools.
        public override int GetHashCode() =>
            Major ^ Minor ^ Patch ^ (Build ?? 0) ^ (Prerelease ?? "").GetHashCode();

        /// <summary>
        /// Returns this structured version, after a "normal" version increment:
        /// - Any GA release has its minor version bumped, and patch set to 0
        /// - Any pre-release has the prerelease part bumped
        /// </summary>
        public StructuredVersion AfterIncrement()
        {
            // Any GA version just increments the minor version.
            if (Prerelease is null)
            {
                return FromMajorMinorPatch(Major, Minor + 1, 0, null);
            }

            // For prereleases, expect something like "beta01" which should be incremented to "beta02".
            var prereleasePattern = new Regex(@"^([^\d]*)(\d+)$");
            var match = prereleasePattern.Match(Prerelease);
            if (!match.Success)
            {
                throw new UserErrorException($"Don't know how to auto-increment version '{this}'");
            }
            var prefix = match.Groups[1].Value;
            var suffix = match.Groups[2].Value;
            if (!int.TryParse(suffix, out var counter))
            {
                throw new UserErrorException($"Don't know how to auto-increment version '{this}'");
            }
            counter++;
            var newSuffix = counter.ToString().PadLeft(suffix.Length, '0');
            return FromMajorMinorPatch(Major, Minor, Patch, $"{prefix}{newSuffix}");
        }

        /// <summary>
        /// Returns this structured version after a patch increment
        /// </summary>
        /// <returns></returns>
        public StructuredVersion AfterPatch() =>
            FromMajorMinorPatchBuild(Major, Minor, Patch + 1, Build, Prerelease);

        /// <summary>
        /// Returns this structured version after a major version bump, assuming it's already at
        /// "a prerelease after the major version bump". For example, 3.0.0-alpha02 => 3.0.0, 3.0.0-beta01 or 3.0.0-alpha01
        /// (depending on the package ID).
        /// </summary>
        public StructuredVersion AfterMajorVersion(string id)
        {
            var lastPart = id.Split('.').Last();
            return lastPart.Contains("Beta") ? new StructuredVersion(Major, 0, 0, null, "beta01")
                : lastPart.Contains("Alpha") ? new StructuredVersion(Major, 0, 0, null, "alpha01")
                : new StructuredVersion(Major, 0, 0, null, null);
        }

        public override string ToString() => new StringBuilder($"{Major}.{Minor}.{Patch}")
            .Append(Build is null ? "" : $".{Build}")
            .Append(Prerelease is null ? "" : $"-{Prerelease}")
            .ToString();
    }
}
