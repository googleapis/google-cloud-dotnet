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

using Google.Cloud.Firestore.V1Beta1;
using Google.Protobuf;
using Google.Type;
using System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Converters
{
    // All the simple converters in a single place for simplicity.
    // It might make sense to have a single IntegerConverter accepting delegates for the conversion to/from Int64,
    // but there's no real benefit of that over this approach, and it does introduce an extra level of indirection.

    internal sealed class StringConverter : ConverterBase
    {
        internal StringConverter() : base(typeof(string)) { }
        public override Value Serialize(object value) => new Value { StringValue = (string) value };
        protected override object DeserializeString(FirestoreDb db, string value) => value;
    }

    internal sealed class ByteConverter : ConverterBase
    {
        internal ByteConverter() : base(typeof(byte)) { }
        public override Value Serialize(object value) => new Value { IntegerValue = (byte) value };
        protected override object DeserializeInteger(FirestoreDb db, long value) => checked((byte) value);
    }

    internal sealed class SByteConverter : ConverterBase
    {
        internal SByteConverter() : base(typeof(sbyte)) { }
        public override Value Serialize(object value) => new Value { IntegerValue = (sbyte) value };
        protected override object DeserializeInteger(FirestoreDb db, long value) => checked((sbyte) value);
    }

    internal sealed class Int16Converter : ConverterBase
    {
        internal Int16Converter() : base(typeof(short)) { }
        public override Value Serialize(object value) => new Value { IntegerValue = (short) value };
        protected override object DeserializeInteger(FirestoreDb db, long value) => checked((short) value);
    }

    internal sealed class UInt16Converter : ConverterBase
    {
        internal UInt16Converter() : base(typeof(ushort)) { }
        public override Value Serialize(object value) => new Value { IntegerValue = (ushort) value };
        protected override object DeserializeInteger(FirestoreDb db, long value) => checked((ushort) value);
    }

    internal sealed class Int32Converter : ConverterBase
    {
        internal Int32Converter() : base(typeof(int)) { }
        public override Value Serialize(object value) => new Value { IntegerValue = (int) value };
        protected override object DeserializeInteger(FirestoreDb db, long value) => checked((int) value);
    }

    internal sealed class UInt32Converter : ConverterBase
    {
        internal UInt32Converter() : base(typeof(uint)) { }
        public override Value Serialize(object value) => new Value { IntegerValue = (uint) value };
        protected override object DeserializeInteger(FirestoreDb db, long value) => checked((uint) value);
    }

    internal sealed class Int64Converter : ConverterBase
    {
        internal Int64Converter() : base(typeof(long)) { }
        public override Value Serialize(object value) => new Value { IntegerValue = (long) value };
        protected override object DeserializeInteger(FirestoreDb db, long value) => value;
    }

    internal sealed class UInt64Converter : ConverterBase
    {
        internal UInt64Converter() : base(typeof(ulong)) { }
        public override Value Serialize(object value) => new Value { IntegerValue = checked((long) (ulong) value) };
        protected override object DeserializeInteger(FirestoreDb db, long value) => checked((ulong) value);
    }

    internal sealed class SingleConverter : ConverterBase
    {
        internal SingleConverter() : base(typeof(float)) { }
        public override Value Serialize(object value) => new Value { DoubleValue = (float) value };
        protected override object DeserializeDouble(FirestoreDb db, double value) => (float) value;
    }

    internal sealed class DoubleConverter : ConverterBase
    {
        internal DoubleConverter() : base(typeof(double)) { }
        public override Value Serialize(object value) => new Value { DoubleValue = (double) value };
        protected override object DeserializeDouble(FirestoreDb db, double value) => value;
    }

    internal sealed class BooleanConverter : ConverterBase
    {
        internal BooleanConverter() : base(typeof(bool)) { }
        public override Value Serialize(object value) => new Value { BooleanValue = (bool) value };
        protected override object DeserializeBoolean(FirestoreDb db, bool value) => value;
    }

    internal sealed class TimestampConverter : ConverterBase
    {
        internal TimestampConverter() : base(typeof(Timestamp)) { }
        public override Value Serialize(object value) => new Value { TimestampValue = ((Timestamp) value).ToProto() };
        protected override object DeserializeTimestamp(FirestoreDb db, wkt::Timestamp value) => Timestamp.FromProto(value);
    }

    internal sealed class GeoPointConverter : ConverterBase
    {
        internal GeoPointConverter() : base(typeof(GeoPoint)) { }
        public override Value Serialize(object value) => new Value { GeoPointValue = ((GeoPoint) value).ToProto() };
        protected override object DeserializeGeoPoint(FirestoreDb db, LatLng value) => GeoPoint.FromProto(value);
    }

    internal sealed class ByteStringConverter : ConverterBase
    {
        internal ByteStringConverter() : base(typeof(ByteString)) { }
        public override Value Serialize(object value) => new Value { BytesValue = (ByteString) value };
        protected override object DeserializeBytes(FirestoreDb db, ByteString value) => value;
    }

    internal sealed class ByteArrayConverter : ConverterBase
    {
        internal ByteArrayConverter() : base(typeof(byte[])) { }
        public override Value Serialize(object value) => new Value { BytesValue = ByteString.CopyFrom((byte[]) value) };
        protected override object DeserializeBytes(FirestoreDb db, ByteString value) => value.ToByteArray();
    }

    internal sealed class BlobConverter : ConverterBase
    {
        internal BlobConverter() : base(typeof(Blob)) { }
        public override Value Serialize(object value) => new Value { BytesValue = ((Blob) value).ByteString };
        protected override object DeserializeBytes(FirestoreDb db, ByteString value) => Blob.FromByteString(value);
    }

    internal sealed class SentinelValueConverter : ConverterBase
    {
        internal SentinelValueConverter() : base(typeof(SentinelValue)) { }
        public override Value Serialize(object value) => ((SentinelValue) value).ToProtoValue();
    }

    internal sealed class DateTimeConverter : ConverterBase
    {
        internal DateTimeConverter() : base(typeof(DateTime)) { }
        public override Value Serialize(object value) => new Value { TimestampValue = wkt::Timestamp.FromDateTime((DateTime) value) };
        protected override object DeserializeTimestamp(FirestoreDb db, wkt::Timestamp value) => value.ToDateTime();
    }

    internal sealed class DateTimeOffsetConverter : ConverterBase
    {
        internal DateTimeOffsetConverter() : base(typeof(DateTimeOffset)) { }
        public override Value Serialize(object value) => new Value { TimestampValue = wkt::Timestamp.FromDateTimeOffset((DateTimeOffset) value) };
        protected override object DeserializeTimestamp(FirestoreDb db, wkt::Timestamp value) => value.ToDateTimeOffset();
    }

    internal sealed class TimestampProtoConverter : ConverterBase
    {
        internal TimestampProtoConverter() : base(typeof(DateTime)) { }
        public override Value Serialize(object value) => new Value { TimestampValue = ((wkt::Timestamp) value).Clone() };
        protected override object DeserializeTimestamp(FirestoreDb db, wkt::Timestamp value) => value.Clone();
    }

    internal sealed class ValueConverter : ConverterBase
    {
        internal ValueConverter() : base(typeof(Value)) { }
        public override Value Serialize(object value) => ((Value) value).Clone();
        public override object DeserializeValue(FirestoreDb db, Value value) => value.Clone();
    }

    internal sealed class LatLngConverter : ConverterBase
    {
        internal LatLngConverter() : base(typeof(LatLng)) { }
        public override Value Serialize(object value) => new Value { GeoPointValue = ((LatLng) value).Clone() };
        protected override object DeserializeGeoPoint(FirestoreDb db, LatLng value) => value.Clone();
    }

    internal sealed class DocumentReferenceConverter : ConverterBase
    {
        internal DocumentReferenceConverter() : base(typeof(DocumentReference)) { }
        public override Value Serialize(object value) => new Value { ReferenceValue = ((DocumentReference) value).Path };
        protected override object DeserializeReference(FirestoreDb db, string value) => db.GetDocumentReferenceFromResourceName(value);
    }
}
