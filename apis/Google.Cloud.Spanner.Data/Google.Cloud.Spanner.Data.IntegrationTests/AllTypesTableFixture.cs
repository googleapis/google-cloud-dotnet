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
        /// </summary>
        /// <returns>The DML command to insert data into a table.</returns>
        public string CreateInsertCommand()
        {
            // The emulator doesn't yet support the JSON type.
            return $@"INSERT {TableName} (
                              K,
                              BoolValue,           
                              Int64Value,          
                              Float64Value,        
                              StringValue,       
                              NumericValue,        
                              BytesValue,       
                              TimestampValue,      
                              DateValue,           
                              BoolArrayValue,      
                              Int64ArrayValue,     
                              Float64ArrayValue,   
                              NumericArrayValue,  
                              StringArrayValue,    
                              Base64ArrayValue,
                              BytesArrayValue,     
                              TimestampArrayValue,
                              {(RunningOnEmulator ? "" : "JsonArrayValue,") } 
                              DateArrayValue) VALUES(
                              @K,
                              @BoolValue,           
                              @Int64Value,          
                              @Float64Value,        
                              @StringValue,         
                              @NumericValue,        
                              @BytesValue,          
                              @TimestampValue,      
                              @DateValue,           
                              @BoolArrayValue,      
                              @Int64ArrayValue,     
                              @Float64ArrayValue,   
                              @NumericArrayValue,   
                              @StringArrayValue,
                              @Base64ArrayValue,
                              @BytesArrayValue,     
                              @TimestampArrayValue,
                              {(RunningOnEmulator ? "" : "@JsonArrayValue,") } 
                              @DateArrayValue)";
        }

        protected override void CreateTable()
        {
            // The emulator doesn't yet support the JSON type.
            ExecuteDdl($@"CREATE TABLE {TableName}(
                              K                   STRING(MAX) NOT NULL,
                              BoolValue           BOOL,
                              Int64Value          INT64,
                              Float64Value        FLOAT64,
                              StringValue         STRING(MAX),
                              NumericValue        NUMERIC,
                              BytesValue          BYTES(MAX),
                              TimestampValue      TIMESTAMP,
                              DateValue           DATE,
                              BoolArrayValue      ARRAY<BOOL>,
                              Int64ArrayValue     ARRAY<INT64>,
                              Float64ArrayValue   ARRAY<FLOAT64>,
                              NumericArrayValue   ARRAY<NUMERIC>,
                              StringArrayValue    ARRAY<STRING(MAX)>,
                              Base64ArrayValue    ARRAY<BYTES(MAX)>,
                              BytesArrayValue     ARRAY<BYTES(MAX)>,
                              TimestampArrayValue ARRAY<TIMESTAMP>,
                              {(RunningOnEmulator ? "" : "JsonArrayValue      ARRAY<JSON>,") }
                              DateArrayValue      ARRAY<DATE>
                            ) PRIMARY KEY(K)");
        }
    }
}
