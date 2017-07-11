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

namespace Google.Cloud.Tools.Common
{
    /// <summary>
    /// Code responsible for understanding the conventions of where source, documentation, output etc live.
    /// </summary>
    public class DirectoryLayout
    {
        /// <summary>
        /// Root of all source for this API, including production code, tests, snippets etc.
        /// </summary>
        public string SourceDirectory { get; }
        public string DocsOutputDirectory { get; }
        public string DocfxMetadataDirectory { get; }
        public string SnippetOutputDirectory { get; }
        public string DocsSourceDirectory { get; } 

        private DirectoryLayout(string source, string docsOutput, string metadata, string snippetOutput, string docsSource)
        {
            SourceDirectory = source;
            DocsOutputDirectory = docsOutput;
            DocfxMetadataDirectory = metadata;
            SnippetOutputDirectory = snippetOutput;
            DocsSourceDirectory = docsSource;
        }

        public static DirectoryLayout ForRootDocs()
        {
            string root = DetermineRootDirectory();
            return new DirectoryLayout(
                source: Path.Combine(root, "tools"),
                docsOutput: Path.Combine(root, "docs", "output", "root"),
                metadata: null,
                snippetOutput: Path.Combine(root, "docs", "output", "root", "obj", "snippets"),
                docsSource: Path.Combine(root, "docs", "root")
                );
        }

        public static DirectoryLayout ForApi(string api)
        {
            var root = DetermineRootDirectory();
            return new DirectoryLayout(
                source: Path.Combine(root, "apis", api),
                docsOutput: Path.Combine(root, "docs", "output", api),
                metadata: Path.Combine(root, "docs", "output", api, "obj", "api"),
                snippetOutput: Path.Combine(root, "docs", "output", api, "obj", "snippets"),
                docsSource: Path.Combine(root, "apis", api, "docs")
                );
        }

        /// <summary>
        /// Find the root directory of the project. We expect this to contain "apis" and "LICENSE".
        /// </summary>
        /// <returns></returns>
        public static string DetermineRootDirectory()
        {
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
            return directory.FullName;
        }
    }
}
