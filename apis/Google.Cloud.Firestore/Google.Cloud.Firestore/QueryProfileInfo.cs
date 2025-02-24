// Copyright 2024 Google LLC
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

using Google.Cloud.Firestore.V1;

namespace Google.Cloud.Firestore;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public sealed class QueryProfileInfo<T>
{
    /// <summary>
    /// 
    /// </summary>
    public T Snapshot { get; }

    // TODO: Expose an IReadOnlyDictionary<string, object> instead?
    /// <summary>
    /// The query plan that was executed or profiled.
    /// </summary>
    public PlanSummary Plan { get; }

    // TODO: Expose an IReadOnlyDictionary<string, object> instead?
    /// <summary>
    /// The stats for the query, or null if the query was only profiled.
    /// </summary>
    public ExecutionStats Stats { get; }

    internal QueryProfileInfo(T snapshot, ExplainMetrics metrics)
    {
        Snapshot = snapshot;
        Plan = metrics?.PlanSummary;
        Stats = metrics?.ExecutionStats;
    }
}
