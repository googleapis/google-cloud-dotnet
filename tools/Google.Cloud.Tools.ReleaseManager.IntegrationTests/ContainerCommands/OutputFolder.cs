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

using System.IO;
using IO = System.IO;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

/// <summary>
/// An output folder from an earlier command.
/// </summary>
public class OutputFolder
{
    public string Directory { get; }

    public OutputFolder(string directory) => IO::Directory.CreateDirectory(Directory = directory);

    public OutputFolder CopyDirectory(string sourceDirectory, string relativeTarget, bool recursive = true)
    {
        TestFiles.CopyDirectory(sourceDirectory, Path.Combine(Directory, relativeTarget), recursive);
        return this;
    }

    public OutputFolder AddEmptyFile(string path) => AddTextFile(path, "");

    public OutputFolder AddTextFile(string path, string text)
    {
        File.WriteAllText(Path.Combine(Directory, path), text);
        return this;
    }
}
