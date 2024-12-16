// Copyright 2019 Google LLC
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

using CommandLine;
using Google.Cloud.Tools.Common;
using Google.Cloud.Tools.VersionCompat;
using Mono.Cecil;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.CompareVersions
{
    /// <summary>
    /// Command line interface to Google.Cloud.Tools.VersionCompat.
    /// </summary>
    internal static class Program
    {
        private static async Task<int> Main(string[] args)
        {
            CommandLineOptions options = null;
            var parsed = Parser.Default.ParseArguments<CommandLineOptions>(args);
            switch (parsed)
            {
                case Parsed<CommandLineOptions> success:
                    options = success.Value;
                    break;
                case NotParsed<CommandLineOptions> failure:
                    // Errors will have already been shown.
                    return 200;
                default:
                    Console.WriteLine("Error: Unexpected command-line parse result.");
                    return 201;
            }

            // Perform secondary validation
            if (!options.Validate())
            {
                return 1;
            }

            var assem0 = await LoadAsync(options, options.File1, options.Version1);
            var assem1 = await LoadAsync(options, options.File2, options.Version2);

            var diffs = Assemblies.Compare(assem0, assem1, null);

            if ((options.OutputBehavior & OutputBehavior.Major) != 0)
            {
                diffs.PrintDifferences(Level.Major, options.FormatDetail);
            }
            if ((options.OutputBehavior & OutputBehavior.Minor) != 0)
            {
                diffs.PrintDifferences(Level.Minor, options.FormatDetail);
            }

            int exitCode;
            switch (options.ExitCodeBehavior)
            {
                case ExitCodeBehavior.MajorOnly:
                    exitCode = diffs.Major.Any() ? 2 : 0;
                    break;
                case ExitCodeBehavior.MajorAndMinor:
                    exitCode = diffs.Major.Any() ? 2 : diffs.Minor.Any() ? 1 : 0;
                    break;
                default:
                    exitCode = 0;
                    break;
            }

            Console.WriteLine($"Diff level: {diffs.Level}");
            Console.WriteLine();

            return exitCode;
        }

        private static Task<AssemblyDefinition> LoadAsync(CommandLineOptions options, string file, string version)
        {
            if (version == "local")
            {
                var apiLayout = RootLayout.ForCurrentDirectory().CreateRepositoryApiLayout(options.Package);
                var productionRoot = apiLayout.ProductionDirectory;
                file = apiLayout.GetReleaseAssembly(options.Framework);
            }
            if (file != null)
            {
                return Task.FromResult(Assemblies.LoadFile(file));
            }

            // Okay, definitely loading from NuGet.
            if (version == "latest")
            {
                version = null; // This is how LoadPackageAsync loads the latest
            }
            return Assemblies.LoadPackageAsync(options.Package, version, options.Framework, assemblyName: null);
        }
    }
}
