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

using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Grpc.Auth;
using Grpc.Core;
using Grpc.Net.Client;

if (args.Length != 2)
{
    Console.WriteLine("Arguments: <project-id> <collection-id>");
    return;
}

string projectId = args[0];
string collectionId = args[1];

// Find the document references using the "normal" Firestore client.
var db = FirestoreDb.Create(projectId);
var collection = db.Collection(collectionId);
var references = await GetDocumentReferences();

// Create a "raw" client using the same credentials.
// (This is extracted into a separate local function so we can easily create multiple ones
// if we want to.)
var rawClient = CreateRawClient();

// Now create all the listeners, wait for 10 seconds logging what they receive, then stop.
List<string> logEntries = new();
var cts = new CancellationTokenSource();
var listeners = references.Select(StartListener).ToList();
Thread.Sleep(10000);
cts.Cancel();
await Task.WhenAll(listeners);
logEntries.ForEach(Console.WriteLine);

// Helper local functions below here...

async Task<List<DocumentReference>> GetDocumentReferences()
{
    var snapshot = await collection.GetSnapshotAsync();
    return snapshot.Documents.Select(doc => doc.Reference).ToList();
}

// We don't write to the console during the test, to avoid threading oddities.
void Log(string message)
{
    lock (logEntries)
    {
        string fullMessage = $"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss.ffffff}Z {message}";
        logEntries.Add(fullMessage);
    }
}

async Task StartListener(DocumentReference doc, int index)
{
    await Task.Yield();
    string operation = "None";
    try
    {
        var client = rawClient;
        Log($"Listener {index} is for document {doc.Id}");
        operation = "Listen";
        var dbRoot = $"projects/{db.ProjectId}/databases/{db.DatabaseId}";
        var metadata = new Metadata { { "google-cloud-resource-prefix", dbRoot } };
        var grpcCall = client.Listen(metadata);
        var request = new ListenRequest
        {
            AddTarget = new Target
            {
                Documents = new Target.Types.DocumentsTarget { Documents = { doc.Path } },
                TargetId = 0x4323
            },
            Database = dbRoot
        };
        operation = "Write";
        await grpcCall.RequestStream.WriteAsync(request, cts.Token);
        Log($"Listener {index}: Sent request");

        operation = "MoveNext";
        while (await grpcCall.ResponseStream.MoveNext(cts.Token))
        {
            var response = grpcCall.ResponseStream.Current;
            Log($"Listener {index} received response type {response.ResponseTypeCase}");
        }
        Log($"Listener {index} reached the end of the stream");
    }
    catch (RpcException rpcEx) when (rpcEx.StatusCode == StatusCode.Cancelled)
    {
        Log($"Listener {index}: RPC for '{operation}' canceled");
    }
    catch (OperationCanceledException)
    {
        Log($"Listener {index}: operation '{operation}' canceled");
    }
    catch (Exception ex)
    {
        Log($"Listener {index}: operation '{operation}' failed with exception:\r\n{ex}");
    }
}

Firestore.FirestoreClient CreateRawClient()
{
    var cred = GoogleCredential.GetApplicationDefault().CreateScoped(FirestoreClient.DefaultScopes);
    if (cred.UnderlyingCredential is ServiceAccountCredential serviceCredential)
    {
        cred = GoogleCredential.FromServiceAccountCredential(serviceCredential.WithUseJwtAccessWithScopes(true));
    }
    var channelOptions = new GrpcChannelOptions
    {
        Credentials = cred.ToChannelCredentials()
    };
    var channel = GrpcChannel.ForAddress("https://firestore.googleapis.com", channelOptions);
    return new Firestore.FirestoreClient(channel);
}
