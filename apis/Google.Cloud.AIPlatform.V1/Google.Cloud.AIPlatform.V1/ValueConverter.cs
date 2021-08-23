// Copyright 2021 Google LLC
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

using Google.Api.Gax;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using WktValue = Google.Protobuf.WellKnownTypes.Value;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>
    /// Utility methods for working with 
    /// <see cref="Google.Protobuf.WellKnownTypes.Value"/> and <see cref="Google.Protobuf.WellKnownTypes.Struct"/>.
    /// </summary>
    public static class ValueConverter
    {
        /// <summary>
        /// Converts a protobuf message to a <see cref="Struct"/>.
        /// </summary>
        /// <param name="message">The message to convert. Must not be null.</param>
        /// <returns>The Struct representation of the message.</returns>
        public static Struct ToStruct(IMessage message)
        {
            GaxPreconditions.CheckNotNull(message, nameof(message));
            return Struct.Parser.ParseJson(message.ToString());
        }

        /// <summary>
        /// Converts a protobuf message to a <see cref="Value"/>.
        /// </summary>
        /// <param name="message">The message to convert. Must not be null.</param>
        /// <returns>The Struct representation of the message.</returns>
        public static WktValue ToValue(IMessage message) => WktValue.ForStruct(ToStruct(message));

        /// <summary>
        /// Converts a <see cref="Struct"/> value to the specified message type.
        /// </summary>
        /// <typeparam name="T">The message type to convert the struct to.</typeparam>
        /// <param name="structValue">The Struct to convert. Must not be null.</param>
        /// <returns>The message representation of the Struct.</returns>
        public static T ToMessage<T>(Struct structValue) where T : IMessage, new()
        {
            GaxPreconditions.CheckNotNull(structValue, nameof(structValue));
            return JsonParser.Default.Parse<T>(structValue.ToString());
        }

        /// <summary>
        /// Converts a <see cref="Value"/> value, which must represent a Struct,
        /// to the specified message type.
        /// </summary>
        /// <typeparam name="T">The message type to convert the struct to.</typeparam>
        /// <param name="structValue">The Struct to convert. Must not be null.</param>
        /// <returns>The message representation of the Struct.</returns>
        public static T ToMessage<T>(WktValue structValue) where T : IMessage, new()
        {
            GaxPreconditions.CheckNotNull(structValue, nameof(structValue));
            GaxPreconditions.CheckArgument(structValue.KindCase == WktValue.KindOneofCase.StructValue,
                nameof(structValue),
                "The value being converted must represent a Struct");
            return ToMessage<T>(structValue.StructValue);
        }
    }
}
