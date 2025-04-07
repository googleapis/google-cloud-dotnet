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
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

internal class PackageLibraryCommand : IContainerCommand
{
    public int Execute(ContainerOptions options)
    {
        var repoRoot = options.RequireOption(options.RepoRoot);
        var outputDirectory = options.RequireOption(options.Output);
        var rootLayout = RootLayout.ForRepositoryRoot(repoRoot);
        var catalog = ApiCatalog.Load(rootLayout);
        var apis = options.GetApisFromLibraryId(catalog);

        foreach (var api in apis)
        {
            Console.WriteLine($"Packing {api.Id}");
            Processes.RunDotnet(repoRoot, "pack",
                // It would be nice to use --no-build here,
                // but we may not have the .NET Framework build at this point.
                "--no-restore",
                "-c", "Release",
                "-o", outputDirectory,
                $"apis/{api.Id}/{api.Id}");
        }
        Processes.RunBashScript(Path.Combine(repoRoot, "docs"), "builddocs.sh", apis.Select(api => api.Id));

        // TODO: We need to create the relevant docs bundles to push later. Ideally, we'll create tgz files
        // ready to just upload. We can probably call into DocUploader directly.

        return 0;
    }
}
