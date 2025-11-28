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
using gcav = Google.Cloud.ApiHub.V1;
using sys = System;

namespace Google.Cloud.ApiHub.V1
{
    /// <summary>Resource name for the <c>Plugin</c> resource.</summary>
    public sealed partial class PluginName : gax::IResourceName, sys::IEquatable<PluginName>
    {
        /// <summary>The possible contents of <see cref="PluginName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/plugins/{plugin}</c>.
            /// </summary>
            ProjectLocationPlugin = 1,
        }

        private static gax::PathTemplate s_projectLocationPlugin = new gax::PathTemplate("projects/{project}/locations/{location}/plugins/{plugin}");

        /// <summary>Creates a <see cref="PluginName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PluginName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PluginName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PluginName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PluginName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pluginId">The <c>Plugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PluginName"/> constructed from the provided ids.</returns>
        public static PluginName FromProjectLocationPlugin(string projectId, string locationId, string pluginId) =>
            new PluginName(ResourceNameType.ProjectLocationPlugin, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), pluginId: gax::GaxPreconditions.CheckNotNullOrEmpty(pluginId, nameof(pluginId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PluginName"/> with pattern
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pluginId">The <c>Plugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PluginName"/> with pattern
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string pluginId) =>
            FormatProjectLocationPlugin(projectId, locationId, pluginId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PluginName"/> with pattern
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pluginId">The <c>Plugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PluginName"/> with pattern
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}</c>.
        /// </returns>
        public static string FormatProjectLocationPlugin(string projectId, string locationId, string pluginId) =>
            s_projectLocationPlugin.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(pluginId, nameof(pluginId)));

