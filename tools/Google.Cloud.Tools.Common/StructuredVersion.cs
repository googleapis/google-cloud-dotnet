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
    public class StructuredVersion
    {
        private static readonly Regex s_matcher = new Regex(@"^([1-9]\d*)\.(\d+)\.(\d+)(-.*)?$");
        
        public int Major { get; }
        public int Minor { get; }
        public int Patch { get; }
        public string Prerelease { get; }

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
    }
}
