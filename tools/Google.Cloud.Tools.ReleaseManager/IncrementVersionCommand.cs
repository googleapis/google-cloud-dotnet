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

using Google.Cloud.Tools.Common;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class IncrementVersionCommand : CommandBase
    {
        public IncrementVersionCommand()
            : base("increment-version", "Increment a version in apis.json and generate project files", "id")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            string id = args[0];

            // It's slightly inefficient that we load the API catalog once here and once later on, and the code duplication
            // is annoying too, but it's insignficant really - and at least the code is simple.
            var catalog = ApiCatalog.Load();
            var api = catalog[id];
            var version = IncrementStructuredVersion(api.StructuredVersion).ToString();
            new SetVersionCommand().Execute(new[] { id, version });

            StructuredVersion IncrementStructuredVersion(StructuredVersion originalVersion)
            {
                // Any GA version just increments the minor version.
                if (originalVersion.Prerelease is null)
                {
                    return StructuredVersion.FromMajorMinorPatch(originalVersion.Major, originalVersion.Minor + 1, 0, null);
                }

                // For prereleases, expect something like "beta01" which should be incremented to "beta02".
                var prereleasePattern = new Regex(@"^([^\d]*)(\d+)$");
                var match = prereleasePattern.Match(originalVersion.Prerelease);
                if (!match.Success)
                {
                    throw new UserErrorException($"Don't know how to auto-increment version '{originalVersion}'");
                }
                var prefix = match.Groups[1].Value;
                var suffix = match.Groups[2].Value;
                if (!int.TryParse(suffix, out var counter))
                {
                    throw new UserErrorException($"Don't know how to auto-increment version '{originalVersion}'");
                }
                counter++;
                var newSuffix = counter.ToString().PadLeft(suffix.Length, '0');
                return StructuredVersion.FromMajorMinorPatch(originalVersion.Major, originalVersion.Minor, originalVersion.Patch, $"{prefix}{newSuffix}");
            }
        }
    }
}
