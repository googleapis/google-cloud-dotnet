// Copyright 2019 Google LLC
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
using sys = System;
using linq = System.Linq;

namespace Grafeas.V1
{
    /// <summary>
    /// Resource name for the 'note' resource.
    /// </summary>
    public sealed partial class NoteName : gax::IResourceName, sys::IEquatable<NoteName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/notes/{note}");

        /// <summary>
        /// Parses the given note resource name in string form into a new
        /// <see cref="NoteName"/> instance.
        /// </summary>
        /// <param name="noteName">The note resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NoteName"/> if successful.</returns>
        public static NoteName Parse(string noteName)
        {
            gax::GaxPreconditions.CheckNotNull(noteName, nameof(noteName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(noteName);
            return new NoteName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given note resource name in string form into a new
        /// <see cref="NoteName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="noteName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="noteName">The note resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="NoteName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string noteName, out NoteName result)
        {
            gax::GaxPreconditions.CheckNotNull(noteName, nameof(noteName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(noteName, out resourceName))
            {
                result = new NoteName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="NoteName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="noteId">The <c>note</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="NoteName"/>.</returns>
        public static string Format(string projectId, string noteId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(noteId, nameof(noteId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="NoteName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="noteId">The note ID. Must not be <c>null</c>.</param>
        public NoteName(string projectId, string noteId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            NoteId = gax::GaxPreconditions.CheckNotNull(noteId, nameof(noteId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The note ID. Never <c>null</c>.
        /// </summary>
        public string NoteId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, NoteId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as NoteName);

        /// <inheritdoc />
        public bool Equals(NoteName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(NoteName a, NoteName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(NoteName a, NoteName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'occurrence' resource.
    /// </summary>
    public sealed partial class OccurrenceName : gax::IResourceName, sys::IEquatable<OccurrenceName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/occurrences/{occurrence}");

        /// <summary>
        /// Parses the given occurrence resource name in string form into a new
        /// <see cref="OccurrenceName"/> instance.
        /// </summary>
        /// <param name="occurrenceName">The occurrence resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OccurrenceName"/> if successful.</returns>
        public static OccurrenceName Parse(string occurrenceName)
        {
            gax::GaxPreconditions.CheckNotNull(occurrenceName, nameof(occurrenceName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(occurrenceName);
            return new OccurrenceName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given occurrence resource name in string form into a new
        /// <see cref="OccurrenceName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="occurrenceName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="occurrenceName">The occurrence resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OccurrenceName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string occurrenceName, out OccurrenceName result)
        {
            gax::GaxPreconditions.CheckNotNull(occurrenceName, nameof(occurrenceName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(occurrenceName, out resourceName))
            {
                result = new OccurrenceName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="OccurrenceName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="occurrenceId">The <c>occurrence</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="OccurrenceName"/>.</returns>
        public static string Format(string projectId, string occurrenceId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(occurrenceId, nameof(occurrenceId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="OccurrenceName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="occurrenceId">The occurrence ID. Must not be <c>null</c>.</param>
        public OccurrenceName(string projectId, string occurrenceId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            OccurrenceId = gax::GaxPreconditions.CheckNotNull(occurrenceId, nameof(occurrenceId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The occurrence ID. Never <c>null</c>.
        /// </summary>
        public string OccurrenceId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, OccurrenceId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OccurrenceName);

        /// <inheritdoc />
        public bool Equals(OccurrenceName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OccurrenceName a, OccurrenceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OccurrenceName a, OccurrenceName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project' resource.
    /// </summary>
    public sealed partial class ProjectName : gax::IResourceName, sys::IEquatable<ProjectName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}");

        /// <summary>
        /// Parses the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectName"/> if successful.</returns>
        public static ProjectName Parse(string projectName)
        {
            gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(projectName);
            return new ProjectName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="projectName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectName, out ProjectName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectName, out resourceName))
            {
                result = new ProjectName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProjectName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProjectName"/>.</returns>
        public static string Format(string projectId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        public ProjectName(string projectId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectName);

        /// <inheritdoc />
        public bool Equals(ProjectName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectName a, ProjectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectName a, ProjectName b) => !(a == b);
    }


    public partial class BatchCreateNotesRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : global::Grafeas.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class BatchCreateOccurrencesRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : global::Grafeas.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateNoteRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : global::Grafeas.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateOccurrenceRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : global::Grafeas.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteNoteRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.NoteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.NoteName NoteName
        {
            get { return string.IsNullOrEmpty(Name) ? null : global::Grafeas.V1.NoteName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteOccurrenceRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.OccurrenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.OccurrenceName OccurrenceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : global::Grafeas.V1.OccurrenceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetNoteRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.NoteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.NoteName NoteName
        {
            get { return string.IsNullOrEmpty(Name) ? null : global::Grafeas.V1.NoteName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetOccurrenceNoteRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.OccurrenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.OccurrenceName OccurrenceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : global::Grafeas.V1.OccurrenceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetOccurrenceRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.OccurrenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.OccurrenceName OccurrenceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : global::Grafeas.V1.OccurrenceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListNoteOccurrencesRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.NoteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.NoteName NoteName
        {
            get { return string.IsNullOrEmpty(Name) ? null : global::Grafeas.V1.NoteName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListNotesRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : global::Grafeas.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListOccurrencesRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : global::Grafeas.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Note
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.NoteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.NoteName NoteName
        {
            get { return string.IsNullOrEmpty(Name) ? null : global::Grafeas.V1.NoteName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Occurrence
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.OccurrenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.OccurrenceName OccurrenceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : global::Grafeas.V1.OccurrenceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateNoteRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.NoteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.NoteName NoteName
        {
            get { return string.IsNullOrEmpty(Name) ? null : global::Grafeas.V1.NoteName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateOccurrenceRequest
    {
        /// <summary>
        /// <see cref="global::Grafeas.V1.OccurrenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public global::Grafeas.V1.OccurrenceName OccurrenceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : global::Grafeas.V1.OccurrenceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}