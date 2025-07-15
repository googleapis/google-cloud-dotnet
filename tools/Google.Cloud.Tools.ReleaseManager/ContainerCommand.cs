// Copyright 2024 Google LLC
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
using Google.Cloud.Tools.ReleaseManager.ContainerCommands;
using System;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

public sealed class ContainerCommand : ICommand
{
    internal const string ToolsLibraryPrefix = "Google.Cloud.Tools.";

    internal const string GenerateRaw = "generate-raw";
    internal const string GenerateLibrary = "generate-library";
    internal const string Clean = "clean";
    internal const string BuildRaw = "build-raw";
    internal const string BuildLibrary = "build-library";
    internal const string Configure = "configure";
    internal const string PrepareLibraryRelease = "prepare-library-release";
    internal const string IntegrationTestLibrary = "integration-test-library";
    internal const string PackageLibrary = "package-library";
    internal const string PublishLibrary = "publish-library";

    public string Description => "Runs the specified container command, expected to be called from the generator CLI";

    public string Command => "container";

    public string ExpectedArguments => "subcommand [args]";

    public int Execute(string[] args)
    {
        if (args.Length == 0)
        {
            throw new UserErrorException("No subcommand specified");
        }

        IContainerCommand subcommand = args[0] switch
        {
            GenerateRaw => new GenerateRawCommand(),
            GenerateLibrary => new GenerateLibraryCommand(),
            Clean => new CleanCommand(),
            BuildRaw => new BuildRawCommand(),
            BuildLibrary => new BuildLibraryCommand(),
            Configure => new ConfigureCommand(),
            PrepareLibraryRelease => new PrepareLibraryReleaseCommand(),
            IntegrationTestLibrary => new IntegrationTestLibraryCommand(),
            PackageLibrary => new PackageLibraryCommand(),
            PublishLibrary => new PublishLibraryCommand(),
            _ => throw new UserErrorException($"Unknown subcommand '{args[0]}'")
        };

        // All container commands have a very specific format for arguments - every argument is
        // --name=value. This allows us to do parsing just once.
        var options = ContainerOptions.FromArgs(args.Skip(1));

        try
        {
            if (options.RepoRoot is string repoRoot && !File.Exists(Path.Combine(repoRoot, ApiCatalog.PathInRepository)))
            {
                return NonGoogleCloudDotnetCommands.Execute(args[0], options);
            }
            if (options.UtilityDocsName is not null)
            {
                return UtilityDocCommands.Execute(args[0], options);
            }
            if (options.LibraryId?.StartsWith(ToolsLibraryPrefix, StringComparison.Ordinal) == true)
            {
                return ToolCommands.Execute(args[0], options);
            }

            return subcommand.Execute(options);
        }
        catch (Exception e)
        {
            // By default, we just print the message if there's a UserErrorException.
            // If the *container* fails, it's more useful to have a full stack trace.
            Console.WriteLine(e);
            return 1;
        }
    }
}
