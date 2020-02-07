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
using gcsv = Google.Cloud.SecurityCenter.V1P1Beta1;
using sys = System;

namespace Google.Cloud.SecurityCenter.V1P1Beta1
{
    /// <summary>Resource name for the <c>Asset</c> resource.</summary>
    public sealed partial class AssetName : gax::IResourceName, sys::IEquatable<AssetName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/assets/{asset}");

        /// <summary>
        /// Parses the given <c>Asset</c> resource name in string form into a new <see cref="AssetName"/> instance.
        /// </summary>
        /// <param name="assetName">The <c>Asset</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssetName"/> if successful.</returns>
        public static AssetName Parse(string assetName)
        {
            gax::GaxPreconditions.CheckNotNull(assetName, nameof(assetName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(assetName);
            return new AssetName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="AssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="assetName"/> is <c>null</c>
        /// , as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="assetName">The <c>Asset</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetName, out AssetName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetName, nameof(assetName));
            if (s_template.TryParseName(assetName, out gax::TemplatedResourceName resourceName))
            {
                result = new AssetName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="AssetName"/>.</summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="AssetName"/>.</returns>
        public static string Format(string organizationId, string assetId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(assetId, nameof(assetId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="AssetName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c>.</param>
        public AssetName(string organizationId, string assetId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            AssetId = gax::GaxPreconditions.CheckNotNull(assetId, nameof(assetId));
        }

        /// <summary>The <c>Organization</c> ID. Never <c>null</c>.</summary>
        public string OrganizationId { get; }

        /// <summary>The <c>Asset</c> ID. Never <c>null</c>.</summary>
        public string AssetId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(OrganizationId, AssetId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssetName);

        /// <inheritdoc/>
        public bool Equals(AssetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AssetName a, AssetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AssetName a, AssetName b) => !(a == b);
    }

    public partial class Asset
    {
        /// <summary>
        /// <see cref="gcsv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::AssetName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
