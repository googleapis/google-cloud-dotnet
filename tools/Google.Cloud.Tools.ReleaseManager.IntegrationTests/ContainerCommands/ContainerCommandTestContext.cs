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
using System;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

/// <summary>
/// The context in which a container command test is run. This may include multiple
/// git repositories and other directories.
/// </summary>
public class ContainerCommandTestContext : IDisposable
{
    /// <summary>
    /// The root directory for the context.
    /// </summary>
    public string RootDirectory { get; }

    public TestRepo CodeRepo { get; private set; }
    public TestRepo ApiRepo { get; private set; }

    public ContainerCommandTestContext(string rootDirectory)
    {
        RootDirectory = rootDirectory;
        Directory.CreateDirectory(rootDirectory);
    }

    /// <summary>
    /// Creates a git repo with metadata in generator-input to match <paramref name="apiCatalog"/>.
    /// (No directories are created under apis, however.)
    /// The repo is clean (committed) after this returns.
    /// The same repo returned by this method is also available as <see cref="CodeRepo"/>.
    /// </summary>
    public TestRepo CreateCodeRepo(ApiCatalog apiCatalog)
    {
        if (CodeRepo is not null)
        {
            throw new InvalidOperationException("Already got a code repo");
        }
        CodeRepo = new TestRepo(Path.Combine(RootDirectory, "code-repo"));        
        var rootLayout = RootLayout.ForRepositoryRoot(CodeRepo.Directory);
        Directory.CreateDirectory(rootLayout.GeneratorInput);
        Directory.CreateDirectory(Path.Combine(CodeRepo.Directory, ".github"));
        apiCatalog.RecreateJson();
        apiCatalog.Save(rootLayout);
        var pipelineState = new PipelineState();
        pipelineState.Libraries.AddRange(apiCatalog.Apis.Where(api => api.PackageGroup is null).Select(CreateLibraryState));
        pipelineState.Libraries.AddRange(apiCatalog.PackageGroups.Select(CreatePackageGroupLibraryState));
        pipelineState.Save(rootLayout);
        CodeRepo.CommitAll();
        return CodeRepo;

        LibraryState CreateLibraryState(ApiMetadata api) => new LibraryState
        {
            Id = api.Id,
            ApiPaths = api.ProtoPath is null ? [] : [api.ProtoPath],
            CurrentVersion = api.Version
        };

        LibraryState CreatePackageGroupLibraryState(PackageGroup group) => new LibraryState
        {
            Id = group.Id,
            ApiPaths = [.. group.PackageIds.Select(p => apiCatalog[p].ProtoPath).Where(p => p is not null)],
            CurrentVersion = apiCatalog[group.PackageIds[0]].Version
        };
    }

    /// <summary>
    /// Creates an in-memory API catalog with the given API IDs, each of which is assumed to be a GAPIC
    /// API.
    /// </summary>
    public ApiCatalog CreateApiCatalog(params string[] ids)
    {
        var apis = ids.Select(id => new ApiMetadata
        {
            Id = id,
            Generator = GeneratorType.Micro,
            Type = ApiType.Grpc,
            ProtoPath = id.Replace(".", "/").ToLowerInvariant()
        });
        var catalog = new ApiCatalog
        {
            Apis = [.. apis],
            PackageGroups = []
        };
        catalog.RecreateJson();
        return catalog;
    }

    public void Dispose()
    {
        CodeRepo?.Dispose();
        ApiRepo?.Dispose();
    }
}
