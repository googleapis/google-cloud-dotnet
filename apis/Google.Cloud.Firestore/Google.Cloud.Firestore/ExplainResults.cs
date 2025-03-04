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

using Google.Cloud.Firestore.V1;

namespace Google.Cloud.Firestore;

/// <summary>
/// Information about planning, execution, and results of a query.
/// </summary>
/// <typeparam name="T">The type of snapshot returned by the query.</typeparam>
public sealed class ExplainResults<T> where T : class
{
    /// <summary>
    /// Returns the snapshot that contains the results of executing the query, or null if the query was
    /// not executed.
    /// </summary>
    public T Snapshot { get; }

    /// <summary>
    /// Returns the information about planning and execution (if any) of the query.
    /// </summary>
    public ExplainMetrics Metrics { get; }

    internal ExplainResults(T snapshot, ExplainMetrics metrics)
    {
        Snapshot = snapshot;
        Metrics = metrics;
    }
}
