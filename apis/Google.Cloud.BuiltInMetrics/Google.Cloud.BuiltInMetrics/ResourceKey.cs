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
using System.Diagnostics;
using System.Globalization;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Identifies one monitored resource and splits measurement labels into resource values and data-point tags.
/// </summary>
internal readonly struct ResourceKey : IEquatable<ResourceKey>
{
    internal ServiceMetricsConfiguration Configuration { get; }
    internal string[] Values { get; }

    private ResourceKey(ServiceMetricsConfiguration configuration, string[] values) =>
        (Configuration, Values) = (configuration, values);

    internal static bool TrySplitLabels(
        ServiceMetricsConfiguration configuration,
        ReadOnlySpan<KeyValuePair<string, object>> labels,
        out ResourceKey key,
        out TagList tags)
    {
        var names = configuration.ResourceLabelNames;
        var values = new string[names.Length];
        tags = default;
        foreach (var label in labels)
        {
            int index = Array.IndexOf(names, label.Key);
            if (index >= 0)
            {
                values[index] = label.Value is string text
                    ? text
                    : Convert.ToString(label.Value, CultureInfo.InvariantCulture);
            }
            else
            {
                tags.Add(label);
            }
        }
        // Without every resource label, Cloud Monitoring cannot map the point to a monitored resource.
        foreach (var value in values)
        {
            if (string.IsNullOrEmpty(value))
            {
                key = default;
                return false;
            }
        }
        key = new ResourceKey(configuration, values);
        return true;
    }

    public bool Equals(ResourceKey other)
    {
        if (!ReferenceEquals(Configuration, other.Configuration))
        {
            return false;
        }
        if (Values is null)
        {
            return true;
        }
        for (int i = 0; i < Values.Length; i++)
        {
            if (!string.Equals(Values[i], other.Values[i], StringComparison.Ordinal))
            {
                return false;
            }
        }
        return true;
    }

    public override bool Equals(object obj) => obj is ResourceKey other && Equals(other);

    public override int GetHashCode()
    {
        if (Configuration is null || Values is null)
        {
            return 0;
        }
        int hash = Configuration.GetHashCode();
        foreach (var value in Values)
        {
            hash = (hash * 31) + StringComparer.Ordinal.GetHashCode(value);
        }
        return hash;
    }
}
