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
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2.ConformanceTests;

public sealed class CloudBigtableV2TestProxyImpl : CloudBigtableV2TestProxy.CloudBigtableV2TestProxyBase
{
    private class CbtClient
    {
        public BigtableClient Client { get; set; }
        public ChannelBase LastCreatedChannel { get; set; }
        public InstanceName InstanceName { get; set; }
    }

    private readonly Dictionary<string, CbtClient> _idClientMap;

    public override async Task<CreateClientResponse> CreateClient(CreateClientRequest request, ServerCallContext context)
    {
        string clientId = request.ClientId;
        string projectId = request.ProjectId;
        string instanceId = request.InstanceId;
        string dataTarget = request.DataTarget;
        CreateClientRequest.Types.SecurityOptions securityOptions = request.SecurityOptions;

        GaxPreconditions.CheckArgument(clientId is not ("" or null), "ClientId", "client id must be provided");
        GaxPreconditions.CheckArgument(projectId is not ("" or null), "ProjectId", "project id must be provided");
        GaxPreconditions.CheckArgument(instanceId is not ("" or null), "InstanceId", "instance id must be provided");
        GaxPreconditions.CheckArgument(dataTarget is not ("" or null), "DataTarget", "data target must be provided");
        GaxPreconditions.CheckArgument(!securityOptions.UseSsl
            || (securityOptions.SslRootCertsPem is not ("" or null)), "SecurityOptions",
            "security_options.ssl_root_certs_pem must be provided if security_options.use_ssl is true");

        if (_idClientMap.ContainsKey(clientId))
        {
            context.Status = new Status(StatusCode.AlreadyExists, $"Client {clientId} already exists");
            throw new RpcException(context.Status);
        }

        try
        {
            BigtableServiceApiSettings settings = new BigtableServiceApiSettings
            {
                AppProfileId = request.AppProfileId
            };

            if (request.PerOperationTimeout is not null)
            {
                OverrideTimeoutSetting(request.PerOperationTimeout.Seconds, settings);
            }

            BigtableServiceApiClientBuilder builder = new BigtableServiceApiClientBuilder
            {
                Settings = settings
            };
            if (dataTarget != "emulator")
            {
                builder.Endpoint = dataTarget;
                builder.ChannelCredentials = GetChannelCredentials(securityOptions.UseSsl, securityOptions.SslRootCertsPem, securityOptions.AccessToken);
                builder.GrpcChannelOptions = (securityOptions.UseSsl && securityOptions.SslEndpointOverride is not null)
                    ? GrpcChannelOptions.Empty.WithCustomOption("grpc.ssl_target_name_override", securityOptions.SslEndpointOverride)
                    : GrpcChannelOptions.Empty;
            }
            else
            {
                builder.EmulatorDetection = EmulatorDetection.EmulatorOnly;
            }
            InstanceName instanceName = new InstanceName(projectId, instanceId);
            BigtableServiceApiClient apiClient = await builder.BuildAsync();

            CbtClient cbtClient = new CbtClient
            {
                Client = BigtableClient.Create(apiClient),
                LastCreatedChannel = builder.LastCreatedChannel,
                InstanceName = instanceName
            };
            _idClientMap[clientId] = cbtClient;
        }
        catch (Exception e)
        {
            context.Status = new Status(StatusCode.Internal, e.Message, e);
            throw new RpcException(context.Status);
        }

        context.Status = new Status(StatusCode.OK, "CreateClient succeeded");
        return new CreateClientResponse();
    }
    public override async Task<CloseClientResponse> CloseClient(CloseClientRequest request, ServerCallContext context)
    {
        CbtClient cbtClient = GetClient(request.ClientId, context);
        try
        {
            await cbtClient.LastCreatedChannel.ShutdownAsync();
        }
        catch (Exception e)
        {
            context.Status = new Status(StatusCode.Internal, e.Message, e);
            throw new RpcException(context.Status);
        }
        context.Status = new Status(StatusCode.OK, "CloseClient succeeded");
        return new CloseClientResponse();
    }

    public override Task<RemoveClientResponse> RemoveClient(RemoveClientRequest request, ServerCallContext context)
    {
        string clientId = request.ClientId;
        GaxPreconditions.CheckArgument(clientId is not ("" or null), "ClientId", "client id must be provided", context);
        bool removed = _idClientMap.Remove(clientId);
        if (!removed)
        {
            context.Status = new Status(StatusCode.NotFound, $"Client {clientId} not found.");
            throw new RpcException(context.Status);
        }
        context.Status = new Status(StatusCode.OK, "RemoveClient succeeded");
        return Task.FromResult(new RemoveClientResponse());
    }

