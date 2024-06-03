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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcdv = Google.Cloud.Dialogflow.V2Beta1;
using sys = System;

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Resource name for the <c>AnswerRecord</c> resource.</summary>
    public sealed partial class AnswerRecordName : gax::IResourceName, sys::IEquatable<AnswerRecordName>
    {
        /// <summary>The possible contents of <see cref="AnswerRecordName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/answerRecords/{answer_record}</c>.</summary>
            ProjectAnswerRecord = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/answerRecords/{answer_record}</c>
            /// .
            /// </summary>
            ProjectLocationAnswerRecord = 2,
        }

        private static gax::PathTemplate s_projectAnswerRecord = new gax::PathTemplate("projects/{project}/answerRecords/{answer_record}");

        private static gax::PathTemplate s_projectLocationAnswerRecord = new gax::PathTemplate("projects/{project}/locations/{location}/answerRecords/{answer_record}");

        /// <summary>Creates a <see cref="AnswerRecordName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AnswerRecordName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AnswerRecordName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AnswerRecordName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AnswerRecordName"/> with the pattern
        /// <c>projects/{project}/answerRecords/{answer_record}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerRecordId">The <c>AnswerRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnswerRecordName"/> constructed from the provided ids.</returns>
        public static AnswerRecordName FromProjectAnswerRecord(string projectId, string answerRecordId) =>
            new AnswerRecordName(ResourceNameType.ProjectAnswerRecord, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), answerRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(answerRecordId, nameof(answerRecordId)));

        /// <summary>
        /// Creates a <see cref="AnswerRecordName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/answerRecords/{answer_record}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerRecordId">The <c>AnswerRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnswerRecordName"/> constructed from the provided ids.</returns>
        public static AnswerRecordName FromProjectLocationAnswerRecord(string projectId, string locationId, string answerRecordId) =>
            new AnswerRecordName(ResourceNameType.ProjectLocationAnswerRecord, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), answerRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(answerRecordId, nameof(answerRecordId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnswerRecordName"/> with pattern
        /// <c>projects/{project}/answerRecords/{answer_record}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerRecordId">The <c>AnswerRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnswerRecordName"/> with pattern
        /// <c>projects/{project}/answerRecords/{answer_record}</c>.
        /// </returns>
        public static string Format(string projectId, string answerRecordId) =>
            FormatProjectAnswerRecord(projectId, answerRecordId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnswerRecordName"/> with pattern
        /// <c>projects/{project}/answerRecords/{answer_record}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerRecordId">The <c>AnswerRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnswerRecordName"/> with pattern
        /// <c>projects/{project}/answerRecords/{answer_record}</c>.
        /// </returns>
        public static string FormatProjectAnswerRecord(string projectId, string answerRecordId) =>
            s_projectAnswerRecord.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(answerRecordId, nameof(answerRecordId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnswerRecordName"/> with pattern
        /// <c>projects/{project}/locations/{location}/answerRecords/{answer_record}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerRecordId">The <c>AnswerRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnswerRecordName"/> with pattern
        /// <c>projects/{project}/locations/{location}/answerRecords/{answer_record}</c>.
        /// </returns>
        public static string FormatProjectLocationAnswerRecord(string projectId, string locationId, string answerRecordId) =>
            s_projectLocationAnswerRecord.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(answerRecordId, nameof(answerRecordId)));

        /// <summary>Parses the given resource name string into a new <see cref="AnswerRecordName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/answerRecords/{answer_record}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/answerRecords/{answer_record}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="answerRecordName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnswerRecordName"/> if successful.</returns>
        public static AnswerRecordName Parse(string answerRecordName) => Parse(answerRecordName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnswerRecordName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/answerRecords/{answer_record}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/answerRecords/{answer_record}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="answerRecordName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AnswerRecordName"/> if successful.</returns>
        public static AnswerRecordName Parse(string answerRecordName, bool allowUnparsed) =>
            TryParse(answerRecordName, allowUnparsed, out AnswerRecordName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnswerRecordName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/answerRecords/{answer_record}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/answerRecords/{answer_record}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="answerRecordName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnswerRecordName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string answerRecordName, out AnswerRecordName result) =>
            TryParse(answerRecordName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnswerRecordName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/answerRecords/{answer_record}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/answerRecords/{answer_record}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="answerRecordName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnswerRecordName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string answerRecordName, bool allowUnparsed, out AnswerRecordName result)
        {
            gax::GaxPreconditions.CheckNotNull(answerRecordName, nameof(answerRecordName));
            gax::TemplatedResourceName resourceName;
            if (s_projectAnswerRecord.TryParseName(answerRecordName, out resourceName))
            {
                result = FromProjectAnswerRecord(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationAnswerRecord.TryParseName(answerRecordName, out resourceName))
            {
                result = FromProjectLocationAnswerRecord(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(answerRecordName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AnswerRecordName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string answerRecordId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnswerRecordId = answerRecordId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnswerRecordName"/> class from the component parts of pattern
        /// <c>projects/{project}/answerRecords/{answer_record}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="answerRecordId">The <c>AnswerRecord</c> ID. Must not be <c>null</c> or empty.</param>
        public AnswerRecordName(string projectId, string answerRecordId) : this(ResourceNameType.ProjectAnswerRecord, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), answerRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(answerRecordId, nameof(answerRecordId)))
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
        /// The <c>AnswerRecord</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string AnswerRecordId { get; }

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
                case ResourceNameType.ProjectAnswerRecord: return s_projectAnswerRecord.Expand(ProjectId, AnswerRecordId);
                case ResourceNameType.ProjectLocationAnswerRecord: return s_projectLocationAnswerRecord.Expand(ProjectId, LocationId, AnswerRecordId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AnswerRecordName);

        /// <inheritdoc/>
        public bool Equals(AnswerRecordName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AnswerRecordName a, AnswerRecordName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AnswerRecordName a, AnswerRecordName b) => !(a == b);
    }

    public partial class AnswerRecord
    {
        /// <summary>
        /// <see cref="gcdv::AnswerRecordName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AnswerRecordName AnswerRecordName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AnswerRecordName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAnswerRecordsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }
}
