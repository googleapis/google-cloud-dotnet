// Copyright 2020 Google Inc. All Rights Reserved.
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
using System.Linq;

namespace Google.Cloud.Tools.TagReleases
{
    /// <summary>
    /// The configuration specified on the commandline.
    /// </summary>
    public sealed class Config
    {
        /// <summary>
        /// Access token to github
        /// </summary>
        public string GitHubToken { get; }

        /// <summary>
        /// Committish (e.g. master, a commit hash or a branch) to tag.
        /// </summary>
        public string Committish { get; }

        /// <summary>
        /// Whether to skip the check for "all project references must be released along with the package that references them".
        /// </summary>
        public bool SkipProjectReferenceCheck { get; }

        private Config(string gitHubToken, string committish, bool skipProjectReferenceCheck) =>
            (GitHubToken, Committish, SkipProjectReferenceCheck) =
            (gitHubToken, committish, skipProjectReferenceCheck);

        /// <summary>
        /// Creates a configuration from the command line arguments. The returned configuration may not be valid;
        /// use <see cref="IsValid"/> to check.
        /// </summary>
        public static Config FromCommandLine(string[] args)
        {
            string token = null;
            string committish = "master";
            bool skipProjectReferenceCheck = false;
            // First command line option is always the token.
            if (args.Length > 0)
            {
                token = args[0];
            }
            // After that, we have "named" arguments
            foreach (var arg in args.Skip(1))
            {
                if (arg.StartsWith("--commit="))
                {
                    committish = arg.Substring("--commit=".Length);
                }
                else if (arg == "--force")
                {
                    skipProjectReferenceCheck = true;
                }
                else
                {
                    throw new UserErrorException($"Unhandled command line argument: '{arg}'");
                }
            }
            return new Config(token, committish, skipProjectReferenceCheck);
        }

        public bool IsValid => !string.IsNullOrEmpty(GitHubToken) && !string.IsNullOrEmpty(Committish);

        public void DisplayUsage()
        {
            Console.WriteLine($"Command line arguments: <token> [--commit=...] [--force]");
            Console.WriteLine("token: The GitHub access token. Required.");
            Console.WriteLine($"--commit: The remote 'committish' to tag; defaults to 'master', but can be a hash, branch or another tag.");
            Console.WriteLine($"--force: Disables the check for project reference integrity. Use with care; consult the team if uncertain.");
        }
    }
}
