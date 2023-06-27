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
using Google.Protobuf;
using Google.Type;
using System;
using wkt = Google.Protobuf.WellKnownTypes;
using DateTime = System.DateTime;

namespace Google.Cloud.Firestore.Converters
{
    // All the simple converters in a single place for simplicity.

    internal sealed class StringConverter : ConverterBase
    {
        internal StringConverter() : base(typeof(string)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { StringValue = (string) value };
        protected override object DeserializeString(IDeserializationContext context, string value) => value;
    }

    internal abstract class IntegerConverterBase : ConverterBase
    {
        internal IntegerConverterBase(System.Type type) : base(type)
        {
        }

        // All integer types allow conversion from double as well.
        protected override object DeserializeDouble(IDeserializationContext context, double value) =>
            DeserializeInteger(context, checked((long) value));
    }

    internal sealed class ByteConverter : IntegerConverterBase
    {
        internal ByteConverter() : base(typeof(byte)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { IntegerValue = (byte) value };
        protected override object DeserializeInteger(IDeserializationContext context, long value) => checked((byte) value);
    }

    internal sealed class SByteConverter : IntegerConverterBase
    {
        internal SByteConverter() : base(typeof(sbyte)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { IntegerValue = (sbyte) value };
        protected override object DeserializeInteger(IDeserializationContext context, long value) => checked((sbyte) value);
    }

    internal sealed class Int16Converter : IntegerConverterBase
    {
        internal Int16Converter() : base(typeof(short)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { IntegerValue = (short) value };
        protected override object DeserializeInteger(IDeserializationContext context, long value) => checked((short) value);
    }

    internal sealed class UInt16Converter : IntegerConverterBase
    {
        internal UInt16Converter() : base(typeof(ushort)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { IntegerValue = (ushort) value };
        protected override object DeserializeInteger(IDeserializationContext context, long value) => checked((ushort) value);
    }

    internal sealed class Int32Converter : IntegerConverterBase
    {
        internal Int32Converter() : base(typeof(int)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { IntegerValue = (int) value };
        protected override object DeserializeInteger(IDeserializationContext context, long value) => checked((int) value);
    }

    internal sealed class UInt32Converter : IntegerConverterBase
    {
        internal UInt32Converter() : base(typeof(uint)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { IntegerValue = (uint) value };
        protected override object DeserializeInteger(IDeserializationContext context, long value) => checked((uint) value);
    }

    internal sealed class Int64Converter : IntegerConverterBase
    {
        internal Int64Converter() : base(typeof(long)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { IntegerValue = (long) value };
        protected override object DeserializeInteger(IDeserializationContext context, long value) => value;
    }

    internal sealed class UInt64Converter : IntegerConverterBase
    {
        internal UInt64Converter() : base(typeof(ulong)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { IntegerValue = checked((long) (ulong) value) };
        protected override object DeserializeInteger(IDeserializationContext context, long value) => checked((ulong) value);
    }

    internal sealed class SingleConverter : ConverterBase
    {
        internal SingleConverter() : base(typeof(float)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { DoubleValue = (float) value };
        protected override object DeserializeDouble(IDeserializationContext context, double value) => (float) value;
        // We allow serialization from integer values as some interactions with Firestore end up storing
        // an integer value even when a double value is expected, if the value happens to be an integer.
        // See https://github.com/googleapis/google-cloud-dotnet/issues/3013
        protected override object DeserializeInteger(IDeserializationContext context, long value) => (float) value;
    }

    internal sealed class DoubleConverter : ConverterBase
    {
        internal DoubleConverter() : base(typeof(double)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { DoubleValue = (double) value };
        protected override object DeserializeDouble(IDeserializationContext context, double value) => value;
        // We allow serialization from integer values as some interactions with Firestore end up storing
        // an integer value even when a double value is expected, if the value happens to be an integer.
        // See https://github.com/googleapis/google-cloud-dotnet/issues/3013
        protected override object DeserializeInteger(IDeserializationContext context, long value) => (double) value;
    }

