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
using Grpc.Net.Client;
using TestProtos;

if (args.Length != 1)
{
    Console.WriteLine("Argument: local port");
    return;
}
string port = args[0];

var channel = GrpcChannel.ForAddress($"http://localhost:{port}");
var client = new Greeter.GreeterClient(channel);

var tasks = new List<Task>();
var totalResponses = 0;
Log("Starting requests");
for (int i = 0; i < 300; i++)
{
    tasks.Add(StreamHello(i));

    tasks.Add(client.SayHelloAsync(new HelloRequest { Name = $"Test {i}" }).ResponseAsync);
}

Log("Created all requests");

await Task.WhenAll(tasks);

Log($"Received all responses. Total: {totalResponses}");


void Log(string message) =>
    Console.WriteLine($"{DateTime.UtcNow:yyyy-MM-ss'T'HH:mm:ss.fff} {message}");

async Task StreamHello(int index)
{
    using var call = client.StreamingHello();
    await call.RequestStream.WriteAsync(new HelloRequest { Name = $"First {index}" });
    await Task.Delay(5000);
    await call.RequestStream.WriteAsync(new HelloRequest { Name = $"Last {index}" });
    await call.RequestStream.CompleteAsync();

    await foreach (var response in call.ResponseStream.ReadAllAsync())
    {
        Interlocked.Increment(ref totalResponses);
    }
}
