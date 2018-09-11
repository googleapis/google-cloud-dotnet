# Sed commands to use Google.Gax.Grpc.Gcp in
# BigtableServiceApiClient.cs

# Add a using directive
s/using gaxgrpc = .*/&\nusing gaxgrpcgcp = Google.Api.Gax.Grpc.Gcp;/

# Replace the channel pool declaration with a call invoker pool declaration
s/gaxgrpc::ChannelPool s_channelPool.*/gaxgrpcgcp::GcpCallInvokerPool s_callInvokerPool = new gaxgrpcgcp::GcpCallInvokerPool(DefaultScopes);/

# Replace channel acquisition with callInvoker acquision
s/grpccore::Channel channel = s_channelPool\.GetChannel\(endpoint \?\? DefaultEndpoint\)/grpccore::CallInvoker callInvoker = s_callInvokerPool.GetCallInvoker(endpoint ?? DefaultEndpoint, settings.CreateChannelOptions())/
s/grpccore::Channel channel = await s_channelPool\.GetChannelAsync\(endpoint \?\? DefaultEndpoint\)/grpccore::CallInvoker callInvoker = await s_callInvokerPool.GetCallInvokerAsync(endpoint ?? DefaultEndpoint, settings.CreateChannelOptions())/

# Replace channel pool shutdown with call invoker pool shutdown
s/s_channelPool\.ShutdownChannelsAsync/s_callInvokerPool.ShutdownChannelsAsync/

# Replace creation using a channel with creation using a call invoker
s/return Create\(channel, settings\);/return Create\(callInvoker, settings\);/