    internal sealed class BooleanConverter : ConverterBase
    {
        internal BooleanConverter() : base(typeof(bool)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { BooleanValue = (bool) value };
        protected override object DeserializeBoolean(IDeserializationContext context, bool value) => value;
    }

    internal sealed class TimestampConverter : ConverterBase
    {
        internal TimestampConverter() : base(typeof(Timestamp)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { TimestampValue = ((Timestamp) value).ToProto() };
        protected override object DeserializeTimestamp(IDeserializationContext context, wkt::Timestamp value) => Timestamp.FromProto(value);
    }

    internal sealed class GeoPointConverter : ConverterBase
    {
        internal GeoPointConverter() : base(typeof(GeoPoint)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { GeoPointValue = ((GeoPoint) value).ToProto() };
        protected override object DeserializeGeoPoint(IDeserializationContext context, LatLng value) => GeoPoint.FromProto(value);
    }

    internal sealed class ByteStringConverter : ConverterBase
    {
        internal ByteStringConverter() : base(typeof(ByteString)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { BytesValue = (ByteString) value };
        protected override object DeserializeBytes(IDeserializationContext context, ByteString value) => value;
    }

    internal sealed class ByteArrayConverter : ConverterBase
    {
        internal ByteArrayConverter() : base(typeof(byte[])) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { BytesValue = ByteString.CopyFrom((byte[]) value) };
        protected override object DeserializeBytes(IDeserializationContext context, ByteString value) => value.ToByteArray();
    }

    internal sealed class BlobConverter : ConverterBase
    {
        internal BlobConverter() : base(typeof(Blob)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { BytesValue = ((Blob) value).ByteString };
        protected override object DeserializeBytes(IDeserializationContext context, ByteString value) => Blob.FromByteString(value);
    }

    internal sealed class SentinelValueConverter : ConverterBase
    {
        internal SentinelValueConverter() : base(typeof(SentinelValue)) { }
        public override Value Serialize(SerializationContext context, object value) => ((SentinelValue) value).ToProtoValue();
    }

    internal sealed class DateTimeConverter : ConverterBase
    {
        internal DateTimeConverter() : base(typeof(DateTime)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { TimestampValue = wkt::Timestamp.FromDateTime((DateTime) value) };
        protected override object DeserializeTimestamp(IDeserializationContext context, wkt::Timestamp value) => value.ToDateTime();
    }

    internal sealed class DateTimeOffsetConverter : ConverterBase
    {
        internal DateTimeOffsetConverter() : base(typeof(DateTimeOffset)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { TimestampValue = wkt::Timestamp.FromDateTimeOffset((DateTimeOffset) value) };
        protected override object DeserializeTimestamp(IDeserializationContext context, wkt::Timestamp value) => value.ToDateTimeOffset();
    }

    internal sealed class TimestampProtoConverter : ConverterBase
    {
        internal TimestampProtoConverter() : base(typeof(wkt::Timestamp)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { TimestampValue = ((wkt::Timestamp) value).Clone() };
        protected override object DeserializeTimestamp(IDeserializationContext context, wkt::Timestamp value) => value.Clone();
    }

    internal sealed class ValueConverter : ConverterBase
    {
        internal ValueConverter() : base(typeof(Value)) { }
        public override Value Serialize(SerializationContext context, object value) => ((Value) value).Clone();
        public override object DeserializeValue(IDeserializationContext context, Value value) => value.Clone();
    }

    internal sealed class LatLngConverter : ConverterBase
    {
        internal LatLngConverter() : base(typeof(LatLng)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { GeoPointValue = ((LatLng) value).Clone() };
        protected override object DeserializeGeoPoint(IDeserializationContext context, LatLng value) => value.Clone();
    }

    internal sealed class DocumentReferenceConverter : ConverterBase
    {
        internal DocumentReferenceConverter() : base(typeof(DocumentReference)) { }
        public override Value Serialize(SerializationContext context, object value) => new Value { ReferenceValue = ((DocumentReference) value).Path };
        protected override object DeserializeReference(IDeserializationContext context, string value) =>
            context.Database.GetDocumentReferenceFromResourceName(value);
    }
}
