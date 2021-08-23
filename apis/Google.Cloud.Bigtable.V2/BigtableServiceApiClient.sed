# Sed commands to use Google.Gax.Grpc.Gcp in
# BigtableServiceApiClient.g.cs

# Replace uses of the gRPC generated client, which is still BigtableClient
s/BigtableServiceApi.BigtableServiceApiClient/Bigtable.BigtableClient/g

# Replace channel acquisition with callInvoker acquision
s/grpccore::Channel channel = ChannelPool\.GetChannel\(endpoint \?\? DefaultEndpoint\)/grpccore::CallInvoker callInvoker = CallInvokerPool.GetCallInvoker(endpoint ?? DefaultEndpoint, settings.CreateChannelOptions())/
s/grpccore::Channel channel = await ChannelPool\.GetChannelAsync\(endpoint \?\? DefaultEndpoint\)/grpccore::CallInvoker callInvoker = await CallInvokerPool.GetCallInvokerAsync(endpoint ?? DefaultEndpoint, settings.CreateChannelOptions())/

# Replace channel pool shutdown with call invoker pool shutdown
s/ChannelPool\.ShutdownChannelsAsync/CallInvokerPool.ShutdownChannelsAsync/

# Replace creation using a channel with creation using a call invoker
s/return Create\(channel, settings\);/return Create\(callInvoker, settings\);/
