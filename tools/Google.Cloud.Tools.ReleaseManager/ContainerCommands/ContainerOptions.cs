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
using System.Runtime.CompilerServices;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

public class ContainerOptions
{
    internal const string UtilityDocsLibraryPrefix = "docs-";
    internal const string ApiPathOption = "api-path";
    internal const string LibraryIdOption = "library-id";
    internal const string RepoRootOption = "repo-root";
    internal const string ApiRootOption = "api-root";
    internal const string GeneratorInputOption = "generator-input";
    internal const string GeneratorOutputOption = "generator-output";
    internal const string PackageOutputOption = "package-output";
    internal const string TestOption = "test";
    internal const string OutputOption = "output";
    internal const string VersionOption = "version";
    internal const string ReleaseNotesOption = "release-notes";

    internal string ApiPath { get; set; }
    internal string LibraryId { get; set; }
    internal string RepoRoot { get; set; }
    internal string ApiRoot { get; set; }
    internal string GeneratorInput { get; set; }
    internal string GeneratorOutput { get; set; }
    internal string PackageOutput { get; set; }
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
        PackageOutput = options.GetValueOrDefault(PackageOutputOption);
        Test = options.GetValueOrDefault(TestOption) == "true";
        Version = options.GetValueOrDefault(VersionOption);
        Output = options.GetValueOrDefault(OutputOption);
        ReleaseNotes = options.GetValueOrDefault(ReleaseNotesOption);
    }

    internal static ContainerOptions FromArgs(params string[] args) => FromArgs((IEnumerable<string>) args);

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

    internal string UtilityDocsName  => LibraryId is null ? null
        : LibraryId.StartsWith(UtilityDocsLibraryPrefix, StringComparison.Ordinal) ? LibraryId[UtilityDocsLibraryPrefix.Length..]
        : null;

    internal string RequireOption(string option, [CallerArgumentExpression("option")] string expression = null) =>
        option ?? throw new UserErrorException($"Option for {expression} is required");

    internal List<ApiMetadata> GetApisFromLibraryId(ApiCatalog catalog) => LibraryId is null ? catalog.Apis
        : catalog.PackageGroups.FirstOrDefault(pg => pg.Id == LibraryId) is PackageGroup group ? group.PackageIds.Select(id => catalog[id]).ToList()
        : new() { catalog[LibraryId] };
}
