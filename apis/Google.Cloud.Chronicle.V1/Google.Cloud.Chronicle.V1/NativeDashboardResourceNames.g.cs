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
using gax = Google.Api.Gax;
using gccv = Google.Cloud.Chronicle.V1;
using sys = System;

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Resource name for the <c>NativeDashboard</c> resource.</summary>
    public sealed partial class NativeDashboardName : gax::IResourceName, sys::IEquatable<NativeDashboardName>
    {
        /// <summary>The possible contents of <see cref="NativeDashboardName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}</c>.
            /// </summary>
            ProjectLocationInstanceDashboard = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceDashboard = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}");

        /// <summary>Creates a <see cref="NativeDashboardName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NativeDashboardName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NativeDashboardName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NativeDashboardName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NativeDashboardName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dashboardId">The <c>Dashboard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NativeDashboardName"/> constructed from the provided ids.</returns>
        public static NativeDashboardName FromProjectLocationInstanceDashboard(string projectId, string locationId, string instanceId, string dashboardId) =>
            new NativeDashboardName(ResourceNameType.ProjectLocationInstanceDashboard, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), dashboardId: gax::GaxPreconditions.CheckNotNullOrEmpty(dashboardId, nameof(dashboardId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NativeDashboardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dashboardId">The <c>Dashboard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NativeDashboardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string dashboardId) =>
            FormatProjectLocationInstanceDashboard(projectId, locationId, instanceId, dashboardId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NativeDashboardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dashboardId">The <c>Dashboard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NativeDashboardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceDashboard(string projectId, string locationId, string instanceId, string dashboardId) =>
            s_projectLocationInstanceDashboard.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dashboardId, nameof(dashboardId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NativeDashboardName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="nativeDashboardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NativeDashboardName"/> if successful.</returns>
        public static NativeDashboardName Parse(string nativeDashboardName) => Parse(nativeDashboardName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NativeDashboardName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nativeDashboardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NativeDashboardName"/> if successful.</returns>
        public static NativeDashboardName Parse(string nativeDashboardName, bool allowUnparsed) =>
            TryParse(nativeDashboardName, allowUnparsed, out NativeDashboardName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NativeDashboardName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="nativeDashboardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NativeDashboardName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nativeDashboardName, out NativeDashboardName result) =>
            TryParse(nativeDashboardName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NativeDashboardName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nativeDashboardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NativeDashboardName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nativeDashboardName, bool allowUnparsed, out NativeDashboardName result)
        {
            gax::GaxPreconditions.CheckNotNull(nativeDashboardName, nameof(nativeDashboardName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceDashboard.TryParseName(nativeDashboardName, out resourceName))
            {
                result = FromProjectLocationInstanceDashboard(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(nativeDashboardName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NativeDashboardName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dashboardId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DashboardId = dashboardId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NativeDashboardName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dashboardId">The <c>Dashboard</c> ID. Must not be <c>null</c> or empty.</param>
        public NativeDashboardName(string projectId, string locationId, string instanceId, string dashboardId) : this(ResourceNameType.ProjectLocationInstanceDashboard, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), dashboardId: gax::GaxPreconditions.CheckNotNullOrEmpty(dashboardId, nameof(dashboardId)))
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
        /// The <c>Dashboard</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DashboardId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstanceDashboard: return s_projectLocationInstanceDashboard.Expand(ProjectId, LocationId, InstanceId, DashboardId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NativeDashboardName);

        /// <inheritdoc/>
        public bool Equals(NativeDashboardName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NativeDashboardName a, NativeDashboardName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NativeDashboardName a, NativeDashboardName b) => !(a == b);
    }

    public partial class ExportNativeDashboardsRequest
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

    public partial class ImportNativeDashboardsRequest
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

    public partial class NativeDashboard
    {
        /// <summary>
        /// <see cref="gccv::NativeDashboardName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::NativeDashboardName NativeDashboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::NativeDashboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateNativeDashboardRequest
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

    public partial class GetNativeDashboardRequest
    {
        /// <summary>
        /// <see cref="gccv::NativeDashboardName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::NativeDashboardName NativeDashboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::NativeDashboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNativeDashboardsRequest
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

    public partial class DuplicateNativeDashboardRequest
    {
        /// <summary>
        /// <see cref="gccv::NativeDashboardName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::NativeDashboardName NativeDashboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::NativeDashboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteNativeDashboardRequest
    {
        /// <summary>
        /// <see cref="gccv::NativeDashboardName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::NativeDashboardName NativeDashboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::NativeDashboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AddChartRequest
    {
        /// <summary>
        /// <see cref="gccv::NativeDashboardName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::NativeDashboardName NativeDashboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::NativeDashboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EditChartRequest
    {
        /// <summary>
        /// <see cref="gccv::NativeDashboardName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::NativeDashboardName NativeDashboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::NativeDashboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RemoveChartRequest
    {
        /// <summary>
        /// <see cref="gccv::NativeDashboardName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::NativeDashboardName NativeDashboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::NativeDashboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DashboardChartName"/>-typed view over the <see cref="DashboardChart"/> resource name property.
        /// </summary>
        public DashboardChartName DashboardChartAsDashboardChartName
        {
            get => string.IsNullOrEmpty(DashboardChart) ? null : DashboardChartName.Parse(DashboardChart, allowUnparsed: true);
            set => DashboardChart = value?.ToString() ?? "";
        }
    }

    public partial class DuplicateChartRequest
    {
        /// <summary>
        /// <see cref="gccv::NativeDashboardName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::NativeDashboardName NativeDashboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::NativeDashboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DashboardChartName"/>-typed view over the <see cref="DashboardChart"/> resource name property.
        /// </summary>
        public DashboardChartName DashboardChartAsDashboardChartName
        {
            get => string.IsNullOrEmpty(DashboardChart) ? null : DashboardChartName.Parse(DashboardChart, allowUnparsed: true);
            set => DashboardChart = value?.ToString() ?? "";
        }
    }

    public partial class DashboardDefinition
    {
        public partial class Types
        {
            public partial class ChartConfig
            {
                /// <summary>
                /// <see cref="DashboardChartName"/>-typed view over the <see cref="DashboardChart"/> resource name
                /// property.
                /// </summary>
                public DashboardChartName DashboardChartAsDashboardChartName
                {
                    get => string.IsNullOrEmpty(DashboardChart) ? null : DashboardChartName.Parse(DashboardChart, allowUnparsed: true);
                    set => DashboardChart = value?.ToString() ?? "";
                }
            }
        }
    }
}
