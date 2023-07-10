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

using Google.Cloud.BigQuery.V2;
using System.Diagnostics;

if (args.Length != 7)
{
    Console.WriteLine("Arguments: <project-id> <dataset-id> <table-id> <text-fields-per-row> <text-length-per-field> <total-rows> <rows-per-insert>");
    return;
}

Random rng = new Random();
string projectId = args[0];
string datasetId = args[1];
string tableId = args[2];
int textFieldCount = int.Parse(args[3]);
int textLengthPerField = int.Parse(args[4]);
int totalRows = int.Parse(args[5]);
int rowsPerInsert = int.Parse(args[6]);

var client = BigQueryClient.Create(args[0]);
var dataset = client.GetOrCreateDataset(datasetId);

var schemaBuilder = new TableSchemaBuilder
{
    { "id", BigQueryDbType.Int64 }
};
for (int i = 0; i < textFieldCount; i++)
{
    schemaBuilder.Add($"text{i}", BigQueryDbType.String);
}
var table = dataset.GetOrCreateTable(tableId, schemaBuilder.Build());

var stopwatch = Stopwatch.StartNew();
int insertedRows = 0;
for (int insertCount = 0; insertedRows < totalRows; insertCount++)
{
    if (insertCount % 10 == 0)
    {
        Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss} Inserted {insertedRows} rows");
    }
    var rows = Enumerable.Range(insertedRows, rowsPerInsert).Select(GenerateRow);
    table.InsertRows(rows);
    insertedRows += rowsPerInsert;
}
stopwatch.Stop();

// Write an easy-to-copy-paste summary
Console.WriteLine();
Console.WriteLine($"Text fields per row (in addition to ID): {textFieldCount}");
Console.WriteLine($"Size of text per field: {textLengthPerField}");
Console.WriteLine($"Rows per insert: {rowsPerInsert}");
Console.WriteLine($"Total rows inserted: {insertedRows}");
Console.WriteLine($"Time taken (seconds): {(int) stopwatch.Elapsed.TotalSeconds}");

BigQueryInsertRow GenerateRow(int id)
{
    var row = new BigQueryInsertRow(Guid.NewGuid().ToString())
    {
        { "id", id },
    };
    for (int i = 0; i < textFieldCount; i++)
    {
        row[$"text{i}"] = GenerateText();
    }
    return row;
}

string GenerateText()
{
    char[] chars = new char[textLengthPerField];
    for (int i = 0; i < chars.Length; i++)
    {
        // Printable ASCII
        chars[i] = (char) (rng.Next(' ', 128));
    }
    return new string(chars);
}
