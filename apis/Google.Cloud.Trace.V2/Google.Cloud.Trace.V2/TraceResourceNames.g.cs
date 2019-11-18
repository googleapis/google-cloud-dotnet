// Copyright 2019 Google LLC
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

using gax = Google.Api.Gax;
using gctv = Google.Cloud.Trace.V2;
using sys = System;

namespace Google.Cloud.Trace.V2
{
    /// <summary>Resource name for the <c>Span</c> resource.</summary>
    public sealed partial class SpanName : gax::IResourceName, sys::IEquatable<SpanName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/traces/{trace}/spans/{span}");

        /// <summary>
        /// Parses the given <c>Span</c> resource name in string form into a new <see cref="SpanName"/> instance.
        /// </summary>
        /// <param name="spanName">The <c>Span</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SpanName"/> if successful.</returns>
        public static SpanName Parse(string spanName)
        {
            gax::GaxPreconditions.CheckNotNull(spanName, nameof(spanName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(spanName);
            return new SpanName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="SpanName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="spanName"/> is <c>null</c>
        /// , as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="spanName">The <c>Span</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SpanName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string spanName, out SpanName result)
        {
            gax::GaxPreconditions.CheckNotNull(spanName, nameof(spanName));
            if (s_template.TryParseName(spanName, out gax::TemplatedResourceName resourceName))
            {
                result = new SpanName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="SpanName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="traceId">The <c>Trace</c> ID. Must not be <c>null</c>.</param>
        /// <param name="spanId">The <c>Span</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="SpanName"/>.</returns>
        public static string Format(string projectId, string traceId, string spanId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(traceId, nameof(traceId)), gax::GaxPreconditions.CheckNotNull(spanId, nameof(spanId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="SpanName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="traceId">The <c>Trace</c> ID. Must not be <c>null</c>.</param>
        /// <param name="spanId">The <c>Span</c> ID. Must not be <c>null</c>.</param>
        public SpanName(string projectId, string traceId, string spanId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TraceId = gax::GaxPreconditions.CheckNotNull(traceId, nameof(traceId));
            SpanId = gax::GaxPreconditions.CheckNotNull(spanId, nameof(spanId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Trace</c> ID. Never <c>null</c>.</summary>
        public string TraceId { get; }

        /// <summary>The <c>Span</c> ID. Never <c>null</c>.</summary>
        public string SpanId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, TraceId, SpanId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SpanName);

        /// <inheritdoc/>
        public bool Equals(SpanName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SpanName a, SpanName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SpanName a, SpanName b) => !(a == b);
    }

    public partial class Span
    {
        /// <summary>
        /// <see cref="gctv::SpanName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::SpanName SpanName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::SpanName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
