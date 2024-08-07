// Copyright 2018 Google LLC
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

using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Protobuf.WellKnownTypes;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    /// <summary>
    /// A table fixture that covers all Spanner types. The fixture doesn't populate any data,
    /// but tests should not depend on the table being empty as other tests may modify it.
    /// </summary>
    [CollectionDefinition(nameof(AllTypesTableFixture))]
    public class AllTypesTableFixture : SpannerTableFixture, ICollectionFixture<AllTypesTableFixture>
    {
        public AllTypesTableFixture() : base("TypesTable")
        {
        }

        /// <summary>
        /// Creates INSERT command for the table created after executing the <see cref="CreateTable"/> method execution.
        /// Note that the emulator doesn't yet support the JSON type.
        /// </summary>
        /// <returns>The DML command to insert data into a table.</returns>
        public string CreateInsertCommand(bool skipProtobufValue = false) =>
            $@"INSERT {TableName} (
                 K,
                 BoolValue,
                 Int64Value,
                 {EmptyOnEmulator("Float32Value,")}
                 Float64Value,
                 StringValue,
                 NumericValue,
                 BytesValue,
                 TimestampValue,
                 {EmptyOnEmulator("JsonValue,")}
                 DateValue,
                 {MaybeEmpty(EmptyOnEmulator("ProtobufValueValue,"), skipProtobufValue)/* b/348716298 and b/348711708 */}
                 ProtobufDurationValue,
                 ProtobufRectangleValue,
                 {EmptyOnEmulator("ProtobufPersonValue,")/* b/348716298 */}
                 {EmptyOnEmulator("ProtobufValueWrapperValue,")/* b/348716298 */}
                 BoolArrayValue,
                 Int64ArrayValue,
                 {EmptyOnEmulator("Float32ArrayValue,")}
                 Float64ArrayValue,
                 NumericArrayValue,
                 StringArrayValue,
                 Base64ArrayValue,
                 BytesArrayValue,
                 TimestampArrayValue,
                 {EmptyOnEmulator("JsonArrayValue,")}
                 DateArrayValue,
                 {EmptyOnEmulator("ProtobufValueArrayValue,")/* b/348716298 */}
                 ProtobufDurationArrayValue,
                 ProtobufRectangleArrayValue
                 {EmptyOnEmulator(", ProtobufPersonArrayValue")/* b/348716298 */}
                 {EmptyOnEmulator(", ProtobufValueWrapperArrayValue")/* b/348716298 */}) VALUES(
                 @K,
                 @BoolValue,
                 @Int64Value,
                 {EmptyOnEmulator("@Float32Value,")}
                 @Float64Value,
                 @StringValue,
                 @NumericValue,
                 @BytesValue,
                 @TimestampValue,
                 {EmptyOnEmulator("@JsonValue,")}
                 @DateValue,
                 {MaybeEmpty(EmptyOnEmulator("@ProtobufValueValue,"), skipProtobufValue)/* b/348716298 and b/348711708 */}
                 @ProtobufDurationValue,
                 @ProtobufRectangleValue,
                 {EmptyOnEmulator("@ProtobufPersonValue,")/* b/348716298 */}
                 {EmptyOnEmulator("@ProtobufValueWrapperValue,")/* b/348716298 */}
                 @BoolArrayValue,
                 @Int64ArrayValue,
                 {EmptyOnEmulator("@Float32ArrayValue,")}
                 @Float64ArrayValue,
                 @NumericArrayValue,
                 @StringArrayValue,
                 @Base64ArrayValue,
                 @BytesArrayValue,
                 @TimestampArrayValue,
                 {EmptyOnEmulator("@JsonArrayValue,")}
                 @DateArrayValue,
                 {EmptyOnEmulator("@ProtobufValueArrayValue,")/* b/348716298 */}
                 @ProtobufDurationArrayValue,
                 @ProtobufRectangleArrayValue
                 {EmptyOnEmulator(", @ProtobufPersonArrayValue")/* b/348716298 */}
                 {EmptyOnEmulator(", @ProtobufValueWrapperArrayValue")/* b/348716298 */}
               )";

        // Note: the emulator doesn't yet support the JSON type.
        protected override void CreateTable() =>
            ExecuteDdl($@"CREATE TABLE {TableName}(
                            K                                                   STRING(MAX) NOT NULL,
                            BoolValue                                           BOOL,
                            Int64Value                                          INT64,
                            {EmptyOnEmulator("Float32Value                      FLOAT32,")}
                            Float64Value                                        FLOAT64,
                            StringValue                                         STRING(MAX),
                            NumericValue                                        NUMERIC,
                            BytesValue                                          BYTES(MAX),
                            TimestampValue                                      TIMESTAMP,
                            {EmptyOnEmulator("JsonValue                         JSON,")}
                            DateValue                                           DATE,
                            {EmptyOnEmulator($"ProtobufValueValue               {Value.Descriptor.FullName},")/* b/348716298 */}
                            ProtobufDurationValue                               {Duration.Descriptor.FullName},
                            ProtobufRectangleValue                              {Rectangle.Descriptor.FullName},
                            {EmptyOnEmulator($"ProtobufPersonValue              {Person.Descriptor.FullName},")/* b/348716298 */}
                            {EmptyOnEmulator($"ProtobufValueWrapperValue        {ValueWrapper.Descriptor.FullName},")/* b/348716298 */}
                            BoolArrayValue                                      ARRAY<BOOL>,
                            Int64ArrayValue                                     ARRAY<INT64>,
                            {EmptyOnEmulator("Float32ArrayValue                 ARRAY<FLOAT32>,")}
                            Float64ArrayValue                                   ARRAY<FLOAT64>,
                            NumericArrayValue                                   ARRAY<NUMERIC>,
                            StringArrayValue                                    ARRAY<STRING(MAX)>,
                            Base64ArrayValue                                    ARRAY<BYTES(MAX)>,
                            BytesArrayValue                                     ARRAY<BYTES(MAX)>,
                            TimestampArrayValue                                 ARRAY<TIMESTAMP>,
                            {EmptyOnEmulator("JsonArrayValue                    ARRAY<JSON>,")}
                            DateArrayValue                                      ARRAY<DATE>,
                            {EmptyOnEmulator($"ProtobufValueArrayValue          ARRAY<{Value.Descriptor.FullName}>,")/* b/348716298 */}
                            ProtobufDurationArrayValue                          ARRAY<{Duration.Descriptor.FullName}>,
                            ProtobufRectangleArrayValue                         ARRAY<{Rectangle.Descriptor.FullName}>
                            {EmptyOnEmulator($", ProtobufPersonArrayValue         ARRAY<{Person.Descriptor.FullName}>")/* b/348716298 */}
                            {EmptyOnEmulator($", ProtobufValueWrapperArrayValue   ARRAY<{ValueWrapper.Descriptor.FullName}>")/* b/348716298 */}
                          ) PRIMARY KEY(K)");

        private string EmptyOnEmulator(string text) => RunningOnEmulator ? "" : text;

        private string MaybeEmpty(string text, bool skip) => skip ? "" : text;
    }
}
