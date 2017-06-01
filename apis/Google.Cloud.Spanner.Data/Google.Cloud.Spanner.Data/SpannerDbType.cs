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
    /// These types come from Google.Cloud.Spanner.V1.TypeCode
    /// </summary>
    public sealed class SpannerDbType
    {
        private SpannerDbType(TypeCode typeCode)
        {
            TypeCode = typeCode;
        }

        private SpannerDbType(TypeCode typeCode, SpannerDbType arrayElementType)
            :this(typeCode)
        {
            ArrayElementType = arrayElementType;
        }

        private SpannerDbType(TypeCode typeCode, IDictionary<string, SpannerDbType> structMembers)
            : this(typeCode)
        {
            StructMembers = structMembers;
        }

        private SpannerDbType(TypeCode typeCode, RepeatedField<StructType.Types.Field> structTypeFields)
            : this(typeCode)
        {
            StructMembers = new Dictionary<string, SpannerDbType>();
            foreach (StructType.Types.Field field in structTypeFields)
            {
                StructMembers[field.Name] = FromProtoBufType(field.Type);
            }
        }

        internal static SpannerDbType FromProtoBufType(V1.Type type)
        {
            switch (type.Code)
            {
                case TypeCode.Array:
                    return new SpannerDbType(TypeCode.Array,
                        FromProtoBufType(type.ArrayElementType));
                case TypeCode.Struct:
                    return new SpannerDbType(TypeCode.Struct, type.StructType.Fields);
                default:
                    return new SpannerDbType(type.Code);
            }
        }

        internal V1.Type ToProtoBufType()
        {
            switch (TypeCode)
            {
                case TypeCode.Array:
                    return new V1.Type
                    {
                        Code = TypeCode,
                        ArrayElementType = ArrayElementType.ToProtoBufType()
                    };
                case TypeCode.Struct:
                    return new V1.Type {
                        Code = TypeCode,
                        StructType =
                            new StructType {
                                Fields = {
                                    StructMembers.Select(kvp => new StructType.Types.Field {
                                        Name = kvp.Key,
                                        Type = kvp.Value.ToProtoBufType()
                                    })
                                }
                            }
                    };
                default: return new V1.Type {Code = TypeCode};
            }
        }

        /// <summary>
        /// Not specified.
        /// </summary>
        public static SpannerDbType Unspecified { get; } = new SpannerDbType(TypeCode.Unspecified);

        /// <summary>
        /// Encoded as JSON `true` or `false`.
        /// </summary>
        public static SpannerDbType Bool { get; } = new SpannerDbType(TypeCode.Bool);

        /// <summary>
        /// Encoded as `string`, in decimal format.
        /// </summary>
        public static SpannerDbType Int64 { get; } = new SpannerDbType(TypeCode.Int64);

        /// <summary>
        /// Encoded as `number`, or the strings `"NaN"`, `"Infinity"`, or
        /// `"-Infinity"`.
        /// </summary>
        public static SpannerDbType Float64 { get; } = new SpannerDbType(TypeCode.Float64);

        /// <summary>
        /// Encoded as `string` in RFC 3339 timestamp format. The time zone
        /// must be present, and must be `"Z"`.
        /// </summary>
        public static SpannerDbType Timestamp { get; } = new SpannerDbType(TypeCode.Timestamp);

        /// <summary>
        /// Encoded as `string` in RFC 3339 date format.
        /// </summary>
        public static SpannerDbType Date { get; } = new SpannerDbType(TypeCode.Date);

        /// <summary>
        /// Encoded as `string`.
        /// </summary>
        public static SpannerDbType String { get; } = new SpannerDbType(TypeCode.String);

        /// <summary>
        /// Encoded as a base64-encoded `string`, as described in RFC 4648,
        /// section 4.
        /// </summary>
        public static SpannerDbType Bytes { get; } = new SpannerDbType(TypeCode.Bytes);

        /// <summary>
        /// Encoded as `list`, where the list elements are represented
        /// according to [array_element_type][google.spanner.v1.Type.array_element_type].
        /// </summary>
        public static SpannerDbType ArrayOf(SpannerDbType elementType) => new SpannerDbType(TypeCode.Array, elementType);

        /// <summary>
        /// Encoded as `list`, where list element `i` is represented according
        /// to [struct_type.fields[i]][google.spanner.v1.StructType.fields].
        /// </summary>
        public static SpannerDbType StructOf(IDictionary<string, SpannerDbType> structMembers) => new SpannerDbType(TypeCode.Struct, structMembers);

        internal TypeCode TypeCode { get; }

        internal SpannerDbType ArrayElementType { get; }

        internal IDictionary<string, SpannerDbType> StructMembers { get; }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return Equals(obj as SpannerDbType);
        }

        private bool Equals(SpannerDbType other)
        {
            return DictionaryEquals(StructMembers, other?.StructMembers) 
                && TypeCode == other?.TypeCode 
                && Equals(ArrayElementType, other.ArrayElementType);
        }

        private bool DictionaryEquals(IDictionary<string, SpannerDbType> d1, IDictionary<string, SpannerDbType> d2)
        {
            if (d1 == null && d2 == null) return true;
            if (d1 == null || d2 == null) return false;
            if (d1.Count != d2.Count) return false;
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
                var hashCode = StructMembers?.GetHashCode() ?? 0;
                hashCode = (hashCode * 397) ^ (int) TypeCode;
                hashCode = (hashCode * 397) ^ (ArrayElementType?.GetHashCode() ?? 0);
                return hashCode;
            }
        }
    }
}