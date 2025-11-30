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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using static Google.Cloud.Tools.ReleaseManager.ReleaseDependencyUpdatesCommand;

// An alias to simplify and clarify other types.
using VersionMap = System.Collections.Immutable.ImmutableDictionary<string, Google.Cloud.Tools.Common.StructuredVersion>;

namespace Google.Cloud.Tools.ReleaseManager.Tests;

public class ReleaseDependencyUpdatesCommandTest
{
    private static readonly TestResource s_testResource = TestResource.Load();

    public static TheoryData<ResolveStatusesTest> ResolveStatusesTests { get; } = new(s_testResource.ResolveStatusesTests);
    public static TheoryData<CreateUpdateBatchTest> CreateUpdateBatchTests { get; } = new(s_testResource.CreateUpdateBatchTests);

    [Theory]
    [MemberData(nameof(ResolveStatusesTests))]
    public void ResolveStatuses(ResolveStatusesTest test)
    {
        var metadataSnapshot = test.CreateMetadataSnapshot();
        var lastReleaseDependenciesByPackage = test.GetLastReleaseDependenciesByPackage();
        var statuses = ReleaseDependencyUpdatesCommand.ResolveStatuses(metadataSnapshot, lastReleaseDependenciesByPackage);
        var actualReleaseDecisions = statuses.ToDictionary(status => status.Api.Id, status => status.ReleaseDecision.ToString());
        Assert.Equal(test.ExpectedReleaseDecisions, actualReleaseDecisions);
    }

    [Theory]
    [MemberData(nameof(CreateUpdateBatchTests))]
    public void CreateUpdateBatch(CreateUpdateBatchTest test)
    {
        var catalog = test.CreateApiCatalog();
        // We assume that CreateUpdateBatch doesn't really care about dependency versions.
        var resolvedStatuses = test.ReleaseDecisions
            .Select(pair => new PackageStatus(catalog[pair.Key], LastReleaseDependencies: null, NextReleaseDependencies: VersionMap.Empty, Enum.Parse<ReleaseDecision>(pair.Value)))
            .ToImmutableList();
        var actualUpdateBatch = ReleaseDependencyUpdatesCommand.CreateUpdateBatch(resolvedStatuses, catalog, test.BatchSize)
            .Select(pkg => pkg.Api.Id)
            .ToList();
        Assert.Equal(test.ExpectedUpdateBatch, actualUpdateBatch);
    }

    public class ResolveStatusesTest : IXunitSerializable
    {
        public string Id { get; set; }
        public JObject ApiCatalog { get; set; }
        public List<string> BlockedPackages { get; set; }
        public Dictionary<string, string> ExternalPackageVersions { get; set; }
        public Dictionary<string, Dictionary<string, string>> LastReleaseDependenciesByPackage { get; set; }
        public Dictionary<string, string> ExpectedReleaseDecisions { get; set; }

        internal MetadataSnapshot CreateMetadataSnapshot()
        {
            var catalog = Common.ApiCatalog.FromJson(ApiCatalog.ToString());
            var externalPackageVersions = ExternalPackageVersions.ToImmutableDictionary(pair => pair.Key, pair => StructuredVersion.FromString(pair.Value), StringComparer.Ordinal);
            return new(catalog, [.. BlockedPackages], externalPackageVersions);
        }

        internal ImmutableDictionary<string, VersionMap> GetLastReleaseDependenciesByPackage() =>
            LastReleaseDependenciesByPackage.ToImmutableDictionary(
                pair => pair.Key,
                pair => pair.Value.ToImmutableDictionary(dep => dep.Key, dep => StructuredVersion.FromString(dep.Value), StringComparer.Ordinal),
                StringComparer.Ordinal);

        // We "deserialize" by just finding the right test and populating all the properties...
        public void Deserialize(IXunitSerializationInfo info)
        {
            var id = info.GetValue<string>(nameof(Id));
            var fullDetails = s_testResource.ResolveStatusesTests.Single(test => test.Id == id);
            Id = id;
            ApiCatalog = fullDetails.ApiCatalog;
            BlockedPackages = fullDetails.BlockedPackages;
            ExternalPackageVersions = fullDetails.ExternalPackageVersions;
            LastReleaseDependenciesByPackage = fullDetails.LastReleaseDependenciesByPackage;
            ExpectedReleaseDecisions = fullDetails.ExpectedReleaseDecisions;
        }

        public void Serialize(IXunitSerializationInfo info) => info.AddValue(nameof(Id), Id);
        public override string ToString() => Id;
    }

    public class CreateUpdateBatchTest : IXunitSerializable
    {
        public string Id { get; set; }
        public JObject ApiCatalog { get; set; }
        public Dictionary<string, string> ReleaseDecisions { get; set; }
        public int BatchSize { get; set; }
        public List<string> ExpectedUpdateBatch { get; set; }

        public ApiCatalog CreateApiCatalog() => Common.ApiCatalog.FromJson(ApiCatalog.ToString());

        // We "deserialize" by just finding the right test and populating all the properties...
        public void Deserialize(IXunitSerializationInfo info)
        {
            var id = info.GetValue<string>(nameof(Id));
            var fullDetails = s_testResource.CreateUpdateBatchTests.Single(test => test.Id == id);
            Id = id;
            ApiCatalog = fullDetails.ApiCatalog;
            ReleaseDecisions = fullDetails.ReleaseDecisions;
            BatchSize = fullDetails.BatchSize;
            ExpectedUpdateBatch = fullDetails.ExpectedUpdateBatch;
        }
        public void Serialize(IXunitSerializationInfo info) => info.AddValue(nameof(Id), Id);
        public override string ToString() => Id;
    }

    public class TestResource
    {
        public List<ResolveStatusesTest> ResolveStatusesTests { get; } = new();
        public List<CreateUpdateBatchTest> CreateUpdateBatchTests { get; } = new();

        internal static TestResource Load()
        {
            var resourceName = typeof(ReleaseDependencyUpdatesCommandTest).FullName + ".json";
            using var stream = typeof(ReleaseDependencyUpdatesCommandTest).Assembly.GetManifestResourceStream(resourceName)
                ?? throw new InvalidOperationException("Can't find test data file " + resourceName);
            using var reader = new StreamReader(stream);
            var json = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<TestResource>(json) ?? throw new InvalidOperationException("Deserialized test data to null");
        }
    }
}
