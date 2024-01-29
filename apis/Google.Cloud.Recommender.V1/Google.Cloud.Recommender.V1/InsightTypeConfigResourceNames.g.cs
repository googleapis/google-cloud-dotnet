// Copyright 2024 Google LLC
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
using gcrv = Google.Cloud.Recommender.V1;
using sys = System;

namespace Google.Cloud.Recommender.V1
{
    /// <summary>Resource name for the <c>InsightTypeConfig</c> resource.</summary>
    public sealed partial class InsightTypeConfigName : gax::IResourceName, sys::IEquatable<InsightTypeConfigName>
    {
        /// <summary>The possible contents of <see cref="InsightTypeConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/config</c>.
            /// </summary>
            ProjectLocationInsightType = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/config</c>.
            /// </summary>
            OrganizationLocationInsightType = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/config</c>.
            /// </summary>
            BillingAccountLocationInsightType = 3,
        }

        private static gax::PathTemplate s_projectLocationInsightType = new gax::PathTemplate("projects/{project}/locations/{location}/insightTypes/{insight_type}/config");

        private static gax::PathTemplate s_organizationLocationInsightType = new gax::PathTemplate("organizations/{organization}/locations/{location}/insightTypes/{insight_type}/config");

        private static gax::PathTemplate s_billingAccountLocationInsightType = new gax::PathTemplate("billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/config");

        /// <summary>Creates a <see cref="InsightTypeConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InsightTypeConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InsightTypeConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InsightTypeConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InsightTypeConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/config</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InsightTypeConfigName"/> constructed from the provided ids.</returns>
        public static InsightTypeConfigName FromProjectLocationInsightType(string projectId, string locationId, string insightTypeId) =>
            new InsightTypeConfigName(ResourceNameType.ProjectLocationInsightType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>
        /// Creates a <see cref="InsightTypeConfigName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/config</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InsightTypeConfigName"/> constructed from the provided ids.</returns>
        public static InsightTypeConfigName FromOrganizationLocationInsightType(string organizationId, string locationId, string insightTypeId) =>
            new InsightTypeConfigName(ResourceNameType.OrganizationLocationInsightType, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>
        /// Creates a <see cref="InsightTypeConfigName"/> with the pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/config</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InsightTypeConfigName"/> constructed from the provided ids.</returns>
        public static InsightTypeConfigName FromBillingAccountLocationInsightType(string billingAccountId, string locationId, string insightTypeId) =>
            new InsightTypeConfigName(ResourceNameType.BillingAccountLocationInsightType, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightTypeConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/config</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightTypeConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/config</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string insightTypeId) =>
            FormatProjectLocationInsightType(projectId, locationId, insightTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightTypeConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/config</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightTypeConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/config</c>.
        /// </returns>
        public static string FormatProjectLocationInsightType(string projectId, string locationId, string insightTypeId) =>
            s_projectLocationInsightType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightTypeConfigName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/config</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightTypeConfigName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/config</c>.
        /// </returns>
        public static string FormatOrganizationLocationInsightType(string organizationId, string locationId, string insightTypeId) =>
            s_organizationLocationInsightType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightTypeConfigName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/config</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightTypeConfigName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/config</c>.
        /// </returns>
        public static string FormatBillingAccountLocationInsightType(string billingAccountId, string locationId, string insightTypeId) =>
            s_billingAccountLocationInsightType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InsightTypeConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/config</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/config</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/config</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="insightTypeConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InsightTypeConfigName"/> if successful.</returns>
        public static InsightTypeConfigName Parse(string insightTypeConfigName) => Parse(insightTypeConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InsightTypeConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/config</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/config</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/config</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="insightTypeConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InsightTypeConfigName"/> if successful.</returns>
        public static InsightTypeConfigName Parse(string insightTypeConfigName, bool allowUnparsed) =>
            TryParse(insightTypeConfigName, allowUnparsed, out InsightTypeConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InsightTypeConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/config</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/config</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/config</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="insightTypeConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InsightTypeConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string insightTypeConfigName, out InsightTypeConfigName result) =>
            TryParse(insightTypeConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InsightTypeConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/config</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/config</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/config</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="insightTypeConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InsightTypeConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string insightTypeConfigName, bool allowUnparsed, out InsightTypeConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(insightTypeConfigName, nameof(insightTypeConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInsightType.TryParseName(insightTypeConfigName, out resourceName))
            {
                result = FromProjectLocationInsightType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationInsightType.TryParseName(insightTypeConfigName, out resourceName))
            {
                result = FromOrganizationLocationInsightType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_billingAccountLocationInsightType.TryParseName(insightTypeConfigName, out resourceName))
            {
                result = FromBillingAccountLocationInsightType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(insightTypeConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InsightTypeConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string insightTypeId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            InsightTypeId = insightTypeId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InsightTypeConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/config</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        public InsightTypeConfigName(string projectId, string locationId, string insightTypeId) : this(ResourceNameType.ProjectLocationInsightType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)))
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
        /// The <c>BillingAccount</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>InsightType</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string InsightTypeId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationInsightType: return s_projectLocationInsightType.Expand(ProjectId, LocationId, InsightTypeId);
                case ResourceNameType.OrganizationLocationInsightType: return s_organizationLocationInsightType.Expand(OrganizationId, LocationId, InsightTypeId);
                case ResourceNameType.BillingAccountLocationInsightType: return s_billingAccountLocationInsightType.Expand(BillingAccountId, LocationId, InsightTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InsightTypeConfigName);

        /// <inheritdoc/>
        public bool Equals(InsightTypeConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InsightTypeConfigName a, InsightTypeConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InsightTypeConfigName a, InsightTypeConfigName b) => !(a == b);
    }

    public partial class InsightTypeConfig
    {
        /// <summary>
        /// <see cref="gcrv::InsightTypeConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::InsightTypeConfigName InsightTypeConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::InsightTypeConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
