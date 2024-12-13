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
using System.Collections.Generic;

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class CompareCommand : CommandBase
    {
        public CompareCommand()
            : base("compare", "Compare each changed version with the previous release")
        {
        }

        protected override int ExecuteImpl(string[] args)
        {
            var rootLayout = RootLayout.ForCurrentDirectory();
            var idsToCheck = new List<string>();
            foreach (var diff in FindChangedVersions())
            {
                if (diff.OldVersion is null)
                {
                    Console.WriteLine($"{diff.Id} is new; no comparison required.");
                }
                else if (diff.NewVersion is null)
                {
                    Console.WriteLine($"{diff.Id} has been deleted; no comparison required.");
                }
                else
                {
                    // Found an API to compare. Build it locally first, so we know we're up-to-date.
                    var api = diff.Id;
                    idsToCheck.Add(api);
                    Console.WriteLine($"Building {api} locally");
                    var sourceRoot = rootLayout.CreateApiLayout(api).SourceDirectory;
                    Processes.RunDotnet(sourceRoot, "build", "-nologo", "-clp:NoSummary", "-v", "quiet", "-c", "Release", api);
                }
            }
            new CheckVersionCompatibilityCommand().Execute(idsToCheck.ToArray());
            return 0;
        }
    }
}
