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
using gcbv = Google.Cloud.Billing.V1;
using sys = System;

namespace Google.Cloud.Billing.V1
{
    /// <summary>Resource name for the <c>Service</c> resource.</summary>
    public sealed partial class ServiceName : gax::IResourceName, sys::IEquatable<ServiceName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("services/{service}");

        /// <summary>
        /// Parses the given <c>Service</c> resource name in string form into a new <see cref="ServiceName"/> instance.
        /// </summary>
        /// <param name="serviceName">The <c>Service</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceName"/> if successful.</returns>
        public static ServiceName Parse(string serviceName)
        {
            gax::GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(serviceName);
            return new ServiceName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="ServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="serviceName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="serviceName">The <c>Service</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceName, out ServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName));
            if (s_template.TryParseName(serviceName, out gax::TemplatedResourceName resourceName))
            {
                result = new ServiceName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ServiceName"/>.</summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ServiceName"/>.</returns>
        public static string Format(string serviceId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(serviceId, nameof(serviceId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ServiceName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c>.</param>
        public ServiceName(string serviceId) => ServiceId = gax::GaxPreconditions.CheckNotNull(serviceId, nameof(serviceId));

        /// <summary>The <c>Service</c> ID. Never <c>null</c>.</summary>
        public string ServiceId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ServiceId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceName);

        /// <inheritdoc/>
        public bool Equals(ServiceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ServiceName a, ServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ServiceName a, ServiceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Sku</c> resource.</summary>
    public sealed partial class SkuName : gax::IResourceName, sys::IEquatable<SkuName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("services/{service}/skus/{sku}");

        /// <summary>
        /// Parses the given <c>Sku</c> resource name in string form into a new <see cref="SkuName"/> instance.
        /// </summary>
        /// <param name="skuName">The <c>Sku</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SkuName"/> if successful.</returns>
        public static SkuName Parse(string skuName)
        {
            gax::GaxPreconditions.CheckNotNull(skuName, nameof(skuName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(skuName);
            return new SkuName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="SkuName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="skuName"/> is <c>null</c>
        /// , as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="skuName">The <c>Sku</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SkuName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string skuName, out SkuName result)
        {
            gax::GaxPreconditions.CheckNotNull(skuName, nameof(skuName));
            if (s_template.TryParseName(skuName, out gax::TemplatedResourceName resourceName))
            {
                result = new SkuName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="SkuName"/>.</summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c>.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="SkuName"/>.</returns>
        public static string Format(string serviceId, string skuId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(serviceId, nameof(serviceId)), gax::GaxPreconditions.CheckNotNull(skuId, nameof(skuId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="SkuName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c>.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c>.</param>
        public SkuName(string serviceId, string skuId)
        {
            ServiceId = gax::GaxPreconditions.CheckNotNull(serviceId, nameof(serviceId));
            SkuId = gax::GaxPreconditions.CheckNotNull(skuId, nameof(skuId));
        }

        /// <summary>The <c>Service</c> ID. Never <c>null</c>.</summary>
        public string ServiceId { get; }

        /// <summary>The <c>Sku</c> ID. Never <c>null</c>.</summary>
        public string SkuId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ServiceId, SkuId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SkuName);

        /// <inheritdoc/>
        public bool Equals(SkuName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SkuName a, SkuName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SkuName a, SkuName b) => !(a == b);
    }

    public partial class Service
    {
        /// <summary>
        /// <see cref="gcbv::ServiceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::ServiceName ServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::ServiceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Sku
    {
        /// <summary>
        /// <see cref="gcbv::SkuName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::SkuName SkuName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::SkuName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSkusRequest
    {
        /// <summary>
        /// <see cref="ServiceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ServiceName ParentAsServiceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ServiceName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
