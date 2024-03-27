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
using Google.Cloud.Firestore.V1;
using Grpc.Auth;
using Grpc.Core;
using Grpc.Net.Client;
using static Google.Cloud.Firestore.V1.Firestore;

if (args.Length != 2)
{
    Console.WriteLine("Arguments: <project-id> <collection-id>");
    return;
}

string projectId = args[0];
string collectionId = args[1];
List<string> logEntries = new();

var client = CreateClient();
var dbRoot = $"projects/{projectId}/databases/(default)";
var documents = await GetDocuments();
Log($"Fetched {documents.Count} documents, e.g. '{documents.FirstOrDefault()}'");

// Now create all the listeners, wait for 10 seconds logging what they receive, then stop.
var cts = new CancellationTokenSource();
int listenersWithResponses = 0;
var listeners = documents.Select(StartListener).ToList();
Thread.Sleep(10000);
cts.Cancel();
await Task.WhenAll(listeners);
Log($"Listeners with responses: {listenersWithResponses}");

logEntries.ForEach(Console.WriteLine);

// Helper local functions below here...

async Task<List<string>> GetDocuments()
{
    var request = new ListDocumentsRequest
    {
        CollectionId = collectionId,
        Parent = $"{dbRoot}/documents",
        ShowMissing = true,
        PageSize = 1000,
        Mask = new DocumentMask()
    };
    var metadata = new Metadata { { "google-cloud-resource-prefix", dbRoot } };
    var response = await client.ListDocumentsAsync(request, metadata);
    if (response.NextPageToken != "")
    {
        throw new Exception("Got a page token: didn't receive all the documents in one call.");
    }
    return response.Documents.Select(doc => doc.Name).ToList();
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

async Task StartListener(string doc, int index)
{
    await Task.Yield();
    string operation = "None";
    try
    {
        Log($"Listener {index} is for document {doc.Split('/').Last()}");
        operation = "Listen";
        var metadata = new Metadata { { "google-cloud-resource-prefix", dbRoot } };
        var grpcCall = client.Listen(metadata);
        var request = new ListenRequest
        {
            AddTarget = new Target
            {
                Documents = new Target.Types.DocumentsTarget { Documents = { doc } },
                TargetId = 0x4323
            },
            Database = dbRoot
        };
        operation = "Write";
        await grpcCall.RequestStream.WriteAsync(request, cts.Token);
        Log($"Listener {index}: Sent request");

        operation = "MoveNext";
        bool anyResponses = false;
        while (await grpcCall.ResponseStream.MoveNext(cts.Token))
        {
            if (!anyResponses)
            {
                Interlocked.Increment(ref listenersWithResponses);
                anyResponses = true;
            }
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

FirestoreClient CreateClient()
{
    string[] scopes = 
    {
        "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/datastore",
    };
    var cred = GoogleCredential.GetApplicationDefault().CreateScoped(scopes);
    if (cred.UnderlyingCredential is ServiceAccountCredential serviceCredential)
    {
        cred = GoogleCredential.FromServiceAccountCredential(serviceCredential.WithUseJwtAccessWithScopes(true));
    }
    var channelOptions = new GrpcChannelOptions
    {
        Credentials = cred.ToChannelCredentials()
    };
    var channel = GrpcChannel.ForAddress("https://firestore.googleapis.com", channelOptions);
    return new FirestoreClient(channel);
}
