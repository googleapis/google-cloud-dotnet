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
using gaxres = Google.Api.Gax.ResourceNames;
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.Asset.V1
{
    /// <summary>
    /// Resource name for the 'feed' resource.
    /// </summary>
    public sealed partial class FeedName : gax::IResourceName, sys::IEquatable<FeedName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/feeds/{feed}");

        /// <summary>
        /// Parses the given feed resource name in string form into a new
        /// <see cref="FeedName"/> instance.
        /// </summary>
        /// <param name="feedName">The feed resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedName"/> if successful.</returns>
        public static FeedName Parse(string feedName)
        {
            gax::GaxPreconditions.CheckNotNull(feedName, nameof(feedName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(feedName);
            return new FeedName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given feed resource name in string form into a new
        /// <see cref="FeedName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="feedName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="feedName">The feed resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FeedName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedName, out FeedName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedName, nameof(feedName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(feedName, out resourceName))
            {
                result = new FeedName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="FeedName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="feedId">The <c>feed</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="FeedName"/>.</returns>
        public static string Format(string projectId, string feedId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(feedId, nameof(feedId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="FeedName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="feedId">The feed ID. Must not be <c>null</c>.</param>
        public FeedName(string projectId, string feedId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            FeedId = gax::GaxPreconditions.CheckNotNull(feedId, nameof(feedId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The feed ID. Never <c>null</c>.
        /// </summary>
        public string FeedId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, FeedId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FeedName);

        /// <inheritdoc />
        public bool Equals(FeedName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FeedName a, FeedName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FeedName a, FeedName b) => !(a == b);
    }


    public partial class BatchGetAssetsHistoryRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ExportAssetsRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

}