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
using gscv = Google.Shopping.Css.V1;
using sys = System;

namespace Google.Shopping.Css.V1
{
    /// <summary>Resource name for the <c>CssProduct</c> resource.</summary>
    public sealed partial class CssProductName : gax::IResourceName, sys::IEquatable<CssProductName>
    {
        /// <summary>The possible contents of <see cref="CssProductName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/cssProducts/{css_product}</c>.</summary>
            AccountCssProduct = 1,
        }

        private static gax::PathTemplate s_accountCssProduct = new gax::PathTemplate("accounts/{account}/cssProducts/{css_product}");

        /// <summary>Creates a <see cref="CssProductName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CssProductName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CssProductName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CssProductName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CssProductName"/> with the pattern <c>accounts/{account}/cssProducts/{css_product}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cssProductId">The <c>CssProduct</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CssProductName"/> constructed from the provided ids.</returns>
        public static CssProductName FromAccountCssProduct(string accountId, string cssProductId) =>
            new CssProductName(ResourceNameType.AccountCssProduct, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), cssProductId: gax::GaxPreconditions.CheckNotNullOrEmpty(cssProductId, nameof(cssProductId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CssProductName"/> with pattern
        /// <c>accounts/{account}/cssProducts/{css_product}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cssProductId">The <c>CssProduct</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CssProductName"/> with pattern
        /// <c>accounts/{account}/cssProducts/{css_product}</c>.
        /// </returns>
        public static string Format(string accountId, string cssProductId) => FormatAccountCssProduct(accountId, cssProductId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CssProductName"/> with pattern
        /// <c>accounts/{account}/cssProducts/{css_product}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cssProductId">The <c>CssProduct</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CssProductName"/> with pattern
        /// <c>accounts/{account}/cssProducts/{css_product}</c>.
        /// </returns>
        public static string FormatAccountCssProduct(string accountId, string cssProductId) =>
            s_accountCssProduct.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cssProductId, nameof(cssProductId)));

        /// <summary>Parses the given resource name string into a new <see cref="CssProductName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/cssProducts/{css_product}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="cssProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CssProductName"/> if successful.</returns>
        public static CssProductName Parse(string cssProductName) => Parse(cssProductName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CssProductName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/cssProducts/{css_product}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cssProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CssProductName"/> if successful.</returns>
        public static CssProductName Parse(string cssProductName, bool allowUnparsed) =>
            TryParse(cssProductName, allowUnparsed, out CssProductName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CssProductName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/cssProducts/{css_product}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="cssProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CssProductName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cssProductName, out CssProductName result) =>
            TryParse(cssProductName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CssProductName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/cssProducts/{css_product}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cssProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CssProductName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cssProductName, bool allowUnparsed, out CssProductName result)
        {
            gax::GaxPreconditions.CheckNotNull(cssProductName, nameof(cssProductName));
            gax::TemplatedResourceName resourceName;
            if (s_accountCssProduct.TryParseName(cssProductName, out resourceName))
            {
                result = FromAccountCssProduct(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cssProductName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CssProductName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string cssProductId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            CssProductId = cssProductId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CssProductName"/> class from the component parts of pattern
        /// <c>accounts/{account}/cssProducts/{css_product}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cssProductId">The <c>CssProduct</c> ID. Must not be <c>null</c> or empty.</param>
        public CssProductName(string accountId, string cssProductId) : this(ResourceNameType.AccountCssProduct, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), cssProductId: gax::GaxPreconditions.CheckNotNullOrEmpty(cssProductId, nameof(cssProductId)))
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
        /// The <c>CssProduct</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CssProductId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountCssProduct: return s_accountCssProduct.Expand(AccountId, CssProductId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CssProductName);

        /// <inheritdoc/>
        public bool Equals(CssProductName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CssProductName a, CssProductName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CssProductName a, CssProductName b) => !(a == b);
    }

    public partial class GetCssProductRequest
    {
        /// <summary>
        /// <see cref="gscv::CssProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gscv::CssProductName CssProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gscv::CssProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CssProduct
    {
        /// <summary>
        /// <see cref="gscv::CssProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gscv::CssProductName CssProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gscv::CssProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCssProductsRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
