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
using System.Collections.Generic;
using System.Data;
using static System.Globalization.CultureInfo;
using System.Linq;
using System.Reflection;
using System.Xml;
using Google.Protobuf.WellKnownTypes;
using TypeCode = Google.Cloud.Spanner.V1.TypeCode;

namespace Google.Cloud.Spanner.Data
{
    internal static class ValueConversion
    {
        public static object ConvertToClrType(this Value wireValue, V1.Type spannerType) => ConvertToClrType(
            wireValue, spannerType, typeof(object));

        public static T ConvertToClrType<T>(
            this Value wireValue,
            V1.Type spannerType) => (T) ConvertToClrType(wireValue, spannerType, typeof(T));

        public static object ConvertToClrType(this Value wireValue, V1.Type spannerType, System.Type targetClrType)
        {
            if (wireValue.KindCase == Value.KindOneofCase.NullValue)
            {
                if (targetClrType.GetTypeInfo().IsValueType)
                {
                    //Returns default(T) for targetClrType
                    return Activator.CreateInstance(targetClrType);
                }
                return null;
            }
            if (targetClrType == typeof(object))
            {
                //then we decide the type for you
                targetClrType = spannerType?.Code.GetDefaultClrTypeFromSpannerType();
            }
            var possibleUnderlyingType = Nullable.GetUnderlyingType(targetClrType);
            if (possibleUnderlyingType != null)
            {
                targetClrType = possibleUnderlyingType;
            }
            //extra supported conversions that are modifications of the "core" versions but may have loss of precision.
            //we call the spannerType with the known supported version and cast it down to lose precision.
            if (targetClrType == typeof(int))
            {
                return Convert.ToInt32(ConvertToClrTypeImpl<long>(wireValue, spannerType));
            }

            if (targetClrType == typeof(uint))
            {
                return Convert.ToUInt32(ConvertToClrTypeImpl<long>(wireValue, spannerType));
            }

            if (targetClrType == typeof(short))
            {
                return Convert.ToInt16(ConvertToClrTypeImpl<long>(wireValue, spannerType));
            }

            if (targetClrType == typeof(ushort))
            {
                return Convert.ToUInt16(ConvertToClrTypeImpl<long>(wireValue, spannerType));
            }

            if (targetClrType == typeof(sbyte))
            {
                return Convert.ToSByte(ConvertToClrTypeImpl<long>(wireValue, spannerType));
            }

            if (targetClrType == typeof(byte))
            {
                return Convert.ToByte(ConvertToClrTypeImpl<long>(wireValue, spannerType));
            }

            if (targetClrType == typeof(float))
            {
                return Convert.ToSingle(ConvertToClrTypeImpl<double>(wireValue, spannerType));
            }

            if (targetClrType == typeof(Guid))
            {
                return Guid.Parse(ConvertToClrTypeImpl<string>(wireValue, spannerType));
            }

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
                    return typeof(List<object>);
                case TypeCode.Struct:
                    return typeof(Hashtable);
                default:
                    //if we don't recognize it (or its a struct), we use the google native wellknown type.
                    return typeof(Value);
            }
        }

