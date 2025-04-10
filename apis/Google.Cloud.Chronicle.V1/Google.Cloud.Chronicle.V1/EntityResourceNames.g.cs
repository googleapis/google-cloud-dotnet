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
using gccv = Google.Cloud.Chronicle.V1;
using sys = System;

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Resource name for the <c>Watchlist</c> resource.</summary>
    public sealed partial class WatchlistName : gax::IResourceName, sys::IEquatable<WatchlistName>
    {
        /// <summary>The possible contents of <see cref="WatchlistName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}</c>.
            /// </summary>
            ProjectLocationInstanceWatchlist = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceWatchlist = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}");

        /// <summary>Creates a <see cref="WatchlistName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WatchlistName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WatchlistName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WatchlistName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WatchlistName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="watchlistId">The <c>Watchlist</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WatchlistName"/> constructed from the provided ids.</returns>
        public static WatchlistName FromProjectLocationInstanceWatchlist(string projectId, string locationId, string instanceId, string watchlistId) =>
            new WatchlistName(ResourceNameType.ProjectLocationInstanceWatchlist, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), watchlistId: gax::GaxPreconditions.CheckNotNullOrEmpty(watchlistId, nameof(watchlistId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WatchlistName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="watchlistId">The <c>Watchlist</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WatchlistName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string watchlistId) =>
            FormatProjectLocationInstanceWatchlist(projectId, locationId, instanceId, watchlistId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WatchlistName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="watchlistId">The <c>Watchlist</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WatchlistName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceWatchlist(string projectId, string locationId, string instanceId, string watchlistId) =>
            s_projectLocationInstanceWatchlist.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(watchlistId, nameof(watchlistId)));

        /// <summary>Parses the given resource name string into a new <see cref="WatchlistName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="watchlistName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WatchlistName"/> if successful.</returns>
        public static WatchlistName Parse(string watchlistName) => Parse(watchlistName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WatchlistName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="watchlistName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WatchlistName"/> if successful.</returns>
        public static WatchlistName Parse(string watchlistName, bool allowUnparsed) =>
            TryParse(watchlistName, allowUnparsed, out WatchlistName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WatchlistName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="watchlistName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WatchlistName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string watchlistName, out WatchlistName result) => TryParse(watchlistName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WatchlistName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="watchlistName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WatchlistName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string watchlistName, bool allowUnparsed, out WatchlistName result)
        {
            gax::GaxPreconditions.CheckNotNull(watchlistName, nameof(watchlistName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceWatchlist.TryParseName(watchlistName, out resourceName))
            {
                result = FromProjectLocationInstanceWatchlist(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(watchlistName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WatchlistName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string projectId = null, string watchlistId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
            WatchlistId = watchlistId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WatchlistName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="watchlistId">The <c>Watchlist</c> ID. Must not be <c>null</c> or empty.</param>
        public WatchlistName(string projectId, string locationId, string instanceId, string watchlistId) : this(ResourceNameType.ProjectLocationInstanceWatchlist, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), watchlistId: gax::GaxPreconditions.CheckNotNullOrEmpty(watchlistId, nameof(watchlistId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Watchlist</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WatchlistId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationInstanceWatchlist: return s_projectLocationInstanceWatchlist.Expand(ProjectId, LocationId, InstanceId, WatchlistId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WatchlistName);

        /// <inheritdoc/>
        public bool Equals(WatchlistName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WatchlistName a, WatchlistName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WatchlistName a, WatchlistName b) => !(a == b);
    }

    public partial class Watchlist
    {
        /// <summary>
        /// <see cref="gccv::WatchlistName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::WatchlistName WatchlistName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::WatchlistName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetWatchlistRequest
    {
        /// <summary>
        /// <see cref="gccv::WatchlistName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::WatchlistName WatchlistName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::WatchlistName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWatchlistsRequest
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

    public partial class CreateWatchlistRequest
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

    public partial class DeleteWatchlistRequest
    {
        /// <summary>
        /// <see cref="gccv::WatchlistName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::WatchlistName WatchlistName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::WatchlistName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
