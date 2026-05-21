// Copyright 2026 Google LLC
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
using gdhv = Google.DevicesAndServices.Health.V4;
using sys = System;

namespace Google.DevicesAndServices.Health.V4
{
    /// <summary>Resource name for the <c>Subscriber</c> resource.</summary>
    public sealed partial class SubscriberName : gax::IResourceName, sys::IEquatable<SubscriberName>
    {
        /// <summary>The possible contents of <see cref="SubscriberName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/subscribers/{subscriber}</c>.</summary>
            ProjectSubscriber = 1,
        }

        private static gax::PathTemplate s_projectSubscriber = new gax::PathTemplate("projects/{project}/subscribers/{subscriber}");

        /// <summary>Creates a <see cref="SubscriberName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SubscriberName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SubscriberName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SubscriberName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SubscriberName"/> with the pattern <c>projects/{project}/subscribers/{subscriber}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriberId">The <c>Subscriber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SubscriberName"/> constructed from the provided ids.</returns>
        public static SubscriberName FromProjectSubscriber(string projectId, string subscriberId) =>
            new SubscriberName(ResourceNameType.ProjectSubscriber, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), subscriberId: gax::GaxPreconditions.CheckNotNullOrEmpty(subscriberId, nameof(subscriberId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubscriberName"/> with pattern
        /// <c>projects/{project}/subscribers/{subscriber}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriberId">The <c>Subscriber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubscriberName"/> with pattern
        /// <c>projects/{project}/subscribers/{subscriber}</c>.
        /// </returns>
        public static string Format(string projectId, string subscriberId) => FormatProjectSubscriber(projectId, subscriberId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubscriberName"/> with pattern
        /// <c>projects/{project}/subscribers/{subscriber}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriberId">The <c>Subscriber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubscriberName"/> with pattern
        /// <c>projects/{project}/subscribers/{subscriber}</c>.
        /// </returns>
        public static string FormatProjectSubscriber(string projectId, string subscriberId) =>
            s_projectSubscriber.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(subscriberId, nameof(subscriberId)));

        /// <summary>Parses the given resource name string into a new <see cref="SubscriberName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/subscribers/{subscriber}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="subscriberName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SubscriberName"/> if successful.</returns>
        public static SubscriberName Parse(string subscriberName) => Parse(subscriberName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SubscriberName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/subscribers/{subscriber}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subscriberName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SubscriberName"/> if successful.</returns>
        public static SubscriberName Parse(string subscriberName, bool allowUnparsed) =>
            TryParse(subscriberName, allowUnparsed, out SubscriberName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubscriberName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/subscribers/{subscriber}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="subscriberName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubscriberName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subscriberName, out SubscriberName result) =>
            TryParse(subscriberName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubscriberName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/subscribers/{subscriber}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subscriberName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubscriberName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subscriberName, bool allowUnparsed, out SubscriberName result)
        {
            gax::GaxPreconditions.CheckNotNull(subscriberName, nameof(subscriberName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSubscriber.TryParseName(subscriberName, out resourceName))
            {
                result = FromProjectSubscriber(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(subscriberName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SubscriberName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string subscriberId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SubscriberId = subscriberId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SubscriberName"/> class from the component parts of pattern
        /// <c>projects/{project}/subscribers/{subscriber}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriberId">The <c>Subscriber</c> ID. Must not be <c>null</c> or empty.</param>
        public SubscriberName(string projectId, string subscriberId) : this(ResourceNameType.ProjectSubscriber, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), subscriberId: gax::GaxPreconditions.CheckNotNullOrEmpty(subscriberId, nameof(subscriberId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Subscriber</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SubscriberId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSubscriber: return s_projectSubscriber.Expand(ProjectId, SubscriberId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SubscriberName);

        /// <inheritdoc/>
        public bool Equals(SubscriberName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SubscriberName a, SubscriberName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SubscriberName a, SubscriberName b) => !(a == b);
    }

    public partial class CreateSubscriberRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListSubscribersRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSubscriberRequest
    {
        /// <summary>
        /// <see cref="gdhv::SubscriberName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::SubscriberName SubscriberName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::SubscriberName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Subscriber
    {
        /// <summary>
        /// <see cref="gdhv::SubscriberName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::SubscriberName SubscriberName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::SubscriberName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SubscriberConfig
    {
        /// <summary>
        /// <see cref="DataTypeName"/>-typed view over the <see cref="DataTypes"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<DataTypeName> DataTypesAsDataTypeNames
        {
            get => new gax::ResourceNameList<DataTypeName>(DataTypes, s => string.IsNullOrEmpty(s) ? null : DataTypeName.Parse(s, allowUnparsed: true));
        }
    }
}
