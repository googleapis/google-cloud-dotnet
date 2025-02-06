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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcbdv = Google.Cloud.BigQuery.DataPolicies.V1;
using sys = System;

namespace Google.Cloud.BigQuery.DataPolicies.V1
{
    /// <summary>Resource name for the <c>DataPolicy</c> resource.</summary>
    public sealed partial class DataPolicyName : gax::IResourceName, sys::IEquatable<DataPolicyName>
    {
        /// <summary>The possible contents of <see cref="DataPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/dataPolicies/{data_policy}</c>.
            /// </summary>
            ProjectLocationDataPolicy = 1,
        }

        private static gax::PathTemplate s_projectLocationDataPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/dataPolicies/{data_policy}");

        /// <summary>Creates a <see cref="DataPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataPolicies/{data_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataPolicyId">The <c>DataPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataPolicyName"/> constructed from the provided ids.</returns>
        public static DataPolicyName FromProjectLocationDataPolicy(string projectId, string locationId, string dataPolicyId) =>
            new DataPolicyName(ResourceNameType.ProjectLocationDataPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataPolicyId, nameof(dataPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataPolicies/{data_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataPolicyId">The <c>DataPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataPolicies/{data_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataPolicyId) =>
            FormatProjectLocationDataPolicy(projectId, locationId, dataPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataPolicies/{data_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataPolicyId">The <c>DataPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataPolicies/{data_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationDataPolicy(string projectId, string locationId, string dataPolicyId) =>
            s_projectLocationDataPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataPolicyId, nameof(dataPolicyId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataPolicyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataPolicies/{data_policy}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataPolicyName"/> if successful.</returns>
        public static DataPolicyName Parse(string dataPolicyName) => Parse(dataPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataPolicyName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataPolicies/{data_policy}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataPolicyName"/> if successful.</returns>
        public static DataPolicyName Parse(string dataPolicyName, bool allowUnparsed) =>
            TryParse(dataPolicyName, allowUnparsed, out DataPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataPolicies/{data_policy}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataPolicyName, out DataPolicyName result) =>
            TryParse(dataPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataPolicies/{data_policy}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataPolicyName, bool allowUnparsed, out DataPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataPolicyName, nameof(dataPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataPolicy.TryParseName(dataPolicyName, out resourceName))
            {
                result = FromProjectLocationDataPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataPolicyId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataPolicyId = dataPolicyId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataPolicyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataPolicies/{data_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataPolicyId">The <c>DataPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public DataPolicyName(string projectId, string locationId, string dataPolicyId) : this(ResourceNameType.ProjectLocationDataPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataPolicyId, nameof(dataPolicyId)))
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
        /// The <c>DataPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataPolicyId { get; }

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
                case ResourceNameType.ProjectLocationDataPolicy: return s_projectLocationDataPolicy.Expand(ProjectId, LocationId, DataPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataPolicyName);

        /// <inheritdoc/>
        public bool Equals(DataPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataPolicyName a, DataPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataPolicyName a, DataPolicyName b) => !(a == b);
    }

    public partial class CreateDataPolicyRequest
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

    public partial class DeleteDataPolicyRequest
    {
        /// <summary>
        /// <see cref="gcbdv::DataPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbdv::DataPolicyName DataPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbdv::DataPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDataPolicyRequest
    {
        /// <summary>
        /// <see cref="gcbdv::DataPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbdv::DataPolicyName DataPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbdv::DataPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataPoliciesRequest
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

    public partial class DataPolicy
    {
        /// <summary>
        /// <see cref="gcbdv::DataPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbdv::DataPolicyName DataPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbdv::DataPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
