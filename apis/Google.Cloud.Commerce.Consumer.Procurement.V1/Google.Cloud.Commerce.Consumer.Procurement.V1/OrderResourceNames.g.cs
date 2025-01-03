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
using gcccpv = Google.Cloud.Commerce.Consumer.Procurement.V1;
using sys = System;

namespace Google.Cloud.Commerce.Consumer.Procurement.V1
{
    /// <summary>Resource name for the <c>Order</c> resource.</summary>
    public sealed partial class OrderName : gax::IResourceName, sys::IEquatable<OrderName>
    {
        /// <summary>The possible contents of <see cref="OrderName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>billingAccounts/{billing_account}/orders/{order}</c>.</summary>
            BillingAccountOrder = 1,
        }

        private static gax::PathTemplate s_billingAccountOrder = new gax::PathTemplate("billingAccounts/{billing_account}/orders/{order}");

        /// <summary>Creates a <see cref="OrderName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrderName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrderName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrderName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrderName"/> with the pattern <c>billingAccounts/{billing_account}/orders/{order}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OrderName"/> constructed from the provided ids.</returns>
        public static OrderName FromBillingAccountOrder(string billingAccountId, string orderId) =>
            new OrderName(ResourceNameType.BillingAccountOrder, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrderName"/> with pattern
        /// <c>billingAccounts/{billing_account}/orders/{order}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrderName"/> with pattern
        /// <c>billingAccounts/{billing_account}/orders/{order}</c>.
        /// </returns>
        public static string Format(string billingAccountId, string orderId) =>
            FormatBillingAccountOrder(billingAccountId, orderId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrderName"/> with pattern
        /// <c>billingAccounts/{billing_account}/orders/{order}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrderName"/> with pattern
        /// <c>billingAccounts/{billing_account}/orders/{order}</c>.
        /// </returns>
        public static string FormatBillingAccountOrder(string billingAccountId, string orderId) =>
            s_billingAccountOrder.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)));

        /// <summary>Parses the given resource name string into a new <see cref="OrderName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>billingAccounts/{billing_account}/orders/{order}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrderName"/> if successful.</returns>
        public static OrderName Parse(string orderName) => Parse(orderName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrderName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>billingAccounts/{billing_account}/orders/{order}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrderName"/> if successful.</returns>
        public static OrderName Parse(string orderName, bool allowUnparsed) =>
            TryParse(orderName, allowUnparsed, out OrderName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrderName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>billingAccounts/{billing_account}/orders/{order}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orderName, out OrderName result) => TryParse(orderName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrderName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>billingAccounts/{billing_account}/orders/{order}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orderName, bool allowUnparsed, out OrderName result)
        {
            gax::GaxPreconditions.CheckNotNull(orderName, nameof(orderName));
            gax::TemplatedResourceName resourceName;
            if (s_billingAccountOrder.TryParseName(orderName, out resourceName))
            {
                result = FromBillingAccountOrder(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(orderName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrderName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string orderId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            OrderId = orderId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrderName"/> class from the component parts of pattern
        /// <c>billingAccounts/{billing_account}/orders/{order}</c>
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orderId">The <c>Order</c> ID. Must not be <c>null</c> or empty.</param>
        public OrderName(string billingAccountId, string orderId) : this(ResourceNameType.BillingAccountOrder, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), orderId: gax::GaxPreconditions.CheckNotNullOrEmpty(orderId, nameof(orderId)))
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
        /// The <c>BillingAccount</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>Order</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OrderId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.BillingAccountOrder: return s_billingAccountOrder.Expand(BillingAccountId, OrderId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrderName);

        /// <inheritdoc/>
        public bool Equals(OrderName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrderName a, OrderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrderName a, OrderName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Offer</c> resource.</summary>
    public sealed partial class OfferName : gax::IResourceName, sys::IEquatable<OfferName>
    {
        /// <summary>The possible contents of <see cref="OfferName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>services/{service}/standardOffers/{offer}</c>.</summary>
            ServiceOffer = 1,

            /// <summary>
            /// A resource name with pattern <c>billingAccounts/{consumer_billing_account}/offers/{offer}</c>.
            /// </summary>
            ConsumerBillingAccountOffer = 2,
        }

        private static gax::PathTemplate s_serviceOffer = new gax::PathTemplate("services/{service}/standardOffers/{offer}");

        private static gax::PathTemplate s_consumerBillingAccountOffer = new gax::PathTemplate("billingAccounts/{consumer_billing_account}/offers/{offer}");

        /// <summary>Creates a <see cref="OfferName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OfferName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OfferName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OfferName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OfferName"/> with the pattern <c>services/{service}/standardOffers/{offer}</c>.
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OfferName"/> constructed from the provided ids.</returns>
        public static OfferName FromServiceOffer(string serviceId, string offerId) =>
            new OfferName(ResourceNameType.ServiceOffer, serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), offerId: gax::GaxPreconditions.CheckNotNullOrEmpty(offerId, nameof(offerId)));

        /// <summary>
        /// Creates a <see cref="OfferName"/> with the pattern
        /// <c>billingAccounts/{consumer_billing_account}/offers/{offer}</c>.
        /// </summary>
        /// <param name="consumerBillingAccountId">
        /// The <c>ConsumerBillingAccount</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OfferName"/> constructed from the provided ids.</returns>
        public static OfferName FromConsumerBillingAccountOffer(string consumerBillingAccountId, string offerId) =>
            new OfferName(ResourceNameType.ConsumerBillingAccountOffer, consumerBillingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(consumerBillingAccountId, nameof(consumerBillingAccountId)), offerId: gax::GaxPreconditions.CheckNotNullOrEmpty(offerId, nameof(offerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OfferName"/> with pattern
        /// <c>services/{service}/standardOffers/{offer}</c>.
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OfferName"/> with pattern
        /// <c>services/{service}/standardOffers/{offer}</c>.
        /// </returns>
        public static string Format(string serviceId, string offerId) => FormatServiceOffer(serviceId, offerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OfferName"/> with pattern
        /// <c>services/{service}/standardOffers/{offer}</c>.
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OfferName"/> with pattern
        /// <c>services/{service}/standardOffers/{offer}</c>.
        /// </returns>
        public static string FormatServiceOffer(string serviceId, string offerId) =>
            s_serviceOffer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(offerId, nameof(offerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OfferName"/> with pattern
        /// <c>billingAccounts/{consumer_billing_account}/offers/{offer}</c>.
        /// </summary>
        /// <param name="consumerBillingAccountId">
        /// The <c>ConsumerBillingAccount</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OfferName"/> with pattern
        /// <c>billingAccounts/{consumer_billing_account}/offers/{offer}</c>.
        /// </returns>
        public static string FormatConsumerBillingAccountOffer(string consumerBillingAccountId, string offerId) =>
            s_consumerBillingAccountOffer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(consumerBillingAccountId, nameof(consumerBillingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(offerId, nameof(offerId)));

        /// <summary>Parses the given resource name string into a new <see cref="OfferName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>services/{service}/standardOffers/{offer}</c></description></item>
        /// <item><description><c>billingAccounts/{consumer_billing_account}/offers/{offer}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="offerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OfferName"/> if successful.</returns>
        public static OfferName Parse(string offerName) => Parse(offerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OfferName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>services/{service}/standardOffers/{offer}</c></description></item>
        /// <item><description><c>billingAccounts/{consumer_billing_account}/offers/{offer}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="offerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OfferName"/> if successful.</returns>
        public static OfferName Parse(string offerName, bool allowUnparsed) =>
            TryParse(offerName, allowUnparsed, out OfferName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OfferName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>services/{service}/standardOffers/{offer}</c></description></item>
        /// <item><description><c>billingAccounts/{consumer_billing_account}/offers/{offer}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="offerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OfferName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string offerName, out OfferName result) => TryParse(offerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OfferName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>services/{service}/standardOffers/{offer}</c></description></item>
        /// <item><description><c>billingAccounts/{consumer_billing_account}/offers/{offer}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="offerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OfferName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string offerName, bool allowUnparsed, out OfferName result)
        {
            gax::GaxPreconditions.CheckNotNull(offerName, nameof(offerName));
            gax::TemplatedResourceName resourceName;
            if (s_serviceOffer.TryParseName(offerName, out resourceName))
            {
                result = FromServiceOffer(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_consumerBillingAccountOffer.TryParseName(offerName, out resourceName))
            {
                result = FromConsumerBillingAccountOffer(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(offerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OfferName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string consumerBillingAccountId = null, string offerId = null, string serviceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConsumerBillingAccountId = consumerBillingAccountId;
            OfferId = offerId;
            ServiceId = serviceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OfferName"/> class from the component parts of pattern
        /// <c>services/{service}/standardOffers/{offer}</c>
        /// </summary>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offerId">The <c>Offer</c> ID. Must not be <c>null</c> or empty.</param>
        public OfferName(string serviceId, string offerId) : this(ResourceNameType.ServiceOffer, serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), offerId: gax::GaxPreconditions.CheckNotNullOrEmpty(offerId, nameof(offerId)))
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
        /// The <c>ConsumerBillingAccount</c> ID. May be <c>null</c>, depending on which resource name is contained by
        /// this instance.
        /// </summary>
        public string ConsumerBillingAccountId { get; }

        /// <summary>
        /// The <c>Offer</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string OfferId { get; }

        /// <summary>
        /// The <c>Service</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ServiceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ServiceOffer: return s_serviceOffer.Expand(ServiceId, OfferId);
                case ResourceNameType.ConsumerBillingAccountOffer: return s_consumerBillingAccountOffer.Expand(ConsumerBillingAccountId, OfferId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OfferName);

        /// <inheritdoc/>
        public bool Equals(OfferName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OfferName a, OfferName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OfferName a, OfferName b) => !(a == b);
    }

    public partial class Order
    {
        /// <summary>
        /// <see cref="gcccpv::OrderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcccpv::OrderName OrderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcccpv::OrderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LineItemInfo
    {
        /// <summary><see cref="OfferName"/>-typed view over the <see cref="Offer"/> resource name property.</summary>
        public OfferName OfferAsOfferName
        {
            get => string.IsNullOrEmpty(Offer) ? null : OfferName.Parse(Offer, allowUnparsed: true);
            set => Offer = value?.ToString() ?? "";
        }
    }
}
