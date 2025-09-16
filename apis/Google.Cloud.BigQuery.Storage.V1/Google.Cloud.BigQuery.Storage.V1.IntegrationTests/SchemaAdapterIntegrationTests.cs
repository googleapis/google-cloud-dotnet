// Copyright 2025 Google LLC
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

using Google.Cloud.BigQuery.V2;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Bq2 = Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.Storage.V1.IntegrationTests
{
    [Collection(nameof(BigQueryStorageFixture))]
    public class SchemaAdapterIntegrationTests : IDisposable
    {
        private readonly BigQueryClient _bqClient;
        private readonly BigQueryWriteClient _writeClient;
        private readonly BigQueryReadClient _readClient;
        private readonly string _datasetId;
        private readonly string _projectId;

        public SchemaAdapterIntegrationTests(BigQueryStorageFixture fixture)
        {
            _projectId = fixture.ProjectId;
            _bqClient = BigQueryClient.Create(_projectId);
            _writeClient = BigQueryWriteClient.Create();
            _readClient = BigQueryReadClient.Create();

            _datasetId = "bigquery_storage_test_" + Guid.NewGuid().ToString("N");

            // Create dataset for the test
            _bqClient.CreateDataset(_datasetId);
        }

        public void Dispose()
        {
            // Clean up BigQuery resources
            //_bqClient.DeleteDataset(_datasetId, new DeleteDatasetOptions { DeleteContents = true });
            _bqClient.Dispose();
        }

        [Fact]
        public async Task WriteAndReadComplexProtoMessage()
        {
            // 1. Create table with schema derived from ComplexTestMessage.Descriptor
            var messageDescriptor = ComplexTestMessage.Descriptor;
            var bqTableSchema = new Bq2.TableSchema
            {
                Fields = messageDescriptor.Fields.InDeclarationOrder().Select(f => ConvertField(f)).ToList()
            };

            var tableId = "complex_test_table";
            var table = _bqClient.GetDataset(_datasetId).CreateTable(tableId, bqTableSchema);

            // 2. Write a ComplexTestMessage record using BigQueryWriteClient
            var originalMessage = new ComplexTestMessage
            {
                Id = "test-id-123",
                Count = 42,
                IsActive = true,
                CreatedAt = Timestamp.FromDateTime(DateTime.UtcNow),
                Data = ByteString.CopyFromUtf8("some binary data"),
                Tags = { "tag1", "tag2", "tag3" },
                NestedField = new NestedMessage { Name = "nested-name", Score = 99.9 },
                RepeatedNestedField =
                {
                    new NestedMessage { Name = "rep-nested-1", Score = 1.1 },
                    new NestedMessage { Name = "rep-nested-2", Score = 2.2 },
                },
                Status = Status.Active
            };

            var createWriteStreamRequest = new CreateWriteStreamRequest
            {
                Parent = new TableName(_projectId, _datasetId, tableId).ToString(),
                WriteStream = new WriteStream
                {
                    Type = WriteStream.Types.Type.Committed,
                }
            };
            var writeStream = await _writeClient.CreateWriteStreamAsync(createWriteStreamRequest);
            var normalizedDescriptor = SchemaAdapter.NormalizeDescriptor(ComplexTestMessage.Descriptor);

            using (var stream = _writeClient.AppendRows())
            {
                var responseHandlerTask = Task.Run(async () =>
                {
                    await foreach (var response in stream.GetResponseStream())
                    {
                        Console.Out.WriteLine(response.ToString() + "\n");
                    }
                });

                await stream.WriteAsync(new AppendRowsRequest
                {
                    WriteStream = writeStream.Name,
                    ProtoRows = new AppendRowsRequest.Types.ProtoData
                    {
                        WriterSchema = new ProtoSchema { ProtoDescriptor = normalizedDescriptor },
                        Rows = new ProtoRows { SerializedRows = { originalMessage.ToByteString() } }
                    }
                });
                await stream.WriteCompleteAsync();
                await responseHandlerTask;
            }

            // 3. Read the record using BigQueryClient (easier than BigQueryReadClient with Avro)
            var query = $"SELECT * FROM `{_projectId}.{_datasetId}.{tableId}`";
            var rows = await _bqClient.ExecuteQueryAsync(query, parameters: null);

            var readMessages = new List<ComplexTestMessage>();
            foreach (var row in rows)
            {
                dynamic nestedRow = row["nested_field"];
                var currentReadMessage = new ComplexTestMessage
                {
                    Id = (string) row["id"],
                    Count = (int) (long) row["count"],
                    IsActive = (bool) row["is_active"],
                    CreatedAt = Timestamp.FromDateTime((DateTime) row["created_at"]),
                    Data = ByteString.CopyFrom((byte[]) row["data"]),
                    Tags = { row["tags"].ToStringArray() },
                    NestedField = new NestedMessage
                    {
                        Name = (string) nestedRow["name"],
                        Score = (double) nestedRow["score"],
                    },
                    Status = (Status) System.Enum.Parse(typeof(Status), (string) row["status"], true)
                };

                // Handle repeated nested field
                if (row["repeated_nested_field"] is IEnumerable<object> repeatedNestedFields)
                {
                    foreach (dynamic item in repeatedNestedFields)
                    {
                        currentReadMessage.RepeatedNestedField.Add(new NestedMessage
                        {
                            Name = (string) item["name"],
                            Score = (double) item["score"],
                        });
                    }
                }
                readMessages.Add(currentReadMessage);
            }

            // 4. Assert that the read record matches the written record
            Assert.Single(readMessages);
            var finalReadMessage = readMessages.First();
            Assert.Equal(originalMessage.Id, finalReadMessage.Id);
            Assert.Equal(originalMessage.Count, finalReadMessage.Count);
            Assert.Equal(originalMessage.IsActive, finalReadMessage.IsActive);
            // Timestamp comparison might need tolerance
            Assert.Equal(originalMessage.CreatedAt.Seconds, finalReadMessage.CreatedAt.Seconds);
            Assert.Equal(originalMessage.Data, finalReadMessage.Data);
            Assert.Equal(originalMessage.Tags, finalReadMessage.Tags);
            Assert.Equal(originalMessage.NestedField.Name, finalReadMessage.NestedField.Name);
            Assert.Equal(originalMessage.NestedField.Score, finalReadMessage.NestedField.Score);
            Assert.Equal(originalMessage.RepeatedNestedField.Count, finalReadMessage.RepeatedNestedField.Count);
            for (int i = 0; i < originalMessage.RepeatedNestedField.Count; i++)
            {
                Assert.Equal(originalMessage.RepeatedNestedField[i].Name, finalReadMessage.RepeatedNestedField[i].Name);
                Assert.Equal(originalMessage.RepeatedNestedField[i].Score, finalReadMessage.RepeatedNestedField[i].Score);
            }
            Assert.Equal(originalMessage.Status, finalReadMessage.Status);
        }

        [Fact]
        public async Task WriteAndReadBusinessMessage()
        {
            // 1. Create table with schema derived from BusinessChangedEvent.Descriptor
            var messageDescriptor = BusinessChangedEvent.Descriptor;
            var bqTableSchema = new Bq2.TableSchema
            {
                Fields = messageDescriptor.Fields.InDeclarationOrder().Select(f => ConvertField(f)).ToList()
            };

            var tableId = "business_test_table";
            var table = _bqClient.GetDataset(_datasetId).CreateTable(tableId, bqTableSchema);

            // 2. Write a BusinessChangedEvent record using BigQueryWriteClient
            var originalMessage = new BusinessChangedEvent
            {
                Business = new Business
                {
                    Id = "business-id-1",
                    FinanceEmail = "finance@example.com",
                    MetaTs = "2025-01-01T00:00:00Z",
                    MetaOp = 1,
                    Status = BusinessStatus.Approved,
                    Disabled = false,
                    Active = true,
                    Tags = { "customer", "priority" }
                }
            };

            var createWriteStreamRequest = new CreateWriteStreamRequest
            {
                Parent = new TableName(_projectId, _datasetId, tableId).ToString(),
                WriteStream = new WriteStream
                {
                    Type = WriteStream.Types.Type.Committed,
                }
            };
            var writeStream = await _writeClient.CreateWriteStreamAsync(createWriteStreamRequest);
            var normalizedDescriptor = SchemaAdapter.NormalizeDescriptor(BusinessChangedEvent.Descriptor);

            using (var stream = _writeClient.AppendRows())
            {
                var responseHandlerTask = Task.Run(async () =>
                {
                    await foreach (var response in stream.GetResponseStream())
                    {
                        Console.Out.WriteLine(response.ToString() + "\n");
                    }
                });

                await stream.WriteAsync(new AppendRowsRequest
                {
                    WriteStream = writeStream.Name,
                    ProtoRows = new AppendRowsRequest.Types.ProtoData
                    {
                        WriterSchema = new ProtoSchema { ProtoDescriptor = normalizedDescriptor },
                        Rows = new ProtoRows { SerializedRows = { originalMessage.ToByteString() } }
                    }
                });
                await stream.WriteCompleteAsync();
                await responseHandlerTask;
            }

            // 3. Read the record using BigQueryClient
            var query = $"SELECT * FROM `{_projectId}.{_datasetId}.{tableId}`";
            var rows = await _bqClient.ExecuteQueryAsync(query, parameters: null);

            var readMessages = new List<BusinessChangedEvent>();
            foreach (var row in rows)
            {
                dynamic businessRow = row["business"];
                var currentReadMessage = new BusinessChangedEvent
                {
                    Business = new Business
                    {
                        Id = (string) businessRow["id"],
                        FinanceEmail = (string) businessRow["finance_email"],
                        MetaTs = (string) businessRow["meta_ts"],
                        MetaOp = (long) businessRow["meta_op"],
                        Status = (BusinessStatus) System.Enum.Parse(typeof(BusinessStatus), ((string) businessRow["status"]).Replace("BUSINESS_STATUS_", ""), true),
                        Disabled = (bool) businessRow["disabled"],
                        Active = (bool) businessRow["active"],
                        Tags = { businessRow["tags"] }
                    }
                };
                readMessages.Add(currentReadMessage);
            }

            // 4. Assert that the read record matches the written record
            Assert.Single(readMessages);
            var finalReadMessage = readMessages.First();
            Assert.Equal(originalMessage.Business.Id, finalReadMessage.Business.Id);
            Assert.Equal(originalMessage.Business.FinanceEmail, finalReadMessage.Business.FinanceEmail);
            Assert.Equal(originalMessage.Business.MetaTs, finalReadMessage.Business.MetaTs);
            Assert.Equal(originalMessage.Business.MetaOp, finalReadMessage.Business.MetaOp);
            Assert.Equal(originalMessage.Business.Status, finalReadMessage.Business.Status);
            Assert.Equal(originalMessage.Business.Disabled, finalReadMessage.Business.Disabled);
            Assert.Equal(originalMessage.Business.Active, finalReadMessage.Business.Active);
            Assert.Equal(originalMessage.Business.Tags, finalReadMessage.Business.Tags);
        }

        private Bq2.TableFieldSchema ConvertField(FieldDescriptor field)
        {
            var fieldSchema = new Bq2.TableFieldSchema
            {
                Name = field.Name,
                Type = ConvertType(field),
                Mode = field.IsRepeated ? "REPEATED" : "NULLABLE"
            };
            if (field.FieldType == FieldType.Message && !IsWellKnownType(field.MessageType))
            {
                fieldSchema.Fields = field.MessageType.Fields.InDeclarationOrder().Select(f => ConvertField(f)).ToList();
            }
            return fieldSchema;
        }

        private bool IsWellKnownType(MessageDescriptor message)
        {
            return message.File.Package == "google.protobuf";
        }

        private string ConvertType(FieldDescriptor field)
        {
            switch (field.FieldType)
            {
                case FieldType.String:
                    return "STRING";
                case FieldType.Bytes:
                    return "BYTES";
                case FieldType.Int64:
                case FieldType.SInt64:
                case FieldType.Fixed64:
                case FieldType.SFixed64:
                    return "INT64";
                case FieldType.Float:
                case FieldType.Double:
                    return "FLOAT64";
                case FieldType.Bool:
                    return "BOOL";
                case FieldType.Message:
                    if (IsWellKnownType(field.MessageType))
                    {
                        switch (field.MessageType.FullName)
                        {
                            case "google.protobuf.Timestamp":
                                return "TIMESTAMP";
                            case "google.protobuf.Duration":
                                return "FLOAT64"; // Best effort mapping
                            case "google.protobuf.DoubleValue":
                            case "google.protobuf.FloatValue":
                                return "FLOAT64";
                            case "google.protobuf.Int64Value":
                            case "google.protobuf.UInt64Value":
                                return "INT64";
                            case "google.protobuf.Int32Value":
                            case "google.protobuf.UInt32Value":
                                return "INTEGER";
                            case "google.protobuf.BoolValue":
                                return "BOOL";
                            case "google.protobuf.StringValue":
                            case "google.protobuf.BytesValue":
                                return "STRING";
                        }
                    }
                    return "STRUCT";
                case FieldType.Int32:
                case FieldType.UInt32:
                case FieldType.SInt32:
                case FieldType.Fixed32:
                case FieldType.SFixed32:
                    return "INTEGER";
                case FieldType.Enum:
                    return "STRING";
                default:
                    throw new ArgumentException($"Unsupported field type: {field.FieldType}");
            }
        }
    }
}

public static class BigQueryExtensions
{
    public static string[] ToStringArray(this object value)
    {
        if (value is IEnumerable<object> enumerable)
        {
            return enumerable.Select(x => x.ToString()).ToArray();
        }
        return new string[0];
    }
}
