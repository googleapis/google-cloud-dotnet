// Copyright 2025 Google LLC
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

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gctv = Google.Cloud.Trace.V2;
using sys = System;

namespace Google.Cloud.Trace.V2
{
    /// <summary>Resource name for the <c>Span</c> resource.</summary>
    public sealed partial class SpanName : gax::IResourceName, sys::IEquatable<SpanName>
    {
        /// <summary>The possible contents of <see cref="SpanName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/traces/{trace}/spans/{span}</c>.</summary>
            ProjectTraceSpan = 1,
        }

        private static gax::PathTemplate s_projectTraceSpan = new gax::PathTemplate("projects/{project}/traces/{trace}/spans/{span}");

        /// <summary>Creates a <see cref="SpanName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SpanName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SpanName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SpanName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SpanName"/> with the pattern <c>projects/{project}/traces/{trace}/spans/{span}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="traceId">The <c>Trace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spanId">The <c>Span</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SpanName"/> constructed from the provided ids.</returns>
        public static SpanName FromProjectTraceSpan(string projectId, string traceId, string spanId) =>
            new SpanName(ResourceNameType.ProjectTraceSpan, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), traceId: gax::GaxPreconditions.CheckNotNullOrEmpty(traceId, nameof(traceId)), spanId: gax::GaxPreconditions.CheckNotNullOrEmpty(spanId, nameof(spanId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SpanName"/> with pattern
        /// <c>projects/{project}/traces/{trace}/spans/{span}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="traceId">The <c>Trace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spanId">The <c>Span</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SpanName"/> with pattern
        /// <c>projects/{project}/traces/{trace}/spans/{span}</c>.
        /// </returns>
        public static string Format(string projectId, string traceId, string spanId) =>
            FormatProjectTraceSpan(projectId, traceId, spanId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SpanName"/> with pattern
        /// <c>projects/{project}/traces/{trace}/spans/{span}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="traceId">The <c>Trace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spanId">The <c>Span</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SpanName"/> with pattern
        /// <c>projects/{project}/traces/{trace}/spans/{span}</c>.
        /// </returns>
        public static string FormatProjectTraceSpan(string projectId, string traceId, string spanId) =>
            s_projectTraceSpan.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(traceId, nameof(traceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spanId, nameof(spanId)));

        /// <summary>Parses the given resource name string into a new <see cref="SpanName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/traces/{trace}/spans/{span}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="spanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SpanName"/> if successful.</returns>
        public static SpanName Parse(string spanName) => Parse(spanName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SpanName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/traces/{trace}/spans/{span}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="spanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SpanName"/> if successful.</returns>
        public static SpanName Parse(string spanName, bool allowUnparsed) =>
            TryParse(spanName, allowUnparsed, out SpanName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="SpanName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/traces/{trace}/spans/{span}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="spanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SpanName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string spanName, out SpanName result) => TryParse(spanName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SpanName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/traces/{trace}/spans/{span}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="spanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SpanName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string spanName, bool allowUnparsed, out SpanName result)
        {
            gax::GaxPreconditions.CheckNotNull(spanName, nameof(spanName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTraceSpan.TryParseName(spanName, out resourceName))
            {
                result = FromProjectTraceSpan(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(spanName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SpanName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string spanId = null, string traceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SpanId = spanId;
            TraceId = traceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SpanName"/> class from the component parts of pattern
        /// <c>projects/{project}/traces/{trace}/spans/{span}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="traceId">The <c>Trace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spanId">The <c>Span</c> ID. Must not be <c>null</c> or empty.</param>
        public SpanName(string projectId, string traceId, string spanId) : this(ResourceNameType.ProjectTraceSpan, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), traceId: gax::GaxPreconditions.CheckNotNullOrEmpty(traceId, nameof(traceId)), spanId: gax::GaxPreconditions.CheckNotNullOrEmpty(spanId, nameof(spanId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Span</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpanId { get; }

        /// <summary>
        /// The <c>Trace</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TraceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTraceSpan: return s_projectTraceSpan.Expand(ProjectId, TraceId, SpanId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SpanName);

        /// <inheritdoc/>
        public bool Equals(SpanName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SpanName a, SpanName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SpanName a, SpanName b) => !(a == b);
    }

    public partial class Span
    {
        /// <summary>
        /// <see cref="gctv::SpanName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::SpanName SpanName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::SpanName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
