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
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.Common
{
    /// <summary>
    /// A structured SemVer version.
    /// </summary>
    public class StructuredVersion : IEquatable<StructuredVersion>, IComparable<StructuredVersion>
    {
        private static readonly Regex s_matcher = new Regex(@"^([1-9]\d*)\.(\d+)\.(\d+)(-.*)?$");
        
        public int Major { get; }
        public int Minor { get; }
        public int Patch { get; }
        public string Prerelease { get; }

        public StructuredVersion(int major, int minor, int patch, string prerelease)
        {
            Major = major;
            Minor = minor;
            Patch = patch;
            Prerelease = prerelease;
        }        

        public StructuredVersion(string version)
        {
            var match = s_matcher.Match(version);
            if (!match.Success)
            {
                throw new ArgumentException($"Invalid version: {version}");
            }
            Major = int.Parse(match.Groups[1].Value);
            Minor = int.Parse(match.Groups[2].Value);
            Patch = int.Parse(match.Groups[3].Value);
            Prerelease = match.Groups[4].Success ? match.Groups[4].Value.Substring(1) : null;
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
            Major ^ Minor ^ Patch ^ (Prerelease ?? "").GetHashCode();

        public override string ToString() =>
            Prerelease is null
            ? $"{Major}.{Minor}.{Patch}"
            : $"{Major}.{Minor}.{Patch}-{Prerelease}";
    }
}
