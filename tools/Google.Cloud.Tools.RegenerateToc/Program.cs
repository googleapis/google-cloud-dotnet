// Copyright 2021 Google LLC
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

using Google.Cloud.Tools.DocfxMetadata;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.RegenerateToc
{
    /// <summary>
    /// Tool to regenerate the TOC of a docfx API, using the assembly name as the top-level
    /// entry, rather than namespace. Namespaces within the assembly are handled intelligently:
    /// <list type="bullet">
    /// <item><description>
    /// If the name of the assembly is the same as the name of the namespace, the namespace
    /// contents are included directly.
    /// </description></item>
    /// <item><description>
    /// "Nested" namespaces are included using the differentiator, e.g. Google.Protobuf.Collections
    /// is included as a subnode of Google.Protobuf, with a name "Collections"
    /// </description></item>
    /// <item><description>
    /// Initially, doubly-nested namespaces have no special support; so if Google.Protobuf.Collections.Immutable
    /// existed, it would be shown as "Collections.Immutable". This will not affect many docs, and can be
    /// revisited later.
    /// </description></item>
    /// <item><description>
    /// Non-nested namespaces are included with a full name, e.g. the namespace of Google.Apis
    /// within the assembly Google.Apis.Core is listed as "Google.Apis".
    /// </description></item>
    /// </list>
    /// </summary>
    public class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Expected argument: directory containing API YML files");
                return 1;
            }
            try
            {
                Regenerate(args[0]);
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 1;
            }
        }

        public static void Regenerate(string directory)
        {
            var allMetadata = Directory
                .GetFiles(directory, "*.yml")
                .Where(file => Path.GetFileName(file) != "toc.yml")
                .SelectMany(file => MetadataFile.LoadYaml(file).Items)
                .ToDictionary(item => item.Uid);
            var assemblies = allMetadata.Values
                .SelectMany(item => item.Assemblies)
                .Distinct()
                .OrderBy(assembly => assembly, StringComparer.Ordinal)
                .ToList();

            var tocEntries = assemblies.Select(assembly => CreateTocEntryForAssembly(assembly, allMetadata)).ToList();
            var tocText = TocEntry.CreateToc(tocEntries);
            File.WriteAllText(Path.Combine(directory, "toc.yml"), tocText);
        }

        private static TocEntry CreateTocEntryForAssembly(string assembly, Dictionary<string, MetadataItem> allMetadata)
        {
            // Note: we can't trust the namespace metadata entries for assemblies,
            // because when types from different assemblies are in the same namespace, the assembly
            // list only contains one of them. (For example, Google.Apis contains Google.Apis.ETagAction
            // from Google.Apis.dll, and Google.Apis.ISerializer from Google.Apis.Core.dll.)
            // The namespace metadata contains all of the types across the assemblies though, so we can use
            // those to find namespaces which actually contribute to this assembly.
            var allNamespaces = allMetadata.Values.Where(item => item.Type == ItemType.Namespace).ToList();
            var assemblyNamespaces = allNamespaces
                .Where(ns => ns.Children.Any(child => allMetadata[child].Assemblies.Contains(assembly)))
                .ToList();

            var tocEntry = new TocEntry
            {
                Uid = assembly,
                Name = assembly,
                Items = new List<TocEntry>()
            };

            var prefix = assembly + ".";
            // Entries in the TOC for an assembly:
            // - Namespace nodes for namespaces with different names to the assembly
            // - Directly-included nodes for the namespace with the same name as the assembly
            foreach (var ns in assemblyNamespaces.Where(candidate => candidate.Uid != assembly))
            {
                string contractedName = ns.Name.StartsWith(prefix) ? ns.Name.Substring(prefix.Length) : ns.Name;
                var nsNode = new TocEntry
                {
                    Name = $"{contractedName} (namespace)",
                    Uid = ns.Uid,
                    Items = new List<TocEntry>()
                };
                nsNode.Items.AddRange(GetTocEntriesForNamespace(ns));
                tocEntry.Items.Add(nsNode);
            }
            // We can't easily sort until we've worked out the names, due to the prefixing.
            tocEntry.Items = tocEntry.Items.OrderBy(item => item.Name, StringComparer.Ordinal).ToList();

            // We'll almost always have a namespace with the same name as the assembly, but we shouldn't
            // fail if we don't... (and there's no Google.Apis.Core namespace).
            if (allMetadata.GetValueOrDefault(assembly) is MetadataItem exactAssemblyNs)
            {
                tocEntry.Items.AddRange(GetTocEntriesForNamespace(exactAssemblyNs));
            }
            return tocEntry;

            IEnumerable<TocEntry> GetTocEntriesForNamespace(MetadataItem nsMetadata)
            {
                yield return new TocEntry { Name = "All types", Uid = nsMetadata.Uid };
                // TODO: Consider adding a level of nesting for classes with multiple nested types.
                // Where there's just one nested type, it's not too bad, but beyond that it ends up
                // causing a rather large list. We could also potentially omit nested types with no children,
                // which is common for protobufs (e.g. RecognitionConfig.Types).
                foreach (var child in nsMetadata.Children)
                {
                    var childMetadata = allMetadata[child];
                    yield return new TocEntry { Name = childMetadata.Name, Uid = childMetadata.Uid };
                }
            }
        }
    }
}
