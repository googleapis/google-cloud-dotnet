// Polyfill for ExperimentalAttribute in .NET
#if !NET
namespace System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface |
    AttributeTargets.Delegate | AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Property |
    AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Assembly)]
internal sealed class ExperimentalAttribute(string diagnosticId) : Attribute
{
    public string DiagnosticId { get; } = diagnosticId;

    public string? UrlFormat { get; set; }
}
#endif
