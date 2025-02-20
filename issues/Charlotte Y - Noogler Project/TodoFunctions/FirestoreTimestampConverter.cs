// Copyright 2025 Google Inc. All Rights Reserved.
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

using Google.Cloud.Firestore;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TodoFunctions
{
    public class FirestoreTimestampConverter : JsonConverter<Timestamp>
    {
        private const string TimestampFormat = "yyyy-MM-ddTHH:mm:ss.ffffffZ"; // ISO 8601 format

        public override void Write(Utf8JsonWriter writer, Timestamp value, JsonSerializerOptions options)
        {
            // Convert Timestamp to ISO 8601 string (UTC)
            DateTime dateTime = value.ToDateTime();
            string isoString = dateTime.ToUniversalTime().ToString(TimestampFormat);
            writer.WriteStringValue(isoString);
        }

        public override Timestamp Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                string dateString = reader.GetString();
                if (DateTime.TryParse(dateString, out DateTime dateTime))
                {
                    return Timestamp.FromDateTime(dateTime.ToUniversalTime());
                }
                else
                {
                    throw new JsonException($"Could not parse DateTime from string: {dateString}");
                }
            }

            throw new JsonException($"Unexpected token type: {reader.TokenType}.  Expected String.");
        }
    }

    public class FirestoreTimestampConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(Timestamp);
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            return new FirestoreTimestampConverter();
        }
    }
}
