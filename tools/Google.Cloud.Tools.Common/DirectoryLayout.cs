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
        /// Special name to be used when we want to generate snippets for non-API-specific documentation.
        /// This is only a partially-valid layout, as there aren't any production projects etc.
        /// This name matches the directory under docs, for convenience.
        /// </summary>
        private const string RootDocsApi = "root";

        private string _api;

        public bool IsRootDocsApi => _api == RootDocsApi;
        public string RootDirectory { get; }

        // Bit of a hack to find the snippets for root docs... we may want to add a GetSnippetDirectories() method or something here.
        public string ApiSourceDirectory => IsRootDocsApi ? Path.Combine(RootDirectory, "tools") : Path.Combine(RootDirectory, "apis", _api);
        public string DocsOutputDirectory => Path.Combine(RootDirectory, "docs", "output", _api);
        public string ApiMetadataDirectory => IsRootDocsApi ? null : Path.Combine(DocsOutputDirectory, "obj", "api");
        public string SnippetOutputDirectory => Path.Combine(DocsOutputDirectory, "obj", "snippets");
        public string ApiDocsSourceDirectory => IsRootDocsApi ? Path.Combine(RootDirectory, "docs", "root") : Path.Combine(ApiSourceDirectory, "docs");

        private DirectoryLayout(string root, string api)
        {
            RootDirectory = root;
            _api = api;
        }

        public static DirectoryLayout FromApi(string api)
        {
            var root = DetermineRootDirectory();
            return new DirectoryLayout(root, api);
        }

        // TODO: Make this a regular class, and move all the logic that's currently in GenerateSnippetMarkdown etc here instead.

        /// <summary>
        /// Find the root directory of the project. We expect this to contain "GoogleApis.sln" and "LICENSE".
        /// </summary>
        /// <returns></returns>
        private static string DetermineRootDirectory()
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
