// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

internal class IntegrationTestLibraryCommand : IContainerCommand
{
    private const int MaxAttempts = 3;

    public int Execute(ContainerOptions options)
    {
        var repoRoot = options.RequireOption(options.RepoRoot);
        var rootLayout = RootLayout.ForRepositoryRoot(repoRoot);
        var catalog = ApiCatalog.Load(rootLayout);
        var apis = options.GetApisFromLibraryId(catalog);
        for (int attempt = 1; true; attempt++)
        {
            var args = attempt == 1 ? apis.Select(api => api.Id) : new List<string> { "--retry" };
            try
            {
                Processes.RunBashScript(repoRoot, "runintegrationtests.sh", args);
                break;
            }
            catch (Exception) when (attempt < MaxAttempts)
            {
                Console.WriteLine($"Failure running integration tests on attempt {attempt}. (Max attempts = {MaxAttempts})");
            }
        }
        return 0;
    }
}
