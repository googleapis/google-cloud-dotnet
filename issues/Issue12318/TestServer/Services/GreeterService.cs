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

using Grpc.Core;
using TestProtos;

namespace TestServer.Services;
public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override async Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        await Task.Delay(10000);
        return new HelloReply { Message = $"Hello {request.Name}" };
    }

    public override async Task StreamingHello(IAsyncStreamReader<HelloRequest> requestStream, IServerStreamWriter<HelloReply> responseStream, ServerCallContext context)
    {
        await responseStream.WriteAsync(new HelloReply { Message = "Before ping-pong " });
        await foreach (var request in requestStream.ReadAllAsync())
        {
            await responseStream.WriteAsync(new HelloReply { Message = $"Hello {request.Name}" });
        }
        await responseStream.WriteAsync(new HelloReply { Message = "After ping-pong " });
    }
}
