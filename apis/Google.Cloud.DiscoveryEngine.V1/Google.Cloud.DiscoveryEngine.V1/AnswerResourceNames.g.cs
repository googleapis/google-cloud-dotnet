// Copyright 2024 Google LLC
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
using gcdv = Google.Cloud.DiscoveryEngine.V1;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Resource name for the <c>Answer</c> resource.</summary>
    public sealed partial class AnswerName : gax::IResourceName, sys::IEquatable<AnswerName>
    {
        /// <summary>The possible contents of <see cref="AnswerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
            /// .
            /// </summary>
            ProjectLocationDataStoreSessionAnswer = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
            /// .
            /// </summary>
            ProjectLocationCollectionDataStoreSessionAnswer = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/answers/{answer}</c>
            /// .
            /// </summary>
            ProjectLocationCollectionEngineSessionAnswer = 3,
        }

        private static gax::PathTemplate s_projectLocationDataStoreSessionAnswer = new gax::PathTemplate("projects/{project}/locations/{location}/dataStores/{data_store}/sessions/{session}/answers/{answer}");

        private static gax::PathTemplate s_projectLocationCollectionDataStoreSessionAnswer = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/sessions/{session}/answers/{answer}");

        private static gax::PathTemplate s_projectLocationCollectionEngineSessionAnswer = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/answers/{answer}");

        /// <summary>Creates a <see cref="AnswerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AnswerName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AnswerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AnswerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AnswerName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerId">The <c>Answer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnswerName"/> constructed from the provided ids.</returns>
        public static AnswerName FromProjectLocationDataStoreSessionAnswer(string projectId, string locationId, string dataStoreId, string sessionId, string answerId) =>
            new AnswerName(ResourceNameType.ProjectLocationDataStoreSessionAnswer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), answerId: gax::GaxPreconditions.CheckNotNullOrEmpty(answerId, nameof(answerId)));

        /// <summary>
        /// Creates a <see cref="AnswerName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerId">The <c>Answer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnswerName"/> constructed from the provided ids.</returns>
        public static AnswerName FromProjectLocationCollectionDataStoreSessionAnswer(string projectId, string locationId, string collectionId, string dataStoreId, string sessionId, string answerId) =>
            new AnswerName(ResourceNameType.ProjectLocationCollectionDataStoreSessionAnswer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), answerId: gax::GaxPreconditions.CheckNotNullOrEmpty(answerId, nameof(answerId)));

        /// <summary>
        /// Creates a <see cref="AnswerName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/answers/{answer}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerId">The <c>Answer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnswerName"/> constructed from the provided ids.</returns>
        public static AnswerName FromProjectLocationCollectionEngineSessionAnswer(string projectId, string locationId, string collectionId, string engineId, string sessionId, string answerId) =>
            new AnswerName(ResourceNameType.ProjectLocationCollectionEngineSessionAnswer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), engineId: gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), answerId: gax::GaxPreconditions.CheckNotNullOrEmpty(answerId, nameof(answerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnswerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerId">The <c>Answer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnswerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataStoreId, string sessionId, string answerId) =>
            FormatProjectLocationDataStoreSessionAnswer(projectId, locationId, dataStoreId, sessionId, answerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnswerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerId">The <c>Answer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnswerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>.
        /// </returns>
        public static string FormatProjectLocationDataStoreSessionAnswer(string projectId, string locationId, string dataStoreId, string sessionId, string answerId) =>
            s_projectLocationDataStoreSessionAnswer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(answerId, nameof(answerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnswerName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerId">The <c>Answer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnswerName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionDataStoreSessionAnswer(string projectId, string locationId, string collectionId, string dataStoreId, string sessionId, string answerId) =>
            s_projectLocationCollectionDataStoreSessionAnswer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(answerId, nameof(answerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnswerName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/answers/{answer}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerId">The <c>Answer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnswerName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/answers/{answer}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionEngineSessionAnswer(string projectId, string locationId, string collectionId, string engineId, string sessionId, string answerId) =>
            s_projectLocationCollectionEngineSessionAnswer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(answerId, nameof(answerId)));

        /// <summary>Parses the given resource name string into a new <see cref="AnswerName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/answers/{answer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="answerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnswerName"/> if successful.</returns>
        public static AnswerName Parse(string answerName) => Parse(answerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnswerName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/answers/{answer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="answerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AnswerName"/> if successful.</returns>
        public static AnswerName Parse(string answerName, bool allowUnparsed) =>
            TryParse(answerName, allowUnparsed, out AnswerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnswerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/answers/{answer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="answerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnswerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string answerName, out AnswerName result) => TryParse(answerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnswerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/answers/{answer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="answerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnswerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string answerName, bool allowUnparsed, out AnswerName result)
        {
            gax::GaxPreconditions.CheckNotNull(answerName, nameof(answerName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataStoreSessionAnswer.TryParseName(answerName, out resourceName))
            {
                result = FromProjectLocationDataStoreSessionAnswer(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (s_projectLocationCollectionDataStoreSessionAnswer.TryParseName(answerName, out resourceName))
            {
                result = FromProjectLocationCollectionDataStoreSessionAnswer(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5]);
                return true;
            }
            if (s_projectLocationCollectionEngineSessionAnswer.TryParseName(answerName, out resourceName))
            {
                result = FromProjectLocationCollectionEngineSessionAnswer(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(answerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AnswerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string answerId = null, string collectionId = null, string dataStoreId = null, string engineId = null, string locationId = null, string projectId = null, string sessionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnswerId = answerId;
            CollectionId = collectionId;
            DataStoreId = dataStoreId;
            EngineId = engineId;
            LocationId = locationId;
            ProjectId = projectId;
            SessionId = sessionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnswerName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/sessions/{session}/answers/{answer}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerId">The <c>Answer</c> ID. Must not be <c>null</c> or empty.</param>
        public AnswerName(string projectId, string locationId, string dataStoreId, string sessionId, string answerId) : this(ResourceNameType.ProjectLocationDataStoreSessionAnswer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), answerId: gax::GaxPreconditions.CheckNotNullOrEmpty(answerId, nameof(answerId)))
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
        /// The <c>Answer</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string AnswerId { get; }

        /// <summary>
        /// The <c>Collection</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string CollectionId { get; }

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

        /// <summary>
        /// The <c>Session</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string SessionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDataStoreSessionAnswer: return s_projectLocationDataStoreSessionAnswer.Expand(ProjectId, LocationId, DataStoreId, SessionId, AnswerId);
                case ResourceNameType.ProjectLocationCollectionDataStoreSessionAnswer: return s_projectLocationCollectionDataStoreSessionAnswer.Expand(ProjectId, LocationId, CollectionId, DataStoreId, SessionId, AnswerId);
                case ResourceNameType.ProjectLocationCollectionEngineSessionAnswer: return s_projectLocationCollectionEngineSessionAnswer.Expand(ProjectId, LocationId, CollectionId, EngineId, SessionId, AnswerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AnswerName);

        /// <inheritdoc/>
        public bool Equals(AnswerName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AnswerName a, AnswerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AnswerName a, AnswerName b) => !(a == b);
    }

    public partial class Answer
    {
        /// <summary>
        /// <see cref="gcdv::AnswerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AnswerName AnswerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AnswerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class Reference
            {
                public partial class Types
                {
                    public partial class UnstructuredDocumentInfo
                    {
                        /// <summary>
                        /// <see cref="DocumentName"/>-typed view over the <see cref="Document"/> resource name
                        /// property.
                        /// </summary>
                        public DocumentName DocumentAsDocumentName
                        {
                            get => string.IsNullOrEmpty(Document) ? null : DocumentName.Parse(Document, allowUnparsed: true);
                            set => Document = value?.ToString() ?? "";
                        }
                    }

                    public partial class ChunkInfo
                    {
                        /// <summary>
                        /// <see cref="ChunkName"/>-typed view over the <see cref="Chunk"/> resource name property.
                        /// </summary>
                        public ChunkName ChunkAsChunkName
                        {
                            get => string.IsNullOrEmpty(Chunk) ? null : ChunkName.Parse(Chunk, allowUnparsed: true);
                            set => Chunk = value?.ToString() ?? "";
                        }

                        public partial class Types
                        {
                            public partial class DocumentMetadata
                            {
                                /// <summary>
                                /// <see cref="DocumentName"/>-typed view over the <see cref="Document"/> resource name
                                /// property.
                                /// </summary>
                                public DocumentName DocumentAsDocumentName
                                {
                                    get => string.IsNullOrEmpty(Document) ? null : DocumentName.Parse(Document, allowUnparsed: true);
                                    set => Document = value?.ToString() ?? "";
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
