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

using System;
using System.Collections;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Xml;
using Google.Protobuf.WellKnownTypes;
using TypeCode = Google.Cloud.Spanner.V1.TypeCode;

namespace Google.Cloud.Spanner.Data
{
    internal static class TypeMap
    {
        public static object ConvertToClrType(this Value wireValue, V1.Type spannerType)
        {
            return ConvertToClrType(wireValue, spannerType, spannerType?.Code.GetDefaultClrTypeFromSpannerType());
        }

        public static T ConvertToClrType<T>(this Value wireValue,
            V1.Type spannerType) {
            return (T) ConvertToClrType(wireValue, spannerType, typeof(T));
        }

        public static object ConvertToClrType(this Value wireValue, V1.Type spannerType, System.Type targetClrType)
        {
            //extra supported conversions that are modifications of the "core" versions but may have loss of precision.
            //we call the spannerType with the known supported version and cast it down to lose precision.
            if (targetClrType == typeof(int))
                return Convert.ToInt32((long) ConvertToClrTypeImpl(wireValue, spannerType, typeof(long)));
            if (targetClrType == typeof(uint))
                return Convert.ToUInt32((long) ConvertToClrTypeImpl(wireValue, spannerType, typeof(long)));
            if (targetClrType == typeof(short))
                return Convert.ToInt16((long) ConvertToClrTypeImpl(wireValue, spannerType, typeof(long)));
            if (targetClrType == typeof(ushort))
                return Convert.ToUInt16((long) ConvertToClrTypeImpl(wireValue, spannerType, typeof(long)));
            if (targetClrType == typeof(char))
                return Convert.ToChar((long) ConvertToClrTypeImpl(wireValue, spannerType, typeof(long)));
            if (targetClrType == typeof(byte))
                return Convert.ToByte((long) ConvertToClrTypeImpl(wireValue, spannerType, typeof(long)));
            if (targetClrType == typeof(decimal))
                return Convert.ToDecimal((long) ConvertToClrTypeImpl(wireValue, spannerType, typeof(decimal)));
            if (targetClrType == typeof(float))
                return Convert.ToSingle((double) ConvertToClrTypeImpl(wireValue, spannerType, typeof(double)));
            if (targetClrType == typeof(Guid))
                return Guid.Parse((string) ConvertToClrTypeImpl(wireValue, spannerType, typeof(string)));
            return ConvertToClrTypeImpl(wireValue, spannerType, targetClrType);
        }

        public static DbType GetDbType(this TypeCode spannerType)
        {
            switch (spannerType)
            {
                case TypeCode.Bool:
                    return DbType.Boolean;
                case TypeCode.Int64:
                    return DbType.Int64;
                case TypeCode.Float64:
                    return DbType.Double;
                case TypeCode.Timestamp:
                    return DbType.DateTime;
                case TypeCode.Date:
                    return DbType.Date;
                case TypeCode.String:
                    return DbType.String;
                case TypeCode.Bytes:
                    return DbType.Binary;
                case TypeCode.Unspecified:
                case TypeCode.Array:
                case TypeCode.Struct:
                    return DbType.Object;
                default:
                    throw new ArgumentOutOfRangeException(nameof(spannerType), spannerType, null);
            }
        }

        public static System.Type GetDefaultClrTypeFromSpannerType(this TypeCode code)
        {
            switch (code)
            {
                case TypeCode.Bool:
                    return typeof(bool);
                case TypeCode.Int64:
                    return typeof(long);
                case TypeCode.Float64:
                    return typeof(double);
                case TypeCode.Timestamp:
                case TypeCode.Date:
                    return typeof(DateTime);
                case TypeCode.String:
                    return typeof(string);
                case TypeCode.Bytes:
                    return typeof(byte[]);
                case TypeCode.Array:
                    return typeof(IList);
                case TypeCode.Struct:
                    return typeof(IDictionary);
                default:
                    //if we don't recognize it (or its a struct), we use the google native wellknown type.
                    return typeof(Value);
            }
        }

