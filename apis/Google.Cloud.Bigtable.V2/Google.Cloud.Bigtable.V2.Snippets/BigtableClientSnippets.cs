// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax.Grpc;
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2.Snippets
{
    [SnippetOutputCollector]
    public class BigtableClientSnippets
    {
        public void CheckAndMutateRow()
        {
            // Snippet: CheckAndMutateRow(TableName,RowKey,RowFilter,IEnumerable<Mutation>,IEnumerable<Mutation>,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            RowKey rowKey = "r1";
            RowFilter predicateFilter = RowFilters.Chain(
                RowFilters.FamilyNameRegex(@"cf\d"),
                RowFilters.ColumnQualifierRegex(@"[a-z]\d"),
                RowFilters.ValueRegex(@"test-value"));
            IEnumerable<Mutation> trueMutations = new Mutation[]
            {
                Mutations.SetCell("cf1", "c1", "test-value2", new BigtableVersion(2))
            };
            IEnumerable<Mutation> falseMutations = new Mutation[]
            {
                Mutations.DeleteFromFamily("cf1"),
                Mutations.SetCell("cf1", "c1", "test-value", new BigtableVersion(1))
            };
            // Make the request
            CheckAndMutateRowResponse response = bigtableClient.CheckAndMutateRow(
                tableName,
                rowKey,
                predicateFilter,
                trueMutations,
                falseMutations);

            if (response.PredicateMatched)
            {
                // The true mutations were applied...
            }
            else
            {
                // The false mutations were applied...
            }
            // End snippet

            // TODO: Verifications
        }

        public void CheckAndMutateRowWithParams()
        {
            // Snippet: CheckAndMutateRow(TableName,RowKey,RowFilter,Mutation[])
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            RowKey rowKey = "r1";
            RowFilter predicateFilter = RowFilters.Chain(
                RowFilters.FamilyNameRegex(@"cf\d"),
                RowFilters.ColumnQualifierRegex(@"[a-z]\d"),
                RowFilters.CellsPerRowLimit(1),
                RowFilters.VersionRange(new BigtableVersion(1), new BigtableVersion(25)));
            Mutation trueMutation1 = Mutations.DeleteFromFamily("cf1");
            Mutation trueMutation2 = Mutations.SetCell("cf1", "c1", "test-value2", new BigtableVersion(2));
            // Make the request
            CheckAndMutateRowResponse response = bigtableClient.CheckAndMutateRow(
                tableName,
                rowKey,
                predicateFilter,
                trueMutation1, trueMutation2);

            if (response.PredicateMatched)
            {
                // The true mutations were applied...
            }
            else
            {
                // The true mutations were not applied...
            }
            // End snippet

            // TODO: Verifications
        }

        public void MutateRow()
        {
            // Snippet: MutateRow(TableName,RowKey,IEnumerable<Mutation>,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            RowKey rowKey = new RowKey(12, 255, 0, 17, 1);
            IEnumerable<Mutation> mutations = new Mutation[]
            {
                Mutations.DeleteFromFamily("cf1"),
                Mutations.DeleteFromColumn("cf2", "c1", new BigtableVersionRange(null, new BigtableVersion(DateTime.UtcNow)))
            };
            // Make the request
            MutateRowResponse response = bigtableClient.MutateRow(
                tableName,
                rowKey,
                mutations);
            // End snippet

            // TODO: Verifications
        }

        public void MutateRowWithParams()
        {
            // Snippet: MutateRow(TableName,RowKey,Mutation[])
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            RowKey rowKey = new RowKey(12, 255, 0, 17, 1);
            Mutation mutation1 = Mutations.DeleteFromFamily("cf1");
            Mutation mutation2 =
                Mutations.DeleteFromColumn("cf2", "c1", new BigtableVersionRange(null, new BigtableVersion(DateTime.UtcNow)));
            // Make the request
            MutateRowResponse response = bigtableClient.MutateRow(
                tableName,
                rowKey,
                mutation1, mutation2);
            // End snippet

            // TODO: Verifications
        }

        public async Task MutateRows()
        {
            // Snippet: MutateRows(TableName,IEnumerable<MutateRowsRequest.Types.Entry>,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            IEnumerable<MutateRowsRequest.Types.Entry> entries = new MutateRowsRequest.Types.Entry[]
            {
                Mutations.CreateEntry("r1",
                    Mutations.DeleteFromFamily("cf1"),
                    Mutations.DeleteFromColumn("cf2", "c1", new BigtableVersionRange(null, new BigtableVersion(DateTime.UtcNow)))),
                Mutations.CreateEntry("r2",
                    Mutations.DeleteFromRow())
            };
            // Make the request
            BigtableClient.MutateRowsStream streamingResponse = bigtableClient.MutateRows(
                tableName,
                entries);

            // Read streaming responses from server until complete
            IAsyncEnumerator<MutateRowsResponse> responseStream = streamingResponse.ResponseStream;
            while (await responseStream.MoveNext())
            {
                MutateRowsResponse response = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet

            // TODO: Verifications
        }

        public async Task MutateRowsWithParams()
        {
            // Snippet: MutateRows(TableName,MutateRowsRequest.Types.Entry[])
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            MutateRowsRequest.Types.Entry entry1 = Mutations.CreateEntry("r1",
                Mutations.DeleteFromFamily("cf1"),
                Mutations.DeleteFromColumn("cf2", "c1", new BigtableVersionRange(null, new BigtableVersion(DateTime.UtcNow))));
            MutateRowsRequest.Types.Entry entry2 = Mutations.CreateEntry("r2",
                Mutations.DeleteFromRow());
            // Make the request
            BigtableClient.MutateRowsStream streamingResponse = bigtableClient.MutateRows(
                tableName,
                entry1, entry2);

            // Read streaming responses from server until complete
            IAsyncEnumerator<MutateRowsResponse> responseStream = streamingResponse.ResponseStream;
            while (await responseStream.MoveNext())
            {
                MutateRowsResponse response = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet

            // TODO: Verifications
        }

        public void ReadModifyWriteRow()
        {
            // Snippet: ReadModifyWriteRow(TableName,RowKey,IEnumerable<ReadModifyWriteRule>,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            RowKey rowKey = new RowKey(12, 255, 0, 17, 1);
            IEnumerable<ReadModifyWriteRule> rules = new ReadModifyWriteRule[]
            {
                ReadModifyWriteRules.Append("cf1", "c1", "_original"),
                ReadModifyWriteRules.Increment("cf1", "c2", 1)
            };
            // Make the request
            ReadModifyWriteRowResponse response = bigtableClient.ReadModifyWriteRow(
                tableName,
                rowKey,
                rules);
            Console.WriteLine($"Row key: {response.Row.Key.ToStringUtf8()}");
            foreach (Family family in response.Row.Families)
            {
                Console.WriteLine($"  Family name: {family.Name}");
                foreach (Column column in family.Columns)
                {
                    Console.WriteLine($"    Column qualifier: {column.Qualifier.ToStringUtf8()}");
                    foreach (Cell cell in column.Cells)
                    {
                        Console.WriteLine($"      New cell value: {cell.Value.ToStringUtf8()}");
                        Console.WriteLine($"      Timestamp: {cell.Version.ToDateTime()}");
                        Console.WriteLine($"      Labels: {string.Join(", ", cell.Labels)}");
                    }
                }
            }
            // End snippet

            // TODO: Verifications
        }

        public void ReadModifyWriteRowWithParams()
        {
            // Snippet: ReadModifyWriteRow(TableName,RowKey,ReadModifyWriteRule[])
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            RowKey rowKey = new RowKey(12, 255, 0, 17, 1);
            ReadModifyWriteRule rule1 = ReadModifyWriteRules.Append("cf1", "c1", "_original");
            ReadModifyWriteRule rule2 = ReadModifyWriteRules.Increment("cf1", "c2", 1);
            // Make the request
            ReadModifyWriteRowResponse response = bigtableClient.ReadModifyWriteRow(
                tableName,
                rowKey,
                rule1, rule2);
            Console.WriteLine($"Row key: {response.Row.Key.ToStringUtf8()}");
            foreach (Family family in response.Row.Families)
            {
                Console.WriteLine($"  Family name: {family.Name}");
                foreach (Column column in family.Columns)
                {
                    Console.WriteLine($"    Column qualifier: {column.Qualifier.ToStringUtf8()}");
                    foreach (Cell cell in column.Cells)
                    {
                        Console.WriteLine($"      New cell value: {cell.Value.ToStringUtf8()}");
                        Console.WriteLine($"      Timestamp: {cell.Version.ToDateTime()}");
                        Console.WriteLine($"      Labels: {string.Join(", ", cell.Labels)}");
                    }
                }
            }
            // End snippet

            // TODO: Verifications
        }

        public async Task ReadRows()
        {
            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;

            // Snippet: ReadRows(TableName,RowSet,RowFilter,long,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");

            // Read rows whose keys are greater than or equal to 'a' and less than 'b'.
            RowSet rows = RowSet.FromRowRanges(
                RowRange.ClosedOpen("a", "b"));
            // Only read cells from the "A" column family and only take the most recent cell from each column.
            RowFilter filter = RowFilters.Chain(
                RowFilters.FamilyNameRegex("A"),
                RowFilters.CellsPerColumnLimit(1));
            // Just read the first 10 rows.
            long rowsLimit = 10;

            // Make the request
            BigtableClient.ReadRowsStream streamingResponse = bigtableClient.ReadRows(
                tableName,
                rows,
                filter,
                rowsLimit,
                CallSettings.FromCancellationToken(cancellationToken));

            // Read streaming responses from server until complete
            IAsyncEnumerator<Row> responseStream = streamingResponse.GetRowsAsync(cancellationToken).GetEnumerator();
            while (await responseStream.MoveNext(cancellationToken))
            {
                Row row = responseStream.Current;

                Console.WriteLine($"Row key: {row.Key.ToStringUtf8()}");
                foreach (Family family in row.Families)
                {
                    Console.WriteLine($"  Family name: {family.Name}");
                    foreach (Column column in family.Columns)
                    {
                        Console.WriteLine($"    Column qualifier: {column.Qualifier.ToStringUtf8()}");
                        foreach (Cell cell in column.Cells)
                        {
                            Console.WriteLine($"      Cell value: {cell.Value.ToStringUtf8()}");
                            Console.WriteLine($"      Timestamp: {cell.Version.ToDateTime()}");
                            Console.WriteLine($"      Labels: {string.Join(", ", cell.Labels)}");
                        }
                    }
                }
            }
            // The response stream has completed
            // End snippet

            // TODO: Verifications
        }
    }
}
