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

using Google.Api.Gax.Grpc;
using Google.Cloud.Firestore;

if (args.Length != 2)
{
    Console.WriteLine("Arguments: <project-id> <collection-id>");
    return;
}

string projectId = args[0];
string collectionId = args[1];

// Workaround for https://github.com/googleapis/google-cloud-dotnet/issues/12318
var db = new FirestoreDbBuilder
{
    ProjectId = projectId,
    GrpcAdapter = GrpcNetClientAdapter.Default.WithAdditionalOptions(ExactVersionHandler.ModifyGrpcChannelOptions)
}.Build();

var collection = db.Collection(collectionId);
var snapshot = await collection.GetSnapshotAsync();
var references = snapshot.Documents.Select(doc => doc.Reference).ToList();

int callCount = 0;
int resultCount = 0;
foreach (var docRef in references)
{
    Interlocked.Increment(ref callCount);
    docRef.Listen(_ => Interlocked.Increment(ref resultCount));
}

Thread.Sleep(10000);

Console.WriteLine($"Calls: {callCount}; Results: {resultCount}");

/// <summary>
/// Delegating handler which enforces that messages are sent with HttpVersionPolicy.RequestVersionExact.
/// </summary>
internal class ExactVersionHandler : DelegatingHandler
{
    internal ExactVersionHandler(HttpMessageHandler handler) : base(handler)
    {
    }

    /// <summary>
    /// Convenience method to be used from GrpcNetClientAdapter.WithAdditionalOptions.
    /// </summary>
    internal static void ModifyGrpcChannelOptions(Grpc.Net.Client.GrpcChannelOptions options) =>
        options.HttpHandler = new ExactVersionHandler(new SocketsHttpHandler { EnableMultipleHttp2Connections = true });

    // Note: gRPC never calls the synchronous method.
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.VersionPolicy = HttpVersionPolicy.RequestVersionExact;
        return base.SendAsync(request, cancellationToken);
    }
}
