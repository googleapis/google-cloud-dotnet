// Copyright 2021 Google Inc. All Rights Reserved.
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

using Google.Cloud.Spanner.V1;
using Google.Protobuf.WellKnownTypes;
using System;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class KeysTests
    {
        [Fact]
        public void CreateKeyFromParameterCollection()
        {
            var key = new Key(
                new SpannerParameterCollection
                {
                    { "", SpannerDbType.Bool, true },
                    { "", SpannerDbType.Bytes, new byte[] {1, 2, 3} },
                    { "", SpannerDbType.Date, new DateTime(2021, 9, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { "", SpannerDbType.Float32, 2.718f },
                    { "", SpannerDbType.Float64, 3.14 },
                    { "", SpannerDbType.Int64, 1 },
                    { "", SpannerDbType.Json, "{\"key\": \"value\"}" },
                    { "", SpannerDbType.PgJsonb, "{\"key1\": \"value1\"}" },
                    { "", SpannerDbType.Numeric, SpannerNumeric.Parse("10.1") },
                    { "", SpannerDbType.PgNumeric, PgNumeric.Parse("20.1") },
                    { "", SpannerDbType.PgOid, 2 },
                    { "", SpannerDbType.String, "test" },
                    { "", SpannerDbType.Timestamp, new DateTime(2021, 9, 10, 9, 37, 10, DateTimeKind.Utc) },
                    { "", SpannerDbType.Uuid, Guid.Parse("8f8c4746-17b1-4d9f-a634-58e11942095f") }
                });

            var actual = key.ToProtobuf(SpannerConversionOptions.Default);
            var expected = new ListValue
            {
                Values =
                {
                    Value.ForBool(true),
                    Value.ForString(Convert.ToBase64String(new byte[] {1,2,3})),
                    Value.ForString("2021-09-10"),
                    Value.ForNumber(2.718f),
                    Value.ForNumber(3.14),
                    Value.ForString("1"),
                    Value.ForString("{\"key\": \"value\"}"),
                    Value.ForString("{\"key1\": \"value1\"}"),
                    Value.ForString("10.1"),
                    Value.ForString("20.1"),
                    Value.ForString("2"),
                    Value.ForString("test"),
                    Value.ForString("2021-09-10T09:37:10Z")
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateKeyFromEmptyParameters()
        {
            var key = new Key(new SpannerParameterCollection());
            Assert.Empty(key.ToProtobuf(SpannerConversionOptions.Default).Values);
        }

        [Fact]
        public void CreateKeyFromValues()
        {
            var key = new Key(
                true,
                new byte[] { 1, 2, 3 },
                // DATE cannot be created directly from a Clr type.
                2.718f,
                3.14,
                1L,
                // JSON cannot be created directly from a Clr type.
                SpannerNumeric.Parse("10.1"),
                PgNumeric.Parse("20.1"),
                "test",
                new DateTime(2021, 9, 10, 9, 37, 10, DateTimeKind.Utc)
            );

            var actual = key.ToProtobuf(SpannerConversionOptions.Default);
            var expected = new ListValue
            {
                Values =
                {
                    Value.ForBool(true),
                    Value.ForString(Convert.ToBase64String(new byte[] {1,2,3})),
                    Value.ForNumber(2.718f),
                    Value.ForNumber(3.14),
                    Value.ForString("1"),
                    Value.ForString("10.1"),
                    Value.ForString("20.1"),
                    Value.ForString("test"),
                    Value.ForString("2021-09-10T09:37:10Z")
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateEmptyKey()
        {
            var key = new Key();
            Assert.Empty(key.ToProtobuf(SpannerConversionOptions.Default).Values);
        }

        [Fact]
        public void CreateKeyWithNullParts()
        {
            var key = new Key(null, 1L, null);
            Assert.Collection(key.ToProtobuf(SpannerConversionOptions.Default).Values,
                v => Assert.Equal(NullValue.NullValue, v.NullValue),
                v => Assert.Equal("1", v.StringValue),
                v => Assert.Equal(NullValue.NullValue, v.NullValue));
        }

        [Fact]
        public void TypeMappings()
        {
            var builder = new SpannerConnectionStringBuilder();
            var key = new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k1", Value = 3.14m },
                new SpannerParameter { ParameterName = "k2", Value = new DateTime(2022, 06, 08) } });

            Assert.Equal(new ListValue { Values = { Value.ForString("3.14"), Value.ForString("2022-06-08T00:00:00Z") } },
                key.ToProtobuf(builder.ConversionOptions));

            // Specify the type mappings.
            builder.ClrToSpannerTypeDefaultMappings = "DecimalToFloat64,DateTimeToDate";
            Assert.Equal(new ListValue { Values = { Value.ForNumber(3.14), Value.ForString("2022-06-08") } },
                key.ToProtobuf(builder.ConversionOptions));

            // Revert the type mappings.
            builder.ClrToSpannerTypeDefaultMappings = "";
            Assert.Equal(new ListValue { Values = { Value.ForString("3.14"), Value.ForString("2022-06-08T00:00:00Z") } },
                key.ToProtobuf(builder.ConversionOptions));
        }

        [Fact]
        public void ToString_()
        {
            var builder = new SpannerConnectionStringBuilder();
            var key = new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k1", Value = 3.14m },
                new SpannerParameter { ParameterName = "k2", Value = new DateTime(2022, 06, 08) } });
            Assert.Equal("[ \"3.14\", \"2022-06-08T00:00:00Z\" ]", key.ToString(builder));

            // Specify the type mappings.
            builder.ClrToSpannerTypeDefaultMappings = "DecimalToFloat64,DateTimeToDate";
            Assert.Equal("[ 3.14, \"2022-06-08\" ]", key.ToString(builder));

            // Revert the type mappings.
            builder.ClrToSpannerTypeDefaultMappings = "";
            Assert.Equal("[ \"3.14\", \"2022-06-08T00:00:00Z\" ]", key.ToString(builder));
        }
    }

    public class KeyRangeTests
    {
        [Fact]
        public void CreateKeyRangeClosedClosed()
        {
            var options = SpannerConversionOptions.Default;
            var closedClosed = KeyRange.ClosedClosed(new Key("begin"), new Key("end"));
            Assert.True(closedClosed.BeginInclusive);
            Assert.True(closedClosed.EndInclusive);
            Assert.Equal(new ListValue { Values = { new[] { new Value { StringValue = "begin" } } } }, closedClosed.BeginAt.ToProtobuf(options));
            Assert.Equal(new ListValue { Values = { new[] { new Value { StringValue = "end" } } } }, closedClosed.End.ToProtobuf(options));
            Assert.Equal(new Key("begin").ToProtobuf(options), closedClosed.BeginAt.ToProtobuf(options));
            Assert.Equal(new Key("end").ToProtobuf(options), closedClosed.End.ToProtobuf(options));
            Assert.Equal(
                new V1.KeyRange
                {
                    StartClosed = new ListValue { Values = { new[] { new Value { StringValue = "begin" } } } },
                    EndClosed = new ListValue { Values = { new[] { new Value { StringValue = "end" } } } }
                }, closedClosed.ToProtobuf(options));
        }

        [Fact]
        public void CreateKeyRangeClosedOpen()
        {
            var options = SpannerConversionOptions.Default;
            var closedOpen = KeyRange.ClosedOpen(new Key(1L), new Key(100L));
            Assert.True(closedOpen.BeginInclusive);
            Assert.False(closedOpen.EndInclusive);
            Assert.Equal(new ListValue { Values = { new[] { new Value { StringValue = "1" } } } }, closedOpen.BeginAt.ToProtobuf(options));
            Assert.Equal(new ListValue { Values = { new[] { new Value { StringValue = "100" } } } }, closedOpen.End.ToProtobuf(options));
            Assert.Equal(new Key(1L).ToProtobuf(options), closedOpen.BeginAt.ToProtobuf(options));
            Assert.Equal(new Key(100L).ToProtobuf(options), closedOpen.End.ToProtobuf(options));
            Assert.Equal(
                new V1.KeyRange
                {
                    StartClosed = new ListValue { Values = { new[] { new Value { StringValue = "1" } } } },
                    EndOpen = new ListValue { Values = { new[] { new Value { StringValue = "100" } } } }
                }, closedOpen.ToProtobuf(options));
        }

        [Fact]
        public void CreateKeyRangeOpenClosed()
        {
            var options = SpannerConversionOptions.Default;
            var openClosed = KeyRange.OpenClosed(new Key(1L, 3.14), new Key(100L, 100.0));
            Assert.False(openClosed.BeginInclusive);
            Assert.True(openClosed.EndInclusive);
            Assert.Equal(new ListValue { Values = { new[] { new Value { StringValue = "1" }, new Value { NumberValue = 3.14 } } } }, openClosed.BeginAt.ToProtobuf(options));
            Assert.Equal(new ListValue { Values = { new[] { new Value { StringValue = "100" }, new Value { NumberValue = 100.0 } } } }, openClosed.End.ToProtobuf(options));
            Assert.Equal(new Key(1L, 3.14).ToProtobuf(options), openClosed.BeginAt.ToProtobuf(options));
            Assert.Equal(new Key(100L, 100.0).ToProtobuf(options), openClosed.End.ToProtobuf(options));
            Assert.Equal(
                new V1.KeyRange
                {
                    StartOpen = new ListValue
                    { Values = { new[] { new Value { StringValue = "1" }, new Value { NumberValue = 3.14 } } } },
                    EndClosed = new ListValue
                    { Values = { new[] { new Value { StringValue = "100" }, new Value { NumberValue = 100.0 } } } }
                }, openClosed.ToProtobuf(options));
        }

        [Fact]
        public void CreateKeyRangeOpenOpen()
        {
            var options = SpannerConversionOptions.Default;
            var openOpen = KeyRange.OpenOpen(new Key(SpannerNumeric.Parse("0.1")), new Key(SpannerNumeric.Parse("100.1")));
            Assert.False(openOpen.BeginInclusive);
            Assert.False(openOpen.EndInclusive);
            Assert.Equal(new ListValue { Values = { new[] { new Value { StringValue = "0.1" } } } }, openOpen.BeginAt.ToProtobuf(options));
            Assert.Equal(new ListValue { Values = { new[] { new Value { StringValue = "100.1" } } } }, openOpen.End.ToProtobuf(options));
            Assert.Equal(new Key(SpannerNumeric.Parse("0.1")).ToProtobuf(options), openOpen.BeginAt.ToProtobuf(options));
            Assert.Equal(new Key(SpannerNumeric.Parse("100.1")).ToProtobuf(options), openOpen.End.ToProtobuf(options));
            Assert.Equal(new V1.KeyRange
            {
                StartOpen = new ListValue { Values = { new[] { new Value { StringValue = "0.1" } } } },
                EndOpen = new ListValue { Values = { new[] { new Value { StringValue = "100.1" } } } }
            }, openOpen.ToProtobuf(options));
        }

        [Fact]
        public void CreateEmptyKeyRange()
        {
            var options = SpannerConversionOptions.Default;
            var empty = KeyRange.ClosedOpen(new Key(), new Key());
            Assert.Empty(empty.BeginAt.ToProtobuf(options).Values);
            Assert.Empty(empty.End.ToProtobuf(options).Values);
        }

        [Fact]
        public void TypeMappings()
        {
            // Without specifying the type mapping.
            var builder = new SpannerConnectionStringBuilder();
            var range1 = KeyRange.ClosedOpen(new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k1", Value = 3.14m } }),
               new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k2", Value = 1.71m } }));
            var range2 = KeyRange.ClosedClosed(new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k3", Value = new DateTime(2022, 06, 08) } }),
              new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k4", Value = new DateTime(2024, 06, 08) } }));

            Assert.Equal(new V1.KeyRange
            {
                StartClosed = new ListValue { Values = { new[] { new Value { StringValue = "3.14" } } } },
                EndOpen = new ListValue { Values = { new[] { new Value { StringValue = "1.71" } } } },
            }, range1.ToProtobuf(builder.ConversionOptions));

            Assert.Equal(new V1.KeyRange
            {
                StartClosed = new ListValue { Values = { new[] { new Value { StringValue = "2022-06-08T00:00:00Z" } } } },
                EndClosed = new ListValue { Values = { new[] { new Value { StringValue = "2024-06-08T00:00:00Z" } } } },
            }, range2.ToProtobuf(builder.ConversionOptions));

            // Specifying the type mappings.
            builder.ClrToSpannerTypeDefaultMappings = "DecimalToFloat64,DateTimeToDate";
            Assert.Equal(new V1.KeyRange
            {
                StartClosed = new ListValue { Values = { new[] { new Value { NumberValue = 3.14 } } } },
                EndOpen = new ListValue { Values = { new[] { new Value { NumberValue = 1.71 } } } },
            }, range1.ToProtobuf(builder.ConversionOptions));

            Assert.Equal(new V1.KeyRange
            {
                StartClosed = new ListValue { Values = { new[] { new Value { StringValue = "2022-06-08" } } } },
                EndClosed = new ListValue { Values = { new[] { new Value { StringValue = "2024-06-08" } } } },
            }, range2.ToProtobuf(builder.ConversionOptions));

            // Revert the type mappings.
            builder.ClrToSpannerTypeDefaultMappings = "";
            Assert.Equal(new V1.KeyRange
            {
                StartClosed = new ListValue { Values = { new[] { new Value { StringValue = "3.14" } } } },
                EndOpen = new ListValue { Values = { new[] { new Value { StringValue = "1.71" } } } },
            }, range1.ToProtobuf(builder.ConversionOptions));

            Assert.Equal(new V1.KeyRange
            {
                StartClosed = new ListValue { Values = { new[] { new Value { StringValue = "2022-06-08T00:00:00Z" } } } },
                EndClosed = new ListValue { Values = { new[] { new Value { StringValue = "2024-06-08T00:00:00Z" } } } },
            }, range2.ToProtobuf(builder.ConversionOptions));
        }

        [Fact]
        public void ToString_()
        {
            var builder = new SpannerConnectionStringBuilder();
            var range1 = KeyRange.ClosedOpen(new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k1", Value = 3.14m } }),
                new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k2", Value = 1.71m } }));
            var range2 = KeyRange.ClosedClosed(new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k3", Value = new DateTime(2022, 06, 08) } }),
              new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k4", Value = new DateTime(2024, 06, 08) } }));
            var range3 = KeyRange.ClosedClosed(new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k5", Value = Guid.Parse("8f8c4746-17b1-4d9f-a634-58e11942095f") } }),
              new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k6", Value = Guid.Parse("8f8c4746-17b1-4d9f-a634-58e11942095f") } }));

            Assert.Equal("[[ \"3.14\" ], [ \"1.71\" ])", range1.ToString(builder));
            Assert.Equal("[[ \"2022-06-08T00:00:00Z\" ], [ \"2024-06-08T00:00:00Z\" ]]", range2.ToString(builder));

            // Specify the type mappings. (double for decimal, Date for DateTime)
            builder.ClrToSpannerTypeDefaultMappings = "DecimalToFloat64,DateTimeToDate";
            Assert.Equal("[[ 3.14 ], [ 1.71 ])", range1.ToString(builder));
            Assert.Equal("[[ \"2022-06-08\" ], [ \"2024-06-08\" ]]", range2.ToString(builder));

            // Revert to default. (Numeric for decimal, Timestamp for DateTime)
            builder.ClrToSpannerTypeDefaultMappings = "";
            Assert.Equal("[[ \"3.14\" ], [ \"1.71\" ])", range1.ToString(builder));
            Assert.Equal("[[ \"2022-06-08T00:00:00Z\" ], [ \"2024-06-08T00:00:00Z\" ]]", range2.ToString(builder));
            Assert.Equal("[[ \"8f8c4746-17b1-4d9f-a634-58e11942095f\", \"8f8c4746-17b1-4d9f-a634-58e11942095f\" ]]", range3.ToString(builder));
        }
    }

    public class KeySetTests
    {
        [Fact]
        public void CreateKeySetAll()
        {
            var all = KeySet.All;
            Assert.True(all.AllKeys);
        }

        [Fact]
        public void CreateKeySetFromKeys()
        {
            var options = SpannerConversionOptions.Default;
            var keys = KeySet.FromKeys(new Key("k1"), new Key("k2"), new Key("k3"));
            Assert.Collection(
                keys.Keys,
                k => Assert.Equal("k1", k.ToProtobuf(options).Values[0].StringValue),
                k => Assert.Equal("k2", k.ToProtobuf(options).Values[0].StringValue),
                k => Assert.Equal("k3", k.ToProtobuf(options).Values[0].StringValue)
            );
        }

        [Fact]
        public void TypeMappings()
        {
            // Without specifying the type mapping.
            var builder = new SpannerConnectionStringBuilder();
            var keySet = KeySet.FromParameters(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k1", Value = 3.14m },
                new SpannerParameter { ParameterName = "k2", Value = new DateTime(2022, 06, 08) } });

            var protobufValues = keySet.ToProtobuf(builder.ConversionOptions);
            Assert.Equal("3.14", protobufValues.Keys[0].Values[0].StringValue); // default to Numeric.
            Assert.Equal("2022-06-08T00:00:00Z", protobufValues.Keys[0].Values[1].StringValue); // default to Timestamp.

            // Specifying the type mappings.
            builder.ClrToSpannerTypeDefaultMappings = "DecimalToFloat64,DateTimeToDate";
            protobufValues = keySet.ToProtobuf(builder.ConversionOptions);
            Assert.Equal(3.14d, protobufValues.Keys[0].Values[0].NumberValue); // double value.
            Assert.Equal("2022-06-08", protobufValues.Keys[0].Values[1].StringValue); // Date string.

            // Revert the type mappings.
            builder.ClrToSpannerTypeDefaultMappings = "";
            protobufValues = keySet.ToProtobuf(builder.ConversionOptions);
            Assert.Equal("3.14", protobufValues.Keys[0].Values[0].StringValue); // default to Numeric.
            Assert.Equal("2022-06-08T00:00:00Z", protobufValues.Keys[0].Values[1].StringValue); // default to Timestamp.
        }

        [Fact]
        public void CreateKeySetFromRanges()
        {
            var options = SpannerConversionOptions.Default;
            var ranges = KeySet.FromRanges(
                KeyRange.ClosedOpen(new Key("begin"), new Key("end")), KeyRange.ClosedClosed(new Key(1L), new Key(2L)));
            Assert.Collection(ranges.Ranges,
                range => Assert.Equal(KeyRange.ClosedOpen(new Key("begin"), new Key("end")).ToProtobuf(options), range.ToProtobuf(options)),
                range => Assert.Equal(KeyRange.ClosedClosed(new Key(1L), new Key(2L)).ToProtobuf(options), range.ToProtobuf(options))
            );
        }

        [Fact]
        public void ToStringKeySetWithBuilder()
        {
            var builder = new SpannerConnectionStringBuilder();
            var keySet = KeySet.FromParameters(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k1", Value = 3.14m },
                new SpannerParameter { ParameterName = "k2", Value = new DateTime(2022, 06, 08) } });

            Assert.Collection(keySet.Keys,
                key1 => Assert.Equal("[ \"3.14\", \"2022-06-08T00:00:00Z\" ]", key1.ToString(builder)));

            // Specify the type mappings.
            builder.ClrToSpannerTypeDefaultMappings = "DecimalToFloat64,DateTimeToDate";
            Assert.Collection(keySet.Keys,
               key1 => Assert.Equal("[ 3.14, \"2022-06-08\" ]", key1.ToString(builder)));

            // Revert the type mappings.
            builder.ClrToSpannerTypeDefaultMappings = "";
            Assert.Collection(keySet.Keys,
               key1 => Assert.Equal("[ \"3.14\", \"2022-06-08T00:00:00Z\" ]", key1.ToString(builder)));
        }

        [Fact]
        public void ToStringKeySetAll()
        {
            Assert.Equal("KeySet {AllKeys = true}", KeySet.All.ToString(new SpannerConnectionStringBuilder()));
        }

        [Fact]
        public void ToStringKeySetFromKeys()
        {
            var keys = KeySet.FromKeys(new Key("k1.1", "k1.2"), new Key("k2.1", "k2.2"), new Key("k3.1", "k3.2"));
            Assert.Equal("KeySet {Keys = [[ \"k1.1\", \"k1.2\" ], [ \"k2.1\", \"k2.2\" ], [ \"k3.1\", \"k3.2\" ]]}", keys.ToString(new SpannerConnectionStringBuilder()));
        }

        [Fact]
        public void ToStringKeySetFromKeysWithBuilder()
        {
            var builder = new SpannerConnectionStringBuilder();
            var keys = KeySet.FromKeys(new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k1", Value = 3.14m } }),
                new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k2", Value = new DateTime(2022, 06, 08) } }));

            Assert.Equal("KeySet {Keys = [[ \"3.14\" ], [ \"2022-06-08T00:00:00Z\" ]]}", keys.ToString(builder));

            // Specify the type mappings. (double for decimal, Date for DateTime)
            builder.ClrToSpannerTypeDefaultMappings = "DecimalToFloat64,DateTimeToDate";
            Assert.Equal("KeySet {Keys = [[ 3.14 ], [ \"2022-06-08\" ]]}", keys.ToString(builder));

            // Revert to default. (Numeric for decimal, Timestamp for DateTime)
            builder.ClrToSpannerTypeDefaultMappings = "";
            Assert.Equal("KeySet {Keys = [[ \"3.14\" ], [ \"2022-06-08T00:00:00Z\" ]]}", keys.ToString(builder));
        }

        [Fact]
        public void ToStringKeySetFromRanges()
        {
            var ranges = KeySet.FromRanges(
                KeyRange.ClosedOpen(new Key("beginKeyPart1", "beginKeyPart2"), new Key("endKeyPart1", "endKeyPart2")), KeyRange.ClosedClosed(new Key(1L), new Key(2L)));
            Assert.Equal("KeySet {Ranges = [[[ \"beginKeyPart1\", \"beginKeyPart2\" ], [ \"endKeyPart1\", \"endKeyPart2\" ]), [[ \"1\" ], [ \"2\" ]]]}", ranges.ToString(new SpannerConnectionStringBuilder()));
        }

        [Fact]
        public void ToStringKeySetFromRangesWithBuilder()
        {
            var builder = new SpannerConnectionStringBuilder();
            var ranges = KeySet.FromRanges(
                KeyRange.ClosedOpen(new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k1", Value = 3.14m } }),
                new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k2", Value = 1.71m } })),
                 KeyRange.ClosedClosed(new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k3", Value = new DateTime(2022, 06, 08) } }),
                 new Key(new SpannerParameterCollection { new SpannerParameter { ParameterName = "k4", Value = new DateTime(2024, 06, 08) } })));

            Assert.Equal("KeySet {Ranges = [[[ \"3.14\" ], [ \"1.71\" ]), [[ \"2022-06-08T00:00:00Z\" ], [ \"2024-06-08T00:00:00Z\" ]]]}", ranges.ToString(builder));

            // Specify the type mappings. (double for decimal, Date for DateTime)
            builder.ClrToSpannerTypeDefaultMappings = "DecimalToFloat64,DateTimeToDate";
            Assert.Equal("KeySet {Ranges = [[[ 3.14 ], [ 1.71 ]), [[ \"2022-06-08\" ], [ \"2024-06-08\" ]]]}", ranges.ToString(builder));

            // Revert to default. (Numeric for decimal, Timestamp for DateTime)
            builder.ClrToSpannerTypeDefaultMappings = "";
            Assert.Equal("KeySet {Ranges = [[[ \"3.14\" ], [ \"1.71\" ]), [[ \"2022-06-08T00:00:00Z\" ], [ \"2024-06-08T00:00:00Z\" ]]]}", ranges.ToString(builder));
        }
    }
}
