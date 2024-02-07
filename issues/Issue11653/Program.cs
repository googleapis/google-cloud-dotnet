// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
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

using Google.Api.Gax;
using Google.Cloud.Firestore;
using Grpc.Core;

if (args.Length != 2)
{
    Console.WriteLine("Arguments: <emulator-host> <project-id>");
    Console.WriteLine("(The FIRESTORE_EMULATOR_HOST environment variable is ignored.)");
    return;
}

Environment.SetEnvironmentVariable("FIRESTORE_EMULATOR_HOST", args[0]);

var db = new FirestoreDbBuilder
{
    ProjectId = args[1],
    EmulatorDetection = EmulatorDetection.EmulatorOnly
}.Build();

await Try("List collections", () => db.ListRootCollectionsAsync().ToListAsync().AsTask());
await Try("Add document", () => db.Collection("test").Document("doc").SetAsync(new { Name = "test" }));
await Try("Get document", () => db.Collection("test").Document("doc").GetSnapshotAsync());

async Task Try(string description, Func<Task> taskProvider)
{
    try
    {
        await taskProvider();
        Console.WriteLine($"'{description}' RPC succeeded");
    }
    catch (RpcException e)
    {
        Console.WriteLine($"'{description}' RPC failed: {e.Message}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"'{description}' failed more dramatically: {e.GetType()}: {e.Message}");
    }
}
