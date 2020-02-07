// Copyright 2020 Google LLC
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
using gcsv = Google.Cloud.SecurityCenter.V1P1Beta1;
using sys = System;

namespace Google.Cloud.SecurityCenter.V1P1Beta1
{
    /// <summary>Resource name for the <c>Source</c> resource.</summary>
    public sealed partial class SourceName : gax::IResourceName, sys::IEquatable<SourceName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/sources/{source}");

        /// <summary>
        /// Parses the given <c>Source</c> resource name in string form into a new <see cref="SourceName"/> instance.
        /// </summary>
        /// <param name="sourceName">The <c>Source</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SourceName"/> if successful.</returns>
        public static SourceName Parse(string sourceName)
        {
            gax::GaxPreconditions.CheckNotNull(sourceName, nameof(sourceName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(sourceName);
            return new SourceName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="SourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="sourceName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="sourceName">The <c>Source</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SourceName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sourceName, out SourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(sourceName, nameof(sourceName));
            if (s_template.TryParseName(sourceName, out gax::TemplatedResourceName resourceName))
            {
                result = new SourceName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="SourceName"/>.</summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="SourceName"/>.</returns>
        public static string Format(string organizationId, string sourceId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(sourceId, nameof(sourceId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="SourceName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c>.</param>
        public SourceName(string organizationId, string sourceId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            SourceId = gax::GaxPreconditions.CheckNotNull(sourceId, nameof(sourceId));
        }

        /// <summary>The <c>Organization</c> ID. Never <c>null</c>.</summary>
        public string OrganizationId { get; }

        /// <summary>The <c>Source</c> ID. Never <c>null</c>.</summary>
        public string SourceId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(OrganizationId, SourceId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SourceName);

        /// <inheritdoc/>
        public bool Equals(SourceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SourceName a, SourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SourceName a, SourceName b) => !(a == b);
    }

    public partial class Source
    {
        /// <summary>
        /// <see cref="gcsv::SourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SourceName SourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SourceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
