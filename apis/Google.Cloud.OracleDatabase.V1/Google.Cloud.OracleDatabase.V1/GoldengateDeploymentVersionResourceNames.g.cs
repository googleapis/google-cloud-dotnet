// Copyright 2026 Google LLC
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
using gcov = Google.Cloud.OracleDatabase.V1;
using sys = System;

namespace Google.Cloud.OracleDatabase.V1
{
    /// <summary>Resource name for the <c>GoldengateDeploymentVersion</c> resource.</summary>
    public sealed partial class GoldengateDeploymentVersionName : gax::IResourceName, sys::IEquatable<GoldengateDeploymentVersionName>
    {
        /// <summary>The possible contents of <see cref="GoldengateDeploymentVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}</c>
            /// .
            /// </summary>
            ProjectLocationGoldengateDeploymentVersion = 1,
        }

        private static gax::PathTemplate s_projectLocationGoldengateDeploymentVersion = new gax::PathTemplate("projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}");

        /// <summary>
        /// Creates a <see cref="GoldengateDeploymentVersionName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GoldengateDeploymentVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GoldengateDeploymentVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GoldengateDeploymentVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GoldengateDeploymentVersionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goldengateDeploymentVersionId">
        /// The <c>GoldengateDeploymentVersion</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="GoldengateDeploymentVersionName"/> constructed from the provided ids.
        /// </returns>
        public static GoldengateDeploymentVersionName FromProjectLocationGoldengateDeploymentVersion(string projectId, string locationId, string goldengateDeploymentVersionId) =>
            new GoldengateDeploymentVersionName(ResourceNameType.ProjectLocationGoldengateDeploymentVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), goldengateDeploymentVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(goldengateDeploymentVersionId, nameof(goldengateDeploymentVersionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GoldengateDeploymentVersionName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goldengateDeploymentVersionId">
        /// The <c>GoldengateDeploymentVersion</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="GoldengateDeploymentVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string goldengateDeploymentVersionId) =>
            FormatProjectLocationGoldengateDeploymentVersion(projectId, locationId, goldengateDeploymentVersionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GoldengateDeploymentVersionName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goldengateDeploymentVersionId">
        /// The <c>GoldengateDeploymentVersion</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="GoldengateDeploymentVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}</c>.
        /// </returns>
        public static string FormatProjectLocationGoldengateDeploymentVersion(string projectId, string locationId, string goldengateDeploymentVersionId) =>
            s_projectLocationGoldengateDeploymentVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(goldengateDeploymentVersionId, nameof(goldengateDeploymentVersionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GoldengateDeploymentVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="goldengateDeploymentVersionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="GoldengateDeploymentVersionName"/> if successful.</returns>
        public static GoldengateDeploymentVersionName Parse(string goldengateDeploymentVersionName) =>
            Parse(goldengateDeploymentVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GoldengateDeploymentVersionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="goldengateDeploymentVersionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GoldengateDeploymentVersionName"/> if successful.</returns>
        public static GoldengateDeploymentVersionName Parse(string goldengateDeploymentVersionName, bool allowUnparsed) =>
            TryParse(goldengateDeploymentVersionName, allowUnparsed, out GoldengateDeploymentVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GoldengateDeploymentVersionName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="goldengateDeploymentVersionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GoldengateDeploymentVersionName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string goldengateDeploymentVersionName, out GoldengateDeploymentVersionName result) =>
            TryParse(goldengateDeploymentVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GoldengateDeploymentVersionName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="goldengateDeploymentVersionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GoldengateDeploymentVersionName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string goldengateDeploymentVersionName, bool allowUnparsed, out GoldengateDeploymentVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(goldengateDeploymentVersionName, nameof(goldengateDeploymentVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGoldengateDeploymentVersion.TryParseName(goldengateDeploymentVersionName, out resourceName))
            {
                result = FromProjectLocationGoldengateDeploymentVersion(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(goldengateDeploymentVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GoldengateDeploymentVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string goldengateDeploymentVersionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GoldengateDeploymentVersionId = goldengateDeploymentVersionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GoldengateDeploymentVersionName"/> class from the component parts
        /// of pattern
        /// <c>projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goldengateDeploymentVersionId">
        /// The <c>GoldengateDeploymentVersion</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public GoldengateDeploymentVersionName(string projectId, string locationId, string goldengateDeploymentVersionId) : this(ResourceNameType.ProjectLocationGoldengateDeploymentVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), goldengateDeploymentVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(goldengateDeploymentVersionId, nameof(goldengateDeploymentVersionId)))
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
        /// The <c>GoldengateDeploymentVersion</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string GoldengateDeploymentVersionId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
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
                case ResourceNameType.ProjectLocationGoldengateDeploymentVersion: return s_projectLocationGoldengateDeploymentVersion.Expand(ProjectId, LocationId, GoldengateDeploymentVersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GoldengateDeploymentVersionName);

        /// <inheritdoc/>
        public bool Equals(GoldengateDeploymentVersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GoldengateDeploymentVersionName a, GoldengateDeploymentVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GoldengateDeploymentVersionName a, GoldengateDeploymentVersionName b) => !(a == b);
    }

    public partial class GoldengateDeploymentVersion
    {
        /// <summary>
        /// <see cref="gcov::GoldengateDeploymentVersionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcov::GoldengateDeploymentVersionName GoldengateDeploymentVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::GoldengateDeploymentVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGoldengateDeploymentVersionsRequest
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
}
