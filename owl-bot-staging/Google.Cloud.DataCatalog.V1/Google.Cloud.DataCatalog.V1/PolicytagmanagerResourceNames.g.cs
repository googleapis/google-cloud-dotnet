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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcdv = Google.Cloud.DataCatalog.V1;
using sys = System;

namespace Google.Cloud.DataCatalog.V1
{
    /// <summary>Resource name for the <c>Taxonomy</c> resource.</summary>
    public sealed partial class TaxonomyName : gax::IResourceName, sys::IEquatable<TaxonomyName>
    {
        /// <summary>The possible contents of <see cref="TaxonomyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}</c>.
            /// </summary>
            ProjectLocationTaxonomy = 1,
        }

        private static gax::PathTemplate s_projectLocationTaxonomy = new gax::PathTemplate("projects/{project}/locations/{location}/taxonomies/{taxonomy}");

        /// <summary>Creates a <see cref="TaxonomyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TaxonomyName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static TaxonomyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TaxonomyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TaxonomyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxonomyId">The <c>Taxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TaxonomyName"/> constructed from the provided ids.</returns>
        public static TaxonomyName FromProjectLocationTaxonomy(string projectId, string locationId, string taxonomyId) =>
            new TaxonomyName(ResourceNameType.ProjectLocationTaxonomy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), taxonomyId: gax::GaxPreconditions.CheckNotNullOrEmpty(taxonomyId, nameof(taxonomyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TaxonomyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxonomyId">The <c>Taxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TaxonomyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string taxonomyId) =>
            FormatProjectLocationTaxonomy(projectId, locationId, taxonomyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TaxonomyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxonomyId">The <c>Taxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TaxonomyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}</c>.
        /// </returns>
        public static string FormatProjectLocationTaxonomy(string projectId, string locationId, string taxonomyId) =>
            s_projectLocationTaxonomy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(taxonomyId, nameof(taxonomyId)));

        /// <summary>Parses the given resource name string into a new <see cref="TaxonomyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/taxonomies/{taxonomy}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="taxonomyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TaxonomyName"/> if successful.</returns>
        public static TaxonomyName Parse(string taxonomyName) => Parse(taxonomyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TaxonomyName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/taxonomies/{taxonomy}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="taxonomyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TaxonomyName"/> if successful.</returns>
        public static TaxonomyName Parse(string taxonomyName, bool allowUnparsed) =>
            TryParse(taxonomyName, allowUnparsed, out TaxonomyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TaxonomyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/taxonomies/{taxonomy}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="taxonomyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TaxonomyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string taxonomyName, out TaxonomyName result) => TryParse(taxonomyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TaxonomyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/taxonomies/{taxonomy}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="taxonomyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TaxonomyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string taxonomyName, bool allowUnparsed, out TaxonomyName result)
        {
            gax::GaxPreconditions.CheckNotNull(taxonomyName, nameof(taxonomyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTaxonomy.TryParseName(taxonomyName, out resourceName))
            {
                result = FromProjectLocationTaxonomy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(taxonomyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TaxonomyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string taxonomyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TaxonomyId = taxonomyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TaxonomyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxonomyId">The <c>Taxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        public TaxonomyName(string projectId, string locationId, string taxonomyId) : this(ResourceNameType.ProjectLocationTaxonomy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), taxonomyId: gax::GaxPreconditions.CheckNotNullOrEmpty(taxonomyId, nameof(taxonomyId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Taxonomy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TaxonomyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTaxonomy: return s_projectLocationTaxonomy.Expand(ProjectId, LocationId, TaxonomyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TaxonomyName);

        /// <inheritdoc/>
        public bool Equals(TaxonomyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TaxonomyName a, TaxonomyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TaxonomyName a, TaxonomyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PolicyTag</c> resource.</summary>
    public sealed partial class PolicyTagName : gax::IResourceName, sys::IEquatable<PolicyTagName>
    {
        /// <summary>The possible contents of <see cref="PolicyTagName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}</c>.
            /// </summary>
            ProjectLocationTaxonomyPolicyTag = 1,
        }

        private static gax::PathTemplate s_projectLocationTaxonomyPolicyTag = new gax::PathTemplate("projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}");

        /// <summary>Creates a <see cref="PolicyTagName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PolicyTagName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PolicyTagName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PolicyTagName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PolicyTagName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxonomyId">The <c>Taxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyTagId">The <c>PolicyTag</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PolicyTagName"/> constructed from the provided ids.</returns>
        public static PolicyTagName FromProjectLocationTaxonomyPolicyTag(string projectId, string locationId, string taxonomyId, string policyTagId) =>
            new PolicyTagName(ResourceNameType.ProjectLocationTaxonomyPolicyTag, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), taxonomyId: gax::GaxPreconditions.CheckNotNullOrEmpty(taxonomyId, nameof(taxonomyId)), policyTagId: gax::GaxPreconditions.CheckNotNullOrEmpty(policyTagId, nameof(policyTagId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyTagName"/> with pattern
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxonomyId">The <c>Taxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyTagId">The <c>PolicyTag</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyTagName"/> with pattern
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string taxonomyId, string policyTagId) =>
            FormatProjectLocationTaxonomyPolicyTag(projectId, locationId, taxonomyId, policyTagId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyTagName"/> with pattern
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxonomyId">The <c>Taxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyTagId">The <c>PolicyTag</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyTagName"/> with pattern
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}</c>.
        /// </returns>
        public static string FormatProjectLocationTaxonomyPolicyTag(string projectId, string locationId, string taxonomyId, string policyTagId) =>
            s_projectLocationTaxonomyPolicyTag.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(taxonomyId, nameof(taxonomyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(policyTagId, nameof(policyTagId)));

        /// <summary>Parses the given resource name string into a new <see cref="PolicyTagName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="policyTagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PolicyTagName"/> if successful.</returns>
        public static PolicyTagName Parse(string policyTagName) => Parse(policyTagName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PolicyTagName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="policyTagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PolicyTagName"/> if successful.</returns>
        public static PolicyTagName Parse(string policyTagName, bool allowUnparsed) =>
            TryParse(policyTagName, allowUnparsed, out PolicyTagName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PolicyTagName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="policyTagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PolicyTagName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string policyTagName, out PolicyTagName result) => TryParse(policyTagName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PolicyTagName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="policyTagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PolicyTagName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string policyTagName, bool allowUnparsed, out PolicyTagName result)
        {
            gax::GaxPreconditions.CheckNotNull(policyTagName, nameof(policyTagName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTaxonomyPolicyTag.TryParseName(policyTagName, out resourceName))
            {
                result = FromProjectLocationTaxonomyPolicyTag(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(policyTagName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PolicyTagName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string policyTagId = null, string projectId = null, string taxonomyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PolicyTagId = policyTagId;
            ProjectId = projectId;
            TaxonomyId = taxonomyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PolicyTagName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taxonomyId">The <c>Taxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyTagId">The <c>PolicyTag</c> ID. Must not be <c>null</c> or empty.</param>
        public PolicyTagName(string projectId, string locationId, string taxonomyId, string policyTagId) : this(ResourceNameType.ProjectLocationTaxonomyPolicyTag, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), taxonomyId: gax::GaxPreconditions.CheckNotNullOrEmpty(taxonomyId, nameof(taxonomyId)), policyTagId: gax::GaxPreconditions.CheckNotNullOrEmpty(policyTagId, nameof(policyTagId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>PolicyTag</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PolicyTagId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Taxonomy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TaxonomyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTaxonomyPolicyTag: return s_projectLocationTaxonomyPolicyTag.Expand(ProjectId, LocationId, TaxonomyId, PolicyTagId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PolicyTagName);

        /// <inheritdoc/>
        public bool Equals(PolicyTagName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PolicyTagName a, PolicyTagName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PolicyTagName a, PolicyTagName b) => !(a == b);
    }

    public partial class Taxonomy
    {
        /// <summary>
        /// <see cref="gcdv::TaxonomyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TaxonomyName TaxonomyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TaxonomyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PolicyTag
    {
        /// <summary>
        /// <see cref="gcdv::PolicyTagName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PolicyTagName PolicyTagName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PolicyTagName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateTaxonomyRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTaxonomyRequest
    {
        /// <summary>
        /// <see cref="gcdv::TaxonomyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TaxonomyName TaxonomyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TaxonomyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTaxonomiesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTaxonomyRequest
    {
        /// <summary>
        /// <see cref="gcdv::TaxonomyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TaxonomyName TaxonomyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TaxonomyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePolicyTagRequest
    {
        /// <summary>
        /// <see cref="TaxonomyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TaxonomyName ParentAsTaxonomyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TaxonomyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePolicyTagRequest
    {
        /// <summary>
        /// <see cref="gcdv::PolicyTagName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PolicyTagName PolicyTagName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PolicyTagName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPolicyTagsRequest
    {
        /// <summary>
        /// <see cref="TaxonomyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TaxonomyName ParentAsTaxonomyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TaxonomyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPolicyTagRequest
    {
        /// <summary>
        /// <see cref="gcdv::PolicyTagName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PolicyTagName PolicyTagName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PolicyTagName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
