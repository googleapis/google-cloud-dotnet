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

using System;

namespace Google.Cloud.Tools.ShowReleaseStatus
{
    public sealed class PackageRelease
    {
        public string Id { get; }
        public string Version { get; }
        public DateTimeOffset Timestamp { get; }
        public bool IsGa => !Version.Contains("-") && !Version.StartsWith("0");

        public PackageRelease(string id, string version, DateTimeOffset timestamp)
        {
            Id = id;
            Version = version;
            Timestamp = timestamp;
        }

        public override string ToString()
        {
            int ageInDays = (int)(DateTime.UtcNow - Timestamp).TotalDays;
            return $"{Version} on {Timestamp:yyyy-MM-dd} ({ageInDays} days ago)";
        }
    }
}
