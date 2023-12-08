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

using Google.Apis.Logging;
using Google;
using Google.Cloud.BigQuery.V2;
using static Google.Apis.Http.ConfigurableMessageHandler;

if (args.Length != 3)
{
    Console.WriteLine("Arguments: <project-id> <dataset-id> <table-id>");
    return;
}

ApplicationContext.RegisterLogger(new ConsoleLogger(LogLevel.All));

string projectId = args[0];
string datasetId = args[1];
string tableId = args[2];

var schema = new TableSchemaBuilder
{
    { "id", BigQueryDbType.Int64 }
}.Build();

var client = BigQueryClient.Create(projectId);
var dataset = client.GetOrCreateDataset(datasetId);
var table = dataset.GetOrCreateTable(tableId, schema);
//var rows = Enumerable.Range(0, 10).Select(i => new BigQueryInsertRow { ["id"] = i });
//table.InsertRows(rows);

client.Service.HttpClient.MessageHandler.LogEvents =
    LogEventType.RequestBody | LogEventType.RequestUri |
    LogEventType.ResponseHeaders | LogEventType.ResponseBody;

var options = new ListRowsOptions { PageSize = 5 };
var list = table.ListRows(options).ToList();
Console.WriteLine($"Rows: {list.Count}");
