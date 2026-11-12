// Copyright 2026 Google LLC
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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

public class ResourceKeyTest
{
    private static readonly ServiceMetricsConfiguration s_spanner = ServiceMetricsConfiguration.Spanner;

    [Theory]
    [InlineData(1)]
    [InlineData(10)]
    public void TrySplitLabels_ExtractsResourceValuesAndPreservesDataPointTags(int tagCount)
    {
        var expectedTags = Enumerable.Range(0, tagCount)
            .Select(i => new KeyValuePair<string, object>($"tag_{i}", $"value_{i}")).ToArray();
        var labels = Enumerable.Reverse(MetricForwarderTest.CreateLabels().Where(pair => pair.Key != "database"))
            .Concat(expectedTags).ToArray();

        Assert.True(ResourceKey.TrySplitLabels(s_spanner, labels, out var key, out var tags));
        Assert.Same(s_spanner, key.Configuration);
        Assert.Equal(["project", "instance", "us-central1", "regional-us-central1", "0000ff"], key.Values);
        Assert.Equal(expectedTags, tags);
    }

    [Fact]
    public void TrySplitLabels_NonStringResourceLabel_ConvertsWithInvariantCulture()
    {
        var labels = MetricForwarderTest.CreateLabels()
            .Select(pair => pair.Key == "client_hash" ? new KeyValuePair<string, object>(pair.Key, 12.5) : pair)
            .ToArray();
        var originalCulture = CultureInfo.CurrentCulture;
        try
        {
            CultureInfo.CurrentCulture = new CultureInfo("fr-FR");
            Assert.True(ResourceKey.TrySplitLabels(s_spanner, labels, out var key, out _));
            Assert.Equal("12.5", key.Values[Array.IndexOf(s_spanner.ResourceLabelNames, "client_hash")]);
        }
        finally
        {
            CultureInfo.CurrentCulture = originalCulture;
        }
    }

    [Theory]
    [InlineData("instance_id", null, true)]
    [InlineData("instance_id", null, false)]
    [InlineData("instance_id", "", false)]
    [InlineData("project_id", "", false)]
    public void TrySplitLabels_MissingOrEmptyResourceLabel_ReturnsFalse(string label, string value, bool omit)
    {
        var labels = MetricForwarderTest.CreateLabels().Where(pair => pair.Key != label).ToList();
        if (!omit)
        {
            labels.Add(new(label, value));
        }

        Assert.False(ResourceKey.TrySplitLabels(s_spanner, labels.ToArray(), out var key, out _));
        Assert.Equal(default, key);
    }

    [Theory]
    [InlineData("instance", false, true)]
    [InlineData("instance", true, true)]
    [InlineData("other-instance", false, false)]
    public void Equals_ComparesResourceValuesRegardlessOfLabelOrder(
        string secondInstanceId, bool reverseSecond, bool expectedEqual)
    {
        var secondLabels = reverseSecond
            ? Enumerable.Reverse(MetricForwarderTest.CreateLabels(secondInstanceId)).ToArray()
            : MetricForwarderTest.CreateLabels(secondInstanceId);
        Assert.True(ResourceKey.TrySplitLabels(s_spanner, MetricForwarderTest.CreateLabels("instance"), out var first, out _));
        Assert.True(ResourceKey.TrySplitLabels(s_spanner, secondLabels, out var second, out _));

        Assert.Equal(expectedEqual, first.Equals(second));
        Assert.Equal(expectedEqual, first.Equals((object) second));
        if (expectedEqual)
        {
            Assert.Equal(first.GetHashCode(), second.GetHashCode());
        }
    }

    [Fact]
    public void Default_EqualsOnlyDefaultWithZeroHashCode()
    {
        ResourceKey defaultKey = default;
        Assert.True(ResourceKey.TrySplitLabels(s_spanner, MetricForwarderTest.CreateLabels(), out var populated, out _));

        Assert.True(defaultKey.Equals(default));
        Assert.True(defaultKey.Equals((object) defaultKey));
        Assert.Equal(0, defaultKey.GetHashCode());
        Assert.False(defaultKey.Equals(populated));
        Assert.False(populated.Equals(defaultKey));
        Assert.False(populated.Equals((object) null));
        Assert.False(defaultKey.Equals((object) null));
    }
}
