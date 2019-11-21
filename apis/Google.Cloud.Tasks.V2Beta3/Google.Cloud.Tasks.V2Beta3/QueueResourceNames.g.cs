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
using gctv = Google.Cloud.Tasks.V2Beta3;
using sys = System;

namespace Google.Cloud.Tasks.V2Beta3
{
    /// <summary>Resource name for the <c>Queue</c> resource.</summary>
    public sealed partial class QueueName : gax::IResourceName, sys::IEquatable<QueueName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/queues/{queue}");

        /// <summary>
        /// Parses the given <c>Queue</c> resource name in string form into a new <see cref="QueueName"/> instance.
        /// </summary>
        /// <param name="queueName">The <c>Queue</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="QueueName"/> if successful.</returns>
        public static QueueName Parse(string queueName)
        {
            gax::GaxPreconditions.CheckNotNull(queueName, nameof(queueName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(queueName);
            return new QueueName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="QueueName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="queueName"/> is <c>null</c>
        /// , as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="queueName">The <c>Queue</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QueueName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string queueName, out QueueName result)
        {
            gax::GaxPreconditions.CheckNotNull(queueName, nameof(queueName));
            if (s_template.TryParseName(queueName, out gax::TemplatedResourceName resourceName))
            {
                result = new QueueName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="QueueName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="queueId">The <c>Queue</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="QueueName"/>.</returns>
        public static string Format(string projectId, string locationId, string queueId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(queueId, nameof(queueId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="QueueName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="queueId">The <c>Queue</c> ID. Must not be <c>null</c>.</param>
        public QueueName(string projectId, string locationId, string queueId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            QueueId = gax::GaxPreconditions.CheckNotNull(queueId, nameof(queueId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Location</c> ID. Never <c>null</c>.</summary>
        public string LocationId { get; }

        /// <summary>The <c>Queue</c> ID. Never <c>null</c>.</summary>
        public string QueueId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, LocationId, QueueId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as QueueName);

        /// <inheritdoc/>
        public bool Equals(QueueName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(QueueName a, QueueName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(QueueName a, QueueName b) => !(a == b);
    }

    public partial class Queue
    {
        /// <summary>
        /// <see cref="gctv::QueueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::QueueName QueueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::QueueName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
