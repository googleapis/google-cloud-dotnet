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

using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Bq2 = Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.Storage.V1.IntegrationTests
{
    public class SchemaAdapterUnitTests
    {
        private static readonly Bq2.TableSchema nestedComplexBqSchema = new Bq2.TableSchema
        {
            Fields = new[]
                {
                    new Bq2.TableFieldSchema { Name = "name", Type = "STRING", Mode = "NULLABLE", Description = "" },
                    new Bq2.TableFieldSchema { Name = "value", Type = "INT64", Mode = "REQUIRED", Description = "" },
                    new Bq2.TableFieldSchema
                    {
                        Name = "nested_repeated",
                        Type = "STRUCT",
                        Mode = "REPEATED",
                        Description = "",
                        Fields = new[]
                        {
                            new Bq2.TableFieldSchema { Name = "inner_name", Type = "STRING", Mode = "NULLABLE", Description = "" },
                            new Bq2.TableFieldSchema { Name = "inner_value", Type = "BYTES", Mode = "REQUIRED", Description = "" },
                            new Bq2.TableFieldSchema { Name = "inner_nested_repeated", Type = "STRUCT", Mode = "REPEATED", Description = "", Fields = new []
                            {
                                new Bq2.TableFieldSchema { Name = "inner_inner_name", Type = "STRING", Mode = "NULLABLE", Description = "" },
                                new Bq2.TableFieldSchema { Name = "inner_inner_value", Type = "BYTES", Mode = "REQUIRED", Description = "" },
                            }
                        }
                        }
                    }
                }
        };

        [Fact]
        public void BqSchemaToStorageTableSchema_AllTypes()
        {
            var bqSchema = new Bq2.TableSchema
            {
                Fields = new List<Bq2.TableFieldSchema>
                {
                    new Bq2.TableFieldSchema { Name = "string_field", Type = "STRING" },
                    new Bq2.TableFieldSchema { Name = "bytes_field", Type = "BYTES" },
                    new Bq2.TableFieldSchema { Name = "int64_field", Type = "INT64" },
                    new Bq2.TableFieldSchema { Name = "integer_field", Type = "INTEGER" },
                    new Bq2.TableFieldSchema { Name = "float64_field", Type = "FLOAT64" },
                    new Bq2.TableFieldSchema { Name = "float_field", Type = "FLOAT" },
                    new Bq2.TableFieldSchema { Name = "bool_field", Type = "BOOL" },
                    new Bq2.TableFieldSchema { Name = "boolean_field", Type = "BOOLEAN" },
                    new Bq2.TableFieldSchema { Name = "timestamp_field", Type = "TIMESTAMP" },
                    new Bq2.TableFieldSchema { Name = "date_field", Type = "DATE" },
                    new Bq2.TableFieldSchema { Name = "time_field", Type = "TIME" },
                    new Bq2.TableFieldSchema { Name = "datetime_field", Type = "DATETIME" },
                    new Bq2.TableFieldSchema { Name = "numeric_field", Type = "NUMERIC" },
                    new Bq2.TableFieldSchema { Name = "bignumeric_field", Type = "BIGNUMERIC" },
                    new Bq2.TableFieldSchema { Name = "geography_field", Type = "GEOGRAPHY" },
                    new Bq2.TableFieldSchema { Name = "json_field", Type = "JSON" },
                    new Bq2.TableFieldSchema { Name = "struct_field", Type = "STRUCT", Fields = new List<Bq2.TableFieldSchema> { new Bq2.TableFieldSchema { Name = "sub_field", Type = "STRING" } } },
                    new Bq2.TableFieldSchema { Name = "record_field", Type = "RECORD", Fields = new List<Bq2.TableFieldSchema> { new Bq2.TableFieldSchema { Name = "sub_field", Type = "STRING" } } },
                }
            };

            var storageSchema = SchemaAdapter.BqSchemaToStorageTableSchema(bqSchema);

            Assert.Equal(bqSchema.Fields.Count, storageSchema.Fields.Count);
            Assert.Equal(TableFieldSchema.Types.Type.String, storageSchema.Fields[0].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Bytes, storageSchema.Fields[1].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Int64, storageSchema.Fields[2].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Int64, storageSchema.Fields[3].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Double, storageSchema.Fields[4].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Double, storageSchema.Fields[5].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Bool, storageSchema.Fields[6].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Bool, storageSchema.Fields[7].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Timestamp, storageSchema.Fields[8].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Date, storageSchema.Fields[9].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Time, storageSchema.Fields[10].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Datetime, storageSchema.Fields[11].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Numeric, storageSchema.Fields[12].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Bignumeric, storageSchema.Fields[13].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Geography, storageSchema.Fields[14].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Json, storageSchema.Fields[15].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Struct, storageSchema.Fields[16].Type);
            Assert.Equal(TableFieldSchema.Types.Type.Struct, storageSchema.Fields[17].Type);
        }

        [Fact]
        public void BqSchemaToStorageTableSchema_EmptyAndNull()
        {
            // Null schema throws ArgumentNullException
            Assert.Throws<ArgumentNullException>(() => SchemaAdapter.BqSchemaToStorageTableSchema(null));

            // Schema with no fields
            var bqSchema = new Bq2.TableSchema();
            var storageSchema = SchemaAdapter.BqSchemaToStorageTableSchema(bqSchema);
            Assert.NotNull(storageSchema);
            Assert.Empty(storageSchema.Fields);

            // Schema with empty fields list
            bqSchema.Fields = new List<Bq2.TableFieldSchema>();
            storageSchema = SchemaAdapter.BqSchemaToStorageTableSchema(bqSchema);
            Assert.NotNull(storageSchema);
            Assert.Empty(storageSchema.Fields);
        }

        [Fact]
        public void BqSchemaToStorageTableSchema_UnknownType_ThrowsArgumentException()
        {
            var bqSchema = new Bq2.TableSchema
            {
                Fields = new[]
                {
                    new Bq2.TableFieldSchema { Name = "bad_field", Type = "UNKNOWN_TYPE" }
                }
            };

            Assert.Throws<ArgumentException>(() => SchemaAdapter.BqSchemaToStorageTableSchema(bqSchema));
        }

        [Fact]
        public void BqSchemaToStorageTableSchema_Roundtrip()
        {
            var bqSchema = new Bq2.TableSchema
            {
                Fields = new[]
                {
                    new Bq2.TableFieldSchema { Name = "name", Type = "STRING", Mode = "NULLABLE" },
                    new Bq2.TableFieldSchema { Name = "value", Type = "INT64", Mode = "REQUIRED" },
                }
            };

            var storageSchema = SchemaAdapter.BqSchemaToStorageTableSchema(bqSchema);
            var convertedBqSchema = SchemaAdapter.StorageTableSchemaToBqSchema(storageSchema);

            Assert.Equal(bqSchema.Fields.Count, convertedBqSchema.Fields.Count);
            for (int i = 0; i < bqSchema.Fields.Count; i++)
            {
                Assert.True(isEqual(bqSchema.Fields[i], convertedBqSchema.Fields[i]));
            }
        }

        [Fact]
        public void BqSchemaToStorageTableSchema_Roundtrip_Complex()
        {
            var storageSchema = SchemaAdapter.BqSchemaToStorageTableSchema(nestedComplexBqSchema);
            var convertedBqSchema = SchemaAdapter.StorageTableSchemaToBqSchema(storageSchema);

            Assert.Equal(nestedComplexBqSchema.Fields.Count, convertedBqSchema.Fields.Count);
            for (int i = 0; i < nestedComplexBqSchema.Fields.Count; i++)
            {
                Assert.True(isEqual(nestedComplexBqSchema.Fields[i], convertedBqSchema.Fields[i]));
            }
        }

        [Fact]
        public void NormalizeDescriptor_SimpleMessage()
        {
            var descriptor = SimpleTestMessage.Descriptor;
            var normalizedDescriptor = SchemaAdapter.NormalizeDescriptor(descriptor);

            Assert.NotNull(normalizedDescriptor);
            Assert.Equal("Google_Cloud_BigQuery_Storage_V1_IntegrationTests_SimpleTestMessage", normalizedDescriptor.Name);
            Assert.Equal(2, normalizedDescriptor.Field.Count);
            Assert.Equal("name", normalizedDescriptor.Field[0].Name);
            Assert.Equal("value", normalizedDescriptor.Field[1].Name);
        }

        [Fact]
        public void NormalizeDescriptor_OneOfTestMessage()
        {
            var descriptor = OneOfTestMessage.Descriptor;
            var normalizedDescriptor = SchemaAdapter.NormalizeDescriptor(descriptor);

            Assert.NotNull(normalizedDescriptor);
            Assert.Equal("Google_Cloud_BigQuery_Storage_V1_IntegrationTests_OneOfTestMessage", normalizedDescriptor.Name);
            Assert.Equal(3, normalizedDescriptor.Field.Count);

            var optionalField = normalizedDescriptor.Field[0];
            Assert.Equal("optional_field", optionalField.Name);
            Assert.Equal(1, optionalField.Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, optionalField.Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.String, optionalField.Type);
            Assert.False(optionalField.Proto3Optional);

            var oneofStringField = normalizedDescriptor.Field[1];
            Assert.Equal("oneof_string", oneofStringField.Name);
            Assert.Equal(2, oneofStringField.Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, oneofStringField.Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.String, oneofStringField.Type);

            var oneofInt32Field = normalizedDescriptor.Field[2];
            Assert.Equal("oneof_int32", oneofInt32Field.Name);
            Assert.Equal(3, oneofInt32Field.Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, oneofInt32Field.Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Int32, oneofInt32Field.Type);
        }

        [Fact]
        public void NormalizeDescriptor_ComplexTestMessage()
        {
            var descriptor = ComplexTestMessage.Descriptor;
            var normalizedDescriptor = SchemaAdapter.NormalizeDescriptor(descriptor);

            Assert.NotNull(normalizedDescriptor);
            Assert.Equal("Google_Cloud_BigQuery_Storage_V1_IntegrationTests_ComplexTestMessage", normalizedDescriptor.Name);
            Assert.Equal(9, normalizedDescriptor.Field.Count);
            Assert.Equal(3, normalizedDescriptor.NestedType.Count);

            var fields = normalizedDescriptor.Field;
            Assert.Equal("id", fields[0].Name);
            Assert.Equal(1, fields[0].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, fields[0].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.String, fields[0].Type);
            Assert.Equal("", fields[0].DefaultValue);

            Assert.Equal("count", fields[1].Name);
            Assert.Equal(2, fields[1].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, fields[1].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Int32, fields[1].Type);
            Assert.Equal("0", fields[1].DefaultValue);

            Assert.Equal("is_active", fields[2].Name);
            Assert.Equal(3, fields[2].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, fields[2].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Bool, fields[2].Type);
            Assert.Equal("false", fields[2].DefaultValue);

            Assert.Equal("created_at", fields[3].Name);
            Assert.Equal(4, fields[3].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, fields[3].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Message, fields[3].Type);
            Assert.Equal("google_protobuf_Timestamp", fields[3].TypeName);

            Assert.Equal("data", fields[4].Name);
            Assert.Equal(5, fields[4].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, fields[4].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Bytes, fields[4].Type);
            Assert.Equal("", fields[4].DefaultValue);

            Assert.Equal("tags", fields[5].Name);
            Assert.Equal(6, fields[5].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Repeated, fields[5].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.String, fields[5].Type);

            Assert.Equal("nested_field", fields[6].Name);
            Assert.Equal(7, fields[6].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, fields[6].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Message, fields[6].Type);
            Assert.Equal("Google_Cloud_BigQuery_Storage_V1_IntegrationTests_NestedMessage", fields[6].TypeName);

            Assert.Equal("repeated_nested_field", fields[7].Name);
            Assert.Equal(8, fields[7].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Repeated, fields[7].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Message, fields[7].Type);
            Assert.Equal("Google_Cloud_BigQuery_Storage_V1_IntegrationTests_NestedMessage", fields[7].TypeName);

            Assert.Equal("status", fields[8].Name);
            Assert.Equal(9, fields[8].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, fields[8].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Enum, fields[8].Type);
            Assert.Equal("Google_Cloud_BigQuery_Storage_V1_IntegrationTests_Status_E.Status", fields[8].TypeName);
            Assert.Equal("STATUS_UNSPECIFIED", fields[8].DefaultValue);

            var nestedTypes = normalizedDescriptor.NestedType;

            var nestedMessage = nestedTypes[0];
            Assert.Equal("Google_Cloud_BigQuery_Storage_V1_IntegrationTests_NestedMessage", nestedMessage.Name);
            Assert.Equal(2, nestedMessage.Field.Count);
            Assert.Equal("name", nestedMessage.Field[0].Name);
            Assert.Equal(1, nestedMessage.Field[0].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, nestedMessage.Field[0].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.String, nestedMessage.Field[0].Type);
            Assert.Equal("", nestedMessage.Field[0].DefaultValue);
            Assert.Equal("score", nestedMessage.Field[1].Name);
            Assert.Equal(2, nestedMessage.Field[1].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, nestedMessage.Field[1].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Double, nestedMessage.Field[1].Type);
            Assert.Equal("0", nestedMessage.Field[1].DefaultValue);

            var statusEnumContainer = nestedTypes[1];
            Assert.Equal("Google_Cloud_BigQuery_Storage_V1_IntegrationTests_Status_E", statusEnumContainer.Name);
            Assert.Equal(1, statusEnumContainer.EnumType.Count);
            var statusEnum = statusEnumContainer.EnumType[0];
            Assert.Equal("Status", statusEnum.Name);
            Assert.Equal(4, statusEnum.Value.Count);
            Assert.Equal("STATUS_UNSPECIFIED", statusEnum.Value[0].Name);
            Assert.Equal(0, statusEnum.Value[0].Number);
            Assert.Equal("ACTIVE", statusEnum.Value[1].Name);
            Assert.Equal(1, statusEnum.Value[1].Number);
            Assert.Equal("INACTIVE", statusEnum.Value[2].Name);
            Assert.Equal(2, statusEnum.Value[2].Number);
            Assert.Equal("PENDING", statusEnum.Value[3].Name);
            Assert.Equal(3, statusEnum.Value[3].Number);

            var timestampMessage = nestedTypes[2];
            Assert.Equal("google_protobuf_Timestamp", timestampMessage.Name);
            Assert.Equal(2, timestampMessage.Field.Count);
            Assert.Equal("seconds", timestampMessage.Field[0].Name);
            Assert.Equal(1, timestampMessage.Field[0].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, timestampMessage.Field[0].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Int64, timestampMessage.Field[0].Type);
            Assert.Equal("0", timestampMessage.Field[0].DefaultValue);
            Assert.Equal("nanos", timestampMessage.Field[1].Name);
            Assert.Equal(2, timestampMessage.Field[1].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, timestampMessage.Field[1].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Int32, timestampMessage.Field[1].Type);
            Assert.Equal("0", timestampMessage.Field[1].DefaultValue);
        }

        [Fact]
        public void NormalizeDescriptor_BusinessMessage()
        {
            var descriptor = BusinessChangedEvent.Descriptor;
            var normalizedDescriptor = SchemaAdapter.NormalizeDescriptor(descriptor);

            Assert.NotNull(normalizedDescriptor);
            Assert.Equal("Google_Cloud_BigQuery_Storage_V1_IntegrationTests_BusinessChangedEvent", normalizedDescriptor.Name);
            Assert.Single(normalizedDescriptor.Field);

            var businessField = normalizedDescriptor.Field[0];
            Assert.Equal("business", businessField.Name);
            Assert.Equal(1, businessField.Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, businessField.Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Message, businessField.Type);
            Assert.Equal("Google_Cloud_BigQuery_Storage_V1_IntegrationTests_Business", businessField.TypeName);

            Assert.Equal(3, normalizedDescriptor.NestedType.Count);

            var businessMessage = normalizedDescriptor.NestedType.FirstOrDefault(n => n.Name == "Google_Cloud_BigQuery_Storage_V1_IntegrationTests_Business");
            Assert.NotNull(businessMessage);
            Assert.Equal(8, businessMessage.Field.Count);

            var idField = businessMessage.Field.FirstOrDefault(f => f.Name == "id");
            Assert.NotNull(idField);
            Assert.Equal(1, idField.Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, idField.Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.String, idField.Type);
            Assert.Equal("", idField.DefaultValue);

            var financeEmailField = businessMessage.Field.FirstOrDefault(f => f.Name == "finance_email");
            Assert.NotNull(financeEmailField);
            Assert.Equal(9, financeEmailField.Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, financeEmailField.Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Message, financeEmailField.Type);
            Assert.Equal("google_protobuf_StringValue", financeEmailField.TypeName);

            var metaTsField = businessMessage.Field.FirstOrDefault(f => f.Name == "meta_ts");
            Assert.NotNull(metaTsField);
            Assert.Equal(11, metaTsField.Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, metaTsField.Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.String, metaTsField.Type);
            Assert.Equal("", metaTsField.DefaultValue);

            var metaOpField = businessMessage.Field.FirstOrDefault(f => f.Name == "meta_op");
            Assert.NotNull(metaOpField);
            Assert.Equal(12, metaOpField.Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, metaOpField.Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Int64, metaOpField.Type);
            Assert.Equal("0", metaOpField.DefaultValue);

            var statusField = businessMessage.Field.FirstOrDefault(f => f.Name == "status");
            Assert.NotNull(statusField);
            Assert.Equal(18, statusField.Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, statusField.Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Enum, statusField.Type);
            Assert.Equal("Google_Cloud_BigQuery_Storage_V1_IntegrationTests_BusinessStatus_E.BusinessStatus", statusField.TypeName);
            Assert.Equal("BUSINESS_STATUS_UNDEFINED", statusField.DefaultValue);

            var disabledField = businessMessage.Field.FirstOrDefault(f => f.Name == "disabled");
            Assert.NotNull(disabledField);
            Assert.Equal(19, disabledField.Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, disabledField.Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Bool, disabledField.Type);
            Assert.Equal("false", disabledField.DefaultValue);

            var activeField = businessMessage.Field.FirstOrDefault(f => f.Name == "active");
            Assert.NotNull(activeField);
            Assert.Equal(24, activeField.Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, activeField.Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Bool, activeField.Type);
            Assert.Equal("false", activeField.DefaultValue);

            var tagsField = businessMessage.Field.FirstOrDefault(f => f.Name == "tags");
            Assert.NotNull(tagsField);
            Assert.Equal(27, tagsField.Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Repeated, tagsField.Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.String, tagsField.Type);

            var businessStatusEnum = normalizedDescriptor.NestedType.FirstOrDefault(n => n.Name == "Google_Cloud_BigQuery_Storage_V1_IntegrationTests_BusinessStatus_E");
            Assert.NotNull(businessStatusEnum);
            Assert.Single(businessStatusEnum.EnumType);
            var enumType = businessStatusEnum.EnumType[0];
            Assert.Equal("BusinessStatus", enumType.Name);
            Assert.Equal(3, enumType.Value.Count);
            Assert.Equal("BUSINESS_STATUS_UNDEFINED", enumType.Value[0].Name);
            Assert.Equal(0, enumType.Value[0].Number);
            Assert.Equal("BUSINESS_STATUS_IN_REVIEW", enumType.Value[1].Name);
            Assert.Equal(1, enumType.Value[1].Number);
            Assert.Equal("BUSINESS_STATUS_APPROVED", enumType.Value[2].Name);
            Assert.Equal(2, enumType.Value[2].Number);

            var stringValueMessage = normalizedDescriptor.NestedType.FirstOrDefault(n => n.Name == "google_protobuf_StringValue");
            Assert.NotNull(stringValueMessage);
            Assert.Single(stringValueMessage.Field);
            var valueField = stringValueMessage.Field[0];
            Assert.Equal("value", valueField.Name);
            Assert.Equal(1, valueField.Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, valueField.Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.String, valueField.Type);
            Assert.Equal("", valueField.DefaultValue);
        }

        [Fact]
        public void NormalizeDescriptor_RecursiveMessage_ThrowsException()
        {
            // 1. Get descriptor for recursive message
            var messageDescriptor = RecursiveMessage.Descriptor;

            // 2. Assert that NormalizeDescriptor throws an InvalidOperationException
            Assert.Throws<InvalidOperationException>(() => SchemaAdapter.NormalizeDescriptor(messageDescriptor));
        }

        [Fact]
        public void StorageSchemaToProtoDescriptor_SimpleSchema()
        {
            var storageSchema = new TableSchema
            {
                Fields =
                {
                    new TableFieldSchema { Name = "name", Type = TableFieldSchema.Types.Type.String },
                    new TableFieldSchema { Name = "value", Type = TableFieldSchema.Types.Type.Int64 },
                }
            };

            var descriptor = SchemaAdapter.StorageSchemaToProtoDescriptor(storageSchema, "MyMessage");

            Assert.NotNull(descriptor);
            Assert.Equal("MyMessage", descriptor.Name);
            // Cast to MessageDescriptor to access Fields property
            var messageDescriptor = (Google.Protobuf.Reflection.MessageDescriptor)descriptor;
            Assert.Equal(2, messageDescriptor.Fields.InDeclarationOrder().Count);
            Assert.Equal("name", messageDescriptor.Fields.InDeclarationOrder()[0].Name);
            Assert.Equal("value", messageDescriptor.Fields.InDeclarationOrder()[1].Name);
        }

        [Fact]
        public void StorageSchemaToNormalizedProtoDescriptor_NestedComplexSchema()
        {
            var storageSchema = SchemaAdapter.BqSchemaToStorageTableSchema(nestedComplexBqSchema);
            var protoDescriptor = (MessageDescriptor)SchemaAdapter.StorageSchemaToProtoDescriptor(storageSchema, "NestedComplexDescriptor");
            var normalizedDescriptor = SchemaAdapter.NormalizeDescriptor(protoDescriptor);

            Assert.NotNull(normalizedDescriptor);
            Assert.Equal("NestedComplexDescriptor", normalizedDescriptor.Name);
            Assert.Equal(3, normalizedDescriptor.Field.Count);
            Assert.Equal("name", normalizedDescriptor.Field[0].Name);
            Assert.Equal(1, normalizedDescriptor.Field[0].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, normalizedDescriptor.Field[0].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.String, normalizedDescriptor.Field[0].Type);
            Assert.Equal("value", normalizedDescriptor.Field[1].Name);
            Assert.Equal(2, normalizedDescriptor.Field[1].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Required, normalizedDescriptor.Field[1].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Int64, normalizedDescriptor.Field[1].Type);
            Assert.Equal("nested_repeated", normalizedDescriptor.Field[2].Name);
            Assert.Equal(3, normalizedDescriptor.Field[2].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Repeated, normalizedDescriptor.Field[2].Label);
            Assert.Equal("NestedComplexDescriptor__nested_repeated", normalizedDescriptor.Field[2].TypeName);

            Assert.Equal(2, normalizedDescriptor.NestedType.Count);
            var nestedType1 = normalizedDescriptor.NestedType[0];
            Assert.Equal("NestedComplexDescriptor__nested_repeated", nestedType1.Name);
            Assert.Equal(3, nestedType1.Field.Count);
            Assert.Equal("inner_name", nestedType1.Field[0].Name);
            Assert.Equal(1, nestedType1.Field[0].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, nestedType1.Field[0].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.String, nestedType1.Field[0].Type);
            Assert.Equal("inner_value", nestedType1.Field[1].Name);
            Assert.Equal(2, nestedType1.Field[1].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Required, nestedType1.Field[1].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Bytes, nestedType1.Field[1].Type);
            Assert.Equal("inner_nested_repeated", nestedType1.Field[2].Name);
            Assert.Equal(3, nestedType1.Field[2].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Repeated, nestedType1.Field[2].Label);
            Assert.Equal("NestedComplexDescriptor__nested_repeated__inner_nested_repeated", nestedType1.Field[2].TypeName);

            var nestedType2 = normalizedDescriptor.NestedType[1];
            Assert.Equal("NestedComplexDescriptor__nested_repeated__inner_nested_repeated", nestedType2.Name);
            Assert.Equal(2, nestedType2.Field.Count);
            Assert.Equal("inner_inner_name", nestedType2.Field[0].Name);
            Assert.Equal(1, nestedType2.Field[0].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Optional, nestedType2.Field[0].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.String, nestedType2.Field[0].Type);
            Assert.Equal("inner_inner_value", nestedType2.Field[1].Name);
            Assert.Equal(2, nestedType2.Field[1].Number);
            Assert.Equal(FieldDescriptorProto.Types.Label.Required, nestedType2.Field[1].Label);
            Assert.Equal(FieldDescriptorProto.Types.Type.Bytes, nestedType2.Field[1].Type);
        }

        [Fact]
        public void StorageSchemaToProtoDescriptor_WithWrapperTypeOption()
        {
            var storageSchema = new TableSchema
            {
                Fields =
                {
                    new TableFieldSchema { Name = "optional_name", Type = TableFieldSchema.Types.Type.String },
                }
            };

            var descriptor = SchemaAdapter.StorageSchemaToProtoDescriptor(
                storageSchema,
                "MyMessageWithWrapper",
                new WithProtoMappingOption(new ProtoMapping
                {
                    FieldType = TableFieldSchema.Types.Type.String,
                    TypeName = "google.protobuf.StringValue",
                    Type = FieldDescriptorProto.Types.Type.Message
                }));

            Assert.NotNull(descriptor);
            var messageDescriptor = (Google.Protobuf.Reflection.MessageDescriptor)descriptor;
            var field = messageDescriptor.Fields.InDeclarationOrder()[0];
            Assert.Equal("optional_name", field.Name);
            Assert.Equal(FieldType.Message, field.FieldType);
            Assert.Equal("google.protobuf.StringValue", field.MessageType.FullName);
        }
        private bool isEqual(Bq2.TableFieldSchema a, Bq2.TableFieldSchema b)
        {
            if (a.Name != b.Name || a.Type != b.Type || (a.Mode ?? "NULLABLE") != (b.Mode ?? "NULLABLE"))
            {
                return false;
            }

            var aFields = a.Fields;
            var bFields = b.Fields;

            if ((aFields == null || aFields.Count == 0) && (bFields == null || bFields.Count == 0))
            {
                return true;
            }
            if (aFields.Count != bFields.Count)
            {
                return false;
            }

            for (int i = 0; i < aFields.Count; i++)
            {
                if (!isEqual(aFields[i], bFields[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
