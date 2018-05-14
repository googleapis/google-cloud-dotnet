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

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxres = Google.Api.Gax.ResourceNames;
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.Trace.V2
{
    /// <summary>
    /// Resource name for the 'span' resource.
    /// </summary>
    public sealed partial class SpanName : gax::IResourceName, sys::IEquatable<SpanName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/traces/{trace}/spans/{span}");

        /// <summary>
        /// Parses the given span resource name in string form into a new
        /// <see cref="SpanName"/> instance.
        /// </summary>
        /// <param name="spanName">The span resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SpanName"/> if successful.</returns>
        public static SpanName Parse(string spanName)
        {
            gax::GaxPreconditions.CheckNotNull(spanName, nameof(spanName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(spanName);
            return new SpanName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given span resource name in string form into a new
        /// <see cref="SpanName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="spanName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="spanName">The span resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SpanName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string spanName, out SpanName result)
        {
            gax::GaxPreconditions.CheckNotNull(spanName, nameof(spanName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(spanName, out resourceName))
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

        /// <summary>
        /// Constructs a new instance of the <see cref="SpanName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="traceId">The trace ID. Must not be <c>null</c>.</param>
        /// <param name="spanId">The span ID. Must not be <c>null</c>.</param>
        public SpanName(string projectId, string traceId, string spanId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TraceId = gax::GaxPreconditions.CheckNotNull(traceId, nameof(traceId));
            SpanId = gax::GaxPreconditions.CheckNotNull(spanId, nameof(spanId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The trace ID. Never <c>null</c>.
        /// </summary>
        public string TraceId { get; }

        /// <summary>
        /// The span ID. Never <c>null</c>.
        /// </summary>
        public string SpanId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, TraceId, SpanId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SpanName);

        /// <inheritdoc />
        public bool Equals(SpanName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SpanName a, SpanName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SpanName a, SpanName b) => !(a == b);
    }


    public partial class BatchWriteSpansRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ProjectName
        {
            get { return string.IsNullOrEmpty(Name) ? null : gaxres::ProjectName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Span
    {
        /// <summary>
        /// <see cref="Google.Cloud.Trace.V2.SpanName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Trace.V2.SpanName SpanName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Trace.V2.SpanName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}