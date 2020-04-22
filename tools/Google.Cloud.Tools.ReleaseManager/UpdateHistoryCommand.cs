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

using System;

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class UpdateHistoryCommand : CommandBase
    {
        public UpdateHistoryCommand()
            : base("update-history", "Update the release history file for each changed version")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            foreach (var diff in FindChangedVersions())
            {
                if (diff.NewVersion is null)
                {
                    Console.WriteLine($"{diff.Id} has been deleted; no history required.");
                }
                else
                {
                    UpdateReleaseNotes.Program.Execute(diff.Id);
                }
            }
        }
    }
}