        /// <summary>Parses the given resource name string into a new <see cref="PluginName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/plugins/{plugin}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="pluginName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PluginName"/> if successful.</returns>
        public static PluginName Parse(string pluginName) => Parse(pluginName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PluginName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/plugins/{plugin}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pluginName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PluginName"/> if successful.</returns>
        public static PluginName Parse(string pluginName, bool allowUnparsed) =>
            TryParse(pluginName, allowUnparsed, out PluginName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PluginName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/plugins/{plugin}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="pluginName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PluginName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pluginName, out PluginName result) => TryParse(pluginName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PluginName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/plugins/{plugin}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pluginName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PluginName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pluginName, bool allowUnparsed, out PluginName result)
        {
            gax::GaxPreconditions.CheckNotNull(pluginName, nameof(pluginName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPlugin.TryParseName(pluginName, out resourceName))
            {
                result = FromProjectLocationPlugin(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(pluginName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PluginName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string pluginId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PluginId = pluginId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PluginName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pluginId">The <c>Plugin</c> ID. Must not be <c>null</c> or empty.</param>
        public PluginName(string projectId, string locationId, string pluginId) : this(ResourceNameType.ProjectLocationPlugin, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), pluginId: gax::GaxPreconditions.CheckNotNullOrEmpty(pluginId, nameof(pluginId)))
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
        /// The <c>Plugin</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PluginId { get; }

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
                case ResourceNameType.ProjectLocationPlugin: return s_projectLocationPlugin.Expand(ProjectId, LocationId, PluginId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PluginName);

        /// <inheritdoc/>
        public bool Equals(PluginName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PluginName a, PluginName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PluginName a, PluginName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PluginInstance</c> resource.</summary>
    public sealed partial class PluginInstanceName : gax::IResourceName, sys::IEquatable<PluginInstanceName>
    {
        /// <summary>The possible contents of <see cref="PluginInstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}</c>.
            /// </summary>
            ProjectLocationPluginInstance = 1,
        }

        private static gax::PathTemplate s_projectLocationPluginInstance = new gax::PathTemplate("projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}");

        /// <summary>Creates a <see cref="PluginInstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PluginInstanceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PluginInstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PluginInstanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PluginInstanceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pluginId">The <c>Plugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PluginInstanceName"/> constructed from the provided ids.</returns>
        public static PluginInstanceName FromProjectLocationPluginInstance(string projectId, string locationId, string pluginId, string instanceId) =>
            new PluginInstanceName(ResourceNameType.ProjectLocationPluginInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), pluginId: gax::GaxPreconditions.CheckNotNullOrEmpty(pluginId, nameof(pluginId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PluginInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pluginId">The <c>Plugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PluginInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string pluginId, string instanceId) =>
            FormatProjectLocationPluginInstance(projectId, locationId, pluginId, instanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PluginInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pluginId">The <c>Plugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PluginInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}</c>.
        /// </returns>
        public static string FormatProjectLocationPluginInstance(string projectId, string locationId, string pluginId, string instanceId) =>
            s_projectLocationPluginInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(pluginId, nameof(pluginId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PluginInstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="pluginInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PluginInstanceName"/> if successful.</returns>
        public static PluginInstanceName Parse(string pluginInstanceName) => Parse(pluginInstanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PluginInstanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pluginInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PluginInstanceName"/> if successful.</returns>
        public static PluginInstanceName Parse(string pluginInstanceName, bool allowUnparsed) =>
            TryParse(pluginInstanceName, allowUnparsed, out PluginInstanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PluginInstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="pluginInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PluginInstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pluginInstanceName, out PluginInstanceName result) =>
            TryParse(pluginInstanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PluginInstanceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pluginInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PluginInstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pluginInstanceName, bool allowUnparsed, out PluginInstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(pluginInstanceName, nameof(pluginInstanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPluginInstance.TryParseName(pluginInstanceName, out resourceName))
            {
                result = FromProjectLocationPluginInstance(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(pluginInstanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PluginInstanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string pluginId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            PluginId = pluginId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PluginInstanceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pluginId">The <c>Plugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        public PluginInstanceName(string projectId, string locationId, string pluginId, string instanceId) : this(ResourceNameType.ProjectLocationPluginInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), pluginId: gax::GaxPreconditions.CheckNotNullOrEmpty(pluginId, nameof(pluginId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Plugin</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PluginId { get; }

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
                case ResourceNameType.ProjectLocationPluginInstance: return s_projectLocationPluginInstance.Expand(ProjectId, LocationId, PluginId, InstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PluginInstanceName);

        /// <inheritdoc/>
        public bool Equals(PluginInstanceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PluginInstanceName a, PluginInstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PluginInstanceName a, PluginInstanceName b) => !(a == b);
    }

    public partial class Plugin
    {
        /// <summary>
        /// <see cref="gcav::PluginName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PluginName PluginName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PluginName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetPluginRequest
    {
        /// <summary>
        /// <see cref="gcav::PluginName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PluginName PluginName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PluginName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EnablePluginRequest
    {
        /// <summary>
        /// <see cref="gcav::PluginName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PluginName PluginName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PluginName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DisablePluginRequest
    {
        /// <summary>
        /// <see cref="gcav::PluginName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PluginName PluginName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PluginName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PluginInstance
    {
        /// <summary>
        /// <see cref="gcav::PluginInstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PluginInstanceName PluginInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PluginInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePluginRequest
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

    public partial class DeletePluginRequest
    {
        /// <summary>
        /// <see cref="gcav::PluginName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PluginName PluginName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PluginName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPluginsRequest
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

    public partial class CreatePluginInstanceRequest
    {
        /// <summary><see cref="PluginName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public PluginName ParentAsPluginName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PluginName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ExecutePluginInstanceActionRequest
    {
        /// <summary>
        /// <see cref="gcav::PluginInstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PluginInstanceName PluginInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PluginInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetPluginInstanceRequest
    {
        /// <summary>
        /// <see cref="gcav::PluginInstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PluginInstanceName PluginInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PluginInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPluginInstancesRequest
    {
        /// <summary><see cref="PluginName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public PluginName ParentAsPluginName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PluginName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class EnablePluginInstanceActionRequest
    {
        /// <summary>
        /// <see cref="gcav::PluginInstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PluginInstanceName PluginInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PluginInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DisablePluginInstanceActionRequest
    {
        /// <summary>
        /// <see cref="gcav::PluginInstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PluginInstanceName PluginInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PluginInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeletePluginInstanceRequest
    {
        /// <summary>
        /// <see cref="gcav::PluginInstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PluginInstanceName PluginInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PluginInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
