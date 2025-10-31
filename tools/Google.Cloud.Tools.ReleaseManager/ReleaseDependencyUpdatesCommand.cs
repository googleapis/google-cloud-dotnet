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

#nullable enable

using Google.Cloud.Tools.Common;
using LibGit2Sharp;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json.Nodes;


// An alias to simplify and clarify other types.
using VersionMap = System.Collections.Immutable.ImmutableDictionary<string, Google.Cloud.Tools.Common.StructuredVersion>;

namespace Google.Cloud.Tools.ReleaseManager;

public class ReleaseDependencyUpdatesCommand : CommandBase
{
    private const string DryRunFlag = "--dry-run";

    public ReleaseDependencyUpdatesCommand() : base("release-dependency-updates", "Bulk releases batches of libraries for dependency updates", minArgs: 1, maxArgs: 2, $"[{DryRunFlag}] batch-size")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        bool dryRun = false;
        int batchSize;
        switch (args.Length)
        {
            case 1:
                batchSize = int.Parse(args[0]);
                break;
            case 2:
                if (args[0] != DryRunFlag)
                {
                    throw new UserErrorException($"Can optionally specify {DryRunFlag} and must specify a batch size");
                }
                dryRun = true;
                batchSize = int.Parse(args[1]);
                break;
            default:
                throw new UserErrorException($"Can optionally specify {DryRunFlag} and must specify a batch size");
        }
        return ReleaseUpdates(dryRun, batchSize);
    }

    private int ReleaseUpdates(bool dryRun, int batchSize)
    {
        using var repo = new Repository(RootLayout.RepositoryRoot);
        // TODO: Check that the repo is clean.

        Commit head = repo.Commits.First();
        var headSnapshot = MetadataSnapshot.FromCommit(head);
        if (headSnapshot is null)
        {
            throw new UserErrorException("Can't load version metadata from head");
        }

        var initialStatuses = DetermineInitialStatuses(repo, headSnapshot);
        var resolvedStatuses = ResolveStatuses(initialStatuses);

        // Diagnostics: show where we are.
        Console.WriteLine("Count by status:");
        var groupedByStatus = resolvedStatuses.GroupBy(pair => pair.ReleaseDecision);
        foreach (var group in groupedByStatus.OrderBy(g => g.Key))
        {
            Console.WriteLine($"{group.Key}: {group.Count()}");
        }
        Console.WriteLine();

        var updateBatch = resolvedStatuses.Where(p => p.ReleaseDecision == ReleaseDecision.NeedsUpdate).Take(batchSize).ToImmutableList();
        if (updateBatch.Count == 0)
        {
            Console.WriteLine("No packages to update.");
            return 0;
        }

        if (dryRun)
        {
            Console.WriteLine("Would update the following APIs:");
            foreach (var status in updateBatch)
            {
                Console.WriteLine($"  status.Api");
            }
            return 0;
        }

        UpdateApis(repo, headSnapshot, updateBatch);

        // Limit to batch size
        // Execute
        return 0;
    }

    private void UpdateApis(Repository repo, MetadataSnapshot headSnapshot, ImmutableList<PackageStatus> updateBatch)
    {
        const string PlaceholderFilename = "dependencies.txt";
        const string PlaceholderContent = "Placeholder file to trigger a release based on dependencies updates.";

        // We assume each PackageStatus.Api is part of headSnapshot.ApiCatalog
        var catalog = headSnapshot.ApiCatalog;
        var externalDefaultVersions = headSnapshot.CentralizedPackageVersions.PackageToVersionMap;

        // Update the dependencies in the batch. This may not actually change anything
        // in apis.json (once defaulting is taken into account) if we're just using defaults.
        foreach (var element in updateBatch)
        {
            var api = element.Api;
            // Assume we only need to update explicitly listed dependencies - the
            // implicit ones use the default anyway.
            foreach (var dependency in element.UpdatedVersions)
            {
                var existingVersion = api.Dependencies.GetValueOrDefault(dependency.Key);
                // If we're already using a project or default value, stick to that.
                if (existingVersion == ApiMetadata.DefaultVersionValue || existingVersion == ApiMetadata.ProjectVersionValue)
                {
                    continue;
                }
                api.Dependencies[dependency.Key] = dependency.Value.ToString();
            }

            File.WriteAllText(GetPlaceholderPath(api), PlaceholderContent);
        }

        // Update anything which is explicitly using the default version from centralized packages.
        foreach (var api in catalog.Apis)
        {
            foreach (var dependency in api.Dependencies.ToList())
            {
                // We only care about external dependencies.
                if (!externalDefaultVersions.TryGetValue(dependency.Key, out StructuredVersion? defaultVersion))
                {
                    continue;
                }
                // If we're already using a project or default value, stick to that.
                // (We don't need to check for project versions here, as they aren't external anyway.)
                if (dependency.Value == ApiMetadata.DefaultVersionValue)
                {
                    continue;
                }
                // If the version we're using explicitly is the same as the default version,
                // then either remove it if it's an implicit dependency, or set it to "default".
                if (defaultVersion.Equals(StructuredVersion.FromString(dependency.Value)))
                {
                    if (api.ImplicitProductionDependencies.Contains(dependency.Key))
                    {
                        api.Dependencies.Remove(dependency.Key);
                    }
                    else
                    {
                        api.Dependencies[dependency.Key] = ApiMetadata.DefaultVersionValue;
                    }
                }
            }
            if (api.Dependencies.Count > 0)
            {
                api.Json["dependencies"] = new JObject(api.Dependencies.Select(pair => new JProperty(pair.Key, pair.Value)));
            }
        }

        catalog.Save(RootLayout);

        GitHelpers.CommitAll(repo, "feat: update dependencies", null);
        foreach (var element in updateBatch)
        {
            File.Delete(GetPlaceholderPath(element.Api));
        }
        GitHelpers.CommitAll(repo, "chore: remove placeholder files", null);

        Console.WriteLine("Created two commits to prompt the releases of the following libraries:");
        foreach (var element in updateBatch)
        {
            Console.WriteLine($"- {element.Api.Id}");
        }
        Console.WriteLine("If this list contains any libraries in package groups, the whole group will be released.");
        Console.WriteLine("Please create a PR containing these two commits.");

        string GetPlaceholderPath(ApiMetadata api) => Path.Combine(RootLayout.CreateRepositoryApiLayout(api).SourceDirectory, PlaceholderFilename);
    }

    private ImmutableDictionary<string, PackageStatus> DetermineInitialStatuses(Repository repo, MetadataSnapshot headSnapshot)
    {
        var catalog = headSnapshot.ApiCatalog;

        var updatedDependenciesByApi = catalog.Apis.ToImmutableDictionary(api => api, api => headSnapshot.DeriveUpdatedDependencies(api.Id));
        var lastDependenciesByApi = catalog.Apis.ToImmutableDictionary(api => api, api => MetadataSnapshot.ForApi(api, repo)?.DeriveExistingDependencies(api.Id));
        return catalog.Apis
            .ToImmutableDictionary(api => api.Id, api => new PackageStatus(api, lastDependenciesByApi[api], updatedDependenciesByApi[api], InitialDecision(api)));

        ReleaseDecision InitialDecision(ApiMetadata api) =>
            api.StructuredVersion.IsNonRelease ? ReleaseDecision.NonReleaseVersion
            : api.BlockRelease is not null || headSnapshot.PipelineState.GetLibrary(api).ReleaseAutomationLevel == PipelineState.AutomationLevelBlocked ? ReleaseDecision.ReleaseBlocked
            : ReleaseDecision.Unknown;
    }

    private ImmutableList<PackageStatus> ResolveStatuses(ImmutableDictionary<string, PackageStatus> packageStatuses)
    {
        // Resolve all the statuses
        var unknownCount = packageStatuses.Count(pair => pair.Value.ReleaseDecision == ReleaseDecision.Unknown);
        while (unknownCount > 0)
        {
            packageStatuses = packageStatuses.ToImmutableDictionary(pair => pair.Key, pair => pair.Value.WithUpdatedReleaseDecision(packageStatuses));
            var newUnknownCount = packageStatuses.Count(pair => pair.Value.ReleaseDecision == ReleaseDecision.Unknown);
            if (newUnknownCount >= unknownCount)
            {
                // Realistically we'll need more info than this, but we can't tell what in advance.
                throw new InvalidOperationException($"Unable to make progress. Unknown count was {unknownCount}; now {newUnknownCount}");
            }
            unknownCount = newUnknownCount;
        }
        return packageStatuses
            .OrderBy(pair => pair.Key, StringComparer.Ordinal)
            .Select(pair => pair.Value)
            .ToImmutableList();
    }

    private enum ReleaseDecision
    {
        /// <summary>
        /// We still need to figure out the status of the package.
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// The package is up-to-date, and doesn't need a new release.
        /// </summary>
        UpToDate = 1,
        /// <summary>
        /// The package should be released with the latest dependencies.
        /// </summary>
        NeedsUpdate = 2,
        /// <summary>
        /// The package is currently blocked from being released, but
        /// the current listed version is valid.
        /// </summary>
        ReleaseBlocked = 3,
        /// <summary>
        /// The current listed version of the package is not a releasable
        /// version (typically 1.0.0-beta00).
        /// </summary>
        NonReleaseVersion = 4,
        /// <summary>
        /// The package depends on at least one other package which is pending an update. 
        /// </summary>
        DependencyNeedsUpdate = 5,
    }

    private sealed record PackageStatus(ApiMetadata Api, VersionMap? LastReleaseVersions, VersionMap UpdatedVersions, ReleaseDecision ReleaseDecision)
    {
        internal PackageStatus WithUpdatedReleaseDecision(ImmutableDictionary<string, PackageStatus> packageStatuses)
        {
            // If we've already reached a decision, we're done.
            if (ReleaseDecision != ReleaseDecision.Unknown)
            {
                return this;
            }
            // If any direct internal dependencies are still unknown, we need to wait for them to be resolved.
            // If any has NeedsUpdate and DependencyNeedsUpdate, we know our result is DependencyNeedsUpdate.
            foreach (var dependency in Api.Dependencies)
            {
                if (packageStatuses.TryGetValue(dependency.Key, out var dependencyStatus))
                {
                    var dependencyDecision = dependencyStatus.ReleaseDecision;
                    if (dependencyDecision == ReleaseDecision.Unknown)
                    {
                        return this;
                    }
                    if (dependencyDecision == ReleaseDecision.NeedsUpdate || dependencyDecision == ReleaseDecision.DependencyNeedsUpdate)
                    {
                        return this with { ReleaseDecision = ReleaseDecision.DependencyNeedsUpdate };
                    }
                }
            }
            // If we don't have any information about the last release, we'll assume the package needs to be updated.
            if (LastReleaseVersions is null)
            {
                return this with { ReleaseDecision = ReleaseDecision.NeedsUpdate };
            }
            // We can definitely make a decision now - either this package is already up-to-date, or it's ready to be updated now.
            foreach (var updatedDependency in UpdatedVersions)
            {
                // If the previous release didn't have this dependency at all, we definitely need an update.
                if (!LastReleaseVersions.TryGetValue(updatedDependency.Key, out var lastReleaseDependencyVersion))
                {
                    return this with { ReleaseDecision = ReleaseDecision.NeedsUpdate };
                }

                // We need an update if the versions are different.
                if (!updatedDependency.Value.Equals(lastReleaseDependencyVersion))
                {
                    // Unlikely to ever come up, but we might as well check here that we're not doing anything silly.
                    if (lastReleaseDependencyVersion.CompareTo(updatedDependency.Value) > 0)
                    {
                        throw new InvalidOperationException($"Attempt to downgrade version of {updatedDependency.Key} in {Api.Id} from {lastReleaseDependencyVersion} to {updatedDependency.Value}");
                    }
                    return this with { ReleaseDecision = ReleaseDecision.NeedsUpdate };
                }
            }
            return this with { ReleaseDecision = ReleaseDecision.UpToDate };
        }
    }

    private sealed record MetadataSnapshot(ApiCatalog ApiCatalog, PipelineState PipelineState, CentralizedPackageVersions CentralizedPackageVersions)
    {
        private static string? LoadText(Commit commit, string path)
        {
            var entry = commit[path];
            if (entry is null)
            {
                return null;
            }
            if (entry.TargetType != TreeEntryTargetType.Blob)
            {
                throw new InvalidOperationException($"Type of entry for {commit.Sha} at '{path}' is {entry.TargetType}");
            }
            Blob blob = (Blob) entry.Target;
            return blob.GetContentText();
        }

        internal static MetadataSnapshot? ForApi(ApiMetadata api, Repository repo)
        {
            if (api.StructuredVersion.IsNonRelease)
            {
                return null;
            }
            var tagPrefix = api.PackageGroup?.Id ?? api.Id;
            var lastReleaseTagName = $"{tagPrefix}-{api.Version}";

            Tag tag = repo.Tags[lastReleaseTagName];
            if (tag is null)
            {
                throw new UserErrorException($"Tag '{lastReleaseTagName}' not found in local repo. Fetch all upstream tags and try again.");
            }
            Commit commit = (Commit) tag.Target;
            return FromCommit(commit);
        }

        /// <summary>
        /// Returns the snapshot where all the expected files can be found at the given commit (not necessarily
        /// *changed* in that commit), or null if anything is missing.
        /// </summary>
        internal static MetadataSnapshot? FromCommit(Commit commit)
        {
            var catalogText = LoadText(commit, ApiCatalog.PathInRepository);
            var stateText = LoadText(commit, PipelineState.PathInRepository);
            var centralizedPackageVersionsText = LoadText(commit, CentralizedPackageVersions.PathInRepository);

            if (catalogText is null || stateText is null || centralizedPackageVersionsText is null)
            {
                return null;
            }
            return new(ApiCatalog.FromJson(catalogText), PipelineState.FromJson(stateText), CentralizedPackageVersions.FromXml(centralizedPackageVersionsText));
        }

        /// <summary>
        /// Works out what dependency versions are currently expressed in the snapshot, retaining
        /// all explicit versions. A version of "project" is mapped to the latest release
        /// for that internal dependency; a version of "default" is mapped to the version declared in
        /// the centralized package versions.
        /// </summary>
        internal VersionMap DeriveExistingDependencies(string id)
        {
            var api = ApiCatalog[id];
            return api
                .DeriveDependencies()
                .ToImmutableDictionary(pair => pair.Key, pair => DeriveVersion(pair.Key, pair.Value), StringComparer.Ordinal);

            StructuredVersion DeriveVersion(string target, string version) => version switch
            {
                ApiMetadata.ProjectVersionValue => ApiCatalog[target].StructuredVersion,
                ApiMetadata.DefaultVersionValue => CentralizedPackageVersions.PackageToVersionMap[target],
                _ => StructuredVersion.FromString(version)
            };
        }
            
        /// <summary>
        /// Work out what dependency versions we should use to update everything. Explicit
        /// versions are ignored unless they are more recent than the defaults. Versions
        /// for internal dependencies (e.g. to Google.LongRunning) are updated to the currently-released
        /// version of that dependency.
        /// </summary>
        internal VersionMap DeriveUpdatedDependencies(string id)
        {
            var api = ApiCatalog[id];
            return api
                .DeriveDependencies()
                .ToImmutableDictionary(pair => pair.Key, pair => DeriveVersion(pair.Key, pair.Value), StringComparer.Ordinal);

            StructuredVersion DeriveVersion(string target, string version) => version switch
            {
                ApiMetadata.ProjectVersionValue => ApiCatalog[target].StructuredVersion,
                ApiMetadata.DefaultVersionValue => CentralizedPackageVersions.PackageToVersionMap[target],
                _ => ReturnLaterVersion(target, version)
            };

            StructuredVersion ReturnLaterVersion(string target, string explicitVersion)
            {
                var structuredExplicitVersion = StructuredVersion.FromString(explicitVersion);
                var projectOrDefaultVersion = ApiCatalog.TryGetApi(target, out var targetApi) ? api.StructuredVersion
                    : CentralizedPackageVersions.PackageToVersionMap.TryGetValue(target, out var externalDependencyVersion) ? externalDependencyVersion
                    : null;

                // If we haven't found anything in the API catalog or the centralized package versions,
                // it must be a dependency which is only used for one or two libraries, and only ever declared explicitly.
                // Just return the explicit version.
                if (projectOrDefaultVersion is null)
                {
                    return structuredExplicitVersion;
                }
                // If we have an internal dependency which is a non-release (e.g. a forward-looking first release of a new major version)
                // then stick to the explicit version we've got.
                if (projectOrDefaultVersion.IsNonRelease)
                {
                    return structuredExplicitVersion;
                }
                return projectOrDefaultVersion.CompareTo(structuredExplicitVersion) > 0 ? projectOrDefaultVersion : structuredExplicitVersion;
            }
        }
    }
}
