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
    /// <summary>Resource name for the <c>OrganizationSettings</c> resource.</summary>
    public sealed partial class OrganizationSettingsName : gax::IResourceName, sys::IEquatable<OrganizationSettingsName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/organizationSettings");

        /// <summary>
        /// Parses the given <c>OrganizationSettings</c> resource name in string form into a new
        /// <see cref="OrganizationSettingsName"/> instance.
        /// </summary>
        /// <param name="organizationSettingsName">
        /// The <c>OrganizationSettings</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="OrganizationSettingsName"/> if successful.</returns>
        public static OrganizationSettingsName Parse(string organizationSettingsName)
        {
            gax::GaxPreconditions.CheckNotNull(organizationSettingsName, nameof(organizationSettingsName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(organizationSettingsName);
            return new OrganizationSettingsName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new
        /// <see cref="OrganizationSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if
        /// <paramref name="organizationSettingsName"/> is <c>null</c>, as this would usually indicate a programming
        /// error rather than a data error.
        /// </remarks>
        /// <param name="organizationSettingsName">
        /// The <c>OrganizationSettings</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationSettingsName"/>, or <c>null</c> if parsing
        /// fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationSettingsName, out OrganizationSettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationSettingsName, nameof(organizationSettingsName));
            if (s_template.TryParseName(organizationSettingsName, out gax::TemplatedResourceName resourceName))
            {
                result = new OrganizationSettingsName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Formats the IDs into the string representation of the <see cref="OrganizationSettingsName"/>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="OrganizationSettingsName"/>.</returns>
        public static string Format(string organizationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationSettingsName"/> resource name class from its
        /// component parts.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        public OrganizationSettingsName(string organizationId) => OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));

        /// <summary>The <c>Organization</c> ID. Never <c>null</c>.</summary>
        public string OrganizationId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(OrganizationId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrganizationSettingsName);

        /// <inheritdoc/>
        public bool Equals(OrganizationSettingsName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(OrganizationSettingsName a, OrganizationSettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(OrganizationSettingsName a, OrganizationSettingsName b) => !(a == b);
    }

    public partial class OrganizationSettings
    {
        /// <summary>
        /// <see cref="gcsv::OrganizationSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::OrganizationSettingsName OrganizationSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::OrganizationSettingsName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
