// Copyright 2018, Google LLC
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

using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using BclType = System.Type;

namespace Google.Cloud.Firestore.Converters
{
    /// <summary>
    /// A converter for a specific enum type.
    /// </summary>
    internal sealed class EnumConverter : ConverterBase
    {
        private static readonly ConcurrentDictionary<BclType, PrimitiveConverter> s_primitiveConverters =
            new ConcurrentDictionary<BclType, PrimitiveConverter>();

        private readonly PrimitiveConverter _converter;

        internal EnumConverter(BclType targetType) : base(targetType)
        {
            _converter = s_primitiveConverters.GetOrAdd(targetType, t => PrimitiveConverter.ForType(t));
        }

        protected override object DeserializeInteger(DeserializationContext context, long value) => _converter.Int64ToEnum(value);

        public override Value Serialize(object value) => new Value { IntegerValue = _converter.EnumToInt64(value) };

        // This is really ugly in terms of repetition, but reasonably simple. I've failed to come up with anything cleaner :(
        private abstract class PrimitiveConverter
        {
            private static readonly Dictionary<TypeCode, BclType> s_genericTypes = new Dictionary<TypeCode, BclType>
            {
                { TypeCode.Byte, typeof(ByteEnumConverter<>) },
                { TypeCode.SByte, typeof(SByteEnumConverter<>) },
                { TypeCode.Int16, typeof(Int16EnumConverter<>) },
                { TypeCode.UInt16, typeof(UInt16EnumConverter<>) },
                { TypeCode.Int32, typeof(Int32EnumConverter<>) },
                { TypeCode.UInt32, typeof(UInt32EnumConverter<>) },
                { TypeCode.Int64, typeof(Int64EnumConverter<>) },
                { TypeCode.UInt64, typeof(UInt64EnumConverter<>) },
            };

            internal abstract object Int64ToEnum(long value);
            internal abstract long EnumToInt64(object value);

            internal static PrimitiveConverter ForType(BclType type)
            {
                TypeCode underlyingTypeCode = BclType.GetTypeCode(type.GetTypeInfo().GetEnumUnderlyingType());
                if (!s_genericTypes.TryGetValue(underlyingTypeCode, out var genericConverterType))
                {
                    throw new InvalidOperationException($"Unexpected underlying type code for enum: {underlyingTypeCode}");
                }
                return (PrimitiveConverter) Activator.CreateInstance(genericConverterType.MakeGenericType(type));
            }

            private sealed class ByteEnumConverter<T> : PrimitiveConverter
            {
                internal override long EnumToInt64(object value) => checked((byte) value);
                internal override object Int64ToEnum(long value) => (T) (object) checked((byte) value);
            }

            private sealed class SByteEnumConverter<T> : PrimitiveConverter
            {
                internal override long EnumToInt64(object value) => checked((sbyte) value);
                internal override object Int64ToEnum(long value) => (T) (object) checked((sbyte) value);
            }

            private sealed class Int16EnumConverter<T> : PrimitiveConverter
            {
                internal override long EnumToInt64(object value) => checked((short) value);
                internal override object Int64ToEnum(long value) => (T) (object) checked((short) value);
            }

            private sealed class UInt16EnumConverter<T> : PrimitiveConverter
            {
                internal override long EnumToInt64(object value) => checked((ushort) value);
                internal override object Int64ToEnum(long value) => (T) (object) checked((ushort) value);
            }

            private sealed class Int32EnumConverter<T> : PrimitiveConverter
            {
                internal override long EnumToInt64(object value) => checked((int) value);
                internal override object Int64ToEnum(long value) => (T) (object) checked((int) value);
            }

            private sealed class UInt32EnumConverter<T> : PrimitiveConverter
            {
                internal override long EnumToInt64(object value) => checked((uint) value);
                internal override object Int64ToEnum(long value) => (T) (object) checked((uint) value);
            }

            private sealed class Int64EnumConverter<T> : PrimitiveConverter
            {
                internal override long EnumToInt64(object value) => (long) value;
                internal override object Int64ToEnum(long value) => (T) (object) value;
            }

            private sealed class UInt64EnumConverter<T> : PrimitiveConverter
            {
                internal override long EnumToInt64(object value) => checked((long) (ulong) value);
                internal override object Int64ToEnum(long value) => (T) (object) checked((ulong) value);
            }
        }
    }
}
