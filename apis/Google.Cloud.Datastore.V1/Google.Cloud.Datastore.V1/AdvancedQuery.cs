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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static Google.Cloud.Datastore.V1.ReadOptions.Types;

namespace Google.Cloud.Datastore.V1;

/// <summary>
/// Prototype only!
/// </summary>
public class AdvancedQuery
{
    /// <summary>
    /// 
    /// </summary>
    public GqlQuery GqlQuery { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Query Query { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ExplainOptions ExplainOptions { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ReadConsistency? ReadConsistency { get; set; }

    internal RunQueryRequest ToRequest(string projectId, string databaseId, PartitionId partitionId)
    {
        var request = new RunQueryRequest
        {
            ProjectId = projectId,
            DatabaseId = databaseId,
            PartitionId = partitionId,
            ReadOptions = GetReadOptions(ReadConsistency),
            ExplainOptions = ExplainOptions
        };
        // TODO: Validation of exactly one being set, or make the properties behave like a oneof.
        if (GqlQuery is not null)
        {
            request.GqlQuery = GqlQuery;
        }
        if (Query is not null)
        {
            request.Query = Query;
        }
        return request;
    }

    private static ReadOptions GetReadOptions(ReadConsistency? readConsistency) =>
        readConsistency == null ? null : new ReadOptions { ReadConsistency = readConsistency.Value };
}
