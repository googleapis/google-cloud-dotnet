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

using Bq2 = Google.Apis.Bigquery.v2.Data;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.BigQuery.Storage.V1
{
    /// <summary>
    /// A utility class to adapt protobuf schemas for the BigQuery Storage Write API.
    /// </summary>
    public static partial class SchemaAdapter
    {
        static SchemaAdapter()
        {
            // Ensure the WrappersReflection is loaded.
            // This is a workaround for a potential issue where the descriptor
            // for wrappers.proto might not be available when needed.
            var _ = Protobuf.WellKnownTypes.WrappersReflection.Descriptor;
        }
        /// <summary>
        /// A mapping from BigQuery data type names (as strings) to the corresponding
        /// <see cref="TableFieldSchema.Types.Type"/> enum value. This allows for parsing
        /// schemas where types are specified as strings. The comparison is case-insensitive.
        /// </summary>
        private static readonly Dictionary<string, TableFieldSchema.Types.Type> s_fieldTypeMap = new Dictionary<string, TableFieldSchema.Types.Type>()
        {
            { "STRING", TableFieldSchema.Types.Type.String },
            { "BYTES", TableFieldSchema.Types.Type.Bytes },
            { "INT64", TableFieldSchema.Types.Type.Int64 },
            { "INTEGER", TableFieldSchema.Types.Type.Int64 },
            { "FLOAT64", TableFieldSchema.Types.Type.Double },
            { "FLOAT", TableFieldSchema.Types.Type.Double },
            { "BOOL", TableFieldSchema.Types.Type.Bool },
            { "BOOLEAN", TableFieldSchema.Types.Type.Bool },
            { "TIMESTAMP", TableFieldSchema.Types.Type.Timestamp },
            { "STRUCT", TableFieldSchema.Types.Type.Struct },
            { "RECORD", TableFieldSchema.Types.Type.Struct },
            { "DATE", TableFieldSchema.Types.Type.Date },
            { "TIME", TableFieldSchema.Types.Type.Time },
            { "DATETIME", TableFieldSchema.Types.Type.Datetime },
            { "NUMERIC", TableFieldSchema.Types.Type.Numeric },
            { "BIGNUMERIC", TableFieldSchema.Types.Type.Bignumeric },
            { "GEOGRAPHY", TableFieldSchema.Types.Type.Geography },
            { "RANGE", TableFieldSchema.Types.Type.Range },
            { "JSON", TableFieldSchema.Types.Type.Json },
        };

        /// <summary>
        /// A reverse mapping from the <see cref="TableFieldSchema.Types.Type"/> enum value
        /// to the BigQuery data type name. This is used when converting a storage schema
        /// back to a BigQuery schema.
        /// </summary>
        private static readonly Dictionary<TableFieldSchema.Types.Type, string> s_reverseFieldTypeMap = new Dictionary<TableFieldSchema.Types.Type, string>()
        {
                { TableFieldSchema.Types.Type.String, "STRING" },
                { TableFieldSchema.Types.Type.Bytes, "BYTES" },
                { TableFieldSchema.Types.Type.Int64, "INT64" },
                { TableFieldSchema.Types.Type.Double, "FLOAT64" },
                { TableFieldSchema.Types.Type.Bool, "BOOL" },
                { TableFieldSchema.Types.Type.Timestamp, "TIMESTAMP" },
                { TableFieldSchema.Types.Type.Struct, "STRUCT" },
                { TableFieldSchema.Types.Type.Date, "DATE" },
                { TableFieldSchema.Types.Type.Time, "TIME" },
                { TableFieldSchema.Types.Type.Datetime, "DATETIME" },
                { TableFieldSchema.Types.Type.Numeric, "NUMERIC" },
                { TableFieldSchema.Types.Type.Bignumeric, "BIGNUMERIC" },
                { TableFieldSchema.Types.Type.Geography, "GEOGRAPHY" },
                { TableFieldSchema.Types.Type.Range, "RANGE" },
                { TableFieldSchema.Types.Type.Json, "JSON" },
                { TableFieldSchema.Types.Type.Unspecified, "UNSPECIFIED" }
        };

        /// <summary>
        /// Converts a BigQuery schema from <see cref="Bq2.TableSchema"/> to the storage <see cref="TableSchema"/>.
        /// </summary>
        /// <param name="bqSchema">The BigQuery schema to convert. Must not be null.</param>
        /// <returns>The converted storage table schema.</returns>
        public static TableSchema BqSchemaToStorageTableSchema(Bq2.TableSchema bqSchema)
        {
            if (bqSchema == null)
            {
                throw new ArgumentNullException(nameof(bqSchema));
            }

            var storageSchema = new TableSchema();
            if (bqSchema.Fields != null)
            {
                foreach (var field in bqSchema.Fields)
                {
                    storageSchema.Fields.Add(BqFieldToProto(field));
                }
            }
            return storageSchema;
        }

        /// <summary>
        /// Converts a single BigQuery field from the v2 API model to the Storage API model.
        /// This is a recursive function that handles nested fields (structs).
        /// </summary>
        private static TableFieldSchema BqFieldToProto(Bq2.TableFieldSchema bqField)
        {
            if (bqField == null)
            {
                return null;
            }

            var protoField = new TableFieldSchema
            {
                Name = bqField.Name ?? "", // Ensure Name is not null
                Description = bqField.Description ?? "", // Provide empty string if null
            };

            if (string.IsNullOrEmpty(bqField.Type) || !s_fieldTypeMap.TryGetValue(bqField.Type, out var type))
            {
                throw new ArgumentException($"Could not convert field '{bqField.Name}' due to unknown or null type value: {bqField.Type}");
            }
            protoField.Type = type;

            protoField.Mode = TableFieldSchema.Types.Mode.Nullable;
            if (string.Equals(bqField.Mode, "REPEATED", StringComparison.OrdinalIgnoreCase))
            {
                protoField.Mode = TableFieldSchema.Types.Mode.Repeated;
            }
            else if (string.Equals(bqField.Mode, "REQUIRED", StringComparison.OrdinalIgnoreCase))
            {
                protoField.Mode = TableFieldSchema.Types.Mode.Required;
            }

            if (bqField.Fields != null)
            {
                foreach (var subField in bqField.Fields)
                {
                    protoField.Fields.Add(BqFieldToProto(subField));
                }
            }

            return protoField;
        }

        /// <summary>
        /// Converts a storage <see cref="TableSchema"/> to a BigQuery <see cref="Bq2.TableSchema"/>.
        /// </summary>
        /// <param name="storageSchema">The storage table schema to convert. Must not be null.</param>
        /// <returns>The converted BigQuery table schema.</returns>
        public static Bq2.TableSchema StorageTableSchemaToBqSchema(TableSchema storageSchema)
        {
            if (storageSchema == null)
            {
                throw new ArgumentNullException(nameof(storageSchema));
            }

            var bqSchema = new Bq2.TableSchema
            {
                Fields = new List<Bq2.TableFieldSchema>() // Initialize Fields as a new list
            };
            if (storageSchema.Fields != null)
            {
                foreach (var field in storageSchema.Fields)
                {
                    if (field != null)
                    {
                        bqSchema.Fields.Add(ProtoToBqField(field));
                    }
                }
            }
            return bqSchema;
        }

        /// <summary>
        /// Converts a single field from the Storage API model to the BigQuery v2 API model.
        /// This is a recursive function that handles nested fields (structs).
        /// </summary>
        private static Bq2.TableFieldSchema ProtoToBqField(TableFieldSchema protoField)
        {
            if (protoField == null)
            {
                return null;
            }

            var bqField = new Bq2.TableFieldSchema();
            bqField.Name = protoField.Name ?? "";
            bqField.Description = protoField.Description ?? "";

            if (!s_reverseFieldTypeMap.TryGetValue(protoField.Type, out var type))
            {
                throw new ArgumentException($"Could not convert proto type to bigquery type: {protoField.Type}");
            }
            bqField.Type = type;

            switch (protoField.Mode)
            {
                case TableFieldSchema.Types.Mode.Repeated:
                    bqField.Mode = "REPEATED";
                    break;
                case TableFieldSchema.Types.Mode.Required:
                    bqField.Mode = "REQUIRED";
                    break;
                default:
                    bqField.Mode = "NULLABLE";
                    break;
            }

            if (protoField.Fields != null)
            {
                bqField.Fields = [];
                foreach (var subField in protoField.Fields)
                {
                    bqField.Fields.Add(ProtoToBqField(subField));
                }
            }

            return bqField;
        }

        /// <summary>
        /// Normalizes a user-provided protobuf MessageDescriptor into a self-contained
        /// DescriptorProto, suitable for use in a WriteStream's ProtoSchema.
        /// This method flattens all nested types and resolves dependencies by inlining them.
        /// </summary>
        /// <param name="descriptor">The message descriptor for the data to be written. Must not be null.</param>
        /// <returns>A self-contained DescriptorProto.</returns>
        public static DescriptorProto NormalizeDescriptor(MessageDescriptor descriptor)
        {
            if (descriptor is null)
            {
                throw new ArgumentNullException(nameof(descriptor));
            }
            return new Normalizer(descriptor).Normalize();
        }

        /// <summary>
        /// A helper class to perform the normalization of a MessageDescriptor.
        /// It maintains the state of the normalization process, including visited types to detect recursion.
        /// </summary>
        private class Normalizer
        {
            private readonly MessageDescriptor _rootDescriptor;

            internal Normalizer(MessageDescriptor rootDescriptor)
            {
                _rootDescriptor = rootDescriptor;
            }

            /// <summary>
            /// Starts the normalization process for the root descriptor.
            /// </summary>
            internal DescriptorProto Normalize()
            {
                return NormalizeDescriptorInternal(_rootDescriptor, new HashSet<string>(), new HashSet<string>(), new HashSet<string>(), null);
            }

            /// <summary>
            /// Recursively normalizes a MessageDescriptor. This method processes each field, inlining nested message
            /// and enum types into the root DescriptorProto. It also handles default values and removes features
            /// not supported by the BigQuery Storage Write API, such as oneofs and proto3 optional.
            /// </summary>
            private static DescriptorProto NormalizeDescriptorInternal(MessageDescriptor descriptor, HashSet<string> visitedTypes, HashSet<string> enumTypes, HashSet<string> structTypes, DescriptorProto root)
            {
                if (descriptor == null)
                {
                    throw new ArgumentNullException(nameof(descriptor));
                }

                var resultDp = new DescriptorProto();
                if (root == null)
                {
                    root = resultDp;
                }

                string fullProtoName = descriptor.FullName;
                resultDp.Name = NormalizeName(fullProtoName);
                visitedTypes.Add(fullProtoName);

                foreach (var field in descriptor.Fields.InDeclarationOrder())
                {
                    var resultFdp = field.ToProto();
                    if (!field.HasPresence && field.ToProto().Label != FieldDescriptorProto.Types.Label.Repeated)
                    {
                        switch (resultFdp.Type)
                        {
                            case FieldDescriptorProto.Types.Type.Bool:
                                resultFdp.DefaultValue = "false";
                                break;
                            case FieldDescriptorProto.Types.Type.Bytes:
                            case FieldDescriptorProto.Types.Type.String:
                                resultFdp.DefaultValue = "";
                                break;
                            case FieldDescriptorProto.Types.Type.Enum:
                                var defaultValueText = field.ToProto().DefaultValue;
                                var defaultValue = field.EnumType.FindValueByNumber(string.IsNullOrEmpty(defaultValueText) ? 0 : int.Parse(defaultValueText));
                                resultFdp.DefaultValue = defaultValue.Name;
                                break;
                            case FieldDescriptorProto.Types.Type.Double:
                            case FieldDescriptorProto.Types.Type.Float:
                            case FieldDescriptorProto.Types.Type.Int64:
                            case FieldDescriptorProto.Types.Type.Uint64:
                            case FieldDescriptorProto.Types.Type.Int32:
                            case FieldDescriptorProto.Types.Type.Fixed64:
                            case FieldDescriptorProto.Types.Type.Fixed32:
                            case FieldDescriptorProto.Types.Type.Uint32:
                            case FieldDescriptorProto.Types.Type.Sfixed32:
                            case FieldDescriptorProto.Types.Type.Sfixed64:
                            case FieldDescriptorProto.Types.Type.Sint32:
                            case FieldDescriptorProto.Types.Type.Sint64:
                                resultFdp.DefaultValue = "0";
                                break;
                        }
                    }

                    if (resultFdp.Proto3Optional)
                    {
                        resultFdp.Proto3Optional = false;
                    }

                    if (resultFdp.HasOneofIndex)
                    {
                        resultFdp.ClearOneofIndex();
                    }

                    if (field.FieldType == FieldType.Message || field.FieldType == FieldType.Group)
                    {
                        string msgFullName = field.MessageType.FullName;
                        if (!SkipNormalization(msgFullName))
                        {
                            string normName = NormalizeName(msgFullName);
                            if (structTypes.Contains(msgFullName))
                            {
                                resultFdp.TypeName = normName;
                            }
                            else
                            {
                                if (visitedTypes.Contains(msgFullName))
                                {
                                    throw new InvalidOperationException($"Recursive type not supported: {field.FullName}");
                                }
                                visitedTypes.Add(msgFullName);
                                var dp = NormalizeDescriptorInternal(field.MessageType, visitedTypes, enumTypes, structTypes, root);
                                root.NestedType.Add(dp);
                                visitedTypes.Remove(msgFullName);
                                resultFdp.TypeName = root.NestedType.Last().Name;
                            }
                        }
                    }

                    if (field.FieldType == FieldType.Enum)
                    {
                        string enumFullName = field.EnumType.FullName;
                        string enclosingTypeName = NormalizeName(enumFullName) + "_E";
                        string enumName = field.EnumType.Name;
                        string actualFullName = $"{enclosingTypeName}.{enumName}";
                        if (enumTypes.Contains(enumFullName))
                        {
                            resultFdp.TypeName = actualFullName;
                        }
                        else
                        {
                            var enumDp = new EnumDescriptorProto { Name = enumName };
                            foreach (var value in field.EnumType.Values)
                            {
                                enumDp.Value.Add(value.ToProto());
                            }
                            root.NestedType.Add(new DescriptorProto { Name = enclosingTypeName, EnumType = { enumDp } });
                            resultFdp.TypeName = actualFullName;
                            enumTypes.Add(enumFullName);
                        }
                    }
                    resultDp.Field.Add(resultFdp);
                }

                var sortedFields = resultDp.Field.OrderBy(f => f.Number).ToList();
                resultDp.Field.Clear();
                resultDp.Field.AddRange(sortedFields);
                var sortedNestedTypes = resultDp.NestedType.OrderBy(t => t.Name, StringComparer.Ordinal).ToList();
                resultDp.NestedType.Clear();
                resultDp.NestedType.AddRange(sortedNestedTypes);
                structTypes.Add(fullProtoName);
                return resultDp;
            }

            /// <summary>
            /// Normalizes a protobuf type name by replacing dots with underscores.
            /// This is necessary because nested types are flattened into a single namespace.
            /// </summary>
            private static string NormalizeName(string name) => name.Replace('.', '_');

            private static readonly string[] s_normalizationSkipList =
            {
                // TODO: when backend supports resolving well known types, this list should be enabled.
                // "google.protobuf.DoubleValue",
                // "google.protobuf.FloatValue",
                // "google.protobuf.Int64Value",
                // "google.protobuf.UInt64Value",
                // "google.protobuf.Int32Value",
                // "google.protobuf.Uint32Value",
                // "google.protobuf.BoolValue",
                // "google.protobuf.StringValue",
                // "google.protobuf.BytesValue",
            };

            /// <summary>
            /// A hook to allow skipping normalization for well-known types.
            /// Currently, no types are skipped.
            /// </summary>
            private static bool SkipNormalization(string fullName) => s_normalizationSkipList.Contains(fullName);
        }
    }
}
