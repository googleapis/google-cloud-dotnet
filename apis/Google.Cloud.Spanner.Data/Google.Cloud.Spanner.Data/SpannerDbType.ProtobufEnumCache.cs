using Google.Api.Gax;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace Google.Cloud.Spanner.Data;

public partial class SpannerDbType
{
    private static class ProtobufEnumCache
    {

        private static readonly ConcurrentDictionary<System.Type, EnumDescriptor> s_enumDescriptorCache = new();

        internal static EnumDescriptor GetEnumDescriptor(System.Type enumType) =>
            s_enumDescriptorCache.GetOrAdd(
                GaxPreconditions.CheckNotNull(enumType, nameof(enumType)),
                GetProtobufEnumDescriptor_Uncached(enumType)
            );

        private static EnumDescriptor GetProtobufEnumDescriptor_Uncached(System.Type targetEnumType)
        {
            // Throw an arguement exception if enumType is not an enum.
            if (!targetEnumType.IsEnum)
            {
                throw new ArgumentException("The type must be an enum.", nameof(targetEnumType));
            }

            // An enum in a proto may be defined at the top-level, or nested within a message.
            // How we get the descriptor depends on which.

            // Nested; Nested enums are within the "Types" field of the parent message type so two levels up.
            if (targetEnumType.DeclaringType?.DeclaringType is System.Type parentMessageType)
            {
                var messageDescriptor = ProtobufCache.GetProtobufMessageDescriptor(parentMessageType);

                foreach (var enumDescriptor in messageDescriptor.EnumTypes)
                {
                    if (enumDescriptor.ClrType == targetEnumType)
                    {
                        return enumDescriptor;
                    }
                }
            }

            // Top-level; Enum is defined at the top level of the proto namespace.

            // In this case the enum descriptor can only be found in the sibling Reflection static class.
            // We first bruteforce finding classes that may have that our Enum's descriptor by:
            // 1) Only considering types that end in "Reflection", and
            // 2) Have a property named "Descriptor" that is a public static FileDescriptor.
            var reflectionDescriptors = targetEnumType.Assembly.GetTypes()
                .Where(t => t.Name.EndsWith("Reflection"))
                .Select(t => t.GetProperty("Descriptor", BindingFlags.Static | BindingFlags.Public))
                .Where(p => p?.PropertyType == typeof(FileDescriptor))
                .Select(p => p!.GetValue(null) as FileDescriptor)
                .Where(rd => rd != null);


            // From these candidates, we go through the enums until we find an enum descriptor that matches.
            foreach (var reflectionDescriptor in reflectionDescriptors)
            {
                var found = reflectionDescriptor.EnumTypes.FirstOrDefault(et => et.ClrType == targetEnumType);

                if (found != null)
                {
                    return found;
                }
            }

            // If we didn't find our enum descriptor by this point, then the enum itself just a regular C# enum
            return null;
        }
    }
}
