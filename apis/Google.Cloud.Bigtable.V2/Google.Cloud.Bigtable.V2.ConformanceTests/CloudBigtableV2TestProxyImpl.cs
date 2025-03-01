using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.Grpc.Gcp;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Bigtable.Common.V2;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2.ConformanceTests;

public class CloudBigtableV2TestProxyImpl : CloudBigtableV2TestProxy.CloudBigtableV2TestProxyBase
{
    private readonly Dictionary<string, CbtClient> _idClientMap;

    private CloudBigtableV2TestProxyImpl() => _idClientMap = new();

    private static void CheckArgument(bool condition, string message, ServerCallContext context)
    {
        if (!condition)
        {
            context.Status = new Status(StatusCode.InvalidArgument, message);
            throw new RpcException(context.Status);
        }
    }

    private static ChannelCredentials GetChannelCredentials(bool encrypted, string rootCertsPem) => encrypted ? new SslCredentials(rootCertsPem) : ChannelCredentials.Insecure;

    public static CloudBigtableV2TestProxyImpl Create() => new();

    protected class CbtClient
    {
        public BigtableClient client { get; set; }
        public GcpCallInvoker callInvoker { get; set; }
        public InstanceName instanceName { get; set; }
    }

    private CbtClient GetClient(string clientId, ServerCallContext context)
    {
        if (!_idClientMap.ContainsKey(clientId))
        {
            context.Status = new Status(StatusCode.NotFound, $"Client {clientId} not found.");
            throw new RpcException(context.Status);
        }
        return _idClientMap[clientId];
    }

    public override async Task<CreateClientResponse> CreateClient(CreateClientRequest request, ServerCallContext context)
    {
        string clientId = request.ClientId;
        string projectId = request.ProjectId;
        string instanceId = request.InstanceId;
        string dataTarget = request.DataTarget;
        CreateClientRequest.Types.SecurityOptions securityOptions = request.SecurityOptions;

        CheckArgument(clientId is not ("" or null), "client id must be provided", context);
        CheckArgument(projectId is not ("" or null), "project id must be provided", context);
        CheckArgument(instanceId is not ("" or null), "instance id must be provided", context);
        CheckArgument(dataTarget is not ("" or null), "data target must be provided", context);
        CheckArgument(!securityOptions.UseSsl
            || (securityOptions.SslRootCertsPem is not ("" or null)),
            "security_options.ssl_root_certs_pem must be provided if security_options.use_ssl is true", context);

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
                Expiration exp = Expiration.FromTimeout(TimeSpan.FromSeconds(request.PerOperationTimeout.Seconds));
                settings.CallSettings = CallSettings.FromExpiration(exp);
            }

            BigtableServiceApiClientBuilder builder = new BigtableServiceApiClientBuilder
            {
                Settings = settings
            };
            if (dataTarget != "emulator")
            {
                string accessToken = request.SecurityOptions.AccessToken;
                builder.Endpoint = dataTarget;
                builder.ChannelCredentials = GetChannelCredentials(securityOptions.UseSsl, securityOptions.SslRootCertsPem); ;
                builder.GrpcChannelOptions = (securityOptions.UseSsl && securityOptions.SslEndpointOverride is not null)
                    ? GrpcChannelOptions.Empty.WithCustomOption("grpc.ssl_target_name_override", securityOptions.SslEndpointOverride)
                    : GrpcChannelOptions.Empty; ;
                builder.GoogleCredential = accessToken is not null ? GoogleCredential.FromAccessToken(accessToken) : GoogleCredential.GetApplicationDefault();
            }
            else
            {
                builder.EmulatorDetection = EmulatorDetection.EmulatorOnly;
            }
            InstanceName instanceName = new InstanceName(projectId, instanceId);
            GcpCallInvoker callInvoker = builder.CreateGcpCallInvoker();
            builder.CallInvoker = callInvoker;

            CbtClient cbtClient = new CbtClient
            {
                client = BigtableClient.Create(await builder.BuildAsync()),
                callInvoker = callInvoker,
                instanceName = instanceName
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
        string clientId = request.ClientId;
        CheckArgument(clientId is not ("" or null), "client id must be provided", context);

        CbtClient cbtClient = GetClient(clientId, context);
        try
        {
            await cbtClient.callInvoker.ShutdownAsync();
        }
        catch (Exception e)
        {
            context.Status = new Status(StatusCode.Internal, e.Message, e);
            throw new RpcException(context.Status);
        }
        context.Status = new Status(StatusCode.OK, "CloseClient succeeded");
        return new CloseClientResponse();
    }

    public override async Task<RemoveClientResponse> RemoveClient(RemoveClientRequest request, ServerCallContext context)
    {
        string clientId = request.ClientId;
        CheckArgument(clientId is not ("" or null), "client id must be provided", context);
        bool removed = await Task.Run(() => _idClientMap.Remove(clientId)).ConfigureAwait(false);
        if (!removed)
        {
            context.Status = new Status(StatusCode.NotFound, $"Client {clientId} not found.");
            throw new RpcException(context.Status);
        }
        context.Status = new Status(StatusCode.OK, "RemoveClient succeeded");
        return new RemoveClientResponse();
    }

    public override async Task<RowResult> ReadRow(ReadRowRequest request, ServerCallContext context)
    {
        string clientId = request.ClientId;
        CheckArgument(clientId is not ("" or null), "client id must be provided", context);

        CbtClient cbtClient = GetClient(clientId, context);

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
            Row row = await cbtClient.client.ReadRowAsync(tableName,
                new BigtableByteString(Encoding.UTF8.GetString(Encoding.Default.GetBytes(request.RowKey))),
                request.Filter);
            string message = row is null ? $"ReadRow didn't find row: {request.RowKey}" : "ReadRow succeeded";
            context.Status = new Status(StatusCode.OK, message);
            return new RowResult
            {
                Row = row,
                Status = new Rpc.Status()
                {
                    Code = (int) Rpc.Code.Ok,
                    Message = message
                }
            };
        }
        catch (Exception e)
        {
            context.Status = new Status(StatusCode.Internal, e.Message, e);
            return new RowResult
            {
                Status = new Rpc.Status()
                {
                    Code = (int) Rpc.Code.Internal,
                    Message = e.Message
                }
            };
        }
    }
}
