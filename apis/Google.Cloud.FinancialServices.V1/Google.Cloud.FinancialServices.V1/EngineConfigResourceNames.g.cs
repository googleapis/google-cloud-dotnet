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
    /// <summary>Resource name for the <c>EngineConfig</c> resource.</summary>
    public sealed partial class EngineConfigName : gax::IResourceName, sys::IEquatable<EngineConfigName>
    {
        /// <summary>The possible contents of <see cref="EngineConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineConfigs/{engine_config}</c>.
            /// </summary>
            ProjectNumLocationInstanceEngineConfig = 1,
        }

        private static gax::PathTemplate s_projectNumLocationInstanceEngineConfig = new gax::PathTemplate("projects/{project_num}/locations/{location}/instances/{instance}/engineConfigs/{engine_config}");

        /// <summary>Creates a <see cref="EngineConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EngineConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EngineConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EngineConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EngineConfigName"/> with the pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineConfigs/{engine_config}</c>.
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineConfigId">The <c>EngineConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EngineConfigName"/> constructed from the provided ids.</returns>
        public static EngineConfigName FromProjectNumLocationInstanceEngineConfig(string projectNumId, string locationId, string instanceId, string engineConfigId) =>
            new EngineConfigName(ResourceNameType.ProjectNumLocationInstanceEngineConfig, projectNumId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumId, nameof(projectNumId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), engineConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(engineConfigId, nameof(engineConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EngineConfigName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineConfigs/{engine_config}</c>.
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineConfigId">The <c>EngineConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EngineConfigName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineConfigs/{engine_config}</c>.
        /// </returns>
        public static string Format(string projectNumId, string locationId, string instanceId, string engineConfigId) =>
            FormatProjectNumLocationInstanceEngineConfig(projectNumId, locationId, instanceId, engineConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EngineConfigName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineConfigs/{engine_config}</c>.
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineConfigId">The <c>EngineConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EngineConfigName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineConfigs/{engine_config}</c>.
        /// </returns>
        public static string FormatProjectNumLocationInstanceEngineConfig(string projectNumId, string locationId, string instanceId, string engineConfigId) =>
            s_projectNumLocationInstanceEngineConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumId, nameof(projectNumId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(engineConfigId, nameof(engineConfigId)));

        /// <summary>Parses the given resource name string into a new <see cref="EngineConfigName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineConfigs/{engine_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="engineConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EngineConfigName"/> if successful.</returns>
        public static EngineConfigName Parse(string engineConfigName) => Parse(engineConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EngineConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineConfigs/{engine_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="engineConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EngineConfigName"/> if successful.</returns>
        public static EngineConfigName Parse(string engineConfigName, bool allowUnparsed) =>
            TryParse(engineConfigName, allowUnparsed, out EngineConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EngineConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineConfigs/{engine_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="engineConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EngineConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string engineConfigName, out EngineConfigName result) =>
            TryParse(engineConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EngineConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineConfigs/{engine_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="engineConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EngineConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string engineConfigName, bool allowUnparsed, out EngineConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(engineConfigName, nameof(engineConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNumLocationInstanceEngineConfig.TryParseName(engineConfigName, out resourceName))
            {
                result = FromProjectNumLocationInstanceEngineConfig(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(engineConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EngineConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string engineConfigId = null, string instanceId = null, string locationId = null, string projectNumId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EngineConfigId = engineConfigId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectNumId = projectNumId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EngineConfigName"/> class from the component parts of pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/engineConfigs/{engine_config}</c>
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineConfigId">The <c>EngineConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public EngineConfigName(string projectNumId, string locationId, string instanceId, string engineConfigId) : this(ResourceNameType.ProjectNumLocationInstanceEngineConfig, projectNumId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumId, nameof(projectNumId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), engineConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(engineConfigId, nameof(engineConfigId)))
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
        /// The <c>EngineConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string EngineConfigId { get; }

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
                case ResourceNameType.ProjectNumLocationInstanceEngineConfig: return s_projectNumLocationInstanceEngineConfig.Expand(ProjectNumId, LocationId, InstanceId, EngineConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EngineConfigName);

        /// <inheritdoc/>
        public bool Equals(EngineConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EngineConfigName a, EngineConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EngineConfigName a, EngineConfigName b) => !(a == b);
    }

    public partial class EngineConfig
    {
        /// <summary>
        /// <see cref="gcfv::EngineConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::EngineConfigName EngineConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::EngineConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EngineVersionName"/>-typed view over the <see cref="EngineVersion"/> resource name property.
        /// </summary>
        public EngineVersionName EngineVersionAsEngineVersionName
        {
            get => string.IsNullOrEmpty(EngineVersion) ? null : EngineVersionName.Parse(EngineVersion, allowUnparsed: true);
            set => EngineVersion = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class Tuning
            {
                /// <summary>
                /// <see cref="DatasetName"/>-typed view over the <see cref="PrimaryDataset"/> resource name property.
                /// </summary>
                public DatasetName PrimaryDatasetAsDatasetName
                {
                    get => string.IsNullOrEmpty(PrimaryDataset) ? null : DatasetName.Parse(PrimaryDataset, allowUnparsed: true);
                    set => PrimaryDataset = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListEngineConfigsRequest
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

    public partial class GetEngineConfigRequest
    {
        /// <summary>
        /// <see cref="gcfv::EngineConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::EngineConfigName EngineConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::EngineConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEngineConfigRequest
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

    public partial class DeleteEngineConfigRequest
    {
        /// <summary>
        /// <see cref="gcfv::EngineConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::EngineConfigName EngineConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::EngineConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportEngineConfigMetadataRequest
    {
        /// <summary>
        /// <see cref="EngineConfigName"/>-typed view over the <see cref="EngineConfig"/> resource name property.
        /// </summary>
        public EngineConfigName EngineConfigAsEngineConfigName
        {
            get => string.IsNullOrEmpty(EngineConfig) ? null : EngineConfigName.Parse(EngineConfig, allowUnparsed: true);
            set => EngineConfig = value?.ToString() ?? "";
        }
    }
}
