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
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Google.Cloud.Tools.Common
{
    /// <summary>
    /// Code responsible for understanding the conventions of where source, documentation, output etc live.
    /// </summary>
    public class DirectoryLayout
    {
        private static string cachedRoot;

        /// <summary>
        /// Root of all source for this API, including production code, tests, snippets etc.
        /// </summary>
        public string SourceDirectory { get; }
        public string DocsOutputDirectory { get; }
        public string DocfxMetadataDirectory { get; }
        public string SnippetOutputDirectory { get; }
        public string DocsSourceDirectory { get; }
        public string TweaksDirectory { get; }

        private DirectoryLayout(string source, string docsOutput, string metadata, string snippetOutput, string docsSource, string tweaks)
        {
            SourceDirectory = source;
            DocsOutputDirectory = docsOutput;
            DocfxMetadataDirectory = metadata;
            SnippetOutputDirectory = snippetOutput;
            DocsSourceDirectory = docsSource;
            TweaksDirectory = tweaks;
        }

        public static DirectoryLayout ForHelpSnippets()
        {
            string root = DetermineRootDirectory();
            return new DirectoryLayout(
                source: Path.Combine(root, "tools"),
                docsOutput: null,
                metadata: null,
                snippetOutput: Path.Combine(root, "docs", "output", "help", "obj", "snippets"),
                docsSource: null,
                tweaks: null
                );
        }

        public static DirectoryLayout ForApi(string api, string outputRoot) =>
            new DirectoryLayout(
                source: Path.Combine(outputRoot, "apis", api),
                docsOutput: Path.Combine(outputRoot, "docs", "output", api),
                metadata: Path.Combine(outputRoot, "docs", "output", api, "obj", "api"),
                snippetOutput: Path.Combine(outputRoot, "docs", "output", api, "obj", "snippets"),
                docsSource: Path.Combine(outputRoot, "apis", api, "docs"),
                // TODO: Maybe accept the root directory for inputs as another parameter?
                // We don't need to do this at the moment.
                tweaks: Path.Combine(DetermineRootDirectory(), "generator-input", "tweaks", api)
                );

        public static DirectoryLayout ForApi(string api) => ForApi(api, DetermineRootDirectory());

        /// <summary>
        /// Find the root directory of the project. We expect this to contain "apis" and "LICENSE".
        /// </summary>
        /// <returns></returns>
        public static string DetermineRootDirectory()
        {
            if (cachedRoot is string)
            {
                return cachedRoot;
            }
            var currentDirectory = Path.GetFullPath(".");
            var directory = new DirectoryInfo(currentDirectory);
            while (directory != null &&
                (!File.Exists(Path.Combine(directory.FullName, "LICENSE"))
                || !Directory.Exists(Path.Combine(directory.FullName, "apis"))))
            {
                directory = directory.Parent;
            }
            if (directory == null)
            {
                throw new UserErrorException("Unable to determine root directory. Please run within google-cloud-dotnet repository.");
            }
            cachedRoot = directory.FullName;
            return cachedRoot;
        }
    }
}
