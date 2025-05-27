// Copyright 2025 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Bigtable.Common.V2;
using Google.Cloud.Bigtable.V2.ConformanceTests.TestProxy;
using Google.Cloud.Bigtable.V2;
using Grpc.Auth;
using Grpc.Core;

namespace google.bigtable.testproxy;

public sealed class CloudBigtableV2TestProxyImpl : CloudBigtableV2TestProxy.CloudBigtableV2TestProxyBase
{
    private static readonly Dictionary<string, BigtableClient> s_clientMap = new Dictionary<string, BigtableClient>();

    public override async Task<CreateClientResponse> CreateClient(CreateClientRequest request, ServerCallContext context)
    {
        try
        {
            BigtableServiceApiSettings settings = BigtableServiceApiSettings.GetDefault();
            settings.AppProfileId = request.AppProfileId;

            MaybeOverrideTimeoutSetting(settings);

            BigtableClientBuilder builder = new BigtableClientBuilder
            {
                Settings = settings
            };

            if (request.SecurityOptions is null)
            {
                Environment.SetEnvironmentVariable("BIGTABLE_EMULATOR_HOST", request.DataTarget);
                builder.EmulatorDetection = EmulatorDetection.EmulatorOnly;
            }
            else
            {
                builder.Endpoint = request.DataTarget;
                builder.ChannelCredentials = GetChannelCredentials();
                builder.GrpcChannelOptions = GetChannelOptions();
            }

            s_clientMap[request.ClientId] = await builder.BuildAsync();
        }
        catch (Exception e)
        {
            throw new RpcException(new Status(StatusCode.Internal, e.Message, e));
        }

        return new CreateClientResponse();

        void MaybeOverrideTimeoutSetting(BigtableServiceApiSettings settings)
        {
            if (request.PerOperationTimeout is not null)
            {
                CallSettings callSettings = CallSettings.FromExpiration(Expiration.FromTimeout(request.PerOperationTimeout.ToTimeSpan()));
                settings.CheckAndMutateRowSettings = callSettings;
                settings.ExecuteQuerySettings = callSettings;
                settings.MutateRowSettings = callSettings;
                settings.MutateRowsSettings = callSettings;
                settings.ReadRowsSettings = callSettings;
                settings.ReadModifyWriteRowSettings = callSettings;
                settings.SampleRowKeysSettings = callSettings;
                settings.CallSettings = callSettings;
                // same as default ReadRowsRetrySettings except DeadlineExceeded is not in the retryFilter
                settings.ReadRowsRetrySettings = RetrySettings.FromExponentialBackoff(
                    maxAttempts: 5,
                    initialBackoff: TimeSpan.FromMilliseconds(10),
                    maxBackoff: TimeSpan.FromMinutes(1),
                    backoffMultiplier: 2,
                    retryFilter: RetrySettings.FilterForStatusCodes(StatusCode.Unavailable, StatusCode.Aborted));
            }
        }

        ChannelCredentials GetChannelCredentials()
        {
            if (request.SecurityOptions.AccessToken is null)
            {
                return request.SecurityOptions.UseSsl ? new SslCredentials(request.SecurityOptions.SslRootCertsPem) : ChannelCredentials.Insecure;
            }
            GoogleCredential googleCredential = GoogleCredential.FromAccessToken(request.SecurityOptions.AccessToken);
            return request.SecurityOptions.UseSsl
                ? ChannelCredentials.Create(new SslCredentials(request.SecurityOptions.SslRootCertsPem), googleCredential.ToCallCredentials())
                : googleCredential.ToChannelCredentials();
        }

        GrpcChannelOptions GetChannelOptions() => request.SecurityOptions.SslEndpointOverride is not null
                    ? GrpcChannelOptions.Empty.WithCustomOption("grpc.ssl_target_name_override", request.SecurityOptions.SslEndpointOverride)
                    : null;
    }

