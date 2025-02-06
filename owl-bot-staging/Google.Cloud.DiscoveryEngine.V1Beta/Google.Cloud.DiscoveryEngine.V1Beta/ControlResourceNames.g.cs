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
    /// <summary>Resource name for the <c>Control</c> resource.</summary>
    public sealed partial class ControlName : gax::IResourceName, sys::IEquatable<ControlName>
    {
        /// <summary>The possible contents of <see cref="ControlName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/controls/{control}</c>.
            /// </summary>
            ProjectLocationDataStoreControl = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/controls/{control}</c>
            /// .
            /// </summary>
            ProjectLocationCollectionDataStoreControl = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/controls/{control}</c>
            /// .
            /// </summary>
            ProjectLocationCollectionEngineControl = 3,
        }

        private static gax::PathTemplate s_projectLocationDataStoreControl = new gax::PathTemplate("projects/{project}/locations/{location}/dataStores/{data_store}/controls/{control}");

        private static gax::PathTemplate s_projectLocationCollectionDataStoreControl = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/controls/{control}");

        private static gax::PathTemplate s_projectLocationCollectionEngineControl = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/controls/{control}");

        /// <summary>Creates a <see cref="ControlName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ControlName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ControlName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ControlName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ControlName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/controls/{control}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="controlId">The <c>Control</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ControlName"/> constructed from the provided ids.</returns>
        public static ControlName FromProjectLocationDataStoreControl(string projectId, string locationId, string dataStoreId, string controlId) =>
            new ControlName(ResourceNameType.ProjectLocationDataStoreControl, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), controlId: gax::GaxPreconditions.CheckNotNullOrEmpty(controlId, nameof(controlId)));

        /// <summary>
        /// Creates a <see cref="ControlName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/controls/{control}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="controlId">The <c>Control</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ControlName"/> constructed from the provided ids.</returns>
        public static ControlName FromProjectLocationCollectionDataStoreControl(string projectId, string locationId, string collectionId, string dataStoreId, string controlId) =>
            new ControlName(ResourceNameType.ProjectLocationCollectionDataStoreControl, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), controlId: gax::GaxPreconditions.CheckNotNullOrEmpty(controlId, nameof(controlId)));

        /// <summary>
        /// Creates a <see cref="ControlName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/controls/{control}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="controlId">The <c>Control</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ControlName"/> constructed from the provided ids.</returns>
        public static ControlName FromProjectLocationCollectionEngineControl(string projectId, string locationId, string collectionId, string engineId, string controlId) =>
            new ControlName(ResourceNameType.ProjectLocationCollectionEngineControl, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), engineId: gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)), controlId: gax::GaxPreconditions.CheckNotNullOrEmpty(controlId, nameof(controlId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ControlName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/controls/{control}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="controlId">The <c>Control</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ControlName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/controls/{control}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataStoreId, string controlId) =>
            FormatProjectLocationDataStoreControl(projectId, locationId, dataStoreId, controlId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ControlName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/controls/{control}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="controlId">The <c>Control</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ControlName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/controls/{control}</c>.
        /// </returns>
        public static string FormatProjectLocationDataStoreControl(string projectId, string locationId, string dataStoreId, string controlId) =>
            s_projectLocationDataStoreControl.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(controlId, nameof(controlId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ControlName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/controls/{control}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="controlId">The <c>Control</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ControlName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/controls/{control}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionDataStoreControl(string projectId, string locationId, string collectionId, string dataStoreId, string controlId) =>
            s_projectLocationCollectionDataStoreControl.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(controlId, nameof(controlId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ControlName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/controls/{control}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="controlId">The <c>Control</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ControlName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/controls/{control}</c>.
        /// </returns>
        public static string FormatProjectLocationCollectionEngineControl(string projectId, string locationId, string collectionId, string engineId, string controlId) =>
            s_projectLocationCollectionEngineControl.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)), gax::GaxPreconditions.CheckNotNullOrEmpty(controlId, nameof(controlId)));

        /// <summary>Parses the given resource name string into a new <see cref="ControlName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/controls/{control}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/controls/{control}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/controls/{control}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="controlName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ControlName"/> if successful.</returns>
        public static ControlName Parse(string controlName) => Parse(controlName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ControlName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/controls/{control}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/controls/{control}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/controls/{control}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="controlName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ControlName"/> if successful.</returns>
        public static ControlName Parse(string controlName, bool allowUnparsed) =>
            TryParse(controlName, allowUnparsed, out ControlName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ControlName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/controls/{control}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/controls/{control}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/controls/{control}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="controlName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ControlName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string controlName, out ControlName result) => TryParse(controlName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ControlName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/controls/{control}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/controls/{control}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/controls/{control}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="controlName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ControlName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string controlName, bool allowUnparsed, out ControlName result)
        {
            gax::GaxPreconditions.CheckNotNull(controlName, nameof(controlName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataStoreControl.TryParseName(controlName, out resourceName))
            {
                result = FromProjectLocationDataStoreControl(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationCollectionDataStoreControl.TryParseName(controlName, out resourceName))
            {
                result = FromProjectLocationCollectionDataStoreControl(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (s_projectLocationCollectionEngineControl.TryParseName(controlName, out resourceName))
            {
                result = FromProjectLocationCollectionEngineControl(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(controlName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ControlName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string controlId = null, string dataStoreId = null, string engineId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            ControlId = controlId;
            DataStoreId = dataStoreId;
            EngineId = engineId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ControlName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/controls/{control}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="controlId">The <c>Control</c> ID. Must not be <c>null</c> or empty.</param>
        public ControlName(string projectId, string locationId, string dataStoreId, string controlId) : this(ResourceNameType.ProjectLocationDataStoreControl, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), controlId: gax::GaxPreconditions.CheckNotNullOrEmpty(controlId, nameof(controlId)))
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
        /// The <c>Collection</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string CollectionId { get; }

        /// <summary>
        /// The <c>Control</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ControlId { get; }

        /// <summary>
        /// The <c>DataStore</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string DataStoreId { get; }

        /// <summary>
        /// The <c>Engine</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string EngineId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationDataStoreControl: return s_projectLocationDataStoreControl.Expand(ProjectId, LocationId, DataStoreId, ControlId);
                case ResourceNameType.ProjectLocationCollectionDataStoreControl: return s_projectLocationCollectionDataStoreControl.Expand(ProjectId, LocationId, CollectionId, DataStoreId, ControlId);
                case ResourceNameType.ProjectLocationCollectionEngineControl: return s_projectLocationCollectionEngineControl.Expand(ProjectId, LocationId, CollectionId, EngineId, ControlId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ControlName);

        /// <inheritdoc/>
        public bool Equals(ControlName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ControlName a, ControlName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ControlName a, ControlName b) => !(a == b);
    }

    public partial class Control
    {
        /// <summary>
        /// <see cref="gcdv::ControlName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ControlName ControlName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ControlName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class BoostAction
            {
                /// <summary>
                /// <see cref="DataStoreName"/>-typed view over the <see cref="DataStore"/> resource name property.
                /// </summary>
                public DataStoreName DataStoreAsDataStoreName
                {
                    get => string.IsNullOrEmpty(DataStore) ? null : DataStoreName.Parse(DataStore, allowUnparsed: true);
                    set => DataStore = value?.ToString() ?? "";
                }
            }

            public partial class FilterAction
            {
                /// <summary>
                /// <see cref="DataStoreName"/>-typed view over the <see cref="DataStore"/> resource name property.
                /// </summary>
                public DataStoreName DataStoreAsDataStoreName
                {
                    get => string.IsNullOrEmpty(DataStore) ? null : DataStoreName.Parse(DataStore, allowUnparsed: true);
                    set => DataStore = value?.ToString() ?? "";
                }
            }
        }
    }
}
