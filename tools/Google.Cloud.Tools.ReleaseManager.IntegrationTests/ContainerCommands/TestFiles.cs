// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Cloud.ClientTesting;
using System.IO;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

/// <summary>
/// Utilities for working with test files for container command tests.
/// </summary>
public static class TestFiles
{
    /// <summary>
    /// The repository root directory (for copying real scripts etc).
    /// </summary>
    public static string RepoRoot { get; }
    /// <summary>
    /// Path to the ContainerCommands directory (the directory containing the source file for this class)
    /// </summary>
    public static string ContainerCommandsDirectory { get; }

    /// <summary>
    /// Path to the CommonFiles directory (which contains test data shared across multiple tests).
    /// </summary>
    public static string CommonFilesDirectory => Path.Combine(ContainerCommandsDirectory, "CommonFiles");

    /// <summary>
    /// Path to the directory containing mock scripts.
    /// </summary>
    public static string MockScriptsDirectory => Path.Combine(CommonFilesDirectory, "MockScripts");

    static TestFiles()
    {
        RepoRoot = TestEnvironment.FindRepositoryRootDirectory();
        ContainerCommandsDirectory = Path.Combine(RepoRoot, "tools", typeof(DockerCommandTest).Assembly.GetName().Name, "ContainerCommands");
    }

    public static void CopyDirectory(string source, string target, bool recursive = true)
    {
        var sourceDir = new DirectoryInfo(source);
        DirectoryInfo[] dirs = sourceDir.GetDirectories();

        Directory.CreateDirectory(target);

        foreach (FileInfo file in sourceDir.GetFiles())
        {
            string targetFilePath = Path.Combine(target, file.Name);
            file.CopyTo(targetFilePath);
        }

        if (recursive)
        {
            foreach (DirectoryInfo subDir in sourceDir.GetDirectories())
            {
                string newTarget = Path.Combine(target, subDir.Name);
                CopyDirectory(subDir.FullName, newTarget, true);
            }
        }
    }
}
