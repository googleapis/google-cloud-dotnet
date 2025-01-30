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
using gcev = Google.Cloud.EnterpriseKnowledgeGraph.V1;
using sys = System;

namespace Google.Cloud.EnterpriseKnowledgeGraph.V1
{
    /// <summary>Resource name for the <c>EntityReconciliationJob</c> resource.</summary>
    public sealed partial class EntityReconciliationJobName : gax::IResourceName, sys::IEquatable<EntityReconciliationJobName>
    {
        /// <summary>The possible contents of <see cref="EntityReconciliationJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}</c>.
            /// </summary>
            ProjectLocationEntityReconciliationJob = 1,
        }

        private static gax::PathTemplate s_projectLocationEntityReconciliationJob = new gax::PathTemplate("projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}");

        /// <summary>Creates a <see cref="EntityReconciliationJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EntityReconciliationJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EntityReconciliationJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EntityReconciliationJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EntityReconciliationJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityReconciliationJobId">
        /// The <c>EntityReconciliationJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EntityReconciliationJobName"/> constructed from the provided ids.
        /// </returns>
        public static EntityReconciliationJobName FromProjectLocationEntityReconciliationJob(string projectId, string locationId, string entityReconciliationJobId) =>
            new EntityReconciliationJobName(ResourceNameType.ProjectLocationEntityReconciliationJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entityReconciliationJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityReconciliationJobId, nameof(entityReconciliationJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntityReconciliationJobName"/> with
        /// pattern <c>projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityReconciliationJobId">
        /// The <c>EntityReconciliationJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EntityReconciliationJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string entityReconciliationJobId) =>
            FormatProjectLocationEntityReconciliationJob(projectId, locationId, entityReconciliationJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntityReconciliationJobName"/> with
        /// pattern <c>projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityReconciliationJobId">
        /// The <c>EntityReconciliationJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EntityReconciliationJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}</c>.
        /// </returns>
        public static string FormatProjectLocationEntityReconciliationJob(string projectId, string locationId, string entityReconciliationJobId) =>
            s_projectLocationEntityReconciliationJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entityReconciliationJobId, nameof(entityReconciliationJobId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EntityReconciliationJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entityReconciliationJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EntityReconciliationJobName"/> if successful.</returns>
        public static EntityReconciliationJobName Parse(string entityReconciliationJobName) =>
            Parse(entityReconciliationJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EntityReconciliationJobName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entityReconciliationJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EntityReconciliationJobName"/> if successful.</returns>
        public static EntityReconciliationJobName Parse(string entityReconciliationJobName, bool allowUnparsed) =>
            TryParse(entityReconciliationJobName, allowUnparsed, out EntityReconciliationJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntityReconciliationJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entityReconciliationJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntityReconciliationJobName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entityReconciliationJobName, out EntityReconciliationJobName result) =>
            TryParse(entityReconciliationJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntityReconciliationJobName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entityReconciliationJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntityReconciliationJobName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entityReconciliationJobName, bool allowUnparsed, out EntityReconciliationJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(entityReconciliationJobName, nameof(entityReconciliationJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEntityReconciliationJob.TryParseName(entityReconciliationJobName, out resourceName))
            {
                result = FromProjectLocationEntityReconciliationJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(entityReconciliationJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EntityReconciliationJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entityReconciliationJobId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntityReconciliationJobId = entityReconciliationJobId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EntityReconciliationJobName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityReconciliationJobId">
        /// The <c>EntityReconciliationJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public EntityReconciliationJobName(string projectId, string locationId, string entityReconciliationJobId) : this(ResourceNameType.ProjectLocationEntityReconciliationJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entityReconciliationJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityReconciliationJobId, nameof(entityReconciliationJobId)))
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
        /// The <c>EntityReconciliationJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string EntityReconciliationJobId { get; }

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
                case ResourceNameType.ProjectLocationEntityReconciliationJob: return s_projectLocationEntityReconciliationJob.Expand(ProjectId, LocationId, EntityReconciliationJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EntityReconciliationJobName);

        /// <inheritdoc/>
        public bool Equals(EntityReconciliationJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EntityReconciliationJobName a, EntityReconciliationJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EntityReconciliationJobName a, EntityReconciliationJobName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Dataset</c> resource.</summary>
    public sealed partial class DatasetName : gax::IResourceName, sys::IEquatable<DatasetName>
    {
        /// <summary>The possible contents of <see cref="DatasetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/datasets/{dataset}</c>.</summary>
            ProjectDataset = 1,
        }

        private static gax::PathTemplate s_projectDataset = new gax::PathTemplate("projects/{project}/datasets/{dataset}");

        /// <summary>Creates a <see cref="DatasetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatasetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DatasetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatasetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatasetName"/> with the pattern <c>projects/{project}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DatasetName"/> constructed from the provided ids.</returns>
        public static DatasetName FromProjectDataset(string projectId, string datasetId) =>
            new DatasetName(ResourceNameType.ProjectDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </returns>
        public static string Format(string projectId, string datasetId) => FormatProjectDataset(projectId, datasetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </returns>
        public static string FormatProjectDataset(string projectId, string datasetId) =>
            s_projectDataset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>Parses the given resource name string into a new <see cref="DatasetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatasetName"/> if successful.</returns>
        public static DatasetName Parse(string datasetName) => Parse(datasetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatasetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatasetName"/> if successful.</returns>
        public static DatasetName Parse(string datasetName, bool allowUnparsed) =>
            TryParse(datasetName, allowUnparsed, out DatasetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetName, out DatasetName result) => TryParse(datasetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetName, bool allowUnparsed, out DatasetName result)
        {
            gax::GaxPreconditions.CheckNotNull(datasetName, nameof(datasetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDataset.TryParseName(datasetName, out resourceName))
            {
                result = FromProjectDataset(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(datasetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatasetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatasetName"/> class from the component parts of pattern
        /// <c>projects/{project}/datasets/{dataset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        public DatasetName(string projectId, string datasetId) : this(ResourceNameType.ProjectDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)))
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
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

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
                case ResourceNameType.ProjectDataset: return s_projectDataset.Expand(ProjectId, DatasetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatasetName);

        /// <inheritdoc/>
        public bool Equals(DatasetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatasetName a, DatasetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatasetName a, DatasetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Table</c> resource.</summary>
    public sealed partial class TableName : gax::IResourceName, sys::IEquatable<TableName>
    {
        /// <summary>The possible contents of <see cref="TableName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/datasets/{dataset}/tables/{table}</c>.
            /// </summary>
            ProjectDatasetTable = 1,
        }

        private static gax::PathTemplate s_projectDatasetTable = new gax::PathTemplate("projects/{project}/datasets/{dataset}/tables/{table}");

        /// <summary>Creates a <see cref="TableName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TableName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TableName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TableName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TableName"/> with the pattern <c>projects/{project}/datasets/{dataset}/tables/{table}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TableName"/> constructed from the provided ids.</returns>
        public static TableName FromProjectDatasetTable(string projectId, string datasetId, string tableId) =>
            new TableName(ResourceNameType.ProjectDatasetTable, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TableName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TableName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}</c>.
        /// </returns>
        public static string Format(string projectId, string datasetId, string tableId) =>
            FormatProjectDatasetTable(projectId, datasetId, tableId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TableName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TableName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}</c>.
        /// </returns>
        public static string FormatProjectDatasetTable(string projectId, string datasetId, string tableId) =>
            s_projectDatasetTable.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)));

        /// <summary>Parses the given resource name string into a new <see cref="TableName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}/tables/{table}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TableName"/> if successful.</returns>
        public static TableName Parse(string tableName) => Parse(tableName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TableName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}/tables/{table}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TableName"/> if successful.</returns>
        public static TableName Parse(string tableName, bool allowUnparsed) =>
            TryParse(tableName, allowUnparsed, out TableName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TableName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}/tables/{table}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TableName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tableName, out TableName result) => TryParse(tableName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TableName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}/tables/{table}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TableName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tableName, bool allowUnparsed, out TableName result)
        {
            gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDatasetTable.TryParseName(tableName, out resourceName))
            {
                result = FromProjectDatasetTable(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tableName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TableName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string projectId = null, string tableId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            ProjectId = projectId;
            TableId = tableId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TableName"/> class from the component parts of pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        public TableName(string projectId, string datasetId, string tableId) : this(ResourceNameType.ProjectDatasetTable, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)))
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
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Table</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TableId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectDatasetTable: return s_projectDatasetTable.Expand(ProjectId, DatasetId, TableId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TableName);

        /// <inheritdoc/>
        public bool Equals(TableName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TableName a, TableName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TableName a, TableName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CloudKnowledgeGraphEntity</c> resource.</summary>
    public sealed partial class CloudKnowledgeGraphEntityName : gax::IResourceName, sys::IEquatable<CloudKnowledgeGraphEntityName>
    {
        /// <summary>The possible contents of <see cref="CloudKnowledgeGraphEntityName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/cloudKnowledgeGraphEntities/{cloud_knowledge_graph_entity}</c>
            /// .
            /// </summary>
            ProjectLocationCloudKnowledgeGraphEntity = 1,
        }

        private static gax::PathTemplate s_projectLocationCloudKnowledgeGraphEntity = new gax::PathTemplate("projects/{project}/locations/{location}/cloudKnowledgeGraphEntities/{cloud_knowledge_graph_entity}");

        /// <summary>
        /// Creates a <see cref="CloudKnowledgeGraphEntityName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CloudKnowledgeGraphEntityName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CloudKnowledgeGraphEntityName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CloudKnowledgeGraphEntityName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CloudKnowledgeGraphEntityName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/cloudKnowledgeGraphEntities/{cloud_knowledge_graph_entity}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudKnowledgeGraphEntityId">
        /// The <c>CloudKnowledgeGraphEntity</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="CloudKnowledgeGraphEntityName"/> constructed from the provided ids.
        /// </returns>
        public static CloudKnowledgeGraphEntityName FromProjectLocationCloudKnowledgeGraphEntity(string projectId, string locationId, string cloudKnowledgeGraphEntityId) =>
            new CloudKnowledgeGraphEntityName(ResourceNameType.ProjectLocationCloudKnowledgeGraphEntity, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cloudKnowledgeGraphEntityId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloudKnowledgeGraphEntityId, nameof(cloudKnowledgeGraphEntityId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloudKnowledgeGraphEntityName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/cloudKnowledgeGraphEntities/{cloud_knowledge_graph_entity}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudKnowledgeGraphEntityId">
        /// The <c>CloudKnowledgeGraphEntity</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CloudKnowledgeGraphEntityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudKnowledgeGraphEntities/{cloud_knowledge_graph_entity}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string cloudKnowledgeGraphEntityId) =>
            FormatProjectLocationCloudKnowledgeGraphEntity(projectId, locationId, cloudKnowledgeGraphEntityId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloudKnowledgeGraphEntityName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/cloudKnowledgeGraphEntities/{cloud_knowledge_graph_entity}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudKnowledgeGraphEntityId">
        /// The <c>CloudKnowledgeGraphEntity</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CloudKnowledgeGraphEntityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudKnowledgeGraphEntities/{cloud_knowledge_graph_entity}</c>.
        /// </returns>
        public static string FormatProjectLocationCloudKnowledgeGraphEntity(string projectId, string locationId, string cloudKnowledgeGraphEntityId) =>
            s_projectLocationCloudKnowledgeGraphEntity.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cloudKnowledgeGraphEntityId, nameof(cloudKnowledgeGraphEntityId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CloudKnowledgeGraphEntityName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/cloudKnowledgeGraphEntities/{cloud_knowledge_graph_entity}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cloudKnowledgeGraphEntityName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="CloudKnowledgeGraphEntityName"/> if successful.</returns>
        public static CloudKnowledgeGraphEntityName Parse(string cloudKnowledgeGraphEntityName) =>
            Parse(cloudKnowledgeGraphEntityName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CloudKnowledgeGraphEntityName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/cloudKnowledgeGraphEntities/{cloud_knowledge_graph_entity}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloudKnowledgeGraphEntityName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CloudKnowledgeGraphEntityName"/> if successful.</returns>
        public static CloudKnowledgeGraphEntityName Parse(string cloudKnowledgeGraphEntityName, bool allowUnparsed) =>
            TryParse(cloudKnowledgeGraphEntityName, allowUnparsed, out CloudKnowledgeGraphEntityName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloudKnowledgeGraphEntityName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/cloudKnowledgeGraphEntities/{cloud_knowledge_graph_entity}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cloudKnowledgeGraphEntityName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloudKnowledgeGraphEntityName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloudKnowledgeGraphEntityName, out CloudKnowledgeGraphEntityName result) =>
            TryParse(cloudKnowledgeGraphEntityName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloudKnowledgeGraphEntityName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/cloudKnowledgeGraphEntities/{cloud_knowledge_graph_entity}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloudKnowledgeGraphEntityName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloudKnowledgeGraphEntityName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloudKnowledgeGraphEntityName, bool allowUnparsed, out CloudKnowledgeGraphEntityName result)
        {
            gax::GaxPreconditions.CheckNotNull(cloudKnowledgeGraphEntityName, nameof(cloudKnowledgeGraphEntityName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCloudKnowledgeGraphEntity.TryParseName(cloudKnowledgeGraphEntityName, out resourceName))
            {
                result = FromProjectLocationCloudKnowledgeGraphEntity(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cloudKnowledgeGraphEntityName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CloudKnowledgeGraphEntityName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cloudKnowledgeGraphEntityId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CloudKnowledgeGraphEntityId = cloudKnowledgeGraphEntityId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CloudKnowledgeGraphEntityName"/> class from the component parts of
        /// pattern
        /// <c>projects/{project}/locations/{location}/cloudKnowledgeGraphEntities/{cloud_knowledge_graph_entity}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudKnowledgeGraphEntityId">
        /// The <c>CloudKnowledgeGraphEntity</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CloudKnowledgeGraphEntityName(string projectId, string locationId, string cloudKnowledgeGraphEntityId) : this(ResourceNameType.ProjectLocationCloudKnowledgeGraphEntity, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cloudKnowledgeGraphEntityId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloudKnowledgeGraphEntityId, nameof(cloudKnowledgeGraphEntityId)))
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
        /// The <c>CloudKnowledgeGraphEntity</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CloudKnowledgeGraphEntityId { get; }

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
                case ResourceNameType.ProjectLocationCloudKnowledgeGraphEntity: return s_projectLocationCloudKnowledgeGraphEntity.Expand(ProjectId, LocationId, CloudKnowledgeGraphEntityId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CloudKnowledgeGraphEntityName);

        /// <inheritdoc/>
        public bool Equals(CloudKnowledgeGraphEntityName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CloudKnowledgeGraphEntityName a, CloudKnowledgeGraphEntityName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CloudKnowledgeGraphEntityName a, CloudKnowledgeGraphEntityName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PublicKnowledgeGraphEntity</c> resource.</summary>
    public sealed partial class PublicKnowledgeGraphEntityName : gax::IResourceName, sys::IEquatable<PublicKnowledgeGraphEntityName>
    {
        /// <summary>The possible contents of <see cref="PublicKnowledgeGraphEntityName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/publicKnowledgeGraphEntities/{public_knowledge_graph_entity}</c>
            /// .
            /// </summary>
            ProjectLocationPublicKnowledgeGraphEntity = 1,
        }

        private static gax::PathTemplate s_projectLocationPublicKnowledgeGraphEntity = new gax::PathTemplate("projects/{project}/locations/{location}/publicKnowledgeGraphEntities/{public_knowledge_graph_entity}");

        /// <summary>
        /// Creates a <see cref="PublicKnowledgeGraphEntityName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PublicKnowledgeGraphEntityName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PublicKnowledgeGraphEntityName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PublicKnowledgeGraphEntityName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PublicKnowledgeGraphEntityName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/publicKnowledgeGraphEntities/{public_knowledge_graph_entity}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publicKnowledgeGraphEntityId">
        /// The <c>PublicKnowledgeGraphEntity</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="PublicKnowledgeGraphEntityName"/> constructed from the provided ids.
        /// </returns>
        public static PublicKnowledgeGraphEntityName FromProjectLocationPublicKnowledgeGraphEntity(string projectId, string locationId, string publicKnowledgeGraphEntityId) =>
            new PublicKnowledgeGraphEntityName(ResourceNameType.ProjectLocationPublicKnowledgeGraphEntity, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), publicKnowledgeGraphEntityId: gax::GaxPreconditions.CheckNotNullOrEmpty(publicKnowledgeGraphEntityId, nameof(publicKnowledgeGraphEntityId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PublicKnowledgeGraphEntityName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/publicKnowledgeGraphEntities/{public_knowledge_graph_entity}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publicKnowledgeGraphEntityId">
        /// The <c>PublicKnowledgeGraphEntity</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="PublicKnowledgeGraphEntityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/publicKnowledgeGraphEntities/{public_knowledge_graph_entity}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string publicKnowledgeGraphEntityId) =>
            FormatProjectLocationPublicKnowledgeGraphEntity(projectId, locationId, publicKnowledgeGraphEntityId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PublicKnowledgeGraphEntityName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/publicKnowledgeGraphEntities/{public_knowledge_graph_entity}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publicKnowledgeGraphEntityId">
        /// The <c>PublicKnowledgeGraphEntity</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="PublicKnowledgeGraphEntityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/publicKnowledgeGraphEntities/{public_knowledge_graph_entity}</c>.
        /// </returns>
        public static string FormatProjectLocationPublicKnowledgeGraphEntity(string projectId, string locationId, string publicKnowledgeGraphEntityId) =>
            s_projectLocationPublicKnowledgeGraphEntity.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(publicKnowledgeGraphEntityId, nameof(publicKnowledgeGraphEntityId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PublicKnowledgeGraphEntityName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/publicKnowledgeGraphEntities/{public_knowledge_graph_entity}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="publicKnowledgeGraphEntityName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="PublicKnowledgeGraphEntityName"/> if successful.</returns>
        public static PublicKnowledgeGraphEntityName Parse(string publicKnowledgeGraphEntityName) =>
            Parse(publicKnowledgeGraphEntityName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PublicKnowledgeGraphEntityName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/publicKnowledgeGraphEntities/{public_knowledge_graph_entity}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="publicKnowledgeGraphEntityName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PublicKnowledgeGraphEntityName"/> if successful.</returns>
        public static PublicKnowledgeGraphEntityName Parse(string publicKnowledgeGraphEntityName, bool allowUnparsed) =>
            TryParse(publicKnowledgeGraphEntityName, allowUnparsed, out PublicKnowledgeGraphEntityName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PublicKnowledgeGraphEntityName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/publicKnowledgeGraphEntities/{public_knowledge_graph_entity}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="publicKnowledgeGraphEntityName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PublicKnowledgeGraphEntityName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string publicKnowledgeGraphEntityName, out PublicKnowledgeGraphEntityName result) =>
            TryParse(publicKnowledgeGraphEntityName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PublicKnowledgeGraphEntityName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/publicKnowledgeGraphEntities/{public_knowledge_graph_entity}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="publicKnowledgeGraphEntityName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PublicKnowledgeGraphEntityName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string publicKnowledgeGraphEntityName, bool allowUnparsed, out PublicKnowledgeGraphEntityName result)
        {
            gax::GaxPreconditions.CheckNotNull(publicKnowledgeGraphEntityName, nameof(publicKnowledgeGraphEntityName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPublicKnowledgeGraphEntity.TryParseName(publicKnowledgeGraphEntityName, out resourceName))
            {
                result = FromProjectLocationPublicKnowledgeGraphEntity(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(publicKnowledgeGraphEntityName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PublicKnowledgeGraphEntityName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string publicKnowledgeGraphEntityId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            PublicKnowledgeGraphEntityId = publicKnowledgeGraphEntityId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PublicKnowledgeGraphEntityName"/> class from the component parts
        /// of pattern
        /// <c>projects/{project}/locations/{location}/publicKnowledgeGraphEntities/{public_knowledge_graph_entity}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publicKnowledgeGraphEntityId">
        /// The <c>PublicKnowledgeGraphEntity</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public PublicKnowledgeGraphEntityName(string projectId, string locationId, string publicKnowledgeGraphEntityId) : this(ResourceNameType.ProjectLocationPublicKnowledgeGraphEntity, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), publicKnowledgeGraphEntityId: gax::GaxPreconditions.CheckNotNullOrEmpty(publicKnowledgeGraphEntityId, nameof(publicKnowledgeGraphEntityId)))
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
        /// The <c>PublicKnowledgeGraphEntity</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string PublicKnowledgeGraphEntityId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationPublicKnowledgeGraphEntity: return s_projectLocationPublicKnowledgeGraphEntity.Expand(ProjectId, LocationId, PublicKnowledgeGraphEntityId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PublicKnowledgeGraphEntityName);

        /// <inheritdoc/>
        public bool Equals(PublicKnowledgeGraphEntityName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PublicKnowledgeGraphEntityName a, PublicKnowledgeGraphEntityName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PublicKnowledgeGraphEntityName a, PublicKnowledgeGraphEntityName b) => !(a == b);
    }

    public partial class InputConfig
    {
        /// <summary>
        /// <see cref="TableName"/>-typed view over the <see cref="PreviousResultBigqueryTable"/> resource name
        /// property.
        /// </summary>
        public TableName PreviousResultBigqueryTableAsTableName
        {
            get => string.IsNullOrEmpty(PreviousResultBigqueryTable) ? null : TableName.Parse(PreviousResultBigqueryTable, allowUnparsed: true);
            set => PreviousResultBigqueryTable = value?.ToString() ?? "";
        }
    }

    public partial class BigQueryInputConfig
    {
        /// <summary>
        /// <see cref="TableName"/>-typed view over the <see cref="BigqueryTable"/> resource name property.
        /// </summary>
        public TableName BigqueryTableAsTableName
        {
            get => string.IsNullOrEmpty(BigqueryTable) ? null : TableName.Parse(BigqueryTable, allowUnparsed: true);
            set => BigqueryTable = value?.ToString() ?? "";
        }
    }

    public partial class OutputConfig
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="BigqueryDataset"/> resource name property.
        /// </summary>
        public DatasetName BigqueryDatasetAsDatasetName
        {
            get => string.IsNullOrEmpty(BigqueryDataset) ? null : DatasetName.Parse(BigqueryDataset, allowUnparsed: true);
            set => BigqueryDataset = value?.ToString() ?? "";
        }
    }

    public partial class CreateEntityReconciliationJobRequest
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

    public partial class GetEntityReconciliationJobRequest
    {
        /// <summary>
        /// <see cref="gcev::EntityReconciliationJobName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcev::EntityReconciliationJobName EntityReconciliationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::EntityReconciliationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEntityReconciliationJobsRequest
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

    public partial class CancelEntityReconciliationJobRequest
    {
        /// <summary>
        /// <see cref="gcev::EntityReconciliationJobName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcev::EntityReconciliationJobName EntityReconciliationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::EntityReconciliationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEntityReconciliationJobRequest
    {
        /// <summary>
        /// <see cref="gcev::EntityReconciliationJobName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcev::EntityReconciliationJobName EntityReconciliationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::EntityReconciliationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EntityReconciliationJob
    {
        /// <summary>
        /// <see cref="gcev::EntityReconciliationJobName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcev::EntityReconciliationJobName EntityReconciliationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::EntityReconciliationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LookupRequest
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

    public partial class SearchRequest
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

    public partial class LookupPublicKgRequest
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

    public partial class SearchPublicKgRequest
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
