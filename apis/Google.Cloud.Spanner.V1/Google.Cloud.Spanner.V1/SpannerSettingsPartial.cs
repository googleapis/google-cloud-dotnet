// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.Spanner.V1.Internal.Logging;

namespace Google.Cloud.Spanner.V1;

public sealed partial class SpannerSettings
{
    partial void OnCopy(SpannerSettings existing)
    {
        Logger = existing.Logger;
        LeaderRoutingEnabled = existing.LeaderRoutingEnabled;
        DirectedReadOptions = existing.DirectedReadOptions;
    }

    private Logger _logger = Logger.DefaultLogger;

    /// <summary>
    /// The logger to use for operations involving this client. This property is never null.
    /// </summary>
    public Logger Logger
    {
        get => _logger;
        set => _logger = GaxPreconditions.CheckNotNull(value, nameof(value));
    }

    /// <summary>
    /// Specifies whether leader routing is enabled or not. This is true by default.
    /// </summary>
    /// <remarks>
    /// If this value is true some operations will always be explicitly routed to the leader,
    /// some operations will never be explicitly routed to the leader, and some operations will
    /// be routed to the leader depending on the transaction type they are using.
    /// </remarks>
    internal bool LeaderRoutingEnabled { get; set; } = true;

    /// <summary>
    /// Specifies which replicas or regions should be used for non-transactional reads or queries.
    /// </summary>
    /// <remarks>
    /// These options will be applied to ExecuteSql, ExecuteStreamingSql, Read and StreamingRead
    /// operation being executed within a single use or read-only transaction. Otherwise, they will
    /// be ignored.
    /// </remarks>
    internal DirectedReadOptions DirectedReadOptions { get; set; }
}