        public static SpannerDbType GetSpannerDbType(this TypeCode typeCode)
        {
            switch (typeCode)
            {
                case TypeCode.Unspecified:
                    return SpannerDbType.Unspecified;
                case TypeCode.Bool:
                    return SpannerDbType.Bool;
                case TypeCode.Int64:
                    return SpannerDbType.Int64;
                case TypeCode.Float64:
                    return SpannerDbType.Float64;
                case TypeCode.Timestamp:
                    return SpannerDbType.Timestamp;
                case TypeCode.Date:
                    return SpannerDbType.Date;
                case TypeCode.String:
                    return SpannerDbType.String;
                case TypeCode.Bytes:
                    return SpannerDbType.Bytes;
                case TypeCode.Array:
                    return SpannerDbType.Array;
                case TypeCode.Struct:
                    return SpannerDbType.Struct;
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeCode), typeCode, null);
            }
        }

        public static TypeCode GetSpannerType(this DbType dbType)
        {
            switch (dbType)
            {
                case DbType.Binary:
                    return TypeCode.Bytes;
                case DbType.Boolean:
                    return TypeCode.Bool;
                case DbType.Date:
                    return TypeCode.Date;
                case DbType.DateTime:
                    return TypeCode.Timestamp;
                case DbType.Double:
                    return TypeCode.Float64;
                case DbType.Int64:
                    return TypeCode.Int64;
                case DbType.Object:
                    return TypeCode.Unspecified;
                case DbType.String:
                    return TypeCode.String;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dbType), dbType, null);
            }
        }

        public static TypeCode GetSpannerTypeCode(this SpannerDbType spannerDbType)
        {
            switch (spannerDbType)
            {
                case SpannerDbType.Unspecified:
                    return TypeCode.Unspecified;
                case SpannerDbType.Bool:
                    return TypeCode.Bool;
                case SpannerDbType.Int64:
                    return TypeCode.Int64;
                case SpannerDbType.Float64:
                    return TypeCode.Float64;
                case SpannerDbType.Timestamp:
                    return TypeCode.Timestamp;
                case SpannerDbType.Date:
                    return TypeCode.Date;
                case SpannerDbType.String:
                    return TypeCode.String;
                case SpannerDbType.Bytes:
                    return TypeCode.Bytes;
                case SpannerDbType.Array:
                    return TypeCode.Array;
                case SpannerDbType.Struct:
                    return TypeCode.Struct;
                default:
                    throw new ArgumentOutOfRangeException(nameof(spannerDbType), spannerDbType, null);
            }
        }

        public static Value ToValue(object value, TypeCode typeCode)
        {
            switch (typeCode)
            {
                case TypeCode.Bool:
                    return new Value {BoolValue = Convert.ToBoolean(value)};
                case TypeCode.String:
                case TypeCode.Int64:
                    return new Value {StringValue = value?.ToString()};
                case TypeCode.Float64:
                    return new Value {NumberValue = Convert.ToDouble(value)};
                case TypeCode.Timestamp:
                    var stringValue = value as string;
                    if (stringValue != null)
                        return new Value {StringValue = stringValue};
                    return new Value {
                        StringValue = XmlConvert.ToString(Convert.ToDateTime(value), XmlDateTimeSerializationMode.Utc)
                    };
                case TypeCode.Date:
                    stringValue = value as string;
                    if (stringValue != null)
                        return new Value {StringValue = stringValue};
                    return new Value {
                        StringValue = StripTimePart(
                            XmlConvert.ToString(Convert.ToDateTime(value), XmlDateTimeSerializationMode.Utc))
                    };
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeCode), typeCode, null);
            }
        }

        private static object ConvertToClrTypeImpl(Value wireValue, V1.Type spannerType, System.Type targetClrType)
        {
            //If the wireValue itself is assignable to the target type, just return it
            //This covers both typeof(Value) and typeof(object).
            if (wireValue == null || targetClrType == null || targetClrType == typeof(Value))
                return wireValue;

            //targetClrType should be one of the values returned by GetDefaultClrTypeFromSpannerType
            if (targetClrType == typeof(bool))
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return default(bool);
                    case Value.KindOneofCase.StringValue:
                        return Convert.ToBoolean(wireValue.StringValue);
                    case Value.KindOneofCase.BoolValue:
                        return wireValue.BoolValue;
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            if (targetClrType == typeof(long))
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NumberValue:
                        return Convert.ToInt64(wireValue.NumberValue);
                    case Value.KindOneofCase.NullValue:
                        return default(long);
                    case Value.KindOneofCase.StringValue:
                        return Convert.ToInt64(wireValue.StringValue);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            if (targetClrType == typeof(double))
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return default(double);
                    case Value.KindOneofCase.NumberValue:
                        return wireValue.NumberValue;
                    case Value.KindOneofCase.StringValue:
                        if (string.Compare(wireValue.StringValue, "NaN", StringComparison.OrdinalIgnoreCase) == 0)
                            return double.NaN;
                        if (string.Compare(wireValue.StringValue, "Infinity", StringComparison.OrdinalIgnoreCase) == 0)
                            return double.PositiveInfinity;
                        if (string.Compare(wireValue.StringValue, "-Infinity", StringComparison.OrdinalIgnoreCase) == 0)
                            return double.NegativeInfinity;

                        return Convert.ToDouble(wireValue.StringValue);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            if (targetClrType == typeof(DateTime))
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return null;
                    case Value.KindOneofCase.StringValue:
                        return XmlConvert.ToDateTime(wireValue.StringValue, XmlDateTimeSerializationMode.Utc);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            if (targetClrType == typeof(Timestamp))
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return null;
                    case Value.KindOneofCase.StringValue:
                        return Timestamp.Parser.ParseJson(wireValue.StringValue);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            if (targetClrType == typeof(string))
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return null;
                    case Value.KindOneofCase.NumberValue:
                        return wireValue.NumberValue.ToString(CultureInfo.CurrentCulture);
                    case Value.KindOneofCase.StringValue:
                        return wireValue.StringValue;
                    case Value.KindOneofCase.BoolValue:
                        return wireValue.BoolValue.ToString();
                    default:
                        return wireValue.ToString();
                }
            if (targetClrType == typeof(byte[]))
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return null;
                    case Value.KindOneofCase.StringValue:
                        return Convert.FromBase64String(wireValue.StringValue);
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            if (targetClrType == typeof(IList))
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return null;
                    case Value.KindOneofCase.ListValue:
                        return wireValue.ListValue.Values.Select(x => x.ConvertToClrType(spannerType.ArrayElementType))
                            .ToList();
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            if (targetClrType == typeof(IDictionary))
            {
                //a bit of recursion here...
                IDictionary dictionary;
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.StructValue:
                        dictionary = new Hashtable();
                        foreach (var structField in spannerType.StructType.Fields)
                            dictionary[structField.Name] =
                                wireValue.StructValue.Fields[structField.Name]
                                    .ConvertToClrType(structField.Type);
                        return dictionary;
                    case Value.KindOneofCase.ListValue:
                        dictionary = new Hashtable();
                        var i = 0;
                        foreach (var listItemValue in wireValue.ListValue.Values)
                        {
                            dictionary[i] = listItemValue.ConvertToClrType(spannerType.ArrayElementType);
                            i++;
                        }
                        return dictionary;
                    default:
                        throw new ArgumentException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }
            throw new ArgumentException(
                $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
        }

        private static string StripTimePart(string rfc3339String)
        {
            if (!string.IsNullOrEmpty(rfc3339String))
            {
                var timeIndex = rfc3339String.IndexOf('T');
                if (timeIndex != -1)
                    return rfc3339String.Substring(0, timeIndex);
            }
            return rfc3339String;
        }
    }
}