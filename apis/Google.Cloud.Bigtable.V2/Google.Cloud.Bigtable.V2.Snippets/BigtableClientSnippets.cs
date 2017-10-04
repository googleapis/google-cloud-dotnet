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
            BigtableByteString rowKey = "r1";
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
            // Make the request
            CheckAndMutateRowResponse response = bigtableClient.CheckAndMutateRow(
                new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                "r1",
                // If the latest value in the "name:missing" column is "yes"...
                RowFilters.Chain(
                    RowFilters.FamilyNameRegex(@"name"),
                    RowFilters.ColumnQualifierRegex(@"missing"),
                    RowFilters.CellsPerRowLimit(1),
                    RowFilters.ValueRegex("yes")),
                // ...remove that marker value and insert the name.
                Mutations.DeleteFromColumn("name", "missing"),
                Mutations.SetCell("name", "first_name", "Alex", new BigtableVersion(1)),
                Mutations.SetCell("name", "last_name", "Trebek", new BigtableVersion(1)));

            if (response.PredicateMatched)
            {
                Console.WriteLine("The name has been set");
            }
            else
            {
                Console.WriteLine("The name was already present");
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
            BigtableByteString rowKey = new BigtableByteString(12, 255, 0, 17, 1);
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
            // Make the request
            MutateRowResponse response = bigtableClient.MutateRow(
                new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                new byte[] { 12, 255, 0, 17 },
                // Delete all cells from the column family "history",
                Mutations.DeleteFromFamily("history"),
                // and all cells from the "metrics:clicks" column which are older than a day (assuming UTC
                // timestamp micros have been used as version values in this column).
                Mutations.DeleteFromColumn(
                    "metrics",
                    "clicks",
                    new BigtableVersionRange(null, new BigtableVersion(DateTime.UtcNow.AddDays(-1)))));
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
                foreach (MutateRowsResponse.Types.Entry entry in response.Entries)
                {
                    switch (entry.Index)
                    {
                        case 0:
                            Console.WriteLine($"The mutations to row 'r1' finished with status code {entry.Status.Code}");
                            break;
                        case 1:
                            Console.WriteLine($"The mutations to row 'r2' finished with status code {entry.Status.Code}");
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
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
            // Make the request
            BigtableClient.MutateRowsStream streamingResponse = bigtableClient.MutateRows(
                new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                // From row 'r1'...
                Mutations.CreateEntry("r1",
                    // delete all cells from the column family "history",
                    Mutations.DeleteFromFamily("history"),
                    // and all cells from the "metrics:clicks" column which are older than a day (assuming UTC
                    // timestamp micros have been used as version values in this column).
                    Mutations.DeleteFromColumn(
                        "metrics",
                        "clicks",
                        new BigtableVersionRange(null, new BigtableVersion(DateTime.UtcNow.AddDays(-1))))),
                // Delete all cells from row 'r2'
                Mutations.CreateEntry("r2", Mutations.DeleteFromRow()));

            // Read streaming responses from server until complete
            IAsyncEnumerator<MutateRowsResponse> responseStream = streamingResponse.ResponseStream;
            while (await responseStream.MoveNext())
            {
                MutateRowsResponse response = responseStream.Current;
                foreach (MutateRowsResponse.Types.Entry entry in response.Entries)
                {
                    switch (entry.Index)
                    {
                        case 0:
                            Console.WriteLine($"The mutations to row 'r1' finished with status code {entry.Status.Code}");
                            break;
                        case 1:
                            Console.WriteLine($"The mutations to row 'r2' finished with status code {entry.Status.Code}");
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
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
            BigtableByteString rowKey = new BigtableByteString(12, 255, 0, 17, 1);
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
            // Make the request
            ReadModifyWriteRowResponse response = bigtableClient.ReadModifyWriteRow(
                new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                "user12345",
                ReadModifyWriteRules.Append("save_data", "name", "_previous"),
                ReadModifyWriteRules.Increment("metrics", "saves", 1));

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

        public void ReadRow()
        {
            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;

            // Snippet: ReadRows(TableName,RowSet,RowFilter,long,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();

            // Make the request
            Row row = bigtableClient.ReadRow(
                new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                "r1",
                // Only read cells from the "A0" through "A9" column families and only take the
                // most recent cell from each column.
                RowFilters.Chain(
                    RowFilters.FamilyNameRegex(@"A\d"),
                    RowFilters.CellsPerColumnLimit(1)),
                CallSettings.FromCancellationToken(cancellationToken));

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
            // The response stream has completed
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

        public async Task SampleRowKeys()
        {
            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;

            // Snippet: ReadRows(TableName,RowSet,RowFilter,long,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");

            // Make the request
            BigtableClient.SampleRowKeysStream streamingResponse = bigtableClient.SampleRowKeys(
                tableName,
                CallSettings.FromCancellationToken(cancellationToken));

            // Read streaming responses from server until complete
            IAsyncEnumerator<SampleRowKeysResponse> responseStream = streamingResponse.ResponseStream;
            long previousRowOffsetBytes = 0;
            while (await responseStream.MoveNext(cancellationToken))
            {
                SampleRowKeysResponse response = responseStream.Current;

                long appoxStorageBetweenPreviousSample = response.OffsetBytes - previousRowOffsetBytes;

                Console.WriteLine($"Row key: {response.RowKey}, at offset ${response.OffsetBytes}");
                Console.WriteLine($"  Approximate bytes since previous row sample: ${appoxStorageBetweenPreviousSample}"); 

                previousRowOffsetBytes = response.OffsetBytes;
            }
            // The response stream has completed
            // End snippet

            // TODO: Verifications
        }
    }
}
