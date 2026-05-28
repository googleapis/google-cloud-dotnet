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
using gax = Google.Api.Gax;
using gdhv = Google.DevicesAndServices.Health.V4;
using sys = System;

namespace Google.DevicesAndServices.Health.V4
{
    /// <summary>Resource name for the <c>User</c> resource.</summary>
    public sealed partial class UserName : gax::IResourceName, sys::IEquatable<UserName>
    {
        /// <summary>The possible contents of <see cref="UserName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>users/{user}</c>.</summary>
            User = 1,
        }

        private static gax::PathTemplate s_user = new gax::PathTemplate("users/{user}");

        /// <summary>Creates a <see cref="UserName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UserName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="UserName"/> with the pattern <c>users/{user}</c>.</summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UserName"/> constructed from the provided ids.</returns>
        public static UserName FromUser(string userId) =>
            new UserName(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserName"/> with pattern <c>users/{user}</c>
        /// .
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserName"/> with pattern <c>users/{user}</c>.
        /// </returns>
        public static string Format(string userId) => FormatUser(userId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserName"/> with pattern <c>users/{user}</c>
        /// .
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserName"/> with pattern <c>users/{user}</c>.
        /// </returns>
        public static string FormatUser(string userId) =>
            s_user.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>Parses the given resource name string into a new <see cref="UserName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}</c></description></item></list>
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserName"/> if successful.</returns>
        public static UserName Parse(string userName) => Parse(userName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserName"/> if successful.</returns>
        public static UserName Parse(string userName, bool allowUnparsed) =>
            TryParse(userName, allowUnparsed, out UserName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="UserName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}</c></description></item></list>
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userName, out UserName result) => TryParse(userName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userName, bool allowUnparsed, out UserName result)
        {
            gax::GaxPreconditions.CheckNotNull(userName, nameof(userName));
            gax::TemplatedResourceName resourceName;
            if (s_user.TryParseName(userName, out resourceName))
            {
                result = FromUser(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UserName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserName"/> class from the component parts of pattern
        /// <c>users/{user}</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        public UserName(string userId) : this(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)))
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
                case ResourceNameType.User: return s_user.Expand(UserId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserName);

        /// <inheritdoc/>
        public bool Equals(UserName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UserName a, UserName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UserName a, UserName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Profile</c> resource.</summary>
    public sealed partial class ProfileName : gax::IResourceName, sys::IEquatable<ProfileName>
    {
        /// <summary>The possible contents of <see cref="ProfileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>users/{user}/profile</c>.</summary>
            User = 1,
        }

        private static gax::PathTemplate s_user = new gax::PathTemplate("users/{user}/profile");

        /// <summary>Creates a <see cref="ProfileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProfileName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProfileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProfileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="ProfileName"/> with the pattern <c>users/{user}/profile</c>.</summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProfileName"/> constructed from the provided ids.</returns>
        public static ProfileName FromUser(string userId) =>
            new ProfileName(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProfileName"/> with pattern
        /// <c>users/{user}/profile</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProfileName"/> with pattern <c>users/{user}/profile</c>.
        /// </returns>
        public static string Format(string userId) => FormatUser(userId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProfileName"/> with pattern
        /// <c>users/{user}/profile</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProfileName"/> with pattern <c>users/{user}/profile</c>.
        /// </returns>
        public static string FormatUser(string userId) =>
            s_user.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProfileName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/profile</c></description></item></list>
        /// </remarks>
        /// <param name="profileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProfileName"/> if successful.</returns>
        public static ProfileName Parse(string profileName) => Parse(profileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProfileName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/profile</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="profileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProfileName"/> if successful.</returns>
        public static ProfileName Parse(string profileName, bool allowUnparsed) =>
            TryParse(profileName, allowUnparsed, out ProfileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/profile</c></description></item></list>
        /// </remarks>
        /// <param name="profileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string profileName, out ProfileName result) => TryParse(profileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProfileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/profile</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="profileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string profileName, bool allowUnparsed, out ProfileName result)
        {
            gax::GaxPreconditions.CheckNotNull(profileName, nameof(profileName));
            gax::TemplatedResourceName resourceName;
            if (s_user.TryParseName(profileName, out resourceName))
            {
                result = FromUser(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(profileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProfileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProfileName"/> class from the component parts of pattern
        /// <c>users/{user}/profile</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        public ProfileName(string userId) : this(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)))
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
                case ResourceNameType.User: return s_user.Expand(UserId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProfileName);

        /// <inheritdoc/>
        public bool Equals(ProfileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProfileName a, ProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProfileName a, ProfileName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PairedDevice</c> resource.</summary>
    public sealed partial class PairedDeviceName : gax::IResourceName, sys::IEquatable<PairedDeviceName>
    {
        /// <summary>The possible contents of <see cref="PairedDeviceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>users/{user}/pairedDevices/{paired_device}</c>.</summary>
            UserPairedDevice = 1,
        }

        private static gax::PathTemplate s_userPairedDevice = new gax::PathTemplate("users/{user}/pairedDevices/{paired_device}");

        /// <summary>Creates a <see cref="PairedDeviceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PairedDeviceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PairedDeviceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PairedDeviceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PairedDeviceName"/> with the pattern <c>users/{user}/pairedDevices/{paired_device}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pairedDeviceId">The <c>PairedDevice</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PairedDeviceName"/> constructed from the provided ids.</returns>
        public static PairedDeviceName FromUserPairedDevice(string userId, string pairedDeviceId) =>
            new PairedDeviceName(ResourceNameType.UserPairedDevice, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), pairedDeviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(pairedDeviceId, nameof(pairedDeviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PairedDeviceName"/> with pattern
        /// <c>users/{user}/pairedDevices/{paired_device}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pairedDeviceId">The <c>PairedDevice</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PairedDeviceName"/> with pattern
        /// <c>users/{user}/pairedDevices/{paired_device}</c>.
        /// </returns>
        public static string Format(string userId, string pairedDeviceId) => FormatUserPairedDevice(userId, pairedDeviceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PairedDeviceName"/> with pattern
        /// <c>users/{user}/pairedDevices/{paired_device}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pairedDeviceId">The <c>PairedDevice</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PairedDeviceName"/> with pattern
        /// <c>users/{user}/pairedDevices/{paired_device}</c>.
        /// </returns>
        public static string FormatUserPairedDevice(string userId, string pairedDeviceId) =>
            s_userPairedDevice.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNullOrEmpty(pairedDeviceId, nameof(pairedDeviceId)));

        /// <summary>Parses the given resource name string into a new <see cref="PairedDeviceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/pairedDevices/{paired_device}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="pairedDeviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PairedDeviceName"/> if successful.</returns>
        public static PairedDeviceName Parse(string pairedDeviceName) => Parse(pairedDeviceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PairedDeviceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/pairedDevices/{paired_device}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pairedDeviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PairedDeviceName"/> if successful.</returns>
        public static PairedDeviceName Parse(string pairedDeviceName, bool allowUnparsed) =>
            TryParse(pairedDeviceName, allowUnparsed, out PairedDeviceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PairedDeviceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/pairedDevices/{paired_device}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="pairedDeviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PairedDeviceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pairedDeviceName, out PairedDeviceName result) =>
            TryParse(pairedDeviceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PairedDeviceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/pairedDevices/{paired_device}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pairedDeviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PairedDeviceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pairedDeviceName, bool allowUnparsed, out PairedDeviceName result)
        {
            gax::GaxPreconditions.CheckNotNull(pairedDeviceName, nameof(pairedDeviceName));
            gax::TemplatedResourceName resourceName;
            if (s_userPairedDevice.TryParseName(pairedDeviceName, out resourceName))
            {
                result = FromUserPairedDevice(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(pairedDeviceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PairedDeviceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string pairedDeviceId = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PairedDeviceId = pairedDeviceId;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PairedDeviceName"/> class from the component parts of pattern
        /// <c>users/{user}/pairedDevices/{paired_device}</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pairedDeviceId">The <c>PairedDevice</c> ID. Must not be <c>null</c> or empty.</param>
        public PairedDeviceName(string userId, string pairedDeviceId) : this(ResourceNameType.UserPairedDevice, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), pairedDeviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(pairedDeviceId, nameof(pairedDeviceId)))
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
        /// The <c>PairedDevice</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PairedDeviceId { get; }

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
                case ResourceNameType.UserPairedDevice: return s_userPairedDevice.Expand(UserId, PairedDeviceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PairedDeviceName);

        /// <inheritdoc/>
        public bool Equals(PairedDeviceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PairedDeviceName a, PairedDeviceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PairedDeviceName a, PairedDeviceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>IrnProfile</c> resource.</summary>
    public sealed partial class IrnProfileName : gax::IResourceName, sys::IEquatable<IrnProfileName>
    {
        /// <summary>The possible contents of <see cref="IrnProfileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>users/{user}/irnProfile</c>.</summary>
            User = 1,
        }

        private static gax::PathTemplate s_user = new gax::PathTemplate("users/{user}/irnProfile");

        /// <summary>Creates a <see cref="IrnProfileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IrnProfileName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IrnProfileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IrnProfileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="IrnProfileName"/> with the pattern <c>users/{user}/irnProfile</c>.</summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IrnProfileName"/> constructed from the provided ids.</returns>
        public static IrnProfileName FromUser(string userId) =>
            new IrnProfileName(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IrnProfileName"/> with pattern
        /// <c>users/{user}/irnProfile</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IrnProfileName"/> with pattern <c>users/{user}/irnProfile</c>.
        /// </returns>
        public static string Format(string userId) => FormatUser(userId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IrnProfileName"/> with pattern
        /// <c>users/{user}/irnProfile</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IrnProfileName"/> with pattern <c>users/{user}/irnProfile</c>.
        /// </returns>
        public static string FormatUser(string userId) =>
            s_user.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>Parses the given resource name string into a new <see cref="IrnProfileName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/irnProfile</c></description></item></list>
        /// </remarks>
        /// <param name="irnProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IrnProfileName"/> if successful.</returns>
        public static IrnProfileName Parse(string irnProfileName) => Parse(irnProfileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IrnProfileName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/irnProfile</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="irnProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IrnProfileName"/> if successful.</returns>
        public static IrnProfileName Parse(string irnProfileName, bool allowUnparsed) =>
            TryParse(irnProfileName, allowUnparsed, out IrnProfileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IrnProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/irnProfile</c></description></item></list>
        /// </remarks>
        /// <param name="irnProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IrnProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string irnProfileName, out IrnProfileName result) =>
            TryParse(irnProfileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IrnProfileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/irnProfile</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="irnProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IrnProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string irnProfileName, bool allowUnparsed, out IrnProfileName result)
        {
            gax::GaxPreconditions.CheckNotNull(irnProfileName, nameof(irnProfileName));
            gax::TemplatedResourceName resourceName;
            if (s_user.TryParseName(irnProfileName, out resourceName))
            {
                result = FromUser(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(irnProfileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IrnProfileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IrnProfileName"/> class from the component parts of pattern
        /// <c>users/{user}/irnProfile</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        public IrnProfileName(string userId) : this(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)))
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
                case ResourceNameType.User: return s_user.Expand(UserId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IrnProfileName);

        /// <inheritdoc/>
        public bool Equals(IrnProfileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(IrnProfileName a, IrnProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(IrnProfileName a, IrnProfileName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Settings</c> resource.</summary>
    public sealed partial class SettingsName : gax::IResourceName, sys::IEquatable<SettingsName>
    {
        /// <summary>The possible contents of <see cref="SettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>users/{user}/settings</c>.</summary>
            User = 1,
        }

        private static gax::PathTemplate s_user = new gax::PathTemplate("users/{user}/settings");

        /// <summary>Creates a <see cref="SettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SettingsName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static SettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="SettingsName"/> with the pattern <c>users/{user}/settings</c>.</summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromUser(string userId) =>
            new SettingsName(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>users/{user}/settings</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern <c>users/{user}/settings</c>.
        /// </returns>
        public static string Format(string userId) => FormatUser(userId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>users/{user}/settings</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern <c>users/{user}/settings</c>.
        /// </returns>
        public static string FormatUser(string userId) =>
            s_user.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>Parses the given resource name string into a new <see cref="SettingsName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/settings</c></description></item></list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName) => Parse(settingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SettingsName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/settings</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName, bool allowUnparsed) =>
            TryParse(settingsName, allowUnparsed, out SettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/settings</c></description></item></list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, out SettingsName result) => TryParse(settingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/settings</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, bool allowUnparsed, out SettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(settingsName, nameof(settingsName));
            gax::TemplatedResourceName resourceName;
            if (s_user.TryParseName(settingsName, out resourceName))
            {
                result = FromUser(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(settingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SettingsName"/> class from the component parts of pattern
        /// <c>users/{user}/settings</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        public SettingsName(string userId) : this(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)))
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
                case ResourceNameType.User: return s_user.Expand(UserId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SettingsName);

        /// <inheritdoc/>
        public bool Equals(SettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SettingsName a, SettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SettingsName a, SettingsName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Identity</c> resource.</summary>
    public sealed partial class IdentityName : gax::IResourceName, sys::IEquatable<IdentityName>
    {
        /// <summary>The possible contents of <see cref="IdentityName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>users/{user}/identity</c>.</summary>
            User = 1,
        }

        private static gax::PathTemplate s_user = new gax::PathTemplate("users/{user}/identity");

        /// <summary>Creates a <see cref="IdentityName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IdentityName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static IdentityName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IdentityName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="IdentityName"/> with the pattern <c>users/{user}/identity</c>.</summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IdentityName"/> constructed from the provided ids.</returns>
        public static IdentityName FromUser(string userId) =>
            new IdentityName(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IdentityName"/> with pattern
        /// <c>users/{user}/identity</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IdentityName"/> with pattern <c>users/{user}/identity</c>.
        /// </returns>
        public static string Format(string userId) => FormatUser(userId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IdentityName"/> with pattern
        /// <c>users/{user}/identity</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IdentityName"/> with pattern <c>users/{user}/identity</c>.
        /// </returns>
        public static string FormatUser(string userId) =>
            s_user.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>Parses the given resource name string into a new <see cref="IdentityName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/identity</c></description></item></list>
        /// </remarks>
        /// <param name="identityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IdentityName"/> if successful.</returns>
        public static IdentityName Parse(string identityName) => Parse(identityName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IdentityName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/identity</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="identityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IdentityName"/> if successful.</returns>
        public static IdentityName Parse(string identityName, bool allowUnparsed) =>
            TryParse(identityName, allowUnparsed, out IdentityName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IdentityName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/identity</c></description></item></list>
        /// </remarks>
        /// <param name="identityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IdentityName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string identityName, out IdentityName result) => TryParse(identityName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IdentityName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/identity</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="identityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IdentityName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string identityName, bool allowUnparsed, out IdentityName result)
        {
            gax::GaxPreconditions.CheckNotNull(identityName, nameof(identityName));
            gax::TemplatedResourceName resourceName;
            if (s_user.TryParseName(identityName, out resourceName))
            {
                result = FromUser(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(identityName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IdentityName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IdentityName"/> class from the component parts of pattern
        /// <c>users/{user}/identity</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        public IdentityName(string userId) : this(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)))
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
                case ResourceNameType.User: return s_user.Expand(UserId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IdentityName);

        /// <inheritdoc/>
        public bool Equals(IdentityName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(IdentityName a, IdentityName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(IdentityName a, IdentityName b) => !(a == b);
    }

    public partial class User
    {
        /// <summary>
        /// <see cref="gdhv::UserName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::UserName UserName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::UserName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Profile
    {
        /// <summary>
        /// <see cref="gdhv::ProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::ProfileName ProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::ProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PairedDevice
    {
        /// <summary>
        /// <see cref="gdhv::PairedDeviceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::PairedDeviceName PairedDeviceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::PairedDeviceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class IrnProfile
    {
        /// <summary>
        /// <see cref="gdhv::IrnProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::IrnProfileName IrnProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::IrnProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Settings
    {
        /// <summary>
        /// <see cref="gdhv::SettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::SettingsName SettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::SettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Identity
    {
        /// <summary>
        /// <see cref="gdhv::IdentityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::IdentityName IdentityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::IdentityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetProfileRequest
    {
        /// <summary>
        /// <see cref="gdhv::ProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::ProfileName ProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::ProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetIrnProfileRequest
    {
        /// <summary>
        /// <see cref="gdhv::IrnProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::IrnProfileName IrnProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::IrnProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSettingsRequest
    {
        /// <summary>
        /// <see cref="gdhv::SettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::SettingsName SettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::SettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetIdentityRequest
    {
        /// <summary>
        /// <see cref="gdhv::IdentityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::IdentityName IdentityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::IdentityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetPairedDeviceRequest
    {
        /// <summary>
        /// <see cref="gdhv::PairedDeviceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::PairedDeviceName PairedDeviceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::PairedDeviceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPairedDevicesRequest
    {
        /// <summary><see cref="UserName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public UserName ParentAsUserName
        {
            get => string.IsNullOrEmpty(Parent) ? null : UserName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