        public static Value ToValue(object value, SpannerDbType spannerDbType)
        {
            if (value == null)
            {
                return Value.ForNull();
            }

            switch (spannerDbType.TypeCode)
            {
                case TypeCode.Bytes:
                    if (value is string s)
                    {
                        return new Value {StringValue = s};
                    }
                    if (value is byte[] bArray)
                    {
                        return new Value {StringValue = Convert.ToBase64String(bArray)};
                    }
                    throw new ArgumentException("TypeCode.Bytes only supports string and byte[]", nameof(value));
                case TypeCode.Bool:
                    return new Value {BoolValue = Convert.ToBoolean(value)};
                case TypeCode.String:
                    if (value is DateTime dateTime)
                    {
                        // If the value is a DateTime, we always convert using XmlConvert.
                        // This allows us to convert back to a datetime reliably from the
                        // resulting string (so roundtrip works properly if the developer uses
                        // a string as a backing field for a datetime for whatever reason).
                        return new Value { StringValue = XmlConvert.ToString(dateTime, XmlDateTimeSerializationMode.Utc) };
                    }
                    return new Value { StringValue = Convert.ToString(value, InvariantCulture) };
                case TypeCode.Int64:
                        return new Value { StringValue = Convert.ToInt64(value, InvariantCulture)
                            .ToString(InvariantCulture) };
                case TypeCode.Float64:
                    return new Value {NumberValue = Convert.ToDouble(value, InvariantCulture)};
                case TypeCode.Timestamp:
                    return new Value
                    {
                        StringValue = XmlConvert.ToString(Convert.ToDateTime(value, InvariantCulture), XmlDateTimeSerializationMode.Utc)
                    };
                case TypeCode.Date:
                    return new Value
                    {
                        StringValue = StripTimePart(
                            XmlConvert.ToString(Convert.ToDateTime(value, InvariantCulture), XmlDateTimeSerializationMode.Utc))
                    };
                case TypeCode.Array:
                    if (value is IEnumerable enumerable)
                    {
                        return Value.ForList(
                            enumerable.Cast<object>()
                                .Select(x => ToValue(x, spannerDbType.ArrayElementType)).ToArray());
                    }
                    throw new ArgumentException("The given array instance needs to implement IEnumerable.", nameof(spannerDbType));
                case TypeCode.Struct:
                    if (value is IDictionary dictionary)
                    {
                        var structValue = new Struct();
                        foreach (var key in dictionary.Keys)
                        {
                            string keyString = Convert.ToString(key, InvariantCulture);
                            if (!spannerDbType.StructMembers.ContainsKey(keyString))
                            {
                                throw new ArgumentException("The given struct instance has members not defined in the Struct.", nameof(value));
                            }
                            structValue.Fields[keyString] = ToValue(
                                dictionary[key],
                                spannerDbType.StructMembers[keyString]);
                        }
                        return Value.ForStruct(structValue);
                    }
                    throw new ArgumentException("The given struct instance needs to implement IDictionary.", nameof(spannerDbType));

                default:
                    throw new ArgumentOutOfRangeException(nameof(spannerDbType), spannerDbType, null);
            }
        }

        private static T ConvertToClrTypeImpl<T>(Value wireValue, V1.Type spannerType) =>
            (T)ConvertToClrTypeImpl(wireValue, spannerType, typeof(T));

        private static object ConvertToClrTypeImpl(Value wireValue, V1.Type spannerType, System.Type targetClrType)
        {
            //If the wireValue itself is assignable to the target type, just return it
            //This covers both typeof(Value) and typeof(object).
            if (wireValue == null || targetClrType == null || targetClrType == typeof(Value))
            {
                return wireValue;
            }

            //targetClrType should be one of the values returned by GetDefaultClrTypeFromSpannerType
            if (targetClrType == typeof(bool))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return default(bool);
                    case Value.KindOneofCase.StringValue:
                        if (spannerType.Code == TypeCode.Int64)
                        {
                            return Convert.ToBoolean(Convert.ToInt64(wireValue.StringValue, InvariantCulture));
                        }
                        return Convert.ToBoolean(wireValue.StringValue);
                    case Value.KindOneofCase.BoolValue:
                        return wireValue.BoolValue;
                    case Value.KindOneofCase.NumberValue:
                        return Convert.ToBoolean(wireValue.NumberValue);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(char))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.BoolValue:
                        return Convert.ToChar(wireValue.BoolValue);
                    case Value.KindOneofCase.NumberValue:
                        return Convert.ToChar(wireValue.NumberValue);
                    case Value.KindOneofCase.NullValue:
                        return default(char);
                    case Value.KindOneofCase.StringValue:
                        if (spannerType.Code == TypeCode.Int64)
                        {
                            return Convert.ToChar(Convert.ToInt64(wireValue.StringValue, InvariantCulture));
                        }
                        return Convert.ToChar(wireValue.StringValue);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(long))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.BoolValue:
                        return Convert.ToInt64(wireValue.BoolValue);
                    case Value.KindOneofCase.NumberValue:
                        return Convert.ToInt64(wireValue.NumberValue);
                    case Value.KindOneofCase.NullValue:
                        return default(long);
                    case Value.KindOneofCase.StringValue:
                        return Convert.ToInt64(wireValue.StringValue, InvariantCulture);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(ulong))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.BoolValue:
                        return Convert.ToUInt64(wireValue.BoolValue);
                    case Value.KindOneofCase.NumberValue:
                        return Convert.ToUInt64(wireValue.NumberValue);
                    case Value.KindOneofCase.NullValue:
                        return default(ulong);
                    case Value.KindOneofCase.StringValue:
                        return Convert.ToUInt64(wireValue.StringValue, InvariantCulture);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(decimal))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.BoolValue:
                        return Convert.ToDecimal(wireValue.BoolValue);
                    case Value.KindOneofCase.NumberValue:
                        return Convert.ToDecimal(wireValue.NumberValue);
                    case Value.KindOneofCase.NullValue:
                        return default(decimal);
                    case Value.KindOneofCase.StringValue:
                        return Convert.ToDecimal(wireValue.StringValue, InvariantCulture);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(double))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.BoolValue:
                        return Convert.ToDouble(wireValue.BoolValue);
                    case Value.KindOneofCase.NullValue:
                        return default(double);
                    case Value.KindOneofCase.NumberValue:
                        return wireValue.NumberValue;
                    case Value.KindOneofCase.StringValue:
                        if (string.Compare(wireValue.StringValue, "NaN", StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            return double.NaN;
                        }

                        if (string.Compare(wireValue.StringValue, "Infinity", StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            return double.PositiveInfinity;
                        }

                        if (string.Compare(wireValue.StringValue, "-Infinity", StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            return double.NegativeInfinity;
                        }

                        return Convert.ToDouble(wireValue.StringValue, InvariantCulture);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(DateTime))
            {
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
            }

            if (targetClrType == typeof(Timestamp))
            {
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
            }

            if (targetClrType == typeof(string))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return null;
                    case Value.KindOneofCase.NumberValue:
                        return wireValue.NumberValue.ToString(InvariantCulture);
                    case Value.KindOneofCase.StringValue:
                        return wireValue.StringValue;
                    case Value.KindOneofCase.BoolValue:
                        return wireValue.BoolValue.ToString();
                    default:
                        return wireValue.ToString();
                }
            }

            if (targetClrType == typeof(byte[]))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return null;
                    case Value.KindOneofCase.StringValue:
                        return Convert.FromBase64String(wireValue.StringValue);
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            if (typeof(IDictionary).IsAssignableFrom(targetClrType))
            {
                if (targetClrType == typeof(IDictionary))
                {
                    targetClrType = typeof(Hashtable);
                }
                //a bit of recursion here...
                IDictionary dictionary = (IDictionary)Activator.CreateInstance(targetClrType);
                var itemType = targetClrType.GetGenericArguments().Skip(1).FirstOrDefault() ?? typeof(object);
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.StructValue:
                        foreach (var structField in spannerType.StructType.Fields)
                        {
                            dictionary[structField.Name] =
                                wireValue.StructValue.Fields[structField.Name]
                                    .ConvertToClrType(structField.Type, itemType);
                        }

                        return dictionary;
                    case Value.KindOneofCase.ListValue:
                        if (spannerType.Code == TypeCode.Struct)
                        {
                            for (var i = 0; i < spannerType.StructType.Fields.Count; i++)
                            {
                                dictionary[spannerType.StructType.Fields[i].Name] = wireValue
                                    .ListValue.Values[i]
                                    .ConvertToClrType(spannerType.StructType.Fields[i].Type, itemType);
                            }
                        }
                        else
                        {
                            var i = 0;
                            foreach (var listItemValue in wireValue.ListValue.Values)
                            {
                                dictionary[i] =
                                    listItemValue.ConvertToClrType(spannerType.ArrayElementType, itemType);
                                i++;
                            }
                        }
                        return dictionary;
                    default:
                        throw new ArgumentException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }
            if (targetClrType.IsArray)
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue: return null;
                    case Value.KindOneofCase.ListValue:
                        var newArray = Array.CreateInstance(
                            targetClrType.GetElementType(),
                            wireValue.ListValue.Values.Count);

                        var i = 0;
                        foreach (var obj in wireValue.ListValue.Values.Select(
                            x => x.ConvertToClrType(spannerType.ArrayElementType, targetClrType.GetElementType())))
                        {
                            newArray.SetValue(obj, i);
                            i++;
                        }
                        return newArray;
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }
            if (typeof(IList).IsAssignableFrom(targetClrType))
            {
                if (targetClrType == typeof(IList))
                {
                    targetClrType = typeof(List<object>);
                }
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue: return null;
                    case Value.KindOneofCase.ListValue:
                        var newList = (IList) Activator.CreateInstance(targetClrType);
                        var itemType = targetClrType.GetGenericArguments().FirstOrDefault() ?? typeof(object);
                        foreach (var obj in wireValue.ListValue.Values.Select(
                            x => x.ConvertToClrType(spannerType.ArrayElementType, itemType)))
                        {
                            newList.Add(obj);
                        }
                        return newList;
                    default:
                        throw new InvalidOperationException(
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
                int timeIndex = rfc3339String.IndexOf('T');
                if (timeIndex != -1)
                {
                    return rfc3339String.Substring(0, timeIndex);
                }
            }
            return rfc3339String;
        }
    }
}
