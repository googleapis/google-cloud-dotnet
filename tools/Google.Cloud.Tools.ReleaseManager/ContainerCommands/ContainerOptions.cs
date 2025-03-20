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
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

public class ContainerOptions
{
    private const string ApiPathOption = "api-path";
    private const string LibraryIdOption = "library-id";
    private const string RepoRootOption = "repo-root";
    private const string ApiRootOption = "api-root";
    private const string GeneratorInputOption = "generator-input";
    private const string GeneratorOutputOption = "generator-output";
    private const string TestOption = "test";
    private const string OutputOption = "output";
    private const string VersionOption = "version";
    private const string ReleaseNotesOption = "release-notes";

    internal string ApiPath { get; set; }
    internal string LibraryId { get; set; }
    internal string RepoRoot { get; set; }
    internal string ApiRoot { get; set; }
    internal string GeneratorInput { get; set; }
    internal string GeneratorOutput { get; set; }
    internal bool Test { get; set; }
    internal string Version { get; set; }
    internal string Output { get; set; }
    internal string ReleaseNotes { get; set; }

    internal ContainerOptions(Dictionary<string, string> options)
    {
        ApiPath = options.GetValueOrDefault(ApiPathOption);
        LibraryId = options.GetValueOrDefault(LibraryIdOption);
        RepoRoot = options.GetValueOrDefault(RepoRootOption);
        ApiRoot = options.GetValueOrDefault(ApiRootOption);
        GeneratorInput = options.GetValueOrDefault(GeneratorInputOption);
        GeneratorOutput = options.GetValueOrDefault(GeneratorOutputOption);
        Test = options.GetValueOrDefault(TestOption) == "true";
        Version = options.GetValueOrDefault(VersionOption);
        Output = options.GetValueOrDefault(OutputOption);
        ReleaseNotes = options.GetValueOrDefault(ReleaseNotesOption);
    }

    internal static ContainerOptions FromArgs(IEnumerable<string> args)
    {
        return new(args.Select(SplitNameAndValue).ToDictionary(pair => pair.name, pair => pair.value));

        (string name, string value) SplitNameAndValue(string arg)
        {
            if (!arg.StartsWith("--") || !arg.Contains('='))
            {
                throw new UserErrorException($"Invalid argument '{arg}'");
            }
            var nameValue = arg.Split('=', 2);
            return (nameValue[0].Substring(2), nameValue[1]);
        }
    }

    internal string RequireOption(string option, [CallerArgumentExpression("option")] string expression = null) =>
        option ?? throw new UserErrorException($"Option for {expression} is required");
}
