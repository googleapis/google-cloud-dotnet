// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;
using Google.Cloud.Spanner.V1;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TypeCode = Google.Cloud.Spanner.V1.TypeCode;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents a Type that can be stored in a Spanner column or returned from a query.
    /// </summary>
    public sealed partial class SpannerDbType
    {
        /// <summary>
        /// Not specified.
        /// </summary>
        public static SpannerDbType Unspecified { get; } = new SpannerDbType(TypeCode.Unspecified);

        /// <summary>
        /// `true` or `false`.
        /// </summary>
        public static SpannerDbType Bool { get; } = new SpannerDbType(TypeCode.Bool);

        /// <summary>
        /// 64 bit signed integer.
        /// </summary>
        public static SpannerDbType Int64 { get; } = new SpannerDbType(TypeCode.Int64);

        /// <summary>
        /// 32 bit floating point number.
        /// </summary>
        public static SpannerDbType Float32 { get; } = new SpannerDbType(TypeCode.Float32);

        /// <summary>
        /// 64 bit floating point number. This is equivalent to Float8 in the PostgreSQL dialect.
        /// </summary>
        public static SpannerDbType Float64 { get; } = new SpannerDbType(TypeCode.Float64);

        /// <summary>
        /// Date and Time.
        /// </summary>
        public static SpannerDbType Timestamp { get; } = new SpannerDbType(TypeCode.Timestamp);

        /// <summary>
        /// A Date.
        /// </summary>
        public static SpannerDbType Date { get; } = new SpannerDbType(TypeCode.Date);

        /// <summary>
        /// A string.
        /// </summary>
        public static SpannerDbType String { get; } = new SpannerDbType(TypeCode.String);

        /// <summary>
        /// A byte array (byte[]).
        /// </summary>
        public static SpannerDbType Bytes { get; } = new SpannerDbType(TypeCode.Bytes);

        /// <summary>
        /// A JSON-formatted string as described in RFC 7159.
        /// </summary>
        public static SpannerDbType Json { get; } = new SpannerDbType(TypeCode.Json);

        /// <summary>
        /// Representation of PostgreSQL JSONB type.
        /// </summary>
        public static SpannerDbType PgJsonb { get; } = new SpannerDbType(TypeCode.Json, TypeAnnotationCode.PgJsonb);

        /// <summary>
        /// A fixed-point number with 29 decimal digits of precision in the whole component and 9 decimal digits of precision in the fractional component.
        /// </summary>
        public static SpannerDbType Numeric { get; } = new SpannerDbType(TypeCode.Numeric);

        /// <summary>
        /// Representation of PostgreSQL numeric type.
        /// The PostgreSQL numeric type has max precision of 147,455 and a max scale of 16383.
        /// </summary>
        public static SpannerDbType PgNumeric { get; } = new SpannerDbType(TypeCode.Numeric, TypeAnnotationCode.PgNumeric);

        /// <summary>
        /// Representation of PostgreSQL OID type.
        /// </summary>
        public static SpannerDbType PgOid { get; } = new SpannerDbType(TypeCode.Int64, TypeAnnotationCode.PgOid);

        /// <summary>
        /// Representation of PostgreSQL Interval type.
        /// </summary>
        public static SpannerDbType Interval { get; } = new SpannerDbType(TypeCode.Interval);

        private static readonly Dictionary<V1.Type, SpannerDbType> s_simpleTypes
            = new Dictionary<V1.Type, SpannerDbType>
            {
                { new V1.Type { Code = TypeCode.Unspecified } , Unspecified },
                { new V1.Type { Code = TypeCode.Bool }, Bool },
                { new V1.Type { Code = TypeCode.Int64 }, Int64 },
                { new V1.Type { Code = TypeCode.Float32 }, Float32 },
                { new V1.Type { Code = TypeCode.Float64 }, Float64 },
                { new V1.Type { Code = TypeCode.Timestamp }, Timestamp },
                { new V1.Type { Code = TypeCode.Date }, Date },
                { new V1.Type { Code = TypeCode.String }, String },
                { new V1.Type { Code = TypeCode.Bytes }, Bytes },
                { new V1.Type { Code = TypeCode.Json }, Json },
                { new V1.Type { Code = TypeCode.Json, TypeAnnotation = TypeAnnotationCode.PgJsonb }, PgJsonb },
                { new V1.Type { Code = TypeCode.Numeric }, Numeric },
                { new V1.Type { Code = TypeCode.Numeric, TypeAnnotation = TypeAnnotationCode.PgNumeric }, PgNumeric },
                { new V1.Type { Code = TypeCode.Int64, TypeAnnotation = TypeAnnotationCode.PgOid }, PgOid },
                { new V1.Type { Code = TypeCode.Interval }, Interval }
            };

        internal static SpannerDbType FromType(V1.Type type) =>
            s_simpleTypes.TryGetValue(type, out SpannerDbType dbType) ?
            dbType : null;

        internal TypeCode TypeCode { get; }

        internal TypeAnnotationCode TypeAnnotationCode { get; }

        /// <summary>
        /// When TypeCode is Array, this is the array element type. Null for non-arrays.
        /// </summary>
        private SpannerDbType ArrayElementType { get; }

        /// <summary>
        /// The field names and types within a struct. Null for non-structs.
        /// This is of type List rather than IList so we can use the protobuf-supplied Lists class for equality
        /// and hash codes.
        /// </summary>
        private List<StructField> StructFields { get; }

        /// <summary>
        /// The fully qualified protobuf message type name if this is a protobuf type. Null for non-protobufs
        /// </summary>
        private string ProtobufTypeName { get; }

        private SpannerDbType(TypeCode typeCode, TypeAnnotationCode typeAnnotationCode = TypeAnnotationCode.Unspecified,
            int? size = null)
        {
            GaxPreconditions.CheckNonNegative(size.GetValueOrDefault(), "Size must be nonnegative.");
            TypeCode = typeCode;
            TypeAnnotationCode = typeAnnotationCode;
            Size = size;
        }

        /// <summary>
        /// The size of the Type, if set.
        /// </summary>
        public int? Size { get; }

        /// <summary>
        /// Builds an instance of <see cref="SpannerDbType"/> that represents an array type
        /// whose elements are of type <paramref name="arrayElementType"/>.
        /// </summary>
        private SpannerDbType(SpannerDbType arrayElementType)
            : this(TypeCode.Array) => ArrayElementType = arrayElementType;

        /// <summary>
        /// Builds an instance of <see cref="SpannerDbType"/> that represents a struct type
        /// whose fields are <paramref name="structFields"/>.
        /// </summary>
        /// <remark>
        /// The list reference is copied directly; callers are expected to be careful.
        /// </remark>
        private SpannerDbType(List<StructField> structFields)
            : this(TypeCode.Struct) => StructFields = structFields;

        private SpannerDbType(string protobufTypeName)
            : this(TypeCode.Proto) => ProtobufTypeName = GaxPreconditions.CheckNotNullOrEmpty(protobufTypeName, nameof(protobufTypeName));

        /// <summary>
        /// The corresponding <see cref="DbType"/> for this Cloud Spanner type.
        /// </summary>
        public DbType DbType
        {
            get
            {
                switch (TypeCode)
                {
                    case TypeCode.Bool:
                        return DbType.Boolean;
                    case TypeCode.Int64:
                        // This handles PG.OID as well.
                        return DbType.Int64;
                    case TypeCode.Float32:
                        return DbType.Single;
                    case TypeCode.Float64:
                        return DbType.Double;
                    case TypeCode.Numeric:
                        // This handles PG numeric as well.
                        return DbType.VarNumeric;
                    case TypeCode.Timestamp:
                        return DbType.DateTime;
                    case TypeCode.Date:
                        return DbType.Date;
                    case TypeCode.String:
                        return DbType.String;
                    case TypeCode.Bytes:
                        return DbType.Binary;
                    case TypeCode.Json:
                        return DbType.String;
                    default:
                        return DbType.Object;
                }
            }
        }

        /// <summary>
        /// Gets the configured <see cref="System.Type"/> for this SpannerDbType based on <see cref="SpannerConversionOptions"/>.
        /// If the configuration for this type doesn't exist in options, the default CLR type is returned.
        /// </summary>
        /// <param name="options">Options to configure the CLR Type for this SpannerDbType.</param>
        /// <returns>The configured <see cref="System.Type"/>.</returns>
        internal System.Type GetConfiguredClrType(SpannerConversionOptions options)
        {
            switch (TypeCode)
            {
                case TypeCode.Bool:
                    return typeof(bool);
                case TypeCode.Int64:
                    return typeof(long);
                case TypeCode.Float32:
                    return typeof(float);
                case TypeCode.Float64:
                    return typeof(double);
                case TypeCode.Timestamp:
                    return typeof(DateTime);
                case TypeCode.Date:
                    return options.DateToConfiguredClrType;
                case TypeCode.String:
                    return typeof(string);
                case TypeCode.Bytes:
                    return typeof(byte[]);
                case TypeCode.Array:
                    return typeof(List<>).MakeGenericType(ArrayElementType.GetConfiguredClrType(options));
                case TypeCode.Struct:
                    return typeof(SpannerStruct);
                case TypeCode.Numeric:
                    if (TypeAnnotationCode == TypeAnnotationCode.PgNumeric)
                    {
                        return typeof(PgNumeric);
                    }
                    return typeof(SpannerNumeric);
                case TypeCode.Json:
                    return typeof(string);
                case TypeCode.Interval:
                    return typeof(Interval);
                default:
                    // If we don't recognize it, we use the protobuf Value well-known type.
                    // But since, as of June 2024, we support protobuf, we need to handle Value
                    // as a special case, as it may be used explicitly as a column type.
                    // We don't do that here though, we do that when we use the CLR value
                    // for conversions.
                    return typeof(Value);
            }
        }

        /// <summary>
        /// The default <see cref="System.Type"/> for this Cloud Spanner type.
        /// </summary>
        public System.Type DefaultClrType => GetConfiguredClrType(SpannerConversionOptions.Default);

        /// <summary>
        /// Converts a <see cref="DbType"/> to the corresponding <see cref="SpannerDbType"/>
        /// </summary>
        internal static SpannerDbType FromDbType(DbType dbType) => dbType switch
        {
            DbType.Binary => Bytes,
            DbType.Boolean => Bool,
            DbType.Date => Date,
            DbType.DateTime => Timestamp,
            DbType.Single => Float32,
            DbType.Double => Float64,
            DbType.Int64 => Int64,
            DbType.VarNumeric => Numeric,
            DbType.Object => Unspecified,
            DbType.String => String,
            _ => throw new ArgumentOutOfRangeException(nameof(DbType), dbType, null),
        };

        internal static SpannerDbType FromProtobufType(V1.Type type)
        {
            switch (type.Code)
            {
                case TypeCode.Array:
                    return new SpannerDbType(FromProtobufType(type.ArrayElementType));
                case TypeCode.Struct:
                    return new SpannerDbType(type.StructType.Fields.Select(f => new StructField(f.Name, FromProtobufType(f.Type))).ToList());
                case TypeCode.Proto:
                    return new SpannerDbType(type.ProtoTypeFqn);
                default:
                    return FromType(type);
            }
        }

        internal V1.Type ToProtobufType()
        {
            switch (TypeCode)
            {
                case TypeCode.Array:
                    return new V1.Type
                    {
                        Code = TypeCode,
                        ArrayElementType = ArrayElementType.ToProtobufType()
                    };
                case TypeCode.Struct:
                    return new V1.Type
                    {
                        Code = TypeCode,
                        StructType =
                            new StructType
                            {
                                Fields = { StructFields.Select(f => f.ToFieldType()) }
                            }
                    };
                case TypeCode.Proto:
                    return new V1.Type
                    {
                        Code = TypeCode,
                        ProtoTypeFqn = ProtobufTypeName
                    };
                default: return new V1.Type { Code = TypeCode, TypeAnnotation = TypeAnnotationCode };
            }
        }

        /// <summary>
        /// Creates an array of the specified type. This can be done on any arbitrary <see cref="SpannerDbType"/>.
        /// You may use any type that implements IEnumerable as a source for the array.  The type of each
        /// item is determined by <paramref name="elementType"/>.
        /// When calling <see cref="SpannerDataReader.GetFieldValue(string)"/> the default type
        /// is <see cref="List{T}"/>. You may, however, specify any type that implements IList which
        /// has a default constructor.
        /// </summary>
        /// <param name="elementType">The type of each item in the array.</param>
        public static SpannerDbType ArrayOf(SpannerDbType elementType) =>
            new SpannerDbType(elementType);


        /// <summary>
        /// Factory method for creating a SpannerDbType from a struct. Public access would be via the instance
        /// method; making this internal allows us to avoid exposing constructors even internally.
        /// </summary>
        internal static SpannerDbType ForStruct(SpannerStruct spannerStruct) =>
            new SpannerDbType(spannerStruct.Select(f => new StructField(f.Name, f.Type)).ToList());

        // Internal for testing, and to continue with the practice of not exposing constructors even internally.
        internal static SpannerDbType ForProtobuf(string protobufTypeName) =>
            new SpannerDbType(protobufTypeName);

        /// <summary>
        /// Returns a SpannerDbType given a ClrType.
        /// If the type cannot be determined, <see cref="SpannerDbType.Unspecified"/> is returned.
        /// </summary>
        /// <param name="type">The clrType to convert.</param>
        /// <returns>The best Spanner representation of the given Clr Type.</returns>
        public static SpannerDbType FromClrType(System.Type type)
        {
            if (type == typeof(bool))
            {
                return Bool;
            }
            if (typeof(IEnumerable<byte>).IsAssignableFrom(type))
            {
                return Bytes;
            }
            if (type == typeof(SpannerDate))
            {
                return Date;
            }
            if (type == typeof(DateTime))
            {
                return Timestamp;
            }
            if (type == typeof(float))
            {
                return Float32;
            }
            if (type == typeof(double))
            {
                return Float64;
            }
            if (type == typeof(short) || type == typeof(int) || type == typeof(long)
                || type == typeof(ulong) || type == typeof(ushort) || type == typeof(uint))
            {
                return Int64;
            }
            if (type == typeof(SpannerNumeric) || type == typeof(decimal))
            {
                return Numeric;
            }
            if (type == typeof(PgNumeric))
            {
                return PgNumeric;
            }
            if (type == typeof(string))
            {
                return String;
            }
            if (ProtobufCache.GetProtobufMessageDescriptor(type) is MessageDescriptor descriptor)
            {
                return new SpannerDbType(descriptor.FullName);
            }
            return Unspecified;
        }

        /// <summary>
        /// Returns a clone of this type with the specified size constraint.
        /// Only valid on <see cref="TypeCode.String"/> and <see cref="TypeCode.Bytes"/>
        /// </summary>
        /// <param name="size">Represents the number of characters (for <see cref="TypeCode.String"/>)
        ///  or bytes (for <see cref="TypeCode.Bytes"/>)</param>
        /// <returns>A new instance of <see cref="SpannerDbType"/> with the same <see cref="TypeCode"/> and new size.</returns>
        public SpannerDbType WithSize(int size)
        {
            if (TypeCode != TypeCode.Bytes && TypeCode != TypeCode.String)
            {
                throw new InvalidOperationException($"Size may only be set on types {nameof(String)} and {nameof(Bytes)}");
            }

            return new SpannerDbType(TypeCode, TypeAnnotationCode, size);
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SpannerDbType);

        private bool Equals(SpannerDbType other) => other != null
            && Lists.Equals(StructFields, other.StructFields)
            && TypeCode == other.TypeCode
            && TypeAnnotationCode == other.TypeAnnotationCode
            && Size == other.Size
            && Equals(ArrayElementType, other.ArrayElementType)
            && ProtobufTypeName == other.ProtobufTypeName;

        /// <inheritdoc />
        public override int GetHashCode() => GaxEqualityHelpers.CombineHashCodes(Lists.GetHashCode(StructFields), Size.GetValueOrDefault(0).GetHashCode(),
            TypeCode.GetHashCode(), TypeAnnotationCode.GetHashCode(), ArrayElementType?.GetHashCode() ?? 0, ProtobufTypeName?.GetHashCode() ?? 0);

        /// <summary>
        /// Value type representing the name and type of a field within a struct. This is like SpannerStruct.Field
        /// but without the value - and it's private. This mostly makes equality comparisons simpler.
        /// </summary>
        private struct StructField : IEquatable<StructField>
        {
            internal string Name { get; }
            internal SpannerDbType Type { get; }

            public StructField(string name, SpannerDbType type)
            {
                Name = GaxPreconditions.CheckNotNull(name, nameof(name));
                Type = GaxPreconditions.CheckNotNull(type, nameof(type));
            }

            public override bool Equals(object obj) => obj is StructField sf && Equals(sf);
            public bool Equals(StructField other) => Name == other.Name && Type.Equals(other.Type);
            public override int GetHashCode() => Name.GetHashCode() * 397 + Type.GetHashCode();

            public StructType.Types.Field ToFieldType() =>
                new StructType.Types.Field { Name = Name, Type = Type.ToProtobufType() };
        }
    }
}