    public override Task<CloseClientResponse> CloseClient(CloseClientRequest request, ServerCallContext context)
    {
        return Task.FromResult(new CloseClientResponse());
    }

    public override Task<RemoveClientResponse> RemoveClient(RemoveClientRequest request, ServerCallContext context)
    {
        string clientId = request.ClientId;
        bool removed = s_clientMap.Remove(clientId);
        if (!removed)
        {
            throw new RpcException(new Status(StatusCode.NotFound, $"Client {clientId} not found."));
        }
        return Task.FromResult(new RemoveClientResponse());
    }

    public override async Task<RowResult> ReadRow(ReadRowRequest request, ServerCallContext context)
    {
        BigtableClient bigtableClient = GetClient(request.ClientId, context);
        TableName tableName = TableName.Parse(request.TableName);
        try
        {
            Row row = await bigtableClient.ReadRowAsync(tableName,
                new BigtableByteString(request.RowKey),
                request.Filter);
            string message = row is null ? $"ReadRow didn't find row: {request.RowKey}" : "ReadRow succeeded";
            return new RowResult
            {
                Row = row,
                Status = SetSuccessStatus(message)
            };
        }
        catch (RpcException e)
        {
            return new RowResult
            {
                Status = SetExceptionStatus(e)
            };
        }
    }
    public override async Task<RowsResult> ReadRows(Google.Cloud.Bigtable.V2.ConformanceTests.TestProxy.ReadRowsRequest request, ServerCallContext context)
    {
        BigtableClient bigtableClient = GetClient(request.ClientId, context);
        RowsResult rowsResult = new RowsResult();
        try
        {
            ReadRowsStream stream = bigtableClient.ReadRows(request.Request);
            await foreach (Row row in stream)
            {
                rowsResult.Rows.Add(row);
            }
            string message = rowsResult.Rows.Count == 0 ? $"ReadRows didn't find rows" : "ReadRows succeeded";
            rowsResult.Status = SetSuccessStatus(message);
            return rowsResult;
        }
        catch (RpcException e)
        {
            rowsResult.Status = SetExceptionStatus(e);
            return rowsResult;
        }
        catch (InvalidOperationException e)
        {
            if (e.Message.Contains("NewRow key must be greater than the previous row's"))
            {
                rowsResult.Status = new Google.Rpc.Status()
                {
                    Message = "increasing decreasing"
                };
            }
            return rowsResult;
        }
    }

    public override async Task<MutateRowResult> MutateRow(Google.Cloud.Bigtable.V2.ConformanceTests.TestProxy.MutateRowRequest request, ServerCallContext context)
    {
        BigtableClient bigtableClient = GetClient(request.ClientId, context);
        try
        {
            MutateRowResponse response = await bigtableClient.MutateRowAsync(request.Request);
            string message = "MutateRow succeeded";
            return new MutateRowResult
            {
                Status = SetSuccessStatus(message)
            };
        }
        catch (RpcException e)
        {
            return new MutateRowResult
            {
                Status = SetExceptionStatus(e)
            };
        }
    }

    public override async Task<MutateRowsResult> BulkMutateRows(Google.Cloud.Bigtable.V2.ConformanceTests.TestProxy.MutateRowsRequest request, ServerCallContext context)
    {
        BigtableClient bigtableClient = GetClient(request.ClientId, context);
        MutateRowsResult result = new MutateRowsResult();
        try
        {
            MutateRowsResponse response = await bigtableClient.MutateRowsAsync(request.Request);
            string message = "MutateRows succeeded";
            result.Status = SetSuccessStatus(message);
            foreach (MutateRowsResponse.Types.Entry entry in response.Entries)
            {
                if (entry.Status.Code > 0)
                {
                    result.Entries.Add(entry);
                }
            }
            return result;
        }
        catch (RpcException e)
        {
            result.Status = SetExceptionStatus(e);
            if (e.StatusCode == StatusCode.DeadlineExceeded)
            {
                int i = 0;
                foreach (Google.Cloud.Bigtable.V2.MutateRowsRequest.Types.Entry entry in request.Request.Entries)
                {
                    MutateRowsResponse.Types.Entry failedResponseEntry = new MutateRowsResponse.Types.Entry();
                    failedResponseEntry.Index = i;
                    failedResponseEntry.Status = new Google.Rpc.Status()
                    {
                        Code = (int) Google.Rpc.Code.DeadlineExceeded
                    };
                    result.Entries.Add(failedResponseEntry);
                    i++;
                }
            }
            return result;
        }
    }

