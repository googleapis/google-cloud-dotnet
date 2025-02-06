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
using gax = Google.Api.Gax;
using gmfdv = Google.Maps.FleetEngine.Delivery.V1;
using sys = System;

namespace Google.Maps.FleetEngine.Delivery.V1
{
    /// <summary>Resource name for the <c>Provider</c> resource.</summary>
    public sealed partial class ProviderName : gax::IResourceName, sys::IEquatable<ProviderName>
    {
        /// <summary>The possible contents of <see cref="ProviderName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>providers/{provider}</c>.</summary>
            Provider = 1,
        }

        private static gax::PathTemplate s_provider = new gax::PathTemplate("providers/{provider}");

        /// <summary>Creates a <see cref="ProviderName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProviderName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static ProviderName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProviderName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="ProviderName"/> with the pattern <c>providers/{provider}</c>.</summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProviderName"/> constructed from the provided ids.</returns>
        public static ProviderName FromProvider(string providerId) =>
            new ProviderName(ResourceNameType.Provider, providerId: gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProviderName"/> with pattern
        /// <c>providers/{provider}</c>.
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProviderName"/> with pattern <c>providers/{provider}</c>.
        /// </returns>
        public static string Format(string providerId) => FormatProvider(providerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProviderName"/> with pattern
        /// <c>providers/{provider}</c>.
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProviderName"/> with pattern <c>providers/{provider}</c>.
        /// </returns>
        public static string FormatProvider(string providerId) =>
            s_provider.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProviderName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>providers/{provider}</c></description></item></list>
        /// </remarks>
        /// <param name="providerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProviderName"/> if successful.</returns>
        public static ProviderName Parse(string providerName) => Parse(providerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProviderName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>providers/{provider}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="providerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProviderName"/> if successful.</returns>
        public static ProviderName Parse(string providerName, bool allowUnparsed) =>
            TryParse(providerName, allowUnparsed, out ProviderName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProviderName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>providers/{provider}</c></description></item></list>
        /// </remarks>
        /// <param name="providerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProviderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string providerName, out ProviderName result) => TryParse(providerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProviderName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>providers/{provider}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="providerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProviderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string providerName, bool allowUnparsed, out ProviderName result)
        {
            gax::GaxPreconditions.CheckNotNull(providerName, nameof(providerName));
            gax::TemplatedResourceName resourceName;
            if (s_provider.TryParseName(providerName, out resourceName))
            {
                result = FromProvider(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(providerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProviderName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string providerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProviderId = providerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProviderName"/> class from the component parts of pattern
        /// <c>providers/{provider}</c>
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        public ProviderName(string providerId) : this(ResourceNameType.Provider, providerId: gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)))
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
        /// The <c>Provider</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProviderId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Provider: return s_provider.Expand(ProviderId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProviderName);

        /// <inheritdoc/>
        public bool Equals(ProviderName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProviderName a, ProviderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProviderName a, ProviderName b) => !(a == b);
    }

    public partial class GetDeliveryVehicleRequest
    {
        /// <summary>
        /// <see cref="gmfdv::DeliveryVehicleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmfdv::DeliveryVehicleName DeliveryVehicleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmfdv::DeliveryVehicleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDeliveryVehiclesRequest
    {
        /// <summary>
        /// <see cref="ProviderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProviderName ParentAsProviderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProviderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateTasksRequest
    {
        /// <summary>
        /// <see cref="ProviderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProviderName ParentAsProviderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProviderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTaskRequest
    {
        /// <summary>
        /// <see cref="gmfdv::TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmfdv::TaskName TaskName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmfdv::TaskName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTasksRequest
    {
        /// <summary>
        /// <see cref="ProviderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProviderName ParentAsProviderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProviderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTaskTrackingInfoRequest
    {
        /// <summary>
        /// <see cref="gmfdv::TaskTrackingInfoName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmfdv::TaskTrackingInfoName TaskTrackingInfoName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmfdv::TaskTrackingInfoName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
