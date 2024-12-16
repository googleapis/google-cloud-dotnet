// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Tools.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Google.Cloud.Tools.GenerateSnippetMarkdown
{
    // Snippet format:

    // Snippet: (name of snippet) - or Sample: (name of snippet)
    // Additional: (member name to match) - 0 or more times
    // Lines of text
    // End snippet (or End sample, equivalently - just for symmetry)

    // A snippet can start with Sample: instead of snippet, in which case the ID must be a valid docfx snippet name,
    // (A-Z, a-z, 0-9, _, .) and the name isn't matched against members.
    //
    // Otherwise, it (and any "additional" member names) must match a member name within the type specified
    // implicitly by the project/source file containing the snippet:
    //   - If there's only one such member, it can be specified without any qualification, e.g. Create
    //   - Otherwise, if it can be specified by arity, use just wildcards, e.g. Create(*,*) for a two parameter overload
    //   - Otherwise, fill in enough parameters to distinguish it from other overloads, e.g. Create(string,)
    //     Precise nature of parameter matching is TBD... we'll do our best.

    // Additionally, outside a sample, a comment starting with "Resource: " indicates that the specified
    // resource should be copied into the text output as if it were a sample in the current file. The snippet ID is provided
    // as a second value, as the filename is unlikely to be a valid snippet ID. For example:
    // Resource: foo.xml sample_foo
    // creates a snippet with an ID of "sample_foo" with the content of "foo.xml".

    // "See also" format, used to create a reference to another method which has a snippet.

    // See-also: (name of reference snippet)
    // Member: (member name to match) - 1 or more times
    // Lines of text including (ref) as a placeholder for the reference.
    // End see-also

    // The reference must be a method which has a snippet; the reference name and all member names
    // must match members in the same way as snippets, except that the reference name may start with a type name.
    // (The see-also members are expected to be in the snippet file for the documentation where the references appear,
    // but the target may well be in a different type.)

    /// <summary>
    /// Simple program to generate markdown and text files for docfx to consume when generating documentation.
    /// The file basically links the snippets projects with the client libraries.
    /// </summary>
    public sealed class Program
    {
        private const string StartSeeAlso = "// See-also: ";
        private const string SeeAlsoMember = "// Member: ";
        private const string Resource = "// Resource: ";
        private const string StartSample = "// Sample: ";
        private const string StartSnippet = "// Snippet: ";
        private const string AdditionalMember = "// Additional: ";
        private const string EndSnippet = "// End snippet";
        private const string EndSample = "// End sample";
        private const string EndSeeAlso = "// End see-also";

        // We skip lines containing these comments when generating snippets, so that the DevRel system can work with this.
        private const string DevRelSnippetStart = "// [START";
        private const string DevRelSnippetEnd = "// [END";

        // All these characters need to be converted to _ when creating a link
        private static readonly Regex DocfxSnippetPattern = new Regex(@"^[\w\.]+$", RegexOptions.Compiled);
        private static readonly Regex NullablePattern = new Regex(@"^System.Nullable\{([\w\.]*)\}$", RegexOptions.Compiled);
        private static readonly Regex GenericMemberPattern = new Regex(@"^([\w\.]+)\{([\w\.,]*)\}$", RegexOptions.Compiled);
        private static readonly Regex GenericSnippetPattern = new Regex(@"^([\w\.]+)\<([\w\.,: ]*)\>$", RegexOptions.Compiled);
        private static readonly Dictionary<string, string> KeywordAliases = new Dictionary<string, string>
        {
            { "string", "System.String" },
            { "bool", "System.Boolean" },
            { "int", "System.Int32" },
            { "long", "System.Int64" },
            { "double", "System.Double" },
            { "float", "System.Single" },
        };
        private static readonly string[] SnippetFileSuffixes =
        {
            "Snippets.cs",
            "Snippets.g.cs"
        };

        private static int Main(string[] args)
        {
            try
            {
                return MainImpl(args);
            }
            catch (UserErrorException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return 1;
            }
        }

        private static int MainImpl(string[] args)
        {
            if (args.Length == 0 || args.Length > 2)
            {
                ThrowUsageError();
            }
            string api = args[0];
            bool generateReport = false;
            string reportFile = null;
            if (args.Length == 2)
            {
                generateReport = true;
                string reportArg = args[1];
                if (!reportArg.StartsWith("--report"))
                {
                    ThrowUsageError();
                }
                if (reportArg != "--report")
                {
                    if (!reportArg.StartsWith("--report="))
                    {
                        ThrowUsageError();
                    }
                    reportFile = reportArg.Substring("--report=".Length);
                }
            }

            var rootLayout = RootLayout.ForCurrentDirectory();
            var docsLayout = api == "help" ? DocsLayout.ForHelpSnippets(rootLayout) : rootLayout.CreateDocsLayout(api);

            string snippetsSource = docsLayout.SnippetSourceDirectory;
            if (!Directory.Exists(snippetsSource))
            {
                Console.WriteLine($"Unable to find snippets within API {api}. Ignoring this API.");
                return 0;
            }

            string output = docsLayout.SnippetOutputDirectory;
            if (!Directory.Exists(output))
            {
                Directory.CreateDirectory(output);
            }
            else
            {
                foreach (var file in Directory.GetFiles(output))
                {
                    File.Delete(file);
                }
            }

            var memberLookup = LoadMembersByType(docsLayout.DocfxMetadataDirectory);
            Console.WriteLine($"Loaded {memberLookup.Count} types with {memberLookup.Sum(x => x.Count())} members");
            List<string> errors = new List<string>();
            var snippets = LoadAllSnippets(snippetsSource, api, errors);
            Console.WriteLine($"Loaded {snippets.Sum(x => x.Count())} snippets");

            foreach (var entry in snippets)
            {
                if (entry.Key.EndsWith(".cs"))
                {
                    errors.Add($"Snippet file {entry.Key} does not end with one of the accepted snippet file suffixes: {string.Join(", ", SnippetFileSuffixes)}");
                    continue;
                }

                string snippetFile = entry.Key + ".txt";
                GenerateSnippetText(Path.Combine(output, snippetFile), entry);
                MapSnippetMetadataUids(entry, memberLookup[entry.Key], errors);
                GenerateSnippetMarkdown(Path.Combine(output, entry.Key + ".md"), snippetFile, entry);
            }

            var seeAlsos = LoadAllSeeAlsos(snippetsSource, errors);
            Console.WriteLine($"Loaded {seeAlsos.Sum(x => x.Count())} see-alsos");
            foreach (var entry in seeAlsos)
            {
                MapSeeAlsoMetadataUids(entry, memberLookup, entry.Key, errors);
                GenerateSeeAlsoMarkdown(Path.Combine(output, entry.Key + ".md"), entry);
            }

            ValidateSeeAlsos(seeAlsos.SelectMany(x => x), snippets.SelectMany(x => x), errors);

            if (errors.Any())
            {
                foreach (var error in errors)
                {
                    Console.Error.WriteLine(error);
                }
                return 1;
            }

            if (generateReport)
            {
                using (var writer = reportFile == null ? Console.Out : File.CreateText(reportFile))
                {
                    GenerateReport(memberLookup, snippets, seeAlsos, writer);
                }
            }
            return 0;
        }

        private static void ThrowUsageError()
        {
            throw new UserErrorException("Usage: <api name> [--report | --report=file.txt]");
        }

        private static void GenerateReport(
            ILookup<string, Member> members,
            ILookup<string, Snippet> snippets,
            ILookup<string, SeeAlso> seeAlsos,
            TextWriter writer)
        {
            // We assume that we at least have one snippet/see-also for each type we're interested in.
            var types = snippets.Select(x => x.Key).Union(seeAlsos.Select(x => x.Key)).OrderBy(x => x).ToList();
            var uncoveredCounts = new Dictionary<string, int>();
            foreach (var type in types)
            {
                writer.WriteLine($"Type {type}:");
                var coveredUids = new HashSet<string>(snippets[type].SelectMany(s => s.MetadataUids)
                    .Union(seeAlsos[type].SelectMany(s => s.MetadataUids)));

                int missing = 0;
                foreach (var member in members[type].Where(m => m.Type == "Method"))
                {
                    if (!coveredUids.Contains(member.Uid))
                    {
                        writer.WriteLine($"  Uncovered member: {member.Id}");
                        missing++;
                    }
                }
                uncoveredCounts[type] = missing;
            }
            writer.WriteLine();
            writer.WriteLine("Summary");
            foreach (var type in types)
            {
                writer.WriteLine($"{type}: {snippets[type].Count()} snippets; {seeAlsos[type].Count()} see-alsos; {uncoveredCounts[type]} uncovered");
            }
        }

        /// <summary>
        /// Validate SeeAlso entries:
        /// - No SeeAlso "source" should already have a snippet
        /// - All SeeAlso "targets" should have a snippet
        /// </summary>
        private static void ValidateSeeAlsos(IEnumerable<SeeAlso> seeAlsos, IEnumerable<Snippet> snippets, List<string> errors)
        {
            var allSnippetUids = new HashSet<string>(snippets.SelectMany(s => s.MetadataUids));
            foreach (var seeAlso in seeAlsos)
            {
                if (seeAlso.SnippetUid != null && !allSnippetUids.Contains(seeAlso.SnippetUid))
                {
                    errors.Add($"{seeAlso.SourceLocation}: See-also target does not contain an example");
                }

                foreach (var uid in seeAlso.MetadataUids)
                {
                    if (allSnippetUids.Contains(uid))
                    {
                        errors.Add($"{seeAlso.SourceLocation}: Member {uid} already has an example, so doesn't need a see-also");
                    }
                }
            }
        }

        private static ILookup<string, Snippet> LoadAllSnippets(string snippetSourceDir, string api, List<string> errors)
        {
            var query = from sourceFile in Directory.GetFiles(snippetSourceDir, "*.cs")
                        let type = api + "." + TrimSuffix(Path.GetFileName(sourceFile), SnippetFileSuffixes)
                        from snippet in LoadFileSnippets(sourceFile, errors)
                        select new { Type = type, Snippet = snippet };
            return query.ToLookup(item => item.Type, item => item.Snippet);
        }

        // TODO: Can we break this method up at all? Feels like there should be alternatives available...
        private static IEnumerable<Snippet> LoadFileSnippets(string file, List<string> errors)
        {
            // Generated snippets start with a . to distinguish them from manual ones in terms of their ID,
            // and we remove and duplicated metadata GUIDs.
            bool generated = file.EndsWith(".g.cs");
            Snippet currentSnippet = null;
            int lineNumber = 0;
            // Only keep the filename part for diagnostics; that's usually going to be obvious enough.
            string sourceFile = Path.GetFileName(file);
            foreach (var line in File.ReadLines(file))
            {
                lineNumber++;
                // By skipping these lines, we can write snippets that the DevRel system can include too.
                if (line.Contains(DevRelSnippetStart) || line.Contains(DevRelSnippetEnd))
                {
                    continue;
                }

                // 5 kinds of line to consider:
                // StartSnippet / StartSample: only valid when not in a snippet
                // EndSnippet / EndSample: only valid when in a snippet
                // Additional: only valid when at the start of a snippet
                // Resource: only valid when not in a snippet
                // Regular line; valid in either case, but with different results.

                string location = $"{sourceFile}:{lineNumber}";

                if (line.Contains(StartSnippet) || line.Contains(StartSample))
                {
                    if (currentSnippet == null)
                    {
                        bool sample = line.Contains(StartSample);
                        string id = GetContentAfterPrefix(line, sample ? StartSample : StartSnippet);
                        if (sample && !DocfxSnippetPattern.IsMatch(id))
                        {
                            errors.Add($"{location}: Sample ID '{id}' is not a valid docfx snippet ID");
                        }
                        else if (!IsValidId(id))
                        {
                            errors.Add($"{location}: Invalid snippet ID '{id}'");
                            // We'll also get an "end snippet with no start" error later, but that's
                            // not too bad.
                        }
                        else
                        {
                            currentSnippet = new Snippet
                            {
                                SnippetId = generated ? "." + id : id,
                                SourceFile = sourceFile,
                                SourceStartLine = lineNumber,
                                Autogenerated = generated
                            };
                            if (!sample)
                            {
                                currentSnippet.MetadataMembers.Add(id);
                            }
                        }
                    }
                    else
                    {
                        errors.Add($"{location}: Invalid start of nested sample/snippet");
                    }
                }
                else if (line.Contains(EndSample) || line.Contains(EndSnippet))
                {
                    if (currentSnippet != null)
                    {
                        TrimLeadingSpaces(currentSnippet.Lines);
                        yield return currentSnippet;
                        currentSnippet = null;
                    }
                    else
                    {
                        errors.Add($"{location}: Snippet/sample end without start");
                    }
                }
                else if (line.Contains(AdditionalMember))
                {
                    if (currentSnippet != null)
                    {
                        string id = GetContentAfterPrefix(line, AdditionalMember);
                        if (currentSnippet.Lines.Count == 0)
                        {
                            if (IsValidId(id))
                            {
                                currentSnippet.MetadataMembers.Add(id);
                            }
                            else
                            {
                                errors.Add($"{location}: Invalid additional member ID '{id}'");
                            }
                        }
                        else
                        {
                            errors.Add($"{location}: Additional member ID part way through snippet");
                        }
                    }
                    else
                    {
                        errors.Add($"{location}: Additional member ID not in snippet");
                    }
                }
                else if (line.Contains(Resource))
                {
                    if (currentSnippet == null)
                    {
                        string[] fileAndId = GetContentAfterPrefix(line, Resource).Split(' ');
                        if (fileAndId.Length != 2)
                        {
                            errors.Add($"{location}: Resource must specify file and snippet ID");
                        }
                        else if (!DocfxSnippetPattern.IsMatch(fileAndId[1]))
                        {
                            errors.Add($"{location}: Resource snippet ID {fileAndId[1]} is not a valid docfx ID");
                        }
                        else
                        {
                            string id = fileAndId[1];
                            string directory = Path.GetDirectoryName(file);
                            string resourceFile = Path.Combine(directory, fileAndId[0]);
                            string[] resourceContent = File.ReadAllLines(resourceFile);

                            var resourceSnippet = new Snippet
                            {
                                SnippetId = generated ? "." + id : id,
                                SourceFile = resourceFile,
                                SourceStartLine = 1,
                                Autogenerated = generated
                            };
                            resourceSnippet.Lines.AddRange(resourceContent);
                            yield return resourceSnippet;
                        }
                    }
                    else
                    {
                        errors.Add($"{location}: Resource specified within snippet");
                    }
                }
                else if (currentSnippet != null)
                {
                    currentSnippet.Lines.Add(line);
                }
            }
            if (currentSnippet != null)
            {
                errors.Add($"{currentSnippet.SourceLocation}: Snippet '{currentSnippet.SnippetId}' didn't end");
            }
        }

        private static ILookup<string, SeeAlso> LoadAllSeeAlsos(string snippetSourceDir, List<string> errors)
        {
            var canonicalName = Path.GetFullPath(snippetSourceDir);
            var projectName = TrimSuffix(Path.GetFileName(canonicalName), ".Snippets");
            // Experimental libraries will be in non-experimental namespaces.
            projectName = TrimSuffix(projectName, ".Experimental");
            var query = from sourceFile in Directory.GetFiles(snippetSourceDir, "*.cs")
                        let type = projectName + "." + TrimSuffix(Path.GetFileName(sourceFile), "Snippets.cs", "Snippets.g.cs")
                        from snippet in LoadFileSeeAlsos(sourceFile, errors)
                        select new { Type = type, Snippet = snippet };
            return query.ToLookup(item => item.Type, item => item.Snippet);
        }

        private static IEnumerable<SeeAlso> LoadFileSeeAlsos(string file, List<string> errors)
        {
            SeeAlso currentSeeAlso = null;
            int lineNumber = 0;
            // Only keep the filename part for diagnostics; that's usually going to be obvious enough.
            string sourceFile = Path.GetFileName(file);
            foreach (var line in File.ReadLines(file))
            {
                lineNumber++;
                // 4 kinds of line to consider:
                // StartSeeAlso: only valid when not in a see-also
                // EndSeeAlso: only valid when in a see-also
                // Member: only valid when at the start of a see-also
                // Regular line; valid in any case, but with different results.

                string location = $"{sourceFile}:{lineNumber}";

                if (line.Contains(StartSeeAlso))
                {
                    if (currentSeeAlso == null)
                    {
                        string id = GetContentAfterPrefix(line, StartSeeAlso);
                        if (!IsValidId(id))
                        {
                            errors.Add($"{location}: Invalid see-also reference ID '{id}'");
                            // We'll also get an "end see-also with no start" error later, but that's
                            // not too bad.
                        }
                        else
                        {
                            currentSeeAlso = new SeeAlso
                            {
                                SnippetId = id,
                                SourceFile = sourceFile,
                                SourceStartLine = lineNumber
                            };
                        }
                    }
                    else
                    {
                        errors.Add($"{location}: Invalid start of nested see-also");
                    }
                }
                else if (line.Contains(EndSeeAlso))
                {
                    if (currentSeeAlso != null)
                    {
                        if (currentSeeAlso.Lines.Count == 0)
                        {
                            errors.Add($"{location}: see-also with no body text");
                        }
                        else
                        {
                            TrimLeadingSpaces(currentSeeAlso.Lines);
                            yield return currentSeeAlso;
                            currentSeeAlso = null;
                        }
                    }
                    else
                    {
                        errors.Add($"{location}: See-also end without start");
                    }
                }
                else if (line.Contains(SeeAlsoMember))
                {
                    if (currentSeeAlso != null)
                    {
                        string id = GetContentAfterPrefix(line, SeeAlsoMember);
                        if (currentSeeAlso.Lines.Count == 0)
                        {
                            if (IsValidId(id))
                            {
                                currentSeeAlso.MetadataMembers.Add(id);
                            }
                            else
                            {
                                errors.Add($"{location}: Invalid see-also member ID '{id}'");
                            }
                        }
                        else
                        {
                            errors.Add($"{location}: see-also member ID part way through see-also");
                        }
                    }
                    else
                    {
                        errors.Add($"{location}: see-also member ID not in see-also");
                    }
                }
                else if (currentSeeAlso != null)
                {
                    if (currentSeeAlso.MetadataMembers.Count == 0 && currentSeeAlso.Lines.Count == 0)
                    {
                        errors.Add($"{location}: see-also with no members");
                    }
                    currentSeeAlso.Lines.Add(line);
                }
            }
            if (currentSeeAlso != null)
            {
                errors.Add($"{currentSeeAlso.SourceLocation}: See-also '{currentSeeAlso.SnippetId}' didn't end");
            }
        }

        // Is this a valid ID for a member match? We only check that if there's an open-paren,
        // the ID must end with a close-paren.
        private static bool IsValidId(string id) =>
            !(id.Contains("(") && !id.EndsWith(")"));

        private static string GetContentAfterPrefix(string line, string prefix)
        {
            int index = line.IndexOf(prefix);
            if (index == -1)
            {
                throw new ArgumentException($"'{line}' doesn't contain '{prefix}'");
            }
            return line.Substring(index + prefix.Length).Trim();
        }

        /// <summary>
        /// Generate a file containing all the given snippets. In the future, we may add
        /// some extra processing to include more text within the snippet flie, such as using directives...
        /// or we could munge any occurrence of template values (e.g. projectId) to string literals ("YOUR PROJECT ID").
        /// Any snippet with an ID which is a valid docfx snippet ID is wrapped in the snippet tags, for the sake
        /// of referring to it from documentation.
        /// </summary>
        private static void GenerateSnippetText(string outputFile, IEnumerable<Snippet> snippets)
        {
            using (var writer = File.CreateText(outputFile))
            {
                int lineIndex = 1;
                foreach (var snippet in snippets)
                {
                    // We produce a docfx snippet for any sample, and any snippet where the ID
                    // is also valid, as we might want to refer to it in conceptual docs *and* API docs.
                    bool validDocfxId = DocfxSnippetPattern.IsMatch(snippet.SnippetId);
                    writer.WriteLine($"----- Snippet {snippet.SnippetId} -----");
                    lineIndex++;
                    if (validDocfxId)
                    {
                        writer.WriteLine(snippet.DocfxSnippetStart);
                        lineIndex++;
                    }
                    snippet.StartLine = lineIndex;
                    snippet.Lines.ForEach(writer.WriteLine);
                    lineIndex += snippet.Lines.Count;
                    snippet.EndLine = lineIndex - 1;
                    if (validDocfxId)
                    {
                        writer.WriteLine(snippet.DocfxSnippetEnd);
                        lineIndex++;
                    }
                    writer.WriteLine();
                    lineIndex++;
                }
            }
        }

        /// <summary>
        /// For each snippet, try to find the relevant matching members and save then in the MetadataUids property.
        /// Errors are collected rather than an exception being immediately thrown, so that many errors can be
        /// detected and fixed in a single run.
        /// </summary>
        private static void MapSnippetMetadataUids(IEnumerable<Snippet> snippets, IEnumerable<Member> members, List<string> errors)
        {
            ISet<string> matchedUids = new HashSet<string>();
            // Match manually written snippets first, then autogenerated ones, so
            // that manually written ones take priority.
            foreach (var snippet in snippets.OrderBy(s => s.Autogenerated))
            {
                foreach (var snippetMemberId in snippet.MetadataMembers)
                {
                    Member member = FindMember(members, snippetMemberId, errors, snippet.SourceLocation);
                    if (member != null)
                    {
                        string uid = member.Uid;
                        if (matchedUids.Add(uid))
                        {
                            snippet.MetadataUids.Add(uid);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// For each see-also, try to find the matching members for both the source and target.
        /// Errors are collected rather than an exception being immediately thrown, so that many errors can be
        /// detected and fixed in a single run.
        /// </summary>
        private static void MapSeeAlsoMetadataUids(IEnumerable<SeeAlso> seeAlsos, ILookup<string, Member> allMembers, string defaultType, List<string> errors)
        {
            var targetMembers = allMembers[defaultType];

            foreach (var seeAlso in seeAlsos)
            {
                string snippetId = seeAlso.SnippetId;
                int dot = snippetId.IndexOf('.');
                string type = defaultType;
                if (dot != -1)
                {
                    string typeNameEnd = "." + snippetId.Substring(0, dot);
                    var typeNames = allMembers.Select(x => x.Key).Where(k => k.EndsWith(typeNameEnd)).ToList();
                    if (typeNames.Count > 1)
                    {
                        errors.Add($"{seeAlso.SourceLocation}: Snippet ID '{snippetId}' type name matches multiple types ({string.Join(", ", typeNames)}).");
                        continue;
                    }
                    else if (typeNames.Count == 0)
                    {
                        errors.Add($"{seeAlso.SourceLocation}: Snippet ID '{snippetId}' type name matches no known types.");
                        continue;
                    }
                    snippetId = snippetId.Substring(dot + 1);
                    type = typeNames[0];
                }
                var snippetMember = FindMember(allMembers[type], snippetId, errors, seeAlso.SourceLocation);
                if (snippetMember == null)
                {
                    continue;
                }
                seeAlso.SnippetUid = snippetMember.Uid;

                foreach (var seeAlsoMemberId in seeAlso.MetadataMembers)
                {
                    var member = FindMember(targetMembers, seeAlsoMemberId, errors, seeAlso.SourceLocation);
                    if (member != null)
                    {
                        seeAlso.MetadataUids.Add(member.Uid);
                    }
                }
            }
        }

        private static Member FindMember(IEnumerable<Member> members, string idToMatch, List<string> errors, string sourceLocation)
        {
            var matches = members.Where(member => IsMemberMatch(member.Id, idToMatch)).ToList();
            if (matches.Count > 1)
            {
                errors.Add($"{sourceLocation}: Member ID '{idToMatch}' matches multiple members:");
                foreach (var match in matches)
                {
                    errors.Add($"    {match.Id}");
                }
                return null;
            }
            else if (matches.Count == 0)
            {
                errors.Add($"{sourceLocation}: Member ID '{idToMatch}' matches no members.");
                var matchingNames = members.Where(member => IsMemberNameMatch(member.Id, idToMatch)).ToList();
                if (matchingNames.Count == 0)
                {
                    errors.Add("  (No members match by name.)");
                }
                else
                {
                    errors.Add("  Members which match only by name:");
                    foreach (var match in matchingNames)
                    {
                        errors.Add($"    {match.Id}");
                    }
                }
                return null;
            }
            return matches[0];
        }

        private static void GenerateSnippetMarkdown(string outputFile, string relativeSnippetFile, IEnumerable<Snippet> snippets)
        {
            if (!snippets.SelectMany(snippet => snippet.MetadataUids).Any())
            {
                return;
            }
            using (var writer = File.CreateText(outputFile))
            {
                foreach (var snippet in snippets)
                {
                    foreach (var metadataUid in snippet.MetadataUids)
                    {
                        writer.WriteLine("---");
                        writer.WriteLine($"uid: {metadataUid}");
                        writer.WriteLine("snippet: *content");
                        writer.WriteLine("---");
                        writer.WriteLine();
                        writer.WriteLine($"[!code-cs[]({relativeSnippetFile}#L{snippet.StartLine}-L{snippet.EndLine})]");
                        writer.WriteLine();
                    }
                }
            }
        }

        private static void GenerateSeeAlsoMarkdown(string outputFile, IEnumerable<SeeAlso> seeAlsos)
        {
            using (var writer = File.AppendText(outputFile))
            {
                foreach (var seeAlso in seeAlsos)
                {
                    string target = $"(xref:{WebUtility.UrlEncode(seeAlso.SnippetUid)})";
                    foreach (var metadataUid in seeAlso.MetadataUids)
                    {
                        writer.WriteLine("---");
                        writer.WriteLine($"uid: {metadataUid}");
                        writer.WriteLine("snippet: *content");
                        writer.WriteLine("---");
                        writer.WriteLine();
                        foreach (var line in seeAlso.Lines)
                        {
                            writer.WriteLine(line.Replace("(ref)", target).Replace("// ", ""));
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        private static bool IsMemberNameMatch(string memberId, string snippetId)
        {
            int openParen = snippetId.IndexOf("(");
            if (openParen != -1)
            {
                return memberId.StartsWith(snippetId.Substring(0, openParen + 1));
            }
            else
            {
                // Parameterless methods have a UID without brackets.
                return memberId.StartsWith(snippetId + "(") || memberId == snippetId;
            }
        }


        private static bool IsMemberMatch(string memberId, string snippetId)
        {
            int openParen = snippetId.IndexOf("(");
            if (openParen != -1)
            {
                // Check member name first
                if (!memberId.StartsWith(snippetId.Substring(0, openParen + 1)))
                {
                    return false;
                }
                // Note: this will fail for generic types with an arity more than 1.
                // Let's cross that bridge when we come to it.
                string snippetParameters = snippetId.Substring(openParen + 1, snippetId.Length - 2 - openParen);
                string memberParameters = memberId.Substring(openParen + 1, memberId.Length - 2 - openParen);

                // Avoid issue of Foo() looking like it has a single parameter.
                if (memberParameters == "")
                {
                    return snippetParameters == "";
                }

                string[] splitSnippetParameters = SplitParameters(snippetParameters);
                string[] splitMemberParameters = SplitParameters(memberParameters);
                if (splitMemberParameters.Length != splitSnippetParameters.Length)
                {
                    return false;
                }
                return splitMemberParameters.Zip(splitSnippetParameters, IsParameterMatch).All(x => x);
            }
            else
            {
                // Parameterless methods have a UID without brackets.
                return memberId.StartsWith(snippetId + "(") || memberId == snippetId;
            }
        }

        private static string[] SplitParameters(string parameters)
        {
            // Commas can appear in generic parameter types as well as at the "top level".
            // Temporarily replace any comma which appears within braces with #,
            // then we can perform an element-wise reverse replacement.
            var builder = new StringBuilder(parameters);
            var arity = 0;
            for (int i = 0; i < builder.Length; i++)
            {
                switch (builder[i])
                {
                    case '<':
                    case '{':
                        arity++;
                        break;
                    case '>':
                    case '}':
                        arity--;
                        break;
                    case ',':
                        if (arity != 0)
                        {
                            builder[i] = '#';
                        }
                        break;
                }
            }
            return builder.ToString()
                .Split(',')
                .Select(s => s.Replace('#', ','))
                .ToArray();
        }

        // TODO: Unit tests for this...
        private static bool IsParameterMatch(string memberParameter, string snippetParameter)
        {
            snippetParameter = snippetParameter.Trim();
            if (snippetParameter == "*")
            {
                return true;
            }
            if (KeywordAliases.ContainsKey(snippetParameter))
            {
                snippetParameter = KeywordAliases[snippetParameter];
            }
            if (snippetParameter.EndsWith("?"))
            {
                var nullableMatch = NullablePattern.Match(memberParameter);
                return nullableMatch.Success &&
                    IsParameterMatch(nullableMatch.Groups[1].Value, snippetParameter.TrimEnd('?'));
            }
            var genericMemberMatch = GenericMemberPattern.Match(memberParameter);
            var genericSnippetMatch = GenericSnippetPattern.Match(snippetParameter);
            if (genericMemberMatch.Success || genericSnippetMatch.Success)
            {
                if (!genericMemberMatch.Success || !genericSnippetMatch.Success)
                {
                    return false;
                }
                // Both the type name and all the type arguments must match.
                var memberTypeArguments = SplitParameters(genericMemberMatch.Groups[2].Value);
                var snippetTypeArguments = SplitParameters(genericSnippetMatch.Groups[2].Value);
                return IsParameterMatch(genericMemberMatch.Groups[1].Value, genericSnippetMatch.Groups[1].Value) &&
                    memberTypeArguments.Length == snippetTypeArguments.Length &&
                    memberTypeArguments.Zip(snippetTypeArguments, IsParameterMatch).All(x => x);
            }

            // Now that we're down to simple names, remove any namespace qualifiers in the snippet.
            if (snippetParameter.Contains("::"))
            {
                snippetParameter = snippetParameter.Split(':').Last();
            }
            // Ignore namespaces, for now.
            var simpleMemberParameterName = memberParameter.Split('.').Last();
            var simpleSnippetParameterName = snippetParameter.Split('.').Last();
            return simpleMemberParameterName == simpleSnippetParameterName;
        }

        /// <summary>
        /// Loads all the members from YAML metadata files, and group them by parent type.
        /// </summary>
        private static ILookup<string, Member> LoadMembersByType(string metadataDir)
        {
            if (metadataDir == null) // Deliberately missing, e.g. root docs
            {
                // Just an empty lookup.
                return new string[0].ToLookup(x => x, x => (Member)null);
            }
            if (!Directory.Exists(metadataDir))
            {
                throw new UserErrorException($"Metadata directory doesn't exist: {metadataDir}");
            }
            var dictionary = new Dictionary<string, List<Member>>();
            // Urgh - there must be a nicer way of doing this.
            foreach (var file in Directory.GetFiles(metadataDir, "*.yml"))
            {
                if (Path.GetFileName(file) == "toc.yml")
                {
                    continue;
                }
                using (var input = File.OpenText(file))
                {
                    var model = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .IgnoreUnmatchedProperties()
                        .Build()
                        .Deserialize<CodeModel>(input);
                    // Assume we only want classes and structs at the moment...
                    var type = model.Items.FirstOrDefault(x => x.Type == "Class" || x.Type == "Struct");
                    if (type == null)
                    {
                        continue;
                    }
                    var members = model.Items.Where(x => x.Parent == type.Uid).ToList();
                    dictionary[type.Uid] = members;
                }
            }
            return dictionary
                .SelectMany(pair => pair.Value.Select(m => new { pair.Key, Value = m }))
                .ToLookup(pair => pair.Key, pair => pair.Value);
        }

        private static string TrimSuffix(string text, params string[] suffixes)
        {
            foreach (var suffix in suffixes)
            {
                if (text.EndsWith(suffix))
                {
                    return text.Substring(0, text.Length - suffix.Length);
                }
            }
            return text;
        }

        /// <summary>
        /// Trim all leading spaces by a uniform amount (the smallest number of spaces in any line).
        /// </summary>
        private static void TrimLeadingSpaces(List<string> lines)
        {
            var spacesToRemove = lines.Min(line => line.Trim() == "" ? int.MaxValue : line.TakeWhile(c => c == ' ').Count());
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = lines[i].Trim() == "" ? "" : lines[i].Substring(spacesToRemove);
            }
        }
    }
}
