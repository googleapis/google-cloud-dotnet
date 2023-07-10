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

using Google.Cloud.Bigtable.Common.V2;
using Google.Cloud.Bigtable.V2;
using Google.Protobuf;
using Grpc.Auth;
using Grpc.Core;
using Grpc.Net.Client;
using System.Diagnostics;

if (args.Length < 3)
{
    Console.WriteLine("Command-line arguments: <project-id> <instance-id> <table-id> [x-goog-request-params value]");
    return;
}

Metadata metadata = new Metadata();
if (args.Length >= 4)
{
    metadata.Add("x-goog-request-params", args[3]);
}
var callOptions = new CallOptions(metadata);

TimeSpan delay = TimeSpan.FromSeconds(10);
string projectId = args[0];
string instanceId = args[1];
string tableId = args[2];
string endpoint = $"https://{BigtableServiceApiClient.DefaultEndpoint}";

var channelCredentials = await GoogleGrpcCredentials.GetApplicationDefaultAsync();
var channel = GrpcChannel.ForAddress(endpoint, new GrpcChannelOptions { Credentials = channelCredentials });

var invoker = channel.CreateCallInvoker();
Bigtable.BigtableClient grpcClient = new Bigtable.BigtableClient(invoker);

TableName TableName = new TableName(projectId, instanceId, tableId);
ReadRowsRequest readRowsRequest = new ReadRowsRequest
{
    TableNameAsTableName = TableName,
    Rows = new RowSet { RowKeys = { ByteString.CopyFromUtf8("invalid-rowId") } }
};

var stopwatch = Stopwatch.StartNew();
for (int requestId = 0; requestId < 1_000_000; requestId++)
{
    stopwatch.Restart();
    using var response = grpcClient.ReadRows(readRowsRequest, metadata);
    // Tight loop to read all values.
    while (await response.ResponseStream.MoveNext())
    {
    }
    var latencyTimerTicks = stopwatch.ElapsedTicks;
    var latencyMillis = latencyTimerTicks * 1_000 / Stopwatch.Frequency;
    Log($"Request: {requestId}; Latency millis: {latencyMillis}");
    await Task.Delay(delay);
}

void Log(string message) =>
    Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss.fff}: {message}");
