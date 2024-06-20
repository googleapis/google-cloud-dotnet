// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
using Google.Protobuf.Reflection;
using System.Collections.Concurrent;
using System.Reflection;

namespace Google.Cloud.Spanner.Data;
public partial class SpannerDbType
{
    /// <summary>
    /// Protobuf CLR type cache.
    /// </summary>
    private static class ProtobufCache
    {
        private static readonly ConcurrentDictionary<System.Type, MessageDescriptor> _descriptors = new ConcurrentDictionary<System.Type, MessageDescriptor>();

        /// <summary>
        /// Attempts to get the <see cref="IMessage.Descriptor"/> for the given protobuf CLR type from the cache, if present,
        /// otherwise, via reflection, caching it for subsequent calls.
        /// </summary>
        /// <returns>
        /// The <see cref="MessageDescriptor"/> for <paramref name="clrProtobufTypeTarget"/> if <paramref name="clrProtobufTypeTarget"/>
        /// is truly the CLR type of a protobuf message.
        /// Otherwise this method returns null.
        /// </returns>
        internal static MessageDescriptor GetProtobufMessageDescriptor(System.Type clrProtobufTypeTarget) =>
            _descriptors.GetOrAdd(
                GaxPreconditions.CheckNotNull(clrProtobufTypeTarget, nameof(clrProtobufTypeTarget)),
                GetProtobufMessageDescriptor_Uncached(clrProtobufTypeTarget));

        /// <summary>
        /// Attempts to get the <see cref="MessageDescriptor.Parser"/> for the given protobuf CLR type from the cache, if present,
        /// otherwise, via reflection, caching it for subsequent calls.
        /// </summary>
        /// <returns>
        /// The <see cref="MessageParser"/> for <paramref name="clrProtobufTypeTarget"/> if <paramref name="clrProtobufTypeTarget"/>
        /// is truly the CLR type of a protobuf message.
        /// Otherwise this method returns null.
        /// </returns>
        internal static MessageParser GetProtobufMessageParser(System.Type clrProtobufTypeTarget) =>
            GetProtobufMessageDescriptor(clrProtobufTypeTarget)?.Parser;

        /// <summary>
        /// Obtains the <see cref="IMessage.Descriptor"/> property value for the given protobuf CLR type, via reflection.
        /// </summary>
        /// <returns>
        /// The <see cref="MessageDescriptor"/> for <paramref name="clrProtobufTypeTarget"/> if <paramref name="clrProtobufTypeTarget"/>
        /// is truly the CLR type of a protobuf message.
        /// Otherwise this method returns null.
        /// </returns>
        private static MessageDescriptor GetProtobufMessageDescriptor_Uncached(System.Type clrProtobufTypeTarget) =>
            typeof(IMessage).IsAssignableFrom(clrProtobufTypeTarget)
            && clrProtobufTypeTarget.GetProperty("Descriptor", BindingFlags.Static | BindingFlags.Public) is PropertyInfo descriptorProperty
            && descriptorProperty.CanRead
            && descriptorProperty.GetValue(null) is MessageDescriptor propertyValue ? propertyValue : null;
    }
}
