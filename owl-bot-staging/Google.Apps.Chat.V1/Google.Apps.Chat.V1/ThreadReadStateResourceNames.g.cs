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
using gacv = Google.Apps.Chat.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Apps.Chat.V1
{
    /// <summary>Resource name for the <c>ThreadReadState</c> resource.</summary>
    public sealed partial class ThreadReadStateName : gax::IResourceName, sys::IEquatable<ThreadReadStateName>
    {
        /// <summary>The possible contents of <see cref="ThreadReadStateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>users/{user}/spaces/{space}/threads/{thread}/threadReadState</c>.
            /// </summary>
            UserSpaceThread = 1,
        }

        private static gax::PathTemplate s_userSpaceThread = new gax::PathTemplate("users/{user}/spaces/{space}/threads/{thread}/threadReadState");

        /// <summary>Creates a <see cref="ThreadReadStateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ThreadReadStateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ThreadReadStateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ThreadReadStateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ThreadReadStateName"/> with the pattern
        /// <c>users/{user}/spaces/{space}/threads/{thread}/threadReadState</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="threadId">The <c>Thread</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ThreadReadStateName"/> constructed from the provided ids.</returns>
        public static ThreadReadStateName FromUserSpaceThread(string userId, string spaceId, string threadId) =>
            new ThreadReadStateName(ResourceNameType.UserSpaceThread, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), threadId: gax::GaxPreconditions.CheckNotNullOrEmpty(threadId, nameof(threadId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ThreadReadStateName"/> with pattern
        /// <c>users/{user}/spaces/{space}/threads/{thread}/threadReadState</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="threadId">The <c>Thread</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ThreadReadStateName"/> with pattern
        /// <c>users/{user}/spaces/{space}/threads/{thread}/threadReadState</c>.
        /// </returns>
        public static string Format(string userId, string spaceId, string threadId) =>
            FormatUserSpaceThread(userId, spaceId, threadId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ThreadReadStateName"/> with pattern
        /// <c>users/{user}/spaces/{space}/threads/{thread}/threadReadState</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="threadId">The <c>Thread</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ThreadReadStateName"/> with pattern
        /// <c>users/{user}/spaces/{space}/threads/{thread}/threadReadState</c>.
        /// </returns>
        public static string FormatUserSpaceThread(string userId, string spaceId, string threadId) =>
            s_userSpaceThread.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(threadId, nameof(threadId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ThreadReadStateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/spaces/{space}/threads/{thread}/threadReadState</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="threadReadStateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ThreadReadStateName"/> if successful.</returns>
        public static ThreadReadStateName Parse(string threadReadStateName) => Parse(threadReadStateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ThreadReadStateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/spaces/{space}/threads/{thread}/threadReadState</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="threadReadStateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ThreadReadStateName"/> if successful.</returns>
        public static ThreadReadStateName Parse(string threadReadStateName, bool allowUnparsed) =>
            TryParse(threadReadStateName, allowUnparsed, out ThreadReadStateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ThreadReadStateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/spaces/{space}/threads/{thread}/threadReadState</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="threadReadStateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ThreadReadStateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string threadReadStateName, out ThreadReadStateName result) =>
            TryParse(threadReadStateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ThreadReadStateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/spaces/{space}/threads/{thread}/threadReadState</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="threadReadStateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ThreadReadStateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string threadReadStateName, bool allowUnparsed, out ThreadReadStateName result)
        {
            gax::GaxPreconditions.CheckNotNull(threadReadStateName, nameof(threadReadStateName));
            gax::TemplatedResourceName resourceName;
            if (s_userSpaceThread.TryParseName(threadReadStateName, out resourceName))
            {
                result = FromUserSpaceThread(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(threadReadStateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ThreadReadStateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string spaceId = null, string threadId = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            SpaceId = spaceId;
            ThreadId = threadId;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ThreadReadStateName"/> class from the component parts of pattern
        /// <c>users/{user}/spaces/{space}/threads/{thread}/threadReadState</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="threadId">The <c>Thread</c> ID. Must not be <c>null</c> or empty.</param>
        public ThreadReadStateName(string userId, string spaceId, string threadId) : this(ResourceNameType.UserSpaceThread, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), threadId: gax::GaxPreconditions.CheckNotNullOrEmpty(threadId, nameof(threadId)))
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
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>
        /// The <c>Thread</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ThreadId { get; }

        /// <summary>
        /// The <c>User</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UserId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.UserSpaceThread: return s_userSpaceThread.Expand(UserId, SpaceId, ThreadId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ThreadReadStateName);

        /// <inheritdoc/>
        public bool Equals(ThreadReadStateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ThreadReadStateName a, ThreadReadStateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ThreadReadStateName a, ThreadReadStateName b) => !(a == b);
    }

    public partial class ThreadReadState
    {
        /// <summary>
        /// <see cref="gacv::ThreadReadStateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::ThreadReadStateName ThreadReadStateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::ThreadReadStateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetThreadReadStateRequest
    {
        /// <summary>
        /// <see cref="gacv::ThreadReadStateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::ThreadReadStateName ThreadReadStateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::ThreadReadStateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
