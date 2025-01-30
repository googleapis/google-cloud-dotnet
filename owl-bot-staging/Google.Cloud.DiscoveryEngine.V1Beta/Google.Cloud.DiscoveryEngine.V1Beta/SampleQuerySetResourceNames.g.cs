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
using gcdv = Google.Cloud.DiscoveryEngine.V1Beta;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Resource name for the <c>SampleQuerySet</c> resource.</summary>
    public sealed partial class SampleQuerySetName : gax::IResourceName, sys::IEquatable<SampleQuerySetName>
    {
        /// <summary>The possible contents of <see cref="SampleQuerySetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}</c>.
            /// </summary>
            ProjectLocationSampleQuerySet = 1,
        }

        private static gax::PathTemplate s_projectLocationSampleQuerySet = new gax::PathTemplate("projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}");

        /// <summary>Creates a <see cref="SampleQuerySetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SampleQuerySetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SampleQuerySetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SampleQuerySetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SampleQuerySetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sampleQuerySetId">The <c>SampleQuerySet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SampleQuerySetName"/> constructed from the provided ids.</returns>
        public static SampleQuerySetName FromProjectLocationSampleQuerySet(string projectId, string locationId, string sampleQuerySetId) =>
            new SampleQuerySetName(ResourceNameType.ProjectLocationSampleQuerySet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sampleQuerySetId: gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQuerySetId, nameof(sampleQuerySetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SampleQuerySetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sampleQuerySetId">The <c>SampleQuerySet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SampleQuerySetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sampleQuerySetId) =>
            FormatProjectLocationSampleQuerySet(projectId, locationId, sampleQuerySetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SampleQuerySetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sampleQuerySetId">The <c>SampleQuerySet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SampleQuerySetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}</c>.
        /// </returns>
        public static string FormatProjectLocationSampleQuerySet(string projectId, string locationId, string sampleQuerySetId) =>
            s_projectLocationSampleQuerySet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQuerySetId, nameof(sampleQuerySetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SampleQuerySetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sampleQuerySetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SampleQuerySetName"/> if successful.</returns>
        public static SampleQuerySetName Parse(string sampleQuerySetName) => Parse(sampleQuerySetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SampleQuerySetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sampleQuerySetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SampleQuerySetName"/> if successful.</returns>
        public static SampleQuerySetName Parse(string sampleQuerySetName, bool allowUnparsed) =>
            TryParse(sampleQuerySetName, allowUnparsed, out SampleQuerySetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SampleQuerySetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sampleQuerySetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SampleQuerySetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sampleQuerySetName, out SampleQuerySetName result) =>
            TryParse(sampleQuerySetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SampleQuerySetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sampleQuerySetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SampleQuerySetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sampleQuerySetName, bool allowUnparsed, out SampleQuerySetName result)
        {
            gax::GaxPreconditions.CheckNotNull(sampleQuerySetName, nameof(sampleQuerySetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSampleQuerySet.TryParseName(sampleQuerySetName, out resourceName))
            {
                result = FromProjectLocationSampleQuerySet(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sampleQuerySetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SampleQuerySetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string sampleQuerySetId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SampleQuerySetId = sampleQuerySetId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SampleQuerySetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sampleQuerySetId">The <c>SampleQuerySet</c> ID. Must not be <c>null</c> or empty.</param>
        public SampleQuerySetName(string projectId, string locationId, string sampleQuerySetId) : this(ResourceNameType.ProjectLocationSampleQuerySet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sampleQuerySetId: gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQuerySetId, nameof(sampleQuerySetId)))
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
        /// The <c>SampleQuerySet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SampleQuerySetId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSampleQuerySet: return s_projectLocationSampleQuerySet.Expand(ProjectId, LocationId, SampleQuerySetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SampleQuerySetName);

        /// <inheritdoc/>
        public bool Equals(SampleQuerySetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SampleQuerySetName a, SampleQuerySetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SampleQuerySetName a, SampleQuerySetName b) => !(a == b);
    }

    public partial class SampleQuerySet
    {
        /// <summary>
        /// <see cref="gcdv::SampleQuerySetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SampleQuerySetName SampleQuerySetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SampleQuerySetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
