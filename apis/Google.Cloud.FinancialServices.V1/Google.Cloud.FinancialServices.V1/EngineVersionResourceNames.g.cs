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
using gcfv = Google.Cloud.FinancialServices.V1;
using sys = System;

namespace Google.Cloud.FinancialServices.V1
{
    /// <summary>Resource name for the <c>EngineVersion</c> resource.</summary>
    public sealed partial class EngineVersionName : gax::IResourceName, sys::IEquatable<EngineVersionName>
    {
        /// <summary>The possible contents of <see cref="EngineVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineVersions/{engine_version}</c>.
            /// </summary>
            ProjectNumLocationInstanceEngineVersion = 1,
        }

        private static gax::PathTemplate s_projectNumLocationInstanceEngineVersion = new gax::PathTemplate("projects/{project_num}/locations/{location}/instances/{instance}/engineVersions/{engine_version}");

        /// <summary>Creates a <see cref="EngineVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EngineVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EngineVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EngineVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EngineVersionName"/> with the pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineVersions/{engine_version}</c>.
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineVersionId">The <c>EngineVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EngineVersionName"/> constructed from the provided ids.</returns>
        public static EngineVersionName FromProjectNumLocationInstanceEngineVersion(string projectNumId, string locationId, string instanceId, string engineVersionId) =>
            new EngineVersionName(ResourceNameType.ProjectNumLocationInstanceEngineVersion, projectNumId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumId, nameof(projectNumId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), engineVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(engineVersionId, nameof(engineVersionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EngineVersionName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineVersions/{engine_version}</c>.
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineVersionId">The <c>EngineVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EngineVersionName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineVersions/{engine_version}</c>.
        /// </returns>
        public static string Format(string projectNumId, string locationId, string instanceId, string engineVersionId) =>
            FormatProjectNumLocationInstanceEngineVersion(projectNumId, locationId, instanceId, engineVersionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EngineVersionName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineVersions/{engine_version}</c>.
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineVersionId">The <c>EngineVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EngineVersionName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineVersions/{engine_version}</c>.
        /// </returns>
        public static string FormatProjectNumLocationInstanceEngineVersion(string projectNumId, string locationId, string instanceId, string engineVersionId) =>
            s_projectNumLocationInstanceEngineVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumId, nameof(projectNumId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(engineVersionId, nameof(engineVersionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EngineVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineVersions/{engine_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="engineVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EngineVersionName"/> if successful.</returns>
        public static EngineVersionName Parse(string engineVersionName) => Parse(engineVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EngineVersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineVersions/{engine_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="engineVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EngineVersionName"/> if successful.</returns>
        public static EngineVersionName Parse(string engineVersionName, bool allowUnparsed) =>
            TryParse(engineVersionName, allowUnparsed, out EngineVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EngineVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineVersions/{engine_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="engineVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EngineVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string engineVersionName, out EngineVersionName result) =>
            TryParse(engineVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EngineVersionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineVersions/{engine_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="engineVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EngineVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string engineVersionName, bool allowUnparsed, out EngineVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(engineVersionName, nameof(engineVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNumLocationInstanceEngineVersion.TryParseName(engineVersionName, out resourceName))
            {
                result = FromProjectNumLocationInstanceEngineVersion(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(engineVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EngineVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string engineVersionId = null, string instanceId = null, string locationId = null, string projectNumId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EngineVersionId = engineVersionId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectNumId = projectNumId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EngineVersionName"/> class from the component parts of pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineVersions/{engine_version}</c>
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineVersionId">The <c>EngineVersion</c> ID. Must not be <c>null</c> or empty.</param>
        public EngineVersionName(string projectNumId, string locationId, string instanceId, string engineVersionId) : this(ResourceNameType.ProjectNumLocationInstanceEngineVersion, projectNumId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumId, nameof(projectNumId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), engineVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(engineVersionId, nameof(engineVersionId)))
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
        /// The <c>EngineVersion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string EngineVersionId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>ProjectNum</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectNumId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNumLocationInstanceEngineVersion: return s_projectNumLocationInstanceEngineVersion.Expand(ProjectNumId, LocationId, InstanceId, EngineVersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EngineVersionName);

        /// <inheritdoc/>
        public bool Equals(EngineVersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EngineVersionName a, EngineVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EngineVersionName a, EngineVersionName b) => !(a == b);
    }

    public partial class EngineVersion
    {
        /// <summary>
        /// <see cref="gcfv::EngineVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::EngineVersionName EngineVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::EngineVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEngineVersionsRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEngineVersionRequest
    {
        /// <summary>
        /// <see cref="gcfv::EngineVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::EngineVersionName EngineVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::EngineVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
