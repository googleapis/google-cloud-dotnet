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
            "build" => new BuildCommand(),
            "configure" => new ConfigureCommand(),
            _ => throw new UserErrorException($"Unknown subcommand '{args[0]}'")
        };

        // All container commands have a very specific format for arguments - every argument is
        // --name=value. This allows us to do parsing just once.
        var options = new Dictionary<string, string>();
        foreach (var arg in args.Skip(1))
        {
            if (!arg.StartsWith("--") || !arg.Contains('='))
            {
                throw new UserErrorException($"Invalid argument '{arg}'");
            }
            var nameValue = arg.Split('=', 2);
            options[nameValue[0].Substring(2)] = nameValue[1];
        }
        return subcommand.Execute(options);
    }
}
