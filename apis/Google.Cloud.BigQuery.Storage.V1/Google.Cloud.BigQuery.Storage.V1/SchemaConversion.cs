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

using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Google.Cloud.BigQuery.Storage.V1
{
    public static partial class SchemaAdapter
    {
        /// <summary>
        /// Converts a <see cref="TableSchema"/> to a <see cref="IDescriptor"/>.
        /// </summary>
        /// <param name="schema">The schema to convert.</param>
        /// <param name="scope">The scope for the generated descriptor.</param>
        /// <param name="options">The options for the conversion.</param>
        /// <returns>The generated descriptor.</returns>
        public static IDescriptor StorageSchemaToProtoDescriptor(TableSchema schema, string scope, params ProtoConversionOption[] options)
        {
            var config = new CustomConfig();
            foreach (var option in options)
            {
                option.Apply(config);
            }
            return new DescriptorConverter(schema, scope, config).Convert();
        }

        /// <summary>
        /// Private class to handle the conversion of a TableSchema to a protobuf Descriptor.
        /// This class maintains the state of the conversion, including the schema, scope, and any custom configurations.
        /// It also uses a dependency cache to avoid reprocessing identical sub-schemas.
        /// </summary>
        private class DescriptorConverter
        {
            private readonly TableSchema _schema;
            private readonly string _scope;
            private readonly CustomConfig _config;
            private readonly DependencyCache _dependencyCache = new DependencyCache();

            internal DescriptorConverter(TableSchema schema, string scope, CustomConfig config)
            {
                _schema = schema;
                _scope = scope;
                _config = config;
            }

            /// <summary>
            /// Initiates the conversion process from TableSchema to a protobuf Descriptor.
            /// This is the entry point for the conversion logic within the DescriptorConverter.
            /// </summary>
            /// <returns>The generated IDescriptor.</returns>
            internal IDescriptor Convert()
            {
                return StorageSchemaToDescriptorInternal(_schema, _scope, _dependencyCache, _config);
            }

            /// <summary>
            /// Recursively converts a TableSchema to a MessageDescriptor.
            /// This method processes each field in the schema, handling nested structs by recursively calling itself.
            /// It builds a list of dependencies and constructs the final FileDescriptorProto.
            /// </summary>
            private static MessageDescriptor StorageSchemaToDescriptorInternal(TableSchema inSchema, string scope, DependencyCache cache, CustomConfig cfg)
            {
                if (inSchema == null)
                {
                    throw new ArgumentNullException(nameof(inSchema));
                }

                var fields = new List<FieldDescriptorProto>();
                var deps = new HashSet<FileDescriptor>();
                int fNumber = 0;

                foreach (var f in inSchema.Fields)
                {
                    fNumber++;
                    string currentScope = $"{scope}__{f.Name}";

                    if (f.Type == TableFieldSchema.Types.Type.Struct)
                    {
                        var subSchema = new TableSchema();
                        subSchema.Fields.AddRange(f.Fields);

                        var foundDesc = cache.Get(subSchema);
                        if (foundDesc != null)
                        {
                            deps.Add(foundDesc.File);
                            fields.Add(TableFieldSchemaToFieldDescriptorProto(f, fNumber, foundDesc.FullName, cfg));
                        }
                        else
                        {
                            var desc = StorageSchemaToDescriptorInternal(subSchema, currentScope, cache, cfg);
                            deps.Add(desc.File);
                            cache.Add(subSchema, desc);
                            fields.Add(TableFieldSchemaToFieldDescriptorProto(f, fNumber, currentScope, cfg));
                        }
                    }
                    else
                    {
                        fields.Add(TableFieldSchemaToFieldDescriptorProto(f, fNumber, currentScope, cfg));
                    }
                }

                var dp = new DescriptorProto
                {
                    Name = scope,
                };
                dp.Field.AddRange(fields);

                var depNames = new HashSet<string> { "google/protobuf/wrappers.proto" };
                foreach (var overrideMapping in cfg.ProtoMappingOverrides)
                {
                    if (s_extraWellKnownTypesPerTypeName.TryGetValue(overrideMapping.TypeName, out var dep))
                    {
                        depNames.Add(dep.Name);
                    }
                }
                foreach (var d in deps)
                {
                    depNames.Add(d.Name);
                }

                var fdp = new FileDescriptorProto
                {
                    Name = $"{scope}.proto",
                    Syntax = cfg.UseProto3 ? "proto3" : "proto2",
                };
                fdp.MessageType.Add(dp);
                fdp.Dependency.AddRange(depNames);
                cache.Add(fdp);

                var fdpList = new List<FileDescriptorProto> { WrappersReflection.Descriptor.ToProto() };
                foreach (var overrideMapping in cfg.ProtoMappingOverrides)
                {
                    if (s_extraWellKnownTypesPerTypeName.TryGetValue(overrideMapping.TypeName, out var dep))
                    {
                        fdpList.Add(dep.FileDescriptor);
                    }
                }
                fdpList.AddRange(cache.GetFileDescriptorProtos());

                var fileDescriptors = FileDescriptor.BuildFromByteStrings(fdpList.Select(p => p.ToByteString()));
                return (MessageDescriptor)fileDescriptors.FirstOrDefault(fd => fd.Name == fdp.Name)?.FindTypeByName<IDescriptor>(scope);
            }
        }

        /// <summary>
        /// Maps BigQuery field types to their corresponding Protocol Buffers field types.
        /// This is used for direct type-to-type conversion where no special handling is needed.
        /// </summary>
        private static readonly Dictionary<TableFieldSchema.Types.Type, FieldDescriptorProto.Types.Type> s_bqTypeToFieldTypeMap = new Dictionary<TableFieldSchema.Types.Type, FieldDescriptorProto.Types.Type>
        {
            [TableFieldSchema.Types.Type.Bignumeric] = FieldDescriptorProto.Types.Type.Bytes,
            [TableFieldSchema.Types.Type.Bool] = FieldDescriptorProto.Types.Type.Bool,
            [TableFieldSchema.Types.Type.Bytes] = FieldDescriptorProto.Types.Type.Bytes,
            [TableFieldSchema.Types.Type.Date] = FieldDescriptorProto.Types.Type.Int32,
            [TableFieldSchema.Types.Type.Datetime] = FieldDescriptorProto.Types.Type.Int64,
            [TableFieldSchema.Types.Type.Double] = FieldDescriptorProto.Types.Type.Double,
            [TableFieldSchema.Types.Type.Geography] = FieldDescriptorProto.Types.Type.String,
            [TableFieldSchema.Types.Type.Int64] = FieldDescriptorProto.Types.Type.Int64,
            [TableFieldSchema.Types.Type.Numeric] = FieldDescriptorProto.Types.Type.Bytes,
            [TableFieldSchema.Types.Type.String] = FieldDescriptorProto.Types.Type.String,
            [TableFieldSchema.Types.Type.Struct] = FieldDescriptorProto.Types.Type.Message,
            [TableFieldSchema.Types.Type.Time] = FieldDescriptorProto.Types.Type.Int64,
            [TableFieldSchema.Types.Type.Timestamp] = FieldDescriptorProto.Types.Type.Int64,
            [TableFieldSchema.Types.Type.Range] = FieldDescriptorProto.Types.Type.Message,
            [TableFieldSchema.Types.Type.Json] = FieldDescriptorProto.Types.Type.String,
        };

        /// <summary>
        /// A dictionary that maps fully qualified type names of well-known Protobuf types
        /// to their corresponding file names and file descriptors. This is used to add
        /// necessary dependencies when these types are used in custom mappings.
        /// </summary>
        private static readonly IReadOnlyDictionary<string, (string Name, FileDescriptorProto FileDescriptor)> s_extraWellKnownTypesPerTypeName = new Dictionary<string, (string, FileDescriptorProto)>()
        {
            [".google.protobuf.Timestamp"] = ("google/protobuf/timestamp.proto", TimestampReflection.Descriptor.ToProto()),
            [".google.protobuf.Duration"] = ("google/protobuf/duration.proto", DurationReflection.Descriptor.ToProto()),
        };

        /// <summary>
        /// Converts a single BigQuery TableFieldSchema to a FieldDescriptorProto.
        /// This method handles the conversion of field name, number, and type.
        /// It also renames fields that are not valid protobuf identifiers and adds an annotation with the original name.
        /// </summary>
        private static FieldDescriptorProto TableFieldSchemaToFieldDescriptorProto(TableFieldSchema field, int idx, string scope, CustomConfig cfg)
        {
            string name = field.Name;
            FieldDescriptorProto fdp;

            if (field.Type == TableFieldSchema.Types.Type.Struct)
            {
                fdp = new FieldDescriptorProto
                {
                    Name = name,
                    Number = idx,
                    TypeName = scope,
                    Label = ConvertModeToLabel(field.Mode, cfg.UseProto3)
                };
            }
            else
            {
                var (typeName, outType, label) = ResolveType(scope, field, cfg);
                fdp = new FieldDescriptorProto
                {
                    Name = name,
                    Number = idx,
                    Type = outType,
                    Label = label
                };
                // Only set TypeName if it's a message type
                if (outType == FieldDescriptorProto.Types.Type.Message)
                {
                    fdp.TypeName = typeName;
                }
            }
            if (NameRequiresAnnotation(name))
            {
                string encodedName = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(name)).TrimEnd('=').Replace('+', '-').Replace('/', '_');
                fdp.Name = $"col_{encodedName}";
                fdp.Options = fdp.Options ?? new FieldOptions();
                fdp.Options.SetExtension(AnnotationsExtensions.ColumnName, name);
            }
            return fdp;
        }

        /// <summary>
        /// Resolves the Protobuf type, type name, and label for a given BigQuery field.
        /// This method checks for any custom type mappings and handles nullable fields in proto3
        /// by using wrapper types.
        /// </summary>
        private static (string TypeName, FieldDescriptorProto.Types.Type, FieldDescriptorProto.Types.Label) ResolveType(string scope, TableFieldSchema field, CustomConfig cfg)
        {
            string path = scope.Contains("__") ? scope.Substring(scope.IndexOf("__") + 2).Replace("__", ".") : scope;
            var overrideMapping = cfg.GetByField(field, path);

            if (overrideMapping != null)
            {
                return (overrideMapping.TypeName, overrideMapping.Type, ConvertModeToLabel(field.Mode, cfg.UseProto3));
            }

            if (field.Mode != TableFieldSchema.Types.Mode.Nullable || !cfg.UseProto3)
            {
                return ("", s_bqTypeToFieldTypeMap[field.Type], ConvertModeToLabel(field.Mode, cfg.UseProto3));
            }

            return (s_bqTypeToWrapperMap[field.Type], FieldDescriptorProto.Types.Type.Message, FieldDescriptorProto.Types.Label.Optional);
        }

        /// <summary>
        /// Maps BigQuery field types to their corresponding Protobuf wrapper types.
        /// This is used for nullable fields in proto3 to distinguish between a default value and a value that was not provided.
        /// </summary>
        private static readonly Dictionary<TableFieldSchema.Types.Type, string> s_bqTypeToWrapperMap = new Dictionary<TableFieldSchema.Types.Type, string>
        {
            [TableFieldSchema.Types.Type.Bignumeric] = ".google.protobuf.BytesValue",
            [TableFieldSchema.Types.Type.Bool] = ".google.protobuf.BoolValue",
            [TableFieldSchema.Types.Type.Bytes] = ".google.protobuf.BytesValue",
            [TableFieldSchema.Types.Type.Date] = ".google.protobuf.Int32Value",
            [TableFieldSchema.Types.Type.Datetime] = ".google.protobuf.Int64Value",
            [TableFieldSchema.Types.Type.Double] = ".google.protobuf.DoubleValue",
            [TableFieldSchema.Types.Type.Geography] = ".google.protobuf.StringValue",
            [TableFieldSchema.Types.Type.Int64] = ".google.protobuf.Int64Value",
            [TableFieldSchema.Types.Type.Numeric] = ".google.protobuf.BytesValue",
            [TableFieldSchema.Types.Type.String] = ".google.protobuf.StringValue",
            [TableFieldSchema.Types.Type.Time] = ".google.protobuf.Int64Value",
            [TableFieldSchema.Types.Type.Timestamp] = ".google.protobuf.Int64Value",
            [TableFieldSchema.Types.Type.Json] = ".google.protobuf.StringValue",
        };

        private static FieldDescriptorProto.Types.Label ConvertModeToLabel(TableFieldSchema.Types.Mode mode, bool useProto3)
        {
            if (useProto3)
            {
                return mode == TableFieldSchema.Types.Mode.Repeated ? FieldDescriptorProto.Types.Label.Repeated : FieldDescriptorProto.Types.Label.Optional;
            }
            switch (mode)
            {
                case TableFieldSchema.Types.Mode.Nullable: return FieldDescriptorProto.Types.Label.Optional;
                case TableFieldSchema.Types.Mode.Repeated: return FieldDescriptorProto.Types.Label.Repeated;
                case TableFieldSchema.Types.Mode.Required: return FieldDescriptorProto.Types.Label.Required;
                default: return FieldDescriptorProto.Types.Label.Optional;
            }
        }

        /// <summary>
        /// Determines if a field name is a valid protobuf identifier.
        /// If not, it will require an annotation to preserve the original BigQuery column name.
        /// </summary>
        private static bool NameRequiresAnnotation(string name) => !Regex.IsMatch(name, "^[a-zA-Z_][a-zA-Z0-9_]*$");

        /// <summary>
        /// Caches descriptors for nested schemas to avoid re-computing them.
        /// This is particularly useful for schemas with repeated or complex struct types.
        /// The cache uses the string representation of a TableSchema as the key.
        /// </summary>
        private class DependencyCache
        {
            private readonly Dictionary<string, MessageDescriptor> _msgs = new Dictionary<string, MessageDescriptor>();
            private readonly Dictionary<string, FileDescriptorProto> _fdps = new Dictionary<string, FileDescriptorProto>();

            internal MessageDescriptor Get(TableSchema schema)
            {
                string key = schema.ToString();
                _msgs.TryGetValue(key, out var descriptor);
                return descriptor;
            }

            internal void Add(TableSchema schema, MessageDescriptor descriptor)
            {
                string key = schema.ToString();
                _msgs[key] = descriptor;
            }

            internal void Add(FileDescriptorProto fdp)
            {
                _fdps[fdp.Name] = fdp;
            }

            internal IEnumerable<FileDescriptorProto> GetFileDescriptorProtos()
            {
                var fromMsgs = _msgs.Values.Select(d => d.File.ToProto());
                var fromFdps = _fdps.Values;
                return fromMsgs.Concat(fromFdps).Distinct(new FileDescriptorProtoComparer());
            }

            private class FileDescriptorProtoComparer : IEqualityComparer<FileDescriptorProto>
            {
                public bool Equals(FileDescriptorProto x, FileDescriptorProto y) => x.Name == y.Name;
                public int GetHashCode(FileDescriptorProto obj) => obj.Name.GetHashCode();
            }
        }
    }

    /// <summary>
    /// An option to customize proto descriptor conversion.
    /// </summary>
    public abstract class ProtoConversionOption
    {
        internal ProtoConversionOption() { }

        internal abstract void Apply(CustomConfig config);
    }

    internal class CustomConfig
    {
        internal List<ProtoMapping> ProtoMappingOverrides { get; } = new List<ProtoMapping>();
        internal bool UseProto3 { get; set; }

        internal ProtoMapping GetByField(TableFieldSchema field, string path)
        {
            ProtoMapping foundOverride = null;
            foreach (var overrideMapping in ProtoMappingOverrides)
            {
                if (overrideMapping.FieldPath == path)
                {
                    return overrideMapping;
                }
                if (overrideMapping.FieldType == field.Type)
                {
                    foundOverride = overrideMapping;
                }
            }
            return foundOverride;
        }
    }

    /// <summary>
    /// Can be used to override protobuf types used when converting from a BigQuery Schema to a Protobuf Descriptor.
    /// </summary>
    public sealed class ProtoMapping
    {
        /// <summary>
        /// The path to the field, e.g. "fieldA.subFieldB.anotherSubFieldC".
        /// </summary>
        public string FieldPath { get; set; }

        /// <summary>
        /// The BigQuery table field type to be overridden.
        /// </summary>
        public TableFieldSchema.Types.Type FieldType { get; set; }

        /// <summary>
        /// The full qualified path name for the protobuf type, e.g. ".google.protobuf.Timestamp".
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// The final descriptor proto type.
        /// </summary>
        public FieldDescriptorProto.Types.Type Type { get; set; }
    }

    /// <summary>
    /// An option to provide a <see cref="ProtoMapping"/>.
    /// </summary>
    public sealed class WithProtoMappingOption : ProtoConversionOption
    {
        private readonly ProtoMapping _mapping;

        /// <summary>
        /// Creates a new instance of <see cref="WithProtoMappingOption"/>.
        /// </summary>
        /// <param name="mapping">The mapping to use.</param>
        public WithProtoMappingOption(ProtoMapping mapping)
        {
            _mapping = mapping;
            if (!string.IsNullOrEmpty(_mapping.TypeName) && !_mapping.TypeName.StartsWith("."))
            {
                _mapping.TypeName = "." + _mapping.TypeName;
            }
        }

        internal override void Apply(CustomConfig config)
        {
            config.ProtoMappingOverrides.Add(_mapping);
        }
    }
}
