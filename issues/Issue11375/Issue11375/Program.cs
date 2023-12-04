// Copyright 2023 Google LLC
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

using Google.Cloud.Datastore.V1;

if (args.Length != 2)
{
    Console.WriteLine("Arguments: <projectid> <databaseid> - the database should already exist");
    return;
}
string projectId = args[0];
string databaseId = args[1];

var builder = new DatastoreDbBuilder
{
    ProjectId = projectId,
    DatabaseId = databaseId,

};
var datastore = builder.Build();
var keyFactory = datastore.CreateKeyFactory("TestKey");

// Close enough to random for our purposes.
long entityId = DateTime.UtcNow.Ticks;
Key entityKey = keyFactory.CreateKey(entityId);

await InsertEntity();
await LookupEntityWithoutTransaction();
await LookupEntityWithTransaction();

async Task InsertEntity()
{
    Console.WriteLine("Inserting entity");
    string guid = Guid.NewGuid().ToString();
    var entity = new Entity
    {
        Key = entityKey,
        Properties =
        {
            ["guid"] = guid,
        }
    };
    await datastore.InsertAsync(entity);
    Console.WriteLine($"Inserted entity with guid '{guid}'");
}

async Task LookupEntityWithoutTransaction()
{
    Console.WriteLine("Looking up entity without a transaction");
    var entity = await datastore.LookupAsync(entityKey);
    Console.WriteLine(entity is null
        ? "Entity lookup returned null"
        : $"Entity lookup returned entity with guid '{entity["guid"].StringValue}'");
}

async Task LookupEntityWithTransaction()
{
    Console.WriteLine("Looking up entity with a transaction");
    using var transaction = await datastore.BeginTransactionAsync();
    var entity = await transaction.LookupAsync(entityKey);
    Console.WriteLine(entity is null
        ? "Entity lookup returned null"
        : $"Entity lookup returned entity with guid '{entity["guid"].StringValue}'");
}
