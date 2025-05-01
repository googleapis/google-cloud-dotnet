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

using LibGit2Sharp;
using System;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Helper to add a remote to the local repo and tell SourceLink to use that remote
/// when building, to avoid problems when we're building from a private repo. This implements
/// IDisposable so that the remote can be removed automatically. If the SOURCELINK_REPO environment
/// variable hasn't been set, or the GitRepositoryRemoteName environment variable *has* already been
/// set, this is a no-op.
/// </summary>
internal sealed class SourceLinkFixer : IDisposable
{
    private readonly Repository _repository;

    // The environment variable populated by Librarian to tell us where SourceLink should point.
    private const string SourceLinkRepoEnvironmentVariable = "SOURCELINK_REPO";

    // The MS Build property we need to set to the remote name.
    private const string MsBuildProperty = "GitRepositoryRemoteName";

    private const string RemoteName = "sourcelink";

    private SourceLinkFixer(Repository repository)
    {
        this._repository = repository;
    }

    internal static SourceLinkFixer Create(string repoRoot)
    {
        string url = Environment.GetEnvironmentVariable(SourceLinkRepoEnvironmentVariable);
        string existingProperty = Environment.GetEnvironmentVariable(MsBuildProperty);
        if (string.IsNullOrEmpty(url) || !string.IsNullOrEmpty(existingProperty))
        {
            return new SourceLinkFixer(null);
        }
        var repository = new Repository(repoRoot);
        repository.Network.Remotes.Add(RemoteName, url);
        Environment.SetEnvironmentVariable(MsBuildProperty, RemoteName);
        return new SourceLinkFixer(repository);
    }

    public void Dispose()
    {
        if (_repository is null)
        {
            return;
        }
        _repository.Network.Remotes.Remove(RemoteName);
        _repository.Dispose();
        Environment.SetEnvironmentVariable(MsBuildProperty, null);
    }
}
