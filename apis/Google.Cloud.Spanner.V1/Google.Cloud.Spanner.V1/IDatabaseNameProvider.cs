// Copyright 2026 Google LLC
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

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// Provides access to the extracted resource identifiers (Project, Instance, Database)
/// from a Spanner RPC request.
/// </summary>
internal interface IDatabaseNameProvider
{
    /// <summary>
    /// Gets the Google Cloud Project ID associated with the request resource.
    /// </summary>
    string ProjectId { get; }

    /// <summary>
    /// Gets the Spanner Instance ID associated with the request resource.
    /// </summary>
    string InstanceId { get; }

    /// <summary>
    /// Gets the Spanner Database ID associated with the request resource.
    /// </summary>
    string DatabaseId { get; }
}

public partial class CreateSessionRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => DatabaseAsDatabaseName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => DatabaseAsDatabaseName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => DatabaseAsDatabaseName?.DatabaseId;
}

public partial class BatchCreateSessionsRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => DatabaseAsDatabaseName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => DatabaseAsDatabaseName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => DatabaseAsDatabaseName?.DatabaseId;
}

public partial class ListSessionsRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => DatabaseAsDatabaseName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => DatabaseAsDatabaseName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => DatabaseAsDatabaseName?.DatabaseId;
}

public partial class GetSessionRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => SessionName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => SessionName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => SessionName?.DatabaseId;
}

public partial class DeleteSessionRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => SessionName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => SessionName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => SessionName?.DatabaseId;
}

public partial class ExecuteSqlRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => SessionAsSessionName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => SessionAsSessionName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => SessionAsSessionName?.DatabaseId;
}

public partial class ExecuteBatchDmlRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => SessionAsSessionName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => SessionAsSessionName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => SessionAsSessionName?.DatabaseId;
}

public partial class ReadRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => SessionAsSessionName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => SessionAsSessionName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => SessionAsSessionName?.DatabaseId;
}

public partial class BeginTransactionRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => SessionAsSessionName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => SessionAsSessionName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => SessionAsSessionName?.DatabaseId;
}

public partial class CommitRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => SessionAsSessionName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => SessionAsSessionName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => SessionAsSessionName?.DatabaseId;
}

public partial class RollbackRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => SessionAsSessionName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => SessionAsSessionName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => SessionAsSessionName?.DatabaseId;
}

public partial class PartitionQueryRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => SessionAsSessionName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => SessionAsSessionName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => SessionAsSessionName?.DatabaseId;
}

public partial class PartitionReadRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => SessionAsSessionName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => SessionAsSessionName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => SessionAsSessionName?.DatabaseId;
}

public partial class BatchWriteRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => SessionAsSessionName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => SessionAsSessionName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => SessionAsSessionName?.DatabaseId;
}

public partial class FetchCacheUpdateRequest : IDatabaseNameProvider
{
    string IDatabaseNameProvider.ProjectId => DatabaseAsDatabaseName?.ProjectId;
    string IDatabaseNameProvider.InstanceId => DatabaseAsDatabaseName?.InstanceId;
    string IDatabaseNameProvider.DatabaseId => DatabaseAsDatabaseName?.DatabaseId;
}
