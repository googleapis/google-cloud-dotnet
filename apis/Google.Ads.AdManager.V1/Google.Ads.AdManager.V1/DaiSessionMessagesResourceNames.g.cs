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
using gaav = Google.Ads.AdManager.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Resource name for the <c>DaiSession</c> resource.</summary>
    public sealed partial class DaiSessionName : gax::IResourceName, sys::IEquatable<DaiSessionName>
    {
        /// <summary>The possible contents of <see cref="DaiSessionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/daiSessions/{dai_session}</c>.
            /// </summary>
            NetworkCodeDaiSession = 1,
        }

        private static gax::PathTemplate s_networkCodeDaiSession = new gax::PathTemplate("networks/{network_code}/daiSessions/{dai_session}");

        /// <summary>Creates a <see cref="DaiSessionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DaiSessionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DaiSessionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DaiSessionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DaiSessionName"/> with the pattern <c>networks/{network_code}/daiSessions/{dai_session}</c>
        /// .
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="daiSessionId">The <c>DaiSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DaiSessionName"/> constructed from the provided ids.</returns>
        public static DaiSessionName FromNetworkCodeDaiSession(string networkCodeId, string daiSessionId) =>
            new DaiSessionName(ResourceNameType.NetworkCodeDaiSession, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), daiSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(daiSessionId, nameof(daiSessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DaiSessionName"/> with pattern
        /// <c>networks/{network_code}/daiSessions/{dai_session}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="daiSessionId">The <c>DaiSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DaiSessionName"/> with pattern
        /// <c>networks/{network_code}/daiSessions/{dai_session}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string daiSessionId) =>
            FormatNetworkCodeDaiSession(networkCodeId, daiSessionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DaiSessionName"/> with pattern
        /// <c>networks/{network_code}/daiSessions/{dai_session}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="daiSessionId">The <c>DaiSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DaiSessionName"/> with pattern
        /// <c>networks/{network_code}/daiSessions/{dai_session}</c>.
        /// </returns>
        public static string FormatNetworkCodeDaiSession(string networkCodeId, string daiSessionId) =>
            s_networkCodeDaiSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(daiSessionId, nameof(daiSessionId)));

        /// <summary>Parses the given resource name string into a new <see cref="DaiSessionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/daiSessions/{dai_session}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="daiSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DaiSessionName"/> if successful.</returns>
        public static DaiSessionName Parse(string daiSessionName) => Parse(daiSessionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DaiSessionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/daiSessions/{dai_session}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="daiSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DaiSessionName"/> if successful.</returns>
        public static DaiSessionName Parse(string daiSessionName, bool allowUnparsed) =>
            TryParse(daiSessionName, allowUnparsed, out DaiSessionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DaiSessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/daiSessions/{dai_session}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="daiSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DaiSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string daiSessionName, out DaiSessionName result) =>
            TryParse(daiSessionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DaiSessionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/daiSessions/{dai_session}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="daiSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DaiSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string daiSessionName, bool allowUnparsed, out DaiSessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(daiSessionName, nameof(daiSessionName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeDaiSession.TryParseName(daiSessionName, out resourceName))
            {
                result = FromNetworkCodeDaiSession(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(daiSessionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DaiSessionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string daiSessionId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DaiSessionId = daiSessionId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DaiSessionName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/daiSessions/{dai_session}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="daiSessionId">The <c>DaiSession</c> ID. Must not be <c>null</c> or empty.</param>
        public DaiSessionName(string networkCodeId, string daiSessionId) : this(ResourceNameType.NetworkCodeDaiSession, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), daiSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(daiSessionId, nameof(daiSessionId)))
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
        /// The <c>DaiSession</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DaiSessionId { get; }

        /// <summary>
        /// The <c>NetworkCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkCodeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeDaiSession: return s_networkCodeDaiSession.Expand(NetworkCodeId, DaiSessionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DaiSessionName);

        /// <inheritdoc/>
        public bool Equals(DaiSessionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DaiSessionName a, DaiSessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DaiSessionName a, DaiSessionName b) => !(a == b);
    }

    public partial class DaiSession
    {
        /// <summary>
        /// <see cref="gaav::DaiSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::DaiSessionName DaiSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DaiSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class CreationContext
            {
                public partial class Types
                {
                    public partial class VodInfo
                    {
                        /// <summary>
                        /// <see cref="ContentName"/>-typed view over the <see cref="Content"/> resource name property.
                        /// </summary>
                        public ContentName ContentAsContentName
                        {
                            get => string.IsNullOrEmpty(Content) ? null : ContentName.Parse(Content, allowUnparsed: true);
                            set => Content = value?.ToString() ?? "";
                        }
                    }

                    public partial class LinearInfo
                    {
                        /// <summary>
                        /// <see cref="LiveStreamName"/>-typed view over the <see cref="LiveStream"/> resource name
                        /// property.
                        /// </summary>
                        public LiveStreamName LiveStreamAsLiveStreamName
                        {
                            get => string.IsNullOrEmpty(LiveStream) ? null : LiveStreamName.Parse(LiveStream, allowUnparsed: true);
                            set => LiveStream = value?.ToString() ?? "";
                        }
                    }
                }
            }
        }
    }
}