    public override async Task<RowResult> ReadRow(ReadRowRequest request, ServerCallContext context)
    {
        CbtClient cbtClient = GetClient(request.ClientId, context);

        if (!TableName.TryParse(request.TableName, out TableName tableName))
        {
            context.Status = new Status(StatusCode.InvalidArgument, "Invalid TableName");
            return new RowResult
            {
                Status = new Rpc.Status()
                {
                    Code = (int) Rpc.Code.InvalidArgument,
                    Message = "Invalid TableName"
                }
            };
        }

        try
        {
            Row row = await cbtClient.Client.ReadRowAsync(tableName,
                new BigtableByteString(request.RowKey),
                request.Filter);
            string message = row is null ? $"ReadRow didn't find row: {request.RowKey}" : "ReadRow succeeded";
            return new RowResult
            {
                Row = row,
                Status = SetSuccessStatus(message, context)
            };
        }
        catch (Exception e)
        {
            return new RowResult
            {
                Status = SetExceptionStatus(e, context)
            };
        }
    }
    public override async Task<RowsResult> ReadRows(ReadRowsRequest request, ServerCallContext context)
    {
        CbtClient cbtClient = GetClient(request.ClientId, context);

        try
        {
            ReadRowsStream stream = cbtClient.Client.ReadRows(request.Request);
            IAsyncEnumerator<Row> enumerator = stream.GetAsyncEnumerator(new System.Threading.CancellationToken(false));
            RowsResult rowsResult = new RowsResult();
            while (await enumerator.MoveNextAsync())
            {
                rowsResult.Rows.Add(enumerator.Current);
            }
            string message = rowsResult.Rows.Count == 0 ? $"ReadRows didn't find rows" : "ReadRows succeeded";
            rowsResult.Status = SetSuccessStatus(message, context);
            return rowsResult;
        }
        catch (Exception e)
        {
            return new RowsResult
            {
                Status = SetExceptionStatus(e, context)
            };
        }
    }

    public override async Task<MutateRowResult> MutateRow(MutateRowRequest request, ServerCallContext context)
    {
        CbtClient cbtClient = GetClient(request.ClientId, context);
        try
        {
            MutateRowResponse response = await cbtClient.Client.MutateRowAsync(request.Request);
            string message = "MutateRow succeeded";
            return new MutateRowResult
            {
                Status = SetSuccessStatus(message, context)
            };
        }
        catch (Exception e)
        {
            return new MutateRowResult
            {
                Status = SetExceptionStatus(e, context)
            };
        }
    }

    public override async Task<MutateRowsResult> BulkMutateRows(MutateRowsRequest request, ServerCallContext context)
    {
        CbtClient cbtClient = GetClient(request.ClientId, context);
        try
        {
            MutateRowsResponse response = await cbtClient.Client.MutateRowsAsync(request.Request);
            string message = "MutateRows succeeded";
            MutateRowsResult result = new MutateRowsResult
            {
                Status = SetSuccessStatus(message, context)
            };
            result.Entries.Add(response.Entries);
            return result;
        }
        catch (Exception e)
        {
            return new MutateRowsResult
            {
                Status = SetExceptionStatus(e, context)
            };
        }
    }

    public override async Task<CheckAndMutateRowResult> CheckAndMutateRow(CheckAndMutateRowRequest request, ServerCallContext context)
    {
        CbtClient cbtClient = GetClient(request.ClientId, context);
        try
        {
            CheckAndMutateRowResponse response = await cbtClient.Client.CheckAndMutateRowAsync(request.Request);
            string message = "CheckAndMutateRow succeeded";
            return new CheckAndMutateRowResult
            {
                Result = response,
                Status = SetSuccessStatus(message, context)
            };
        }
        catch (Exception e)
        {
            return new CheckAndMutateRowResult
            {
                Status = SetExceptionStatus(e, context)
            };
        }
    }

    public static CloudBigtableV2TestProxyImpl Create() => new();

    private CloudBigtableV2TestProxyImpl() => _idClientMap = new();

    private CbtClient GetClient(string clientId, ServerCallContext context)
    {
        GaxPreconditions.CheckArgument(clientId is not ("" or null), "ClientId", "client id must be provided", context);

        if (!_idClientMap.ContainsKey(clientId))
        {
            context.Status = new Status(StatusCode.NotFound, $"Client {clientId} not found.");
            throw new RpcException(context.Status);
        }
        return _idClientMap[clientId];
    }

    private void OverrideTimeoutSetting(long timeout, BigtableServiceApiSettings settings)
    {
        CallSettings callSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromSeconds(timeout)));
        settings.CheckAndMutateRowSettings = callSettings;
        settings.ExecuteQuerySettings = callSettings;
        settings.MutateRowSettings = callSettings;
        settings.MutateRowsSettings = callSettings;
        settings.ReadRowsSettings = callSettings;
        settings.ReadModifyWriteRowSettings = callSettings;
        settings.SampleRowKeysSettings = callSettings;
        settings.CallSettings = callSettings;
    }

    private static ChannelCredentials GetChannelCredentials(bool encrypted, string rootCertsPem, string accessToken)
    {
        if (accessToken is not null)
        {
            GoogleCredential googleCredential = GoogleCredential.FromAccessToken(accessToken);
            return encrypted
                ? ChannelCredentials.Create(new SslCredentials(rootCertsPem), googleCredential.ToCallCredentials())
                : googleCredential.ToChannelCredentials();
        }
        return encrypted ? new SslCredentials(rootCertsPem) : ChannelCredentials.Insecure;
    }

    private static Rpc.Status SetExceptionStatus(Exception e, ServerCallContext context)
    {
        context.Status = new Status(StatusCode.Internal, e.Message, e);
        return new Rpc.Status()
        {
            Code = (int) Rpc.Code.Internal,
            Message = e.Message
        };
    }

    private static Rpc.Status SetSuccessStatus(string message, ServerCallContext context)
    {
        context.Status = new Status(StatusCode.OK, message);
        return new Rpc.Status()
        {
            Code = (int) Rpc.Code.Ok,
            Message = message
        };
    }
}
