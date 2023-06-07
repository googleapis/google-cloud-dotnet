// Copyright 2020 Google LLC
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

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Simple (simplistic!) approach to a command line interface. Implementations
    /// are expected to have a parameterless constructor.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// The description to display in the usage instructions.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The name of the command (specified as the first command line parameter).
        /// </summary>
        string Command { get; }

        /// <summary>
        /// Description of the expected arguments, e.g. "&lt;id&gt; &lt;new-version&gt;".
        /// </summary>
        string ExpectedArguments { get; }

        /// <summary>
        /// Executes the command. If this throws <see cref="UserErrorException"/>, the exception
        /// will be caught and displayed in a brief form. Other exceptions result in a full stack trace.
        /// </summary>
        /// <param name="args">The command line parameters, excluding the command name.</param>
        /// <returns>The exit code for the process.</returns>
        int Execute(string[] args);
    }
}
