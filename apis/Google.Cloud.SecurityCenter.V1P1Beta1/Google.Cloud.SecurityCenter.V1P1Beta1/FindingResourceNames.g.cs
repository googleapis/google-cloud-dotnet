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
    /// <summary>Resource name for the <c>Finding</c> resource.</summary>
    public sealed partial class FindingName : gax::IResourceName, sys::IEquatable<FindingName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/sources/{source}/findings/{finding}");

        /// <summary>
        /// Parses the given <c>Finding</c> resource name in string form into a new <see cref="FindingName"/> instance.
        /// </summary>
        /// <param name="findingName">The <c>Finding</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FindingName"/> if successful.</returns>
        public static FindingName Parse(string findingName)
        {
            gax::GaxPreconditions.CheckNotNull(findingName, nameof(findingName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(findingName);
            return new FindingName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="FindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="findingName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="findingName">The <c>Finding</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FindingName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingName, out FindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(findingName, nameof(findingName));
            if (s_template.TryParseName(findingName, out gax::TemplatedResourceName resourceName))
            {
                result = new FindingName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="FindingName"/>.</summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c>.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="FindingName"/>.</returns>
        public static string Format(string organizationId, string sourceId, string findingId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNull(findingId, nameof(findingId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="FindingName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c>.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c>.</param>
        public FindingName(string organizationId, string sourceId, string findingId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            SourceId = gax::GaxPreconditions.CheckNotNull(sourceId, nameof(sourceId));
            FindingId = gax::GaxPreconditions.CheckNotNull(findingId, nameof(findingId));
        }

        /// <summary>The <c>Organization</c> ID. Never <c>null</c>.</summary>
        public string OrganizationId { get; }

        /// <summary>The <c>Source</c> ID. Never <c>null</c>.</summary>
        public string SourceId { get; }

        /// <summary>The <c>Finding</c> ID. Never <c>null</c>.</summary>
        public string FindingId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(OrganizationId, SourceId, FindingId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FindingName);

        /// <inheritdoc/>
        public bool Equals(FindingName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(FindingName a, FindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(FindingName a, FindingName b) => !(a == b);
    }

    public partial class Finding
    {
        /// <summary>
        /// <see cref="gcsv::FindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::FindingName FindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::FindingName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
