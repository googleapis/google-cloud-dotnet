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
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.VersionCompat
{
    /// <summary>
    /// Utility methods for loading and comparing assemblies.
    /// </summary>
    public static class Assemblies
    {
        private static IEnumerable<Diff> CompareTypes(IEnumerable<TypeDefinition> olderTypes, IEnumerable<TypeDefinition> newerTypes)
        {
            var oWithNested = olderTypes.WithNested().ToImmutableList();
            var nWithNested = newerTypes.WithNested().ToImmutableList();

            return TopLevel.Diffs(oWithNested, nWithNested).ToImmutableList();
        }

        private static IEnumerable<Diff> CompareDependencies(AssemblyDefinition older, AssemblyDefinition newer)
        {
            var olderDeps = older.MainModule.AssemblyReferences.Where(FilterDep).ToDictionary(d => d.Name, d => d.Version);
            var newerDeps = newer.MainModule.AssemblyReferences.Where(FilterDep).ToDictionary(d => d.Name, d => d.Version);

            var oldOnly = olderDeps
                .Where(dep => !newerDeps.ContainsKey(dep.Key))
                .OrderBy(dep => dep.Key, StringComparer.Ordinal)
                .Select(pair => Diff.Minor(Cause.DependencyRemoved, $"Dependency {pair.Key} v{pair.Value} removed"));
            var newOnly = newerDeps
                .Where(dep => !olderDeps.ContainsKey(dep.Key))
                .OrderBy(dep => dep.Key, StringComparer.Ordinal)
                .Select(pair => Diff.Minor(Cause.DependencyAdded, $"Dependency {pair.Key} v{pair.Value} added"));
            var changed = olderDeps
                .Join(newerDeps, pair => pair.Key, pair => pair.Key, (oldPair, newPair) => (dep: oldPair.Key, oldVersion: oldPair.Value, newVersion: newPair.Value))
                .Where(tuple => !tuple.oldVersion.Equals(tuple.newVersion))
                .OrderBy(tuple => tuple.dep, StringComparer.Ordinal)
                .Select(tuple => Diff.Create(
                    tuple.oldVersion.Major == tuple.newVersion.Major ? Level.Minor : Level.Minor,
                    Cause.DependencyChanged, $"Dependency {tuple.dep} changed from v{tuple.oldVersion} to v{tuple.newVersion}"));

            return oldOnly.Concat(newOnly).Concat(changed);

            // Filtering for aspects we don't care about, such as the actual target framework.
            bool FilterDep(AssemblyNameReference asmName) => asmName.Name != "netstandard";
        }

        public static DiffResult Compare(AssemblyDefinition older, AssemblyDefinition newer, string testNamespace)
        {
            if (testNamespace == null)
            {
                var diffs = CompareTypes(GetAllTypes(older), GetAllTypes(newer))
                    .Concat(CompareDependencies(older, newer));
                return new DiffResult(diffs);
            }
            else
            {
                var olderTypesList = new List<TypeDefinition>();
                var newerTypesList = new List<TypeDefinition>();
                var nsOlder = $"{testNamespace}.A.";
                var nsNewer = $"{testNamespace}.B.";
                foreach (var type in GetAllTypes(older).Where(x => x.FullName.StartsWith(nsOlder)))
                {
                    type.Namespace = type.Namespace.Replace($"{testNamespace}.A", testNamespace);
                    olderTypesList.Add(type);
                }
                foreach (var type in GetAllTypes(newer).Where(x => x.FullName.StartsWith(nsNewer)))
                {
                    type.Namespace = type.Namespace.Replace($"{testNamespace}.B", testNamespace);
                    newerTypesList.Add(type);
                }
                if (!olderTypesList.Any() || !newerTypesList.Any())
                {
                    throw new InvalidOperationException("Test data has no relevant types.");
                }
                return new DiffResult(CompareTypes(olderTypesList, newerTypesList));
            }

            IEnumerable<TypeDefinition> GetAllTypes(AssemblyDefinition asm) => asm.Modules.SelectMany(x => x.Types);
        }

        /// <summary>
        /// Loads a package from NuGet and extracts an assembly definition.
        /// </summary>
        /// <param name="package">The name of the package to load. Must not be null.</param>
        /// <param name="version">The version of the package to load. May be null, in which case the latest stable version is downloaded.</param>
        /// <param name="tfm">The target framework to find within the package. May be null, in which case we check the archive to find a reasonable TFM.</param>
        /// <param name="assemblyName">The name of the assembly to find within the package. May be null, in which case it's assumed to be the same as the package.</param>
        /// <returns>The assembly definition loaded from the given package.</returns>
        public static async Task<AssemblyDefinition> LoadPackageAsync(string package, string version, string tfm, string assemblyName)
        {
            var bytes = await LoadPackageData();

            assemblyName ??= package;
            
            Regex pattern = new Regex($@"lib/([a-z0-9.]+)/{Regex.Escape(assemblyName)}\.dll");
            var tfms = new List<string>();
            using (var zip = ZipArchive.Open(new MemoryStream(bytes)))
            {
                foreach (var entry in zip.Entries)
                {
                    if (pattern.Match(entry.Key) is Match { Success: true } match)
                    {
                        tfms.Add(match.Groups[1].Value);
                    }
                }
            }

            if (tfm is not null && !tfms.Contains(tfm))
            {
                throw new InvalidOperationException($"Can't find TFM '{tfm}' in package '{package}' version '{version ?? "latest"}'. Available TFMs: {string.Join(", ", tfms)}");
            }
            else if (tfm is null)
            {
                var tfmsToFind = new string[] { "netstandard2.1", "netstandard2.0", "net6.0", "netcoreapp3.1", "netcoreapp2.1", "net462", "net461", "net452" };
                tfm = tfmsToFind.Intersect(tfms).FirstOrDefault();
                if (tfm is null)
                {
                    throw new InvalidOperationException($"No expected TFM in package '{package}' version '{version ?? "latest"}'. Available TFMs: {string.Join(", ", tfms)}");
                }
            }
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

            async Task<byte[]> LoadPackageData()
            {
                // Handily, this automatically loads the latest stable release if version is null.
                var url = $"https://www.nuget.org/api/v2/package/{package}/{version}";
                using var client = new HttpClient();
                var response = await client.GetAsync(url).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            }
        }

        public static AssemblyDefinition LoadFile(string file)
        {
            var bytes = File.ReadAllBytes(file);
            return AssemblyDefinition.ReadAssembly(new MemoryStream(bytes));
        }

    }
}
