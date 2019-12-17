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
using Google.Cloud.Tools.VersionCompat;
using System;

namespace Google.Cloud.Tools.CompareVersions
{
    internal class CommandLineOptions
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

        [Option("format-detail", Required = false, Default = FormatDetail.Brief,
            HelpText = "Format detail: `Full` - emit full, precise diffs; " +
            "`Brief` - emit brief diffs (e.g. omit namespaces). ")]
        public FormatDetail FormatDetail { get; private set; }

        [Option("package", Required = false,
            HelpText = "Package name, e.g. Google.Cloud.Speech.V1. Required unless file and file2 are both specified")]
        public string Package { get; private set; }

        [Option("framework", Required = false, Default = "netstandard2.0",
            HelpText = "Target framework, e.g. netstandard2.0")]
        public string Framework { get; private set; }

        [Option("file1", Required = false,
            HelpText = "The first file to compare; ignores package, framework, version1")]
        public string File1 { get; private set; }

        [Option("version1", Required = false,
            HelpText = "The first version to compare; either a version number, 'latest' for the latest NuGet version, or 'local' for the local release build")]
        public string Version1 { get; private set; }

        [Option("file2", Required = false,
            HelpText = "The second file to compare; ignores package, framework, version2")]
        public string File2 { get; private set; }

        [Option("version2", Required = false,
            HelpText = "The second version to compare; either a version number, 'latest' for the latest NuGet version, or 'local' for the local release build")]
        public string Version2 { get; private set; }
        
        /// <summary>
        /// Validation beyond what CommandLineParser can do automatically.
        /// </summary>
        internal bool Validate()
        {
            if (Package is null && !(File1 is object && File2 is object))
            {
                Console.Error.WriteLine("--package must be specified unless both --file1 and --file2 are specified");
                return false;
            }
            if (File1 is object && Version1 is object)
            {
                Console.Error.WriteLine("--file1 and --version1 cannot be used together");
                return false;
            }
            if (File2 is object && Version2 is object)
            {
                Console.Error.WriteLine("--file2 and --version2 cannot be used together");
                return false;
            }
            // We *could* show an error if package or framework has been specified, but file1 and file2 are both specified,
            // but let's not worry about that.
            return true;
        }
    }
}
