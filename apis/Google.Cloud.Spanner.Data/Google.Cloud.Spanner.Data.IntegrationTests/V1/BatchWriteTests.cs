// Copyright 2025 Google LLC
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

using Google.Cloud.Spanner.Data.IntegrationTests;
using Google.Protobuf.WellKnownTypes;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace Google.Cloud.Spanner.V1.IntegrationTests;

[CommonTestDiagnostics]
[Collection(nameof(BatchWriteTableFixture))]
public class BatchWriteTests
{
    private record BatchWriteResponseAnalysis(int successCount, int failureCount);

    private readonly BatchWriteTableFixture _fixture;
    private const int TimeoutSeconds = 60;

    public BatchWriteTests(BatchWriteTableFixture fixture) =>
            _fixture = fixture;

    [Fact]
    public async Task BatchWrite_Success()
    {
        // Create two non-conflicting write mutations
        PooledSession pooledSession = await _fixture.GetPooledSessionAsync();
        var mutationGroup = new BatchWriteRequest.Types.MutationGroup();
        mutationGroup.Mutations.AddRange([
        new Mutation
        {
            Insert = new Mutation.Types.Write
            {
                Table = _fixture.TableName,
                Columns = { _fixture.KeyName },
                Values = { new ListValue { Values = { Value.ForString(Guid.NewGuid().ToString()) } } }
            }
        },
        new Mutation
        {
            Insert = new Mutation.Types.Write
            {
                Table = _fixture.TableName,
                Columns = { _fixture.KeyName },
                Values = { new ListValue { Values = { Value.ForString(Guid.NewGuid().ToString()) } } }
            }
        }
        ]);

        BatchWriteRequest batchWriteRequest = new()
        {
            Session = pooledSession.Session.Name,
            MutationGroups = { mutationGroup }
        };

        IAsyncEnumerable<BatchWriteResponse> responseStream = pooledSession.BatchWriteAsync(batchWriteRequest, _fixture.GetCallSettings());
        BatchWriteResponseAnalysis responseAnalysis = await GetResponseAnalysis(responseStream);

        // The single mutation group will succeed as one atomic unit
        Assert.Equal(0, responseAnalysis.failureCount);
        Assert.Equal(1, responseAnalysis.successCount);
    }

    [Fact]
    public async Task BatchWrite_Failure_Conflict()
    {
        // Create a valid and a conflicting write mutation group.
        PooledSession pooledSession = await _fixture.GetPooledSessionAsync();
        var mutation =  new Mutation
        {
            Insert = new Mutation.Types.Write
            {
                Table = _fixture.TableName,
                Columns = { _fixture.KeyName },
                Values = { new ListValue { Values = { Value.ForString("Conflict because matching write.") } } },
            }
        };

        var mutationGroupNoConflict = new BatchWriteRequest.Types.MutationGroup();
        var mutationGroupConflict = new BatchWriteRequest.Types.MutationGroup();
        mutationGroupConflict.Mutations.AddRange([mutation, mutation]);
        mutationGroupNoConflict.Mutations.AddRange([mutation]);

        BatchWriteRequest batchWriteRequest = new()
        {
            Session = pooledSession.Session.Name,
            MutationGroups = { mutationGroupConflict, mutationGroupNoConflict }
        };

        // Send the batch write request and parse the response
        IAsyncEnumerable<BatchWriteResponse> responseStream = pooledSession.BatchWriteAsync(batchWriteRequest, _fixture.GetCallSettings());
        BatchWriteResponseAnalysis responseAnalysis = await GetResponseAnalysis(responseStream);

        // The mutation group with a conflict will result in one failure
        Assert.Equal(1, responseAnalysis.failureCount);
        // The mutation group without a conflict will result in one success
        Assert.Equal(1, responseAnalysis.successCount);
    }

    [Fact]
    public async Task BatchWrite_Failure_TransactionModeNotNone()
    {
        // Any transaction associated with the session will cause the batchwrite to throw an exception
        var options = new TransactionOptions()
        {
            ReadWrite = new TransactionOptions.Types.ReadWrite()
        };
        PooledSession pooledSession = await _fixture.GetPooledSessionAsync(options);

        var mutationGroup = new BatchWriteRequest.Types.MutationGroup();
        mutationGroup.Mutations.AddRange([
        new Mutation
        {
            Insert = new Mutation.Types.Write
            {
                Table = _fixture.TableName,
                Columns = { _fixture.KeyName },
                Values = { new ListValue { Values = { Value.ForString(Guid.NewGuid().ToString()) } } }
            }
        }]);

        BatchWriteRequest batchWriteRequest = new()
        {
            Session = pooledSession.Session.Name,
            MutationGroups = { mutationGroup }
        };

        Assert.Throws<InvalidOperationException>(() =>
                pooledSession.BatchWriteAsync(batchWriteRequest, _fixture.GetCallSettings()));
    }

    private static async Task<BatchWriteResponseAnalysis> GetResponseAnalysis(IAsyncEnumerable<BatchWriteResponse> responseStream)
    {
        var successCount = 0;
        var failureCount = 0;
        string result = "";
        await foreach(var response in responseStream)
        {
            // STATUS CODE of 0 is a success
            if (response.Status.Code == 0)
            {
                successCount += response.Indexes.Count;
            }
            else
            {
                failureCount += response.Indexes.Count;
            }
            result += JsonConvert.SerializeObject(response);
        }

        return new BatchWriteResponseAnalysis(successCount: successCount, failureCount: failureCount);
    }
}
