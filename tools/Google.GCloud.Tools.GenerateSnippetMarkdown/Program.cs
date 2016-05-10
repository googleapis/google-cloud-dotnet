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

namespace Google.GCloud.Tools.GenerateSnippetMarkdown
{
    /// <summary>
    /// Simple program to generate a snippets.md file for docfx to consume when generating documentation.
    /// The file basically links the snippets projects with the client libraries.
    /// </summary>
    public sealed class Program
    {
        private static readonly Regex StartSnippetTag = new Regex(@"^\s*// \<(?<name>[^>]+)>\s*$", RegexOptions.Compiled);

        private static int Main(string[] args)
        {
            string root = DetermineRootDirectory();
            if (root == null)
            {
                Console.WriteLine("Unable to determine root directory. Please run within gcloud-dotnet repository.");
                return 1;
            }

            string snippets = Path.Combine(root, "snippets");
            if (!Directory.Exists(snippets))
            {
                Console.WriteLine($"Snippets directory {snippets} doesn't exist. Aborting.");
                return 1;
            }

            string metadata = Path.Combine(root, "docs", "obj", "api");
            if (!Directory.Exists(metadata))
            {
                Console.WriteLine($"Metadata directory {metadata} doesn't exist. Aborting.");
                return 1;
            }

            string output = Path.Combine(root, "docs", "extra");
            if (!Directory.Exists(output))
            {
                Console.WriteLine($"Output directory {output} doesn't exist. Aborting.");
                return 1;
            }
            GenerateSnippetUids(snippets, metadata, Path.Combine(output, "snippets.md"));
            return 0;
        }

        /// <summary>
        /// Generates a markdown file containing snippets 
        /// </summary>
        private static void GenerateSnippetUids(string snippetsDir, string metadataDir, string outputFile)
        {
            // TODO: Use a YAML parser
            // TODO: Create a lookup by project name and client name.
            var uids = new HashSet<string>(
                from yaml in Directory.GetFiles(metadataDir, "Google*.yml")
                from line in File.ReadLines(yaml)
                let trimmed = line.Trim()
                where line.StartsWith("- uid: ")
                select line.Substring("- uid: ".Length)).ToList();

            using (var outputMarkdown = File.CreateText(outputFile))
            {
                // Search every line, in every source file, in every project.
                // If we find a snippet, e.g. // <snippetName>, then find all the UIDs from YAML
                // files that are for that method name, scoped by the project/source names.
                var query = from project in Directory.GetDirectories(snippetsDir)
                            // Path.GetFileName just takes the last part of the name; it doesn't know that it's a directory.
                            let projectName = TrimSuffix(Path.GetFileName(project), ".Snippets")
                            from sourceFile in Directory.GetFiles(project, "*.cs")
                            let sourceRelativeToOutput = $"../../snippets/{Path.GetFileName(project)}/{Path.GetFileName(sourceFile)}"
                            let clientName = TrimSuffix(Path.GetFileName(sourceFile), "Snippets.cs")
                            from line in File.ReadLines(sourceFile)
                            let match = StartSnippetTag.Match(line)
                            where match.Success
                            let snippetName = match.Groups["name"].Value
                            from uid in uids
                            where uid.StartsWith(projectName)
                            where UidMatches(uid, projectName, clientName, snippetName)
                            select new { uid, sourceRelativeToOutput, snippetName };

                foreach (var result in query)
                {
                    outputMarkdown.WriteLine("---");
                    outputMarkdown.WriteLine($"uid: {result.uid}");
                    outputMarkdown.WriteLine("---");
                    outputMarkdown.WriteLine();
                    outputMarkdown.WriteLine("Example:");
                    outputMarkdown.WriteLine($"[!code-cs[]({result.sourceRelativeToOutput}#{result.snippetName})]");
                    outputMarkdown.WriteLine();
                }
            }
        }

        static bool UidMatches(string uid, string projectName, string clientName, string snippetName)
        {
            // We want to use prefix matching for overload resolution, as well as avoiding false-positives
            // due to short names. So two situations:
            // <Foo> - match project.client.Foo(
            // <Foo_Bar> - match project.client.Foo(Bar
            string methodStart = snippetName.Contains("_") ? snippetName.Replace("_", "(") : snippetName + "(";
            return uid.StartsWith($"{projectName}.{clientName}.{methodStart}");
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
