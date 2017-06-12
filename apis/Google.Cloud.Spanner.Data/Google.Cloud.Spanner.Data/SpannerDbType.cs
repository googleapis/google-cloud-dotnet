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

using System.Collections.Generic;
using System.Linq;
using Google.Cloud.Spanner.V1;
using Google.Protobuf.Collections;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents a Type that can be stored in a Spanner column or returned from a query.
    /// </summary>
    public sealed class SpannerDbType
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
        /// 64 bit floating point number.
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

        internal TypeCode TypeCode { get; }

        internal SpannerDbType ArrayElementType { get; }

        internal IDictionary<string, SpannerDbType> StructMembers { get; }

        private SpannerDbType(TypeCode typeCode) => TypeCode = typeCode;

        private SpannerDbType(TypeCode typeCode, SpannerDbType arrayElementType)
            : this(typeCode) => ArrayElementType = arrayElementType;

        private SpannerDbType(TypeCode typeCode, IDictionary<string, SpannerDbType> structMembers)
            : this(typeCode) => StructMembers = structMembers;

        private SpannerDbType(TypeCode typeCode, RepeatedField<StructType.Types.Field> structTypeFields)
            : this(typeCode)
        {
            StructMembers = new Dictionary<string, SpannerDbType>();
            foreach (var field in structTypeFields)
            {
                StructMembers[field.Name] = FromProtoBufType(field.Type);
            }
        }

        internal static SpannerDbType FromProtoBufType(V1.Type type)
        {
            switch (type.Code)
            {
                case TypeCode.Array:
                    return new SpannerDbType(
                        TypeCode.Array,
                        FromProtoBufType(type.ArrayElementType));
                case TypeCode.Struct:
                    return new SpannerDbType(TypeCode.Struct, type.StructType.Fields);
                default:
                    return new SpannerDbType(type.Code);
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
                                Fields =
                                {
                                    StructMembers.Select(
                                        kvp => new StructType.Types.Field
                                        {
                                            Name = kvp.Key,
                                            Type = kvp.Value.ToProtobufType()
                                        })
                                }
                            }
                    };
                default: return new V1.Type {Code = TypeCode};
            }
        }

        /// <summary>
        /// Creates an array of the specified type. This can be done on any arbitrary <see cref="SpannerDbType"/>.
        /// </summary>
        public static SpannerDbType ArrayOf(SpannerDbType elementType) =>
            new SpannerDbType(TypeCode.Array, elementType);


        /// <summary>
        /// Creates a struct of the specified type.
        /// A struct has field names and field values.
        /// </summary>
        /// <param name="structMembers">A dictionary containing the field names and types of each member of the struct.</param>
        /// <returns></returns>
        public static SpannerDbType StructOf(IDictionary<string, SpannerDbType> structMembers) => new SpannerDbType(
            TypeCode.Struct, structMembers);

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SpannerDbType);

        private bool Equals(SpannerDbType other) => DictionaryEquals(StructMembers, other?.StructMembers)
            && TypeCode == other?.TypeCode
            && Equals(ArrayElementType, other.ArrayElementType);

        private bool DictionaryEquals(IDictionary<string, SpannerDbType> d1, IDictionary<string, SpannerDbType> d2)
        {
            if (d1 == null && d2 == null)
            {
                return true;
            }

            if (d1 == null || d2 == null)
            {
                return false;
            }

            if (d1.Count != d2.Count)
            {
                return false;
            }

            foreach (var kvp in d1)
            {
                SpannerDbType d2Value;
                if (!d2.TryGetValue(kvp.Key, out d2Value) || !kvp.Value.Equals(d2Value))
                {
                    return false;
                }
            }
            return true;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = StructMembers?.GetHashCode() ?? 0;
                hashCode = (hashCode * 397) ^ (int) TypeCode;
                hashCode = (hashCode * 397) ^ (ArrayElementType?.GetHashCode() ?? 0);
                return hashCode;
            }
        }
    }
}
