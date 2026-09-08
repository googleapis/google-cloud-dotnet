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
    /// <summary>Resource name for the <c>BreakTemplate</c> resource.</summary>
    public sealed partial class BreakTemplateName : gax::IResourceName, sys::IEquatable<BreakTemplateName>
    {
        /// <summary>The possible contents of <see cref="BreakTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/breakTemplates/{break_template}</c>.
            /// </summary>
            NetworkCodeBreakTemplate = 1,
        }

        private static gax::PathTemplate s_networkCodeBreakTemplate = new gax::PathTemplate("networks/{network_code}/breakTemplates/{break_template}");

        /// <summary>Creates a <see cref="BreakTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BreakTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BreakTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BreakTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BreakTemplateName"/> with the pattern
        /// <c>networks/{network_code}/breakTemplates/{break_template}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="breakTemplateId">The <c>BreakTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BreakTemplateName"/> constructed from the provided ids.</returns>
        public static BreakTemplateName FromNetworkCodeBreakTemplate(string networkCodeId, string breakTemplateId) =>
            new BreakTemplateName(ResourceNameType.NetworkCodeBreakTemplate, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), breakTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(breakTemplateId, nameof(breakTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BreakTemplateName"/> with pattern
        /// <c>networks/{network_code}/breakTemplates/{break_template}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="breakTemplateId">The <c>BreakTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BreakTemplateName"/> with pattern
        /// <c>networks/{network_code}/breakTemplates/{break_template}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string breakTemplateId) =>
            FormatNetworkCodeBreakTemplate(networkCodeId, breakTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BreakTemplateName"/> with pattern
        /// <c>networks/{network_code}/breakTemplates/{break_template}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="breakTemplateId">The <c>BreakTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BreakTemplateName"/> with pattern
        /// <c>networks/{network_code}/breakTemplates/{break_template}</c>.
        /// </returns>
        public static string FormatNetworkCodeBreakTemplate(string networkCodeId, string breakTemplateId) =>
            s_networkCodeBreakTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(breakTemplateId, nameof(breakTemplateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BreakTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/breakTemplates/{break_template}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="breakTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BreakTemplateName"/> if successful.</returns>
        public static BreakTemplateName Parse(string breakTemplateName) => Parse(breakTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BreakTemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/breakTemplates/{break_template}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="breakTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BreakTemplateName"/> if successful.</returns>
        public static BreakTemplateName Parse(string breakTemplateName, bool allowUnparsed) =>
            TryParse(breakTemplateName, allowUnparsed, out BreakTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BreakTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/breakTemplates/{break_template}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="breakTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BreakTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string breakTemplateName, out BreakTemplateName result) =>
            TryParse(breakTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BreakTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/breakTemplates/{break_template}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="breakTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BreakTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string breakTemplateName, bool allowUnparsed, out BreakTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(breakTemplateName, nameof(breakTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeBreakTemplate.TryParseName(breakTemplateName, out resourceName))
            {
                result = FromNetworkCodeBreakTemplate(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(breakTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BreakTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string breakTemplateId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BreakTemplateId = breakTemplateId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BreakTemplateName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/breakTemplates/{break_template}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="breakTemplateId">The <c>BreakTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        public BreakTemplateName(string networkCodeId, string breakTemplateId) : this(ResourceNameType.NetworkCodeBreakTemplate, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), breakTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(breakTemplateId, nameof(breakTemplateId)))
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
        /// The <c>BreakTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string BreakTemplateId { get; }

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
                case ResourceNameType.NetworkCodeBreakTemplate: return s_networkCodeBreakTemplate.Expand(NetworkCodeId, BreakTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BreakTemplateName);

        /// <inheritdoc/>
        public bool Equals(BreakTemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BreakTemplateName a, BreakTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BreakTemplateName a, BreakTemplateName b) => !(a == b);
    }

    public partial class BreakTemplate
    {
        /// <summary>
        /// <see cref="gaav::BreakTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::BreakTemplateName BreakTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::BreakTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BreakTemplateMember
    {
        /// <summary><see cref="AdSpotName"/>-typed view over the <see cref="AdSpot"/> resource name property.</summary>
        public AdSpotName AdSpotAsAdSpotName
        {
            get => string.IsNullOrEmpty(AdSpot) ? null : AdSpotName.Parse(AdSpot, allowUnparsed: true);
            set => AdSpot = value?.ToString() ?? "";
        }
    }
}
