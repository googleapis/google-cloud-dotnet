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
public class GeneratorOutputFolder
{
    public string Directory { get; }

    public GeneratorOutputFolder(string directory) => IO::Directory.CreateDirectory(Directory = directory);

    public void CopyDirectory(string sourceDirectory, bool recursive)
    {
        CopyDirectoryImpl(sourceDirectory, Directory, recursive);

        static void CopyDirectoryImpl(string source, string target, bool recursive)
        {
            var sourceDir = new DirectoryInfo(source);
            DirectoryInfo[] dirs = sourceDir.GetDirectories();

            IO::Directory.CreateDirectory(target);

            foreach (FileInfo file in sourceDir.GetFiles())
            {
                string targetFilePath = Path.Combine(target, file.Name);
                file.CopyTo(targetFilePath);
            }

            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newTarget = Path.Combine(target, subDir.Name);
                    CopyDirectoryImpl(subDir.FullName, newTarget, true);
                }
            }
        }
    }
}
