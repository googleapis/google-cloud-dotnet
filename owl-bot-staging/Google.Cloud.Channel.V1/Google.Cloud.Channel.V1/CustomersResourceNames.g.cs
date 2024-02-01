// Copyright 2024 Google LLC
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
using gccv = Google.Cloud.Channel.V1;
using sys = System;

namespace Google.Cloud.Channel.V1
{
    /// <summary>Resource name for the <c>Customer</c> resource.</summary>
    public sealed partial class CustomerName : gax::IResourceName, sys::IEquatable<CustomerName>
    {
        /// <summary>The possible contents of <see cref="CustomerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/customers/{customer}</c>.</summary>
            AccountCustomer = 1,
        }

        private static gax::PathTemplate s_accountCustomer = new gax::PathTemplate("accounts/{account}/customers/{customer}");

        /// <summary>Creates a <see cref="CustomerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static CustomerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerName"/> with the pattern <c>accounts/{account}/customers/{customer}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomerName"/> constructed from the provided ids.</returns>
        public static CustomerName FromAccountCustomer(string accountId, string customerId) =>
            new CustomerName(ResourceNameType.AccountCustomer, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerName"/> with pattern
        /// <c>accounts/{account}/customers/{customer}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerName"/> with pattern
        /// <c>accounts/{account}/customers/{customer}</c>.
        /// </returns>
        public static string Format(string accountId, string customerId) => FormatAccountCustomer(accountId, customerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerName"/> with pattern
        /// <c>accounts/{account}/customers/{customer}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerName"/> with pattern
        /// <c>accounts/{account}/customers/{customer}</c>.
        /// </returns>
        public static string FormatAccountCustomer(string accountId, string customerId) =>
            s_accountCustomer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)));

        /// <summary>Parses the given resource name string into a new <see cref="CustomerName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/customers/{customer}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerName"/> if successful.</returns>
        public static CustomerName Parse(string customerName) => Parse(customerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/customers/{customer}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerName"/> if successful.</returns>
        public static CustomerName Parse(string customerName, bool allowUnparsed) =>
            TryParse(customerName, allowUnparsed, out CustomerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/customers/{customer}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerName, out CustomerName result) => TryParse(customerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/customers/{customer}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerName, bool allowUnparsed, out CustomerName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerName, nameof(customerName));
            gax::TemplatedResourceName resourceName;
            if (s_accountCustomer.TryParseName(customerName, out resourceName))
            {
                result = FromAccountCustomer(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerName"/> class from the component parts of pattern
        /// <c>accounts/{account}/customers/{customer}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomerName(string accountId, string customerId) : this(ResourceNameType.AccountCustomer, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)))
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
        /// The <c>Account</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AccountId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountCustomer: return s_accountCustomer.Expand(AccountId, CustomerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerName);

        /// <inheritdoc/>
        public bool Equals(CustomerName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomerName a, CustomerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CustomerName a, CustomerName b) => !(a == b);
    }

    public partial class Customer
    {
        /// <summary>
        /// <see cref="gccv::CustomerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CustomerName CustomerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CustomerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
