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

using Avro;
using Avro.Generic;
using Avro.IO;
using Google.Api.Gax.ResourceNames;
using Google.Cloud.BigQuery.Storage.V1;
using Google.Cloud.BigQuery.V2;
using Google.Cloud.ClientTesting;
using Google.Cloud.Tools.Snippets;
using Google.Protobuf;
using Google.Type;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.BigQuery.Storage.V1.AppendRowsRequest.Types;

namespace Google.Cloud.Docs.Snippets;

[SnippetOutputCollector]
[Collection(nameof(SnippetFixture))]
public class StreamingSnippets
{
    private readonly SnippetFixture _fixture;

    public StreamingSnippets(SnippetFixture fixture) =>
        _fixture = fixture;

    [Fact]
    public async Task ServerStreaming()
    {
        // Used in the local method; declared here to avoid them being shown in the sample.
        DefaultReader reader = null;
        int totalRows = 0;
        string projectId = _fixture.ProjectId;

        // Sample: ServerStreaming
        BigQueryReadClient client = BigQueryReadClient.Create();

        // Create a read session and return the name of a stream from it.
        // (The details are unimportant for this sample.)
        ReadStreamName streamName = await PrepareQuery(client);

        // Make the streaming RPC, which will return responses asynchronously.
        // The using statement ensures that we dispose of the call at the end.
        using BigQueryReadClient.ReadRowsStream readRowsStream = client.ReadRows(streamName, offset: 0);

        // Asynchronously iterate over all the responses in the stream, processing each one in a
        // separate method (not shown in this sample).
        await foreach (ReadRowsResponse response in readRowsStream.GetResponseStream())
        {
            ProcessResponse(response);
        }
        // End sample

        // At the time of writing, this is 249. It's plausible that it may change,
        // so let's test in a fairly loose way.
        Assert.InRange(totalRows, 240, 270);

        void ProcessResponse(ReadRowsResponse response)
        {
            Console.WriteLine($"Start of response");
            var bytes = response.AvroRows.SerializedBinaryRows;
            if (reader is null && response.AvroSchema is not null)
            {
                var schema = Schema.Parse(response.AvroSchema.Schema);
                Console.WriteLine($"Read schema: {schema.Name}");
                reader = new DefaultReader(schema, schema);
            }

            if (reader is not null)
            {
                var decoder = new BinaryDecoder(new MemoryStream(bytes.ToArray()));
                for (int i = 0; i < response.RowCount; i++)
                {
                    var record = reader.Read<GenericRecord>(reuse: null, decoder);
                    Console.WriteLine($"Row {i}:");
                    foreach (var field in record.Schema.Fields)
                    {
                        Console.WriteLine($"{field.Name}: {record[field.Name]}");
                    }
                    totalRows++;
                }
            }
            Console.WriteLine($"End of response");
        }

        async Task<ReadStreamName> PrepareQuery(BigQueryReadClient client)
        {
            CreateReadSessionRequest createSessionRequest = new CreateReadSessionRequest
            {
                MaxStreamCount = 1,
                ParentAsProjectName = new ProjectName(projectId),
                ReadSession = new ReadSession
                {
                    DataFormat = DataFormat.Avro,
                    TableAsTableName = new TableName("bigquery-public-data", "country_codes", "country_codes")
                }
            };
            ReadSession session = await client.CreateReadSessionAsync(createSessionRequest);
            return session.Streams[0].ReadStreamName;
        }
    }

    [Fact]
    public async Task BidirectionalStreaming()
    {
        // Populated in the ProcessResponsesAsync
        int totalResponses = 0;
        int errorResponses = 0;

        string projectId = _fixture.ProjectId;
        string datasetId = IdGenerator.FromDateTime(prefix: "test_");
        string tableId = "write_test";

        // The storage write API forces us to write proto messages.
        // LocalizedText is a handy message with two string fields - nice
        // and easy to describe in a schema and populate with test data.
        var bqClient = BigQueryClient.Create(projectId);
        var dataset = bqClient.CreateDataset(datasetId);
        var schema = new TableSchemaBuilder
        {
            { "language_code", BigQueryDbType.String, BigQueryFieldMode.Required },
            { "text", BigQueryDbType.String, BigQueryFieldMode.Required },
        }.Build();
        dataset.CreateTable(tableId, schema);
        // Use the default write stream for the table.
        WriteStreamName streamName = new WriteStreamName(projectId, datasetId, tableId, "_default");

        // Sample: BidirectionalStreaming
        BigQueryWriteClient client = BigQueryWriteClient.Create();
        // The using statement ensures that we dispose of the call at the end.
        using BigQueryWriteClient.AppendRowsStream stream = client.AppendRows();

        // Start processing responses from the stream asynchronously, in a separate
        // asynchronous method which uses
        // await foreach (AppendRowsResponse response in stream.GetResponseStream()).
        // In this example, the requests and responses are effectively independent;
        // in more complex scenarios you may wish to send requests to react to
        // responses, etc.
        var responseTask = ProcessResponsesAsync(stream);

        // Write each request to the stream.
        foreach (AppendRowsRequest request in CreateRequests())
        {
            await stream.WriteAsync(request);
        }
        // Indicate that we've finished writing requests.
        await stream.WriteCompleteAsync();

        // Wait for all the responses to be processed before automatically
        // disposing of the stream (due to the using statement).
        await responseTask;
        // End sample

        // We should have seen at least one response, but no errors.
        Assert.NotEqual(0, totalResponses);
        Assert.Equal(0, errorResponses);

        async Task ProcessResponsesAsync(BigQueryWriteClient.AppendRowsStream stream)
        {
            await foreach (AppendRowsResponse response in stream.GetResponseStream())
            {
                Console.WriteLine($"Received {response}");
                totalResponses++;
                if (response.Error is not null)
                {
                    errorResponses++;
                }
            }
        }

        IEnumerable<AppendRowsRequest> CreateRequests()
        {
            var data = new[]
            {
                new LocalizedText { LanguageCode = "en", Text = "It is raining" },
                new LocalizedText { LanguageCode = "fr", Text = "Il pleut" },
                new LocalizedText { LanguageCode = "de", Text = "Es regnet" }
            };

            bool firstRequest = true;
            foreach (var item in data)
            {
                var request = new AppendRowsRequest
                {
                    ProtoRows = new ProtoData
                    {
                        Rows = new ProtoRows { SerializedRows = { item.ToByteString() } }
                    }
                };
                if (firstRequest)
                {
                    request.ProtoRows.WriterSchema = new ProtoSchema { ProtoDescriptor = LocalizedText.Descriptor.ToProto() };
                    request.WriteStreamAsWriteStreamName = streamName;
                    firstRequest = false;
                }
                yield return request;
            }
        }
    }
}