    public override async Task<CheckAndMutateRowResult> CheckAndMutateRow(Google.Cloud.Bigtable.V2.ConformanceTests.TestProxy.CheckAndMutateRowRequest request, ServerCallContext context)
    {
        BigtableClient bigtableClient = GetClient(request.ClientId, context);
        try
        {
            CheckAndMutateRowResponse response = await bigtableClient.CheckAndMutateRowAsync(request.Request);
            string message = "CheckAndMutateRow succeeded";
            return new CheckAndMutateRowResult
            {
                Result = response,
                Status = SetSuccessStatus(message)
            };
        }
        catch (RpcException e)
        {
            return new CheckAndMutateRowResult
            {
                Status = SetExceptionStatus(e)
            };
        }
    }

    public override async Task<SampleRowKeysResult> SampleRowKeys(Google.Cloud.Bigtable.V2.ConformanceTests.TestProxy.SampleRowKeysRequest request, ServerCallContext context)
    {
        BigtableClient bigtableClient = GetClient(request.ClientId, context);
        try
        {
            BigtableServiceApiClient.SampleRowKeysStream stream = bigtableClient.SampleRowKeys(request.Request);
            SampleRowKeysResult result = new SampleRowKeysResult();
            result.Samples.Add(await stream.ToListAsync());
            string message = result.Samples.Count == 0 ? "SampleRowKeys did not find sample" : "SampleRowKeys succeeded";
            result.Status = SetSuccessStatus(message);
            return result;
        }
        catch (RpcException e)
        {
            return new SampleRowKeysResult
            {
                Status = SetExceptionStatus(e)
            };
        }
    }

    public override async Task<RowResult> ReadModifyWriteRow(Google.Cloud.Bigtable.V2.ConformanceTests.TestProxy.ReadModifyWriteRowRequest request, ServerCallContext context)
    {
        BigtableClient bigtableClient = GetClient(request.ClientId, context);
        try
        {
            Row row = (await bigtableClient.ReadModifyWriteRowAsync(request.Request)).Row;
            string message = row is null ? "ReadModifyRow didn't find row" : "ReadModifyRow succeeded";
            return new RowResult
            {
                Row = row,
                Status = SetSuccessStatus(message)
            };
        }
        catch (RpcException e)
        {
            return new RowResult
            {
                Status = SetExceptionStatus(e)
            };
        }
    }

    public override Task<ExecuteQueryResult> ExecuteQuery(Google.Cloud.Bigtable.V2.ConformanceTests.TestProxy.ExecuteQueryRequest request, ServerCallContext context)
    {
        throw new NotImplementedException();
    }

    public static CloudBigtableV2TestProxyImpl Create() => new();

    private BigtableClient GetClient(string clientId, ServerCallContext context)
    {
        if (!s_clientMap.ContainsKey(clientId))
        {
            throw new RpcException(new Status(StatusCode.NotFound, $"Client {clientId} not found."));
        }

        return s_clientMap[clientId];
    }

    private static Google.Rpc.Status SetExceptionStatus(RpcException e)
    {
        return new Google.Rpc.Status()
        {
            Code = (int) e.Status.StatusCode,
            Message = e.Message
        };
    }

    private static Google.Rpc.Status SetSuccessStatus(string message)
    {
        return new Google.Rpc.Status()
        {
            Code = (int) Google.Rpc.Code.Ok,
            Message = message
        };
    }
}
