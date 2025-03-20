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
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

public sealed class ContainerCommand : ICommand
{
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
            "generate" => new GenerateCommand(),
            "clean" => new CleanCommand(),
            "build-raw" => new BuildRawCommand(),
            "build-library" => new BuildLibraryCommand(),
            "configure" => new ConfigureCommand(),
            "prepare-library-release" => new PrepareLibraryReleaseCommand(),
            _ => throw new UserErrorException($"Unknown subcommand '{args[0]}'")
        };

        // All container commands have a very specific format for arguments - every argument is
        // --name=value. This allows us to do parsing just once.
        var options = ContainerOptions.FromArgs(args.Skip(1));
        try
        {
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
