// Copyright 2026 Google LLC
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
using Google.Protobuf.Reflection;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace Google.Cloud.Spanner.Data;

public partial class SpannerDbType
{
    /// <summary>
    /// Protobuf Enum Type Cache
    /// </summary>
    internal static class ProtobufEnumCache
    {
        private static readonly ConcurrentDictionary<System.Type, EnumDescriptor> s_enumDescriptorCache = new();

        /// <summary>
        /// If <paramref name="enumType"/> is a Protobuf enum, attempts to return the corresponding <see cref="EnumDescriptor"/>
        /// from the cache. If not present in the cache, uses reflection to find it and add it to the cache then returns it.
        /// Returns null if <paramref name="enumType"/> is not a Protobuf enum.
        /// </summary>
        /// <param name="enumType">The Protobuf enum type</param>
        /// <returns>The <see cref="EnumDescriptor"/> for the Protobuf enum type, or null if <paramref name="enumType"/>
        /// is not a Protobuf enum</returns>
        internal static EnumDescriptor GetEnumDescriptor(System.Type enumType)
        {
            if (!enumType.IsEnum)
            {
                return null;
            }

            return s_enumDescriptorCache.GetOrAdd(
                GaxPreconditions.CheckNotNull(enumType, nameof(enumType)),
                GetProtobufEnumDescriptor_Uncached(enumType)
            );
        }


        /// <summary>
        /// Gets the <see cref="EnumDescriptor"/> for the Protobuf enum type. Uses reflection to
        /// determine if the enum is top-level or nested, and then searches for the underlying,
        /// <see cref="FileDescriptor"/> or <see cref="MessageDescriptor"/> that contains the
        /// <see cref="EnumDescriptor"/>.
        /// </summary>
        /// <param name="targetEnumType">Protobuf enum type</param>
        /// <returns>The <see cref="EnumDescriptor"/> for the Protobuf enum, or null if it could not be found</returns>
        private static EnumDescriptor GetProtobufEnumDescriptor_Uncached(System.Type targetEnumType)
        {
            // An Protobuf enum may be defined at the package level, or nested within a message.
            // How we get the descriptor depends on which.

            // Nested enums are within the "Types" class of the parent message type so two levels up.
            if (targetEnumType.DeclaringType is System.Type intermediateParent
                && intermediateParent.Name == "Types" && intermediateParent.IsClass
                && intermediateParent.IsAbstract && intermediateParent.IsSealed // Check for "IsStatic"
                && intermediateParent.DeclaringType is System.Type parentMessageType
                && ProtobufCache.GetProtobufMessageDescriptor(parentMessageType) is MessageDescriptor messageDescriptor
                && messageDescriptor.EnumTypes.FirstOrDefault(enumDescriptor => enumDescriptor.ClrType.Equals(targetEnumType)) is EnumDescriptor enumDescriptor)
            {
                return enumDescriptor;
            }

            // Top-level; Enum is defined at the top level of the proto namespace.

            // We inspect all the Protobuf reflection classes, and specifically the FileDescriptor property,
            // trying to find the one that contains the descriptor for our enum type.
            foreach (var maybeEnumReflection in targetEnumType.Assembly.GetTypes())
            {
                if (maybeEnumReflection.IsClass
                    && maybeEnumReflection.Name.EndsWith("Reflection")
                    && maybeEnumReflection.GetProperty("Descriptor", BindingFlags.Static | BindingFlags.Public)?.GetValue(null) is FileDescriptor maybeEnumFileDescriptor
                    && maybeEnumFileDescriptor.EnumTypes.FirstOrDefault(maybeEnumDescriptor => maybeEnumDescriptor.ClrType == targetEnumType) is EnumDescriptor targetEnumDescriptor)
                {
                    return targetEnumDescriptor;
                }
            }

            // If we didn't find our enum descriptor by this point, then the enum itself just a regular C# enum
            return null;
        }
    }
}
