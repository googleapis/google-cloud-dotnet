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
using gcmv = Google.Cloud.ManagedIdentities.V1;
using sys = System;

namespace Google.Cloud.ManagedIdentities.V1
{
    /// <summary>Resource name for the <c>Domain</c> resource.</summary>
    public sealed partial class DomainName : gax::IResourceName, sys::IEquatable<DomainName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/domains/{domain}");

        /// <summary>
        /// Parses the given <c>Domain</c> resource name in string form into a new <see cref="DomainName"/> instance.
        /// </summary>
        /// <param name="domainName">The <c>Domain</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DomainName"/> if successful.</returns>
        public static DomainName Parse(string domainName)
        {
            gax::GaxPreconditions.CheckNotNull(domainName, nameof(domainName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(domainName);
            return new DomainName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="DomainName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="domainName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="domainName">The <c>Domain</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DomainName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string domainName, out DomainName result)
        {
            gax::GaxPreconditions.CheckNotNull(domainName, nameof(domainName));
            if (s_template.TryParseName(domainName, out gax::TemplatedResourceName resourceName))
            {
                result = new DomainName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="DomainName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="domainId">The <c>Domain</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="DomainName"/>.</returns>
        public static string Format(string projectId, string locationId, string domainId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(domainId, nameof(domainId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="DomainName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="domainId">The <c>Domain</c> ID. Must not be <c>null</c>.</param>
        public DomainName(string projectId, string locationId, string domainId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            DomainId = gax::GaxPreconditions.CheckNotNull(domainId, nameof(domainId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Location</c> ID. Never <c>null</c>.</summary>
        public string LocationId { get; }

        /// <summary>The <c>Domain</c> ID. Never <c>null</c>.</summary>
        public string DomainId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, LocationId, DomainId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DomainName);

        /// <inheritdoc/>
        public bool Equals(DomainName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DomainName a, DomainName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DomainName a, DomainName b) => !(a == b);
    }

    public partial class Domain
    {
        /// <summary>
        /// <see cref="gcmv::DomainName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::DomainName DomainName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::DomainName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
