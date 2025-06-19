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

using Google.Cloud.Tools.Common;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using IO = System.IO;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

/// <summary>
/// A git repository used for testing. This is mostly a wrapper around libgit2sharp
/// with convenience methods.
/// </summary>
public class TestRepo : IDisposable
{
    private readonly Repository _repo;
    public string Directory { get; }

    public TestRepo(string directory)
    {
        Repository.Init(directory);
        _repo = new Repository(directory);
        Directory = directory;
    }

    public TestRepo AddFile(string relativePath, string text = "test")
    {
        var path = Path.Combine(Directory, relativePath);
        IO::Directory.CreateDirectory(Path.GetDirectoryName(path));
        File.WriteAllText(path, text);
        return this;
    }

    public TestRepo AddScriptMocks()
    {
        CopyDirectory("ContainerCommands\\MockScripts", "", true);
        return this;
    }

    public TestRepo AddProjectAndSource(ApiMetadata api, string suffix) =>
        AddFile($"apis/{api.Id}/{api.Id}{suffix}/{api.Id}{suffix}.csproj")
        .AddFile($"apis/{api.Id}/{api.Id}{suffix}/SourceCode.g.cs");

    public TestRepo AddGeneratedFiles(IEnumerable<ApiMetadata> apis)
    {
        foreach (var api in apis)
        {
            AddGeneratedFiles(api);
        }
        return this;
    }

    public TestRepo AddGeneratedFiles(ApiMetadata api) =>
        AddProjectAndSource(api, "")
        .AddProjectAndSource(api, ".GeneratedSnippets")
        .AddProjectAndSource(api, ".Snippets")
        .AddFile($"apis/{api.Id}/{api.Id}.sln")
        .AddFile($"apis/{api.Id}/gapic_metadata.json")
        .AddFile($"apis/{api.Id}/.repo-metadata.json");

    public TestRepo CopyDirectory(string sourceDirectory, string relativeTarget, bool recursive)
    {
        CopyDirectoryImpl(sourceDirectory, Path.Combine(Directory, relativeTarget), recursive);

        return this;

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

    public Commit CommitAll(string message = "commit")
    {
        RepositoryStatus status = _repo.RetrieveStatus();
        AddAll(status.Modified);
        AddAll(status.Missing);
        AddAll(status.Untracked);
        _repo.Index.Write();
        var signature = _repo.Config.BuildSignature(DateTimeOffset.UtcNow);
        return _repo.Commit(message, signature, signature);

        void AddAll(IEnumerable<StatusEntry> entries)
        {
            foreach (var entry in entries)
            {
                _repo.Index.Add(entry.FilePath);
            }
        }
    }

    public void AssertDoNotExist(params string[] relativePaths)
    {
        foreach (var relativePath in relativePaths)
        {
            Assert.False(Exists(Path.Combine(Directory, relativePath)), $"Expected {relativePath} not to exist");
        }
    }

    public void AssertExist(params string[] relativePaths)
    {
        foreach (var relativePath in relativePaths)
        {
            Assert.True(Exists(Path.Combine(Directory, relativePath)), $"Expected {relativePath} to exist");
        }
    }

    private static bool Exists(string path) => File.Exists(path) || IO::Directory.Exists(path);

    public void Dispose()
    {
        _repo.Dispose();
    }
}
