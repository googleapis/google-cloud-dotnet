using System;

namespace Google.Cloud.Spanner.Data;

/// <summary>
/// Convenience methods for working with Protobuf enums
/// </summary>
internal static class ProtobufEnumExtensions
{
    /// <summary>
    /// Gets the Protobuf enum FQN(Fully Qualified Name) of the enum type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_">Enum value for the Protobuf enum</param>
    /// <returns>
    /// The FQN of a Protobuf enum, or the empty string if enum is
    /// not a Protobuf enum.
    /// </returns>
    internal static string GetProtobufEnumFqn<T>(this T _) where T : struct, Enum =>
        SpannerDbType.ProtobufEnumCache.GetEnumDescriptor(typeof(T))?.FullName ?? "";
}
