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

namespace Google.Cloud.Translate.V3
{
    /// <summary>
    /// Resource name for the 'glossary' resource.
    /// </summary>
    public sealed partial class GlossaryName : gax::IResourceName, sys::IEquatable<GlossaryName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/glossaries/{glossary}");

        /// <summary>
        /// Parses the given glossary resource name in string form into a new
        /// <see cref="GlossaryName"/> instance.
        /// </summary>
        /// <param name="glossaryName">The glossary resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GlossaryName"/> if successful.</returns>
        public static GlossaryName Parse(string glossaryName)
        {
            gax::GaxPreconditions.CheckNotNull(glossaryName, nameof(glossaryName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(glossaryName);
            return new GlossaryName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given glossary resource name in string form into a new
        /// <see cref="GlossaryName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="glossaryName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="glossaryName">The glossary resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="GlossaryName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string glossaryName, out GlossaryName result)
        {
            gax::GaxPreconditions.CheckNotNull(glossaryName, nameof(glossaryName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(glossaryName, out resourceName))
            {
                result = new GlossaryName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="GlossaryName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="glossaryId">The <c>glossary</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="GlossaryName"/>.</returns>
        public static string Format(string projectId, string locationId, string glossaryId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(glossaryId, nameof(glossaryId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="GlossaryName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="glossaryId">The glossary ID. Must not be <c>null</c>.</param>
        public GlossaryName(string projectId, string locationId, string glossaryId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            GlossaryId = gax::GaxPreconditions.CheckNotNull(glossaryId, nameof(glossaryId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The glossary ID. Never <c>null</c>.
        /// </summary>
        public string GlossaryId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, GlossaryId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as GlossaryName);

        /// <inheritdoc />
        public bool Equals(GlossaryName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(GlossaryName a, GlossaryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(GlossaryName a, GlossaryName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'location' resource.
    /// </summary>
    public sealed partial class LocationName : gax::IResourceName, sys::IEquatable<LocationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}");

        /// <summary>
        /// Parses the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(locationName);
            return new LocationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="locationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, out LocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(locationName, out resourceName))
            {
                result = new LocationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="LocationName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="LocationName"/>.</returns>
        public static string Format(string projectId, string locationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        public LocationName(string projectId, string locationId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LocationName);

        /// <inheritdoc />
        public bool Equals(LocationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LocationName a, LocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LocationName a, LocationName b) => !(a == b);
    }


    public partial class BatchTranslateTextRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Translate.V3.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Translate.V3.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Translate.V3.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateGlossaryRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Translate.V3.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Translate.V3.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Translate.V3.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteGlossaryRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Translate.V3.GlossaryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Translate.V3.GlossaryName GlossaryName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Translate.V3.GlossaryName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DetectLanguageRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Translate.V3.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Translate.V3.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Translate.V3.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetGlossaryRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Translate.V3.GlossaryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Translate.V3.GlossaryName GlossaryName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Translate.V3.GlossaryName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetSupportedLanguagesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Translate.V3.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Translate.V3.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Translate.V3.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Glossary
    {
        /// <summary>
        /// <see cref="Google.Cloud.Translate.V3.GlossaryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Translate.V3.GlossaryName GlossaryName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Translate.V3.GlossaryName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListGlossariesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Translate.V3.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Translate.V3.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Translate.V3.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class TranslateTextRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Translate.V3.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Translate.V3.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Translate.V3.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

}