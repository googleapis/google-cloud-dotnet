// Copyright 2023 Google LLC
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

using Google.Apis.Bigquery.v2.Data;
using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests;

[Collection(nameof(BigQueryFixture))]
public class SnapshotCloneTest
{
    private readonly BigQueryFixture _fixture;
    public SnapshotCloneTest(BigQueryFixture fixture)
    {
        _fixture = fixture;
    }

    private TableReference GetTableReference(string datasetId, string tableId) =>
        new TableReference { ProjectId = _fixture.ProjectId, DatasetId = datasetId, TableId = tableId };

    [Fact]
    public void CreateTableSnapshot()
    {
        var client = BigQueryClient.Create(_fixture.ProjectId);
        var datasetId = _fixture.DatasetId;
        var tableId = _fixture.PeopleTableId;

        var sourceTableReference = GetTableReference(datasetId, tableId);
        var destinationTableReference = GetTableReference(datasetId, tableId + "SnapshotTable");
        var jobOptions = new CreateCopyJobOptions
        {
            OperationType = CopyOperationType.Snapshot
        };
        var job = client.CreateCopyJob(sourceTableReference, destinationTableReference, jobOptions).PollUntilCompleted();
        Assert.Null(job.Status.ErrorResult);

        var destTable = client.GetTable(_fixture.DatasetId, destinationTableReference.TableId);
        Assert.NotNull(destTable.Resource.SnapshotDefinition);

        var baseTableReference = destTable.Resource.SnapshotDefinition.BaseTableReference;
        Assert.Equal(sourceTableReference.TableId, baseTableReference.TableId);
        Assert.Equal(sourceTableReference.ProjectId, baseTableReference.ProjectId);
        Assert.Equal(sourceTableReference.DatasetId, baseTableReference.DatasetId);
    }

    [Fact]
    public void CreateTableClone()
    {
        var client = BigQueryClient.Create(_fixture.ProjectId);
        var datasetId = _fixture.DatasetId;
        var tableId = _fixture.PeopleTableId;

        var sourceTableReference = GetTableReference(datasetId, tableId);
        var destinationTableReference = GetTableReference(datasetId, tableId + "CloneTable");
        var jobOptions = new CreateCopyJobOptions
        {
            OperationType = CopyOperationType.Clone
        };
        var job = client.CreateCopyJob(sourceTableReference, destinationTableReference, jobOptions).PollUntilCompleted();
        Assert.Null(job.Status.ErrorResult);

        var destTable = client.GetTable(_fixture.DatasetId, destinationTableReference.TableId);
        Assert.NotNull(destTable.Resource.CloneDefinition);

        var baseTableReference = destTable.Resource.CloneDefinition.BaseTableReference;
        Assert.Equal(sourceTableReference.TableId, baseTableReference.TableId);
        Assert.Equal(sourceTableReference.ProjectId, baseTableReference.ProjectId);
        Assert.Equal(sourceTableReference.DatasetId, baseTableReference.DatasetId);
    }
}
