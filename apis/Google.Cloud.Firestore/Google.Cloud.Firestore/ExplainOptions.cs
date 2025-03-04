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

using Google.Api.Gax;

namespace Google.Cloud.Firestore;

/// <summary>
/// Options for query explanations.
/// </summary>
public sealed class ExplainOptions
{
    /// <summary>
    /// Options that only plan a query, without executing it.
    /// </summary>
    public static ExplainOptions PlanOnly { get; } = new(new V1.ExplainOptions());

    /// <summary>
    /// Options to plan and execute a query.
    /// </summary>
    public static ExplainOptions PlanAndExecute { get; } = new(new V1.ExplainOptions { Analyze = true });

    /// <summary>
    /// Whether to execute this query.
    ///
    /// When false (the default), the query will be planned, returning only
    /// metrics from the planning stages.
    ///
    /// When true, the query will be planned and executed, returning the full
    /// query results along with both planning and execution stage metrics.
    /// </summary>
    public bool Analyze => Proto.Analyze;

    /// <summary>
    /// The protobuf representation of the options. This must not be mutated or exposed directly beyond this assembly.
    /// </summary>
    internal V1.ExplainOptions Proto { get; }

    private ExplainOptions(V1.ExplainOptions proto)
    {
        Proto = proto;
    }

    /// <summary>
    /// Creates a new instance based on the Protobuf <see cref="V1.ExplainOptions"/> representation.
    /// Later modifications to the Protobuf representation will not affect the returned oject.
    /// </summary>
    /// <param name="proto">The underlying Protobuf representation. Must not be null.</param>
    /// <returns>A new instance wrapping a clone of the protobuf message.</returns>
    public static ExplainOptions FromProto(V1.ExplainOptions proto)
    {
        GaxPreconditions.CheckNotNull(proto, nameof(proto));
        return new(proto.Clone());
    }

    /// <summary>
    /// Creates a Protobuf <see cref="V1.ExplainOptions"/> representation of this
    /// set of options. Modifications to the returned message will not be reflected in this object.
    /// </summary>
    /// <returns>A Protobuf representation.</returns>
    public V1.ExplainOptions ToProto() => Proto.Clone();
}
