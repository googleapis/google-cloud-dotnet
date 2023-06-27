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
        private readonly TypeCode _typeCode;

        internal EnumConverter(BclType targetType) : base(targetType)
        {
            _typeCode = BclType.GetTypeCode(TargetType);
        }

        protected override object DeserializeInteger(IDeserializationContext context, long value)
        {
            object baseValue = Int64ToEnumBaseType(value);
            return Enum.ToObject(TargetType, baseValue);
        }

        public override Value Serialize(SerializationContext context, object value) =>
            new Value { IntegerValue = EnumToInt64(value) };

        private long EnumToInt64(object value)
        {
            switch (_typeCode)
            {
                case TypeCode.Byte: return checked((byte) value);
                case TypeCode.SByte: return checked((sbyte) value);
                case TypeCode.Int16: return checked((short) value);
                case TypeCode.UInt16: return checked((ushort) value);
                case TypeCode.Int32: return checked((int) value);
                case TypeCode.UInt32: return checked((uint) value);
                case TypeCode.Int64: return checked((long) value);
                case TypeCode.UInt64: return checked((long) (ulong) value);
                default:
                    throw new InvalidOperationException($"Unexpected underlying type code for enum: {_typeCode}");
            }
        }

        private object Int64ToEnumBaseType(long value)
        {
            switch (_typeCode)
            {
                case TypeCode.Byte: return checked((byte) value);
                case TypeCode.SByte: return checked((sbyte) value);
                case TypeCode.Int16: return checked((short) value);
                case TypeCode.UInt16: return checked((ushort) value);
                case TypeCode.Int32: return checked((int) value);
                case TypeCode.UInt32: return checked((uint) value);
                case TypeCode.Int64: return value;
                case TypeCode.UInt64: return checked((ulong) value);
                default:
                    throw new InvalidOperationException($"Unexpected underlying type code for enum: {_typeCode}");
            }
        }
    }
}
