// Copyright 2016 Google Inc
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http: *www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Linq;
using static Google.Datastore.V1Beta3.CommitRequest.Types;
using static Google.Datastore.V1Beta3.Key.Types;
using static Google.Datastore.V1Beta3.PropertyOrder.Types;

namespace Google.Datastore.V1Beta3.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Required arguments: <project-id> <message>");
                return;
            }
            var projectId = args[0];
            var text = args[1];
            Console.WriteLine($"Using projectId = {projectId}; text = {text}");
            var client = DatastoreClient.Create();

            var partitionId = new PartitionId { ProjectId = projectId };
            // First insert the message
            var entity = new Entity
            {
                Key = new Key { PartitionId = partitionId, Path = { new PathElement { Kind = "message" } } },
                ["created"] = DateTime.UtcNow,
                ["text"] = args[1],
            };

            var transaction = client.BeginTransaction(projectId).Transaction;
            var commitResponse = client.Commit(projectId, Mode.TRANSACTIONAL, transaction, new[] { entity.ToInsert() });
            var insertedKey = commitResponse.MutationResults[0].Key;

            Console.WriteLine($"Inserted entity with key {insertedKey}");
            Console.WriteLine();

            // Check we can look it up...
            var lookupResponse = client.Lookup(projectId, null, new[] { insertedKey });
            if (lookupResponse.Found.Count == 1)
            {
                var retrieved = lookupResponse.Found[0];
                Console.WriteLine($"Looked up entity: {retrieved}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Unable to look up inserted entity!");
                Console.WriteLine();
            }

            // Then list the first page of messages
            // TODO: Hook into page-streaming...
            var query = new Query
            {
                Limit = 20,
                Order = { new PropertyOrder { Direction = Direction.DESCENDING, Property = new PropertyReference { Name = "created" } } },
                Kind = { new KindExpression { Name = "message" } }
            };
            var result = client.RunQuery(projectId, partitionId, null, query);
            Console.WriteLine("Query results:");
            foreach (var resultEntity in result.Batch.EntityResults.Select(er => er.Entity))
            {
                var created = (DateTime)resultEntity["created"];
                var resultText = (string)resultEntity["text"];
                Console.WriteLine($"{created:yyyy-MM-dd'T'HH:mm:ss'Z'}: {resultText}");
            }
        }
    }
}
