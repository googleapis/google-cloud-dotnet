// Copyright 2020 Google LLC
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

using gax = Google.Api.Gax;
using gv = Grafeas.V1;
using sys = System;

namespace Grafeas.V1
{
    /// <summary>Resource name for the <c>Occurrence</c> resource.</summary>
    public sealed partial class OccurrenceName : gax::IResourceName, sys::IEquatable<OccurrenceName>
    {
        /// <summary>The possible contents of <see cref="OccurrenceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/occurrences/{occurrence}</c>.</summary>
            ProjectOccurrence = 1
        }

        private static gax::PathTemplate s_projectOccurrence = new gax::PathTemplate("projects/{project}/occurrences/{occurrence}");

        /// <summary>Creates a <see cref="OccurrenceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OccurrenceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OccurrenceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OccurrenceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OccurrenceName"/> with the pattern <c>projects/{project}/occurrences/{occurrence}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="occurrenceId">The <c>Occurrence</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OccurrenceName"/> constructed from the provided ids.</returns>
        public static OccurrenceName FromProjectOccurrence(string projectId, string occurrenceId) =>
            new OccurrenceName(ResourceNameType.ProjectOccurrence, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), occurrenceId: gax::GaxPreconditions.CheckNotNullOrEmpty(occurrenceId, nameof(occurrenceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OccurrenceName"/> with pattern
        /// <c>projects/{project}/occurrences/{occurrence}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="occurrenceId">The <c>Occurrence</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OccurrenceName"/> with pattern
        /// <c>projects/{project}/occurrences/{occurrence}</c>.
        /// </returns>
        public static string Format(string projectId, string occurrenceId) => FormatProjectOccurrence(projectId, occurrenceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OccurrenceName"/> with pattern
        /// <c>projects/{project}/occurrences/{occurrence}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="occurrenceId">The <c>Occurrence</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OccurrenceName"/> with pattern
        /// <c>projects/{project}/occurrences/{occurrence}</c>.
        /// </returns>
        public static string FormatProjectOccurrence(string projectId, string occurrenceId) =>
            s_projectOccurrence.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(occurrenceId, nameof(occurrenceId)));

        /// <summary>Parses the given resource name string into a new <see cref="OccurrenceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/occurrences/{occurrence}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="occurrenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OccurrenceName"/> if successful.</returns>
        public static OccurrenceName Parse(string occurrenceName) => Parse(occurrenceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OccurrenceName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/occurrences/{occurrence}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="occurrenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OccurrenceName"/> if successful.</returns>
        public static OccurrenceName Parse(string occurrenceName, bool allowUnparsed) =>
            TryParse(occurrenceName, allowUnparsed, out OccurrenceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OccurrenceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/occurrences/{occurrence}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="occurrenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OccurrenceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string occurrenceName, out OccurrenceName result) =>
            TryParse(occurrenceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OccurrenceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/occurrences/{occurrence}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="occurrenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OccurrenceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string occurrenceName, bool allowUnparsed, out OccurrenceName result)
        {
            gax::GaxPreconditions.CheckNotNull(occurrenceName, nameof(occurrenceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectOccurrence.TryParseName(occurrenceName, out resourceName))
            {
                result = FromProjectOccurrence(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(occurrenceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OccurrenceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string occurrenceId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            OccurrenceId = occurrenceId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OccurrenceName"/> class from the component parts of pattern
        /// <c>projects/{project}/occurrences/{occurrence}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="occurrenceId">The <c>Occurrence</c> ID. Must not be <c>null</c> or empty.</param>
        public OccurrenceName(string projectId, string occurrenceId) : this(ResourceNameType.ProjectOccurrence, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), occurrenceId: gax::GaxPreconditions.CheckNotNullOrEmpty(occurrenceId, nameof(occurrenceId)))
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
        /// The <c>Occurrence</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OccurrenceId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectOccurrence: return s_projectOccurrence.Expand(ProjectId, OccurrenceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OccurrenceName);

        /// <inheritdoc/>
        public bool Equals(OccurrenceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(OccurrenceName a, OccurrenceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(OccurrenceName a, OccurrenceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Note</c> resource.</summary>
    public sealed partial class NoteName : gax::IResourceName, sys::IEquatable<NoteName>
    {
        /// <summary>The possible contents of <see cref="NoteName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/notes/{note}</c>.</summary>
            ProjectNote = 1
        }

        private static gax::PathTemplate s_projectNote = new gax::PathTemplate("projects/{project}/notes/{note}");

        /// <summary>Creates a <see cref="NoteName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NoteName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NoteName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NoteName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="NoteName"/> with the pattern <c>projects/{project}/notes/{note}</c>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="noteId">The <c>Note</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NoteName"/> constructed from the provided ids.</returns>
        public static NoteName FromProjectNote(string projectId, string noteId) =>
            new NoteName(ResourceNameType.ProjectNote, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), noteId: gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NoteName"/> with pattern
        /// <c>projects/{project}/notes/{note}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="noteId">The <c>Note</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NoteName"/> with pattern <c>projects/{project}/notes/{note}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string noteId) => FormatProjectNote(projectId, noteId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NoteName"/> with pattern
        /// <c>projects/{project}/notes/{note}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="noteId">The <c>Note</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NoteName"/> with pattern <c>projects/{project}/notes/{note}</c>
        /// .
        /// </returns>
        public static string FormatProjectNote(string projectId, string noteId) =>
            s_projectNote.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)));

        /// <summary>Parses the given resource name string into a new <see cref="NoteName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/notes/{note}</c></description></item></list>
        /// </remarks>
        /// <param name="noteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NoteName"/> if successful.</returns>
        public static NoteName Parse(string noteName) => Parse(noteName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NoteName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/notes/{note}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="noteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NoteName"/> if successful.</returns>
        public static NoteName Parse(string noteName, bool allowUnparsed) =>
            TryParse(noteName, allowUnparsed, out NoteName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="NoteName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/notes/{note}</c></description></item></list>
        /// </remarks>
        /// <param name="noteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NoteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string noteName, out NoteName result) => TryParse(noteName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NoteName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/notes/{note}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="noteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NoteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string noteName, bool allowUnparsed, out NoteName result)
        {
            gax::GaxPreconditions.CheckNotNull(noteName, nameof(noteName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNote.TryParseName(noteName, out resourceName))
            {
                result = FromProjectNote(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(noteName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NoteName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string noteId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NoteId = noteId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NoteName"/> class from the component parts of pattern
        /// <c>projects/{project}/notes/{note}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="noteId">The <c>Note</c> ID. Must not be <c>null</c> or empty.</param>
        public NoteName(string projectId, string noteId) : this(ResourceNameType.ProjectNote, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), noteId: gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)))
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
        /// The <c>Note</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NoteId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNote: return s_projectNote.Expand(ProjectId, NoteId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NoteName);

        /// <inheritdoc/>
        public bool Equals(NoteName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(NoteName a, NoteName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(NoteName a, NoteName b) => !(a == b);
    }

    public partial class Occurrence
    {
        /// <summary>
        /// <see cref="gv::OccurrenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gv::OccurrenceName OccurrenceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gv::OccurrenceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Note
    {
        /// <summary><see cref="gv::NoteName"/>-typed view over the <see cref="Name"/> resource name property.</summary>
        public gv::NoteName NoteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gv::NoteName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetOccurrenceRequest
    {
        /// <summary>
        /// <see cref="gv::OccurrenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gv::OccurrenceName OccurrenceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gv::OccurrenceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListOccurrencesRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteOccurrenceRequest
    {
        /// <summary>
        /// <see cref="gv::OccurrenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gv::OccurrenceName OccurrenceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gv::OccurrenceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateOccurrenceRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateOccurrenceRequest
    {
        /// <summary>
        /// <see cref="gv::OccurrenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gv::OccurrenceName OccurrenceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gv::OccurrenceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetNoteRequest
    {
        /// <summary><see cref="gv::NoteName"/>-typed view over the <see cref="Name"/> resource name property.</summary>
        public gv::NoteName NoteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gv::NoteName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetOccurrenceNoteRequest
    {
        /// <summary>
        /// <see cref="gv::OccurrenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gv::OccurrenceName OccurrenceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gv::OccurrenceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNotesRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteNoteRequest
    {
        /// <summary><see cref="gv::NoteName"/>-typed view over the <see cref="Name"/> resource name property.</summary>
        public gv::NoteName NoteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gv::NoteName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateNoteRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateNoteRequest
    {
        /// <summary><see cref="gv::NoteName"/>-typed view over the <see cref="Name"/> resource name property.</summary>
        public gv::NoteName NoteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gv::NoteName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNoteOccurrencesRequest
    {
        /// <summary><see cref="gv::NoteName"/>-typed view over the <see cref="Name"/> resource name property.</summary>
        public gv::NoteName NoteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gv::NoteName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateNotesRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateOccurrencesRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
