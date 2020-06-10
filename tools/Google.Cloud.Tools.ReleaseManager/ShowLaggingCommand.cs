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
using System;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Command to show packages whose last release was a pre-release, but which represent a GA
    /// API (and should therefore be considered for a GA release).
    /// </summary>
    public class ShowLaggingCommand : CommandBase
    {
        public ShowLaggingCommand() : base("show-lagging", "Shows pre-release packages where a GA should be considered")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            var catalog = ApiCatalog.Load();
            var lagging = catalog.Apis.Where(api => api.CanHaveGaRelease && api.StructuredVersion.Prerelease is string);
            Console.WriteLine($"Lagging packages:");
            foreach (var api in lagging)
            {
                Console.WriteLine($"{api.Id} ({api.Version})");
            }
        }
    }
}
