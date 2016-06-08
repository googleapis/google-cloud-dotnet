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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Google.GCloud.Tools.GenerateSnippetMarkdown
{
    // Snippet format:

    // Snippet: (name of snippet)
    // Lines of text
    // End snippet

    // The name of the snippet can be:
    // - A name which isn't a member at all, in order to link from documentation. In this case it has to be a valid docfx snippet name.
    // - A member name within the type specified implicitly by the project/source file containing the snippet
    //   - If there's only one such member, it can be specified without any qualification, e.g. Create
    //   - Otherwise, if it can be specified by arity, use just wildcards, e.g. Create(*,*) for a two parameter overload
    //   - Otherwise, fill in enough parameters to distinguish it from other overloads, e.g. Create(string,)
    //     Precise nature of parameter matching is TBD... we'll do our best.
    //
    // A name which isn't a valid docfx snippet name (A-Z, a-z, 0-9, _, .) *must* match exactly one member,
    // or an error is displayed.


    /// <summary>
    /// Simple program to generate a snippets.md file for docfx to consume when generating documentation.
    /// The file basically links the snippets projects with the client libraries.
    /// </summary>
    public sealed class Program
    {
        private const string StartSnippet = "// Snippet: ";
        private const string AdditionalMember = "// Additional: ";
        private const string EndSnippet = "// End snippet";
        private static readonly Regex DocfxSnippetPattern = new Regex(@"^[\w\.]+$", RegexOptions.Compiled);

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
            string root = DetermineRootDirectory();
            if (root == null)
            {
                throw new UserErrorException("Unable to determine root directory. Please run within gcloud-dotnet repository.");
            }

            string snippetsSource = Path.Combine(root, "snippets");
            if (!Directory.Exists(snippetsSource))
            {
                throw new UserErrorException($"Snippets directory {snippetsSource} doesn't exist. Aborting.");
            }

            string metadata = Path.Combine(root, "docs", "obj", "api");
            if (!Directory.Exists(metadata))
            {
                throw new UserErrorException($"Metadata directory {metadata} doesn't exist. Aborting.");
            }

            string output = Path.Combine(root, "docs", "obj", "snippets");
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

            var memberLookup = LoadMembersByType(metadata);
            Console.WriteLine($"Loaded {memberLookup.Count} types with {memberLookup.Sum(x => x.Count())} members");
            List<string> errors = new List<string>();
            var snippets = LoadAllSnippets(snippetsSource, errors);
            Console.WriteLine($"Loaded {snippets.Sum(x => x.Count())} snippets");
            foreach (var entry in snippets)
            {
                string snippetFile = entry.Key + ".txt";
                GenerateSnippetText(Path.Combine(output, snippetFile), entry);
                MapMetadataUids(entry, memberLookup[entry.Key], errors);
                GenerateSnippetMarkdown(Path.Combine(output, entry.Key + ".md"), snippetFile, entry);
            }
            if (errors.Any())
            {
                foreach (var error in errors)
                {
                    Console.Error.WriteLine(error);
                }
                return 1;
            }

            return 0;
        }

        private static ILookup<string, Snippet> LoadAllSnippets(string snippetSourceDir, List<string> errors)
        {
            var query = from project in Directory.GetDirectories(snippetSourceDir)
                            // Path.GetFileName just takes the last part of the name; it doesn't know that it's a directory.
                        let projectName = TrimSuffix(Path.GetFileName(project), ".Snippets")
                        from sourceFile in Directory.GetFiles(project, "*.cs")
                        let type = projectName + "." + TrimSuffix(Path.GetFileName(sourceFile), "Snippets.cs")
                        from snippet in LoadFileSnippets(sourceFile, errors)
                        select new { Type = type, Snippet = snippet };
            return query.ToLookup(item => item.Type, item => item.Snippet);
        }

        private static IEnumerable<Snippet> LoadFileSnippets(string file, List<string> errors)
        {
            Snippet currentSnippet = null;
            int lineNumber = 0;
            // Only keep the filename part for diagnostics; that's usually going to be obvious enough.
            string sourceFile = Path.GetFileName(file);
            foreach (var line in File.ReadLines(file))
            {
                lineNumber++;
                int startSnippetIdIndex = line.IndexOf(StartSnippet);
                bool startSnippet = startSnippetIdIndex != -1;
                bool endSnippet = line.Contains(EndSnippet);

                int startAdditionalIndex = line.IndexOf(AdditionalMember);
                bool additional = startAdditionalIndex != -1;

                if (currentSnippet != null)
                {
                    if (startSnippet)
                    {
                        errors.Add($"Extra snippet start at {sourceFile}:{lineNumber} within snippet starting at line {currentSnippet.SourceStartLine}.");
                    }
                    else if (endSnippet)
                    {
                        currentSnippet.TrimLeadingSpaces();
                        yield return currentSnippet;
                        currentSnippet = null;
                    }
                    else if (additional)
                    {
                        string additionalId = line.Substring(startAdditionalIndex + AdditionalMember.Length).Trim();
                        if (additionalId.Contains("(") && !additionalId.EndsWith(")"))
                        {
                            errors.Add($"Invalid additional ID: {additionalId} at {sourceFile}:{lineNumber}");
                        }
                        else if (currentSnippet.Lines.Any())
                        {
                            errors.Add($"Additional ID: {additionalId} at {sourceFile}:{lineNumber} after body of snippet start");
                        }
                        else
                        {
                            currentSnippet.AdditionalMembers.Add(additionalId);
                        }
                    }
                    else
                    {
                        currentSnippet.Lines.Add(line);
                    }
                }
                else
                {
                    if (endSnippet)
                    {
                        errors.Add($"Snippet end without start at {sourceFile}:{lineNumber}");
                    }
                    else if (additional)
                    {
                        errors.Add($"Additional member when not in snippet at {sourceFile}:{lineNumber}");
                    }
                    else if (startSnippet)
                    {
                        string snippetId = line.Substring(startSnippetIdIndex + StartSnippet.Length).Trim();
                        if (snippetId.Contains("(") && !snippetId.EndsWith(")"))
                        {
                            errors.Add($"Invalid snippet ID: {snippetId} at {sourceFile}:{lineNumber}");
                            // We'll also get an "end snippet with no start" error later, but that's
                            // not too bad.
                        }
                        else
                        {
                            currentSnippet = new Snippet { SnippetId = snippetId, SourceFile = sourceFile, SourceStartLine = lineNumber };
                        }
                    }
                }
            }
            if (currentSnippet != null)
            {
                errors.Add($"Snippet {currentSnippet.SnippetId} didn't end");
            }
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
                    bool validDocfxId = DocfxSnippetPattern.IsMatch(snippet.SnippetId);
                    writer.WriteLine($"----- Snippet {snippet.SnippetId} -----");
                    lineIndex++;
                    if (validDocfxId)
                    {
                        writer.WriteLine($"// <{snippet.SnippetId}>");
                        lineIndex++;
                    }
                    snippet.StartLine = lineIndex;
                    snippet.Lines.ForEach(writer.WriteLine);
                    lineIndex += snippet.Lines.Count;
                    snippet.EndLine = lineIndex - 1;
                    if (validDocfxId)
                    {
                        writer.WriteLine($"// </{snippet.SnippetId}>");
                        lineIndex++;
                    }
                    writer.WriteLine();
                    lineIndex++;
                }
            }
        }

        /// <summary>
        /// For each snippet, try to find a single matching member and save it in the MetadataUid property.
        /// Errors are collected rather than an exception being immediately thrown, so that many errors can be
        /// detected and fixed in a single run.
        /// </summary>
        private static void MapMetadataUids(IEnumerable<Snippet> snippets, IEnumerable<Member> members, List<string> errors)
        {
            foreach (var snippet in snippets)
            {
                // TODO: Should AdditionalMembers always match a member?
                foreach (var snippetMemberId in new[] { snippet.SnippetId }.Concat(snippet.AdditionalMembers))
                {
                    var matches = members.Where(member => IsMemberMatch(member.Id, snippetMemberId)).ToList();
                    if (matches.Count > 1)
                    {
                        errors.Add($"Member ID '{snippetMemberId}' at {snippet.SourceLocation} matches multiple members ({string.Join(", ", matches.Select(m => m.Id))}).");
                    }
                    else if (matches.Count == 0 && !DocfxSnippetPattern.IsMatch(snippetMemberId))
                    {
                        errors.Add($"Snippet ID '{snippetMemberId}' at {snippet.SourceLocation} matches matched no members and isn't a valid docfx snippet name.");
                    }
                    else
                    {
                        snippet.MetadataUids.AddRange(matches.Select(m => m.Uid));
                    }
                }
            }
        }

        private static void GenerateSnippetMarkdown(string outputFile, string relativeSnippetFile, IEnumerable<Snippet> snippets)
        {
            using (var writer = File.CreateText(outputFile))
            {
                foreach (var snippet in snippets)
                {
                    foreach (var metadataUid in snippet.MetadataUids)
                    {
                        writer.WriteLine("---");
                        writer.WriteLine($"uid: {metadataUid}");
                        writer.WriteLine("---");
                        writer.WriteLine();
                        writer.WriteLine("Example:");
                        writer.WriteLine($"[!code-cs[]({relativeSnippetFile}#L{snippet.StartLine}-L{snippet.EndLine})]");
                        writer.WriteLine();
                    }
                }
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

                string[] splitSnippetParameters = snippetParameters.Split(',');
                string[] splitMemberParameters = memberParameters.Split(',');
                if (splitMemberParameters.Length != splitSnippetParameters.Length)
                {
                    return false;
                }
                return splitMemberParameters.Zip(splitSnippetParameters, IsParameterMatch).All(x => x);
            }
            else
            {
                return memberId.StartsWith(snippetId + "(");
            }
        }

        // This needs to be a *lot* smarter...
        private static bool IsParameterMatch(string memberParameter, string snippetParameter) =>
            snippetParameter == "*"
                || (snippetParameter == "string" && memberParameter == "System.String")
                || (memberParameter.Split('.').Last() == snippetParameter.Split('.').Last());

        /// <summary>
        /// Loads all the members from YAML metadata files, and group them by parent type.
        /// </summary>
        private static ILookup<string, Member> LoadMembersByType(string metadataDir)
        {
            var dictionary = new Dictionary<string, List<Member>>();
            // Urgh - there must be a nicer way of doing this.
            foreach (var file in Directory.GetFiles(metadataDir, "Google*.yml"))
            {
                using (var input = File.OpenText(file))
                {
                    var model = new Deserializer(namingConvention: new CamelCaseNamingConvention(), ignoreUnmatched: true).Deserialize<CodeModel>(input);
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

        /// <summary>
        /// Find the root directory of the project. We expect this to contain "GoogleApis.sln" and "LICENSE".
        /// </summary>
        /// <returns></returns>
        private static string DetermineRootDirectory()
        {
            var directory = new DirectoryInfo(Environment.CurrentDirectory);
            while (directory != null &&
                (!File.Exists(Path.Combine(directory.FullName, "LICENSE"))
                || !File.Exists(Path.Combine(directory.FullName, "GoogleApis.sln"))))
            {
                directory = directory.Parent;
            }
            return directory?.FullName;
        }

        private static string TrimSuffix(string text, string suffix)
            => text.EndsWith(suffix) ? text.Substring(0, text.Length - suffix.Length) : text;
    }
}
