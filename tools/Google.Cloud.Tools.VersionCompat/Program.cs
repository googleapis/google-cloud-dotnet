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
using Google.Cloud.Tools.VersionCompat.CecilUtils;
using Google.Cloud.Tools.VersionCompat.Detectors;
using Mono.Cecil;
using SharpCompress.Archives.Zip;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Google.Cloud.Tools.VersionCompat
{
    public class Program
    {
        private static DiffResult Check(IReadOnlyList<TypeDefinition> olderTypes, IReadOnlyList<TypeDefinition> newerTypes)
        {
            var oWithNested = olderTypes.WithNested().ToImmutableList();
            var nWithNested = newerTypes.WithNested().ToImmutableList();

            var diffs = TopLevel.Diffs(oWithNested, nWithNested).ToImmutableList();

            return new DiffResult(diffs);
        }

        public static DiffResult Check(AssemblyDefinition older, AssemblyDefinition newer, string testNamespace)
        {
            if (testNamespace == null)
            {
                return Check(older.Modules.SelectMany(x => x.Types).ToList(), newer.Modules.SelectMany(x => x.Types).ToList());
            }
            else
            {
                var olderTypesList = new List<TypeDefinition>();
                var newerTypesList = new List<TypeDefinition>();
                var nsOlder = $"{testNamespace}.A.";
                var nsNewer = $"{testNamespace}.B.";
                foreach (var type in older.Modules.SelectMany(x => x.Types).Where(x => x.FullName.StartsWith(nsOlder)))
                {
                    type.Namespace = type.Namespace.Replace($"{testNamespace}.A", testNamespace);
                    olderTypesList.Add(type);
                }
                foreach (var type in newer.Modules.SelectMany(x => x.Types).Where(x => x.FullName.StartsWith(nsNewer)))
                {
                    type.Namespace = type.Namespace.Replace($"{testNamespace}.B", testNamespace);
                    newerTypesList.Add(type);
                }
                if (!olderTypesList.Any() || !newerTypesList.Any())
                {
                    throw new InvalidOperationException("Test data has no relevant types.");
                }
                return Check(olderTypesList, newerTypesList);
            }
        }

        /// <summary>
        /// Loads a package from NuGet and extracts an assembly definition.
        /// </summary>
        /// <param name="package">The name of the package to load. Must not be null.</param>
        /// <param name="version">The version of the package to load. May be null, in which case the latest stable version is downloaded.</param>
        /// <param name="tfm">The target framework to find within the package. May be null, in which case "netstandard2.0" is assumed.</param>
        /// <param name="assemblyName">The name of the assembly to find within the package. May be null, in which case it's assumed to be the same as the package.</param>
        /// <returns>The assembly definition loaded from the given package.</returns>
        public async static Task<AssemblyDefinition> LoadPackageAsync(string package, string version, string tfm, string assemblyName)
        {
            tfm = tfm ?? "netstandard2.0";
            assemblyName = assemblyName ?? package;
            using (var client = new HttpClient())
            {
                // Handily, this automatically loads the latest stable release if version is null.
                var url = $"https://www.nuget.org/api/v2/package/{package}/{version}";
                var response = await client.GetAsync(url).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                var bytes = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);

                string expectedPath = $"lib/{tfm}/{assemblyName}.dll";

                using (var zip = ZipArchive.Open(new MemoryStream(bytes)))
                {
                    foreach (var entry in zip.Entries)
                    {
                        if (entry.Key == expectedPath)
                        {
                            var path = entry.Key.Substring(4);
                            string targetFramework = Path.GetDirectoryName(path);
                            using (var stream = entry.OpenEntryStream())
                            {
                                // Mono.Cecil requires the stream to be seekable. It's simplest
                                // just to copy the whole DLL to a MemoryStream and pass that to Cecil.
                                var ms = new MemoryStream();
                                await stream.CopyToAsync(ms).ConfigureAwait(false);
                                ms.Position = 0;
                                return AssemblyDefinition.ReadAssembly(ms);
                            }
                        }
                    }
                }
                throw new InvalidOperationException($"Unable to find entry '{expectedPath}' in package");
            }
        }

        public static AssemblyDefinition LoadFile(string file)
        {
            var bytes = File.ReadAllBytes(file);
            return AssemblyDefinition.ReadAssembly(new MemoryStream(bytes));
        }

        private static AssemblyDefinition Load(string name)
        {
            var parts = name.Split('|');
            if (parts.Length == 1 || parts[0] == "file")
            {
                return LoadFile(parts.Last());
            }
            else if (parts[0] == "nuget")
            {
                if (parts.Length < 2 || parts.Length > 4)
                {
                    throw new InvalidOperationException($"Invalid arg: '{name}'");
                }
                string package = parts[1];
                string version = parts.Length > 2 ? parts[2] : null;
                string tfm = parts.Length > 3 ? parts[3] : null;
                // We assume that this method is only called in a console app, so we don't need to worry about deadlock.
                // (Both Main and Load are private, so we shouldn't be called from other contexts.)
                return LoadPackageAsync(package, version, tfm, package).Result;
            }
            else
            {
                throw new InvalidOperationException($"Invalid arg: '{name}'");
            }
        }

        private enum ExitCodeBehavior
        {
            None = 0,
            MajorOnly = 1,
            MajorAndMinor = 2,
        }

        [Flags]
        private enum OutputBehavior
        {
            None = 0,
            Major = 1,
            Minor = 2,

            // To allow all combinations to be set with a single flag value
            MajorAndMinor = 3,
        }

        private class Options
        {
            [Option("exit-code-behavior", Required = false, Default = ExitCodeBehavior.None,
                HelpText = "Exit-code behavior: `None` - always return 0; `MajorOnly` - major breakage returns 2; " +
                "`MajorAndMinor` - major breakage returns 2, minor breakage returns 1")]
            public ExitCodeBehavior ExitCodeBehavior { get; private set; }

            [Option("output-behavior", Required = false, Default = OutputBehavior.MajorAndMinor,
                HelpText = "Output behavior: `MajorAndMinor` - show all breaking and non-breaking changes; " +
                "`Major` - only show major breakage; `Minor` - show only minor non-breaking changes; " +
                "`None` - don't output any details of changes.")]
            public OutputBehavior OutputBehavior { get; private set; }
        }

        private static int Main(string[] args)
        {
            // TODO: Move completely to flags-based, rather than ad-hoc command-line args.
            // TODO: Support framework-based and configuration-based dll specification.

            Options options = null;
            var parsed = Parser.Default.ParseArguments<Options>(args);
            switch (parsed)
            {
                case Parsed<Options> success:
                    options = success.Value;
                    break;
                case NotParsed<Options> failure:
                    // Errors will have already been shown.
                    return 200;
                default:
                    Console.WriteLine("Error: Unexpected command-line parse result.");
                    return 201;
            }
            // Hack - this will go once everything is done properly with flags.
            args = args.TakeLast(2).Where(x => !x.StartsWith("-")).ToArray();

            if (args.Length != 2)
            {
                Console.WriteLine("Must have two args after any flags, the old dll and the new dll.");
                Console.WriteLine("  Each arg is of the form: \"nuget|<package>[|<version>[|<tfm>]]\" or \"[file|]<filename>\"");
                Console.WriteLine();
                return 1;
            }

            var assem0 = Load(args[0]);
            var assem1 = Load(args[1]);

            var diffs = Check(assem0, assem1, null);

            if ((options.OutputBehavior & OutputBehavior.Major) != 0)
            {
                diffs.PrintDifferences(Level.Major);
            }
            if ((options.OutputBehavior & OutputBehavior.Minor) != 0)
            {
                diffs.PrintDifferences(Level.Minor);
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
    }
}
