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
    /// <summary>Resource name for the <c>CssProductInput</c> resource.</summary>
    public sealed partial class CssProductInputName : gax::IResourceName, sys::IEquatable<CssProductInputName>
    {
        /// <summary>The possible contents of <see cref="CssProductInputName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>accounts/{account}/cssProductInputs/{css_product_input}</c>.
            /// </summary>
            AccountCssProductInput = 1,
        }

        private static gax::PathTemplate s_accountCssProductInput = new gax::PathTemplate("accounts/{account}/cssProductInputs/{css_product_input}");

        /// <summary>Creates a <see cref="CssProductInputName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CssProductInputName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CssProductInputName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CssProductInputName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CssProductInputName"/> with the pattern
        /// <c>accounts/{account}/cssProductInputs/{css_product_input}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cssProductInputId">The <c>CssProductInput</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CssProductInputName"/> constructed from the provided ids.</returns>
        public static CssProductInputName FromAccountCssProductInput(string accountId, string cssProductInputId) =>
            new CssProductInputName(ResourceNameType.AccountCssProductInput, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), cssProductInputId: gax::GaxPreconditions.CheckNotNullOrEmpty(cssProductInputId, nameof(cssProductInputId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CssProductInputName"/> with pattern
        /// <c>accounts/{account}/cssProductInputs/{css_product_input}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cssProductInputId">The <c>CssProductInput</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CssProductInputName"/> with pattern
        /// <c>accounts/{account}/cssProductInputs/{css_product_input}</c>.
        /// </returns>
        public static string Format(string accountId, string cssProductInputId) =>
            FormatAccountCssProductInput(accountId, cssProductInputId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CssProductInputName"/> with pattern
        /// <c>accounts/{account}/cssProductInputs/{css_product_input}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cssProductInputId">The <c>CssProductInput</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CssProductInputName"/> with pattern
        /// <c>accounts/{account}/cssProductInputs/{css_product_input}</c>.
        /// </returns>
        public static string FormatAccountCssProductInput(string accountId, string cssProductInputId) =>
            s_accountCssProductInput.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cssProductInputId, nameof(cssProductInputId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CssProductInputName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/cssProductInputs/{css_product_input}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="cssProductInputName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CssProductInputName"/> if successful.</returns>
        public static CssProductInputName Parse(string cssProductInputName) => Parse(cssProductInputName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CssProductInputName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/cssProductInputs/{css_product_input}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cssProductInputName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CssProductInputName"/> if successful.</returns>
        public static CssProductInputName Parse(string cssProductInputName, bool allowUnparsed) =>
            TryParse(cssProductInputName, allowUnparsed, out CssProductInputName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CssProductInputName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/cssProductInputs/{css_product_input}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="cssProductInputName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CssProductInputName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cssProductInputName, out CssProductInputName result) =>
            TryParse(cssProductInputName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CssProductInputName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/cssProductInputs/{css_product_input}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cssProductInputName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CssProductInputName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cssProductInputName, bool allowUnparsed, out CssProductInputName result)
        {
            gax::GaxPreconditions.CheckNotNull(cssProductInputName, nameof(cssProductInputName));
            gax::TemplatedResourceName resourceName;
            if (s_accountCssProductInput.TryParseName(cssProductInputName, out resourceName))
            {
                result = FromAccountCssProductInput(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cssProductInputName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CssProductInputName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string cssProductInputId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            CssProductInputId = cssProductInputId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CssProductInputName"/> class from the component parts of pattern
        /// <c>accounts/{account}/cssProductInputs/{css_product_input}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cssProductInputId">The <c>CssProductInput</c> ID. Must not be <c>null</c> or empty.</param>
        public CssProductInputName(string accountId, string cssProductInputId) : this(ResourceNameType.AccountCssProductInput, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), cssProductInputId: gax::GaxPreconditions.CheckNotNullOrEmpty(cssProductInputId, nameof(cssProductInputId)))
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
        /// The <c>CssProductInput</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CssProductInputId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountCssProductInput: return s_accountCssProductInput.Expand(AccountId, CssProductInputId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CssProductInputName);

        /// <inheritdoc/>
        public bool Equals(CssProductInputName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CssProductInputName a, CssProductInputName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CssProductInputName a, CssProductInputName b) => !(a == b);
    }

    public partial class CssProductInput
    {
        /// <summary>
        /// <see cref="gscv::CssProductInputName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gscv::CssProductInputName CssProductInputName
        {
            get => string.IsNullOrEmpty(Name) ? null : gscv::CssProductInputName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InsertCssProductInputRequest
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

    public partial class DeleteCssProductInputRequest
    {
        /// <summary>
        /// <see cref="gscv::CssProductInputName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gscv::CssProductInputName CssProductInputName
        {
            get => string.IsNullOrEmpty(Name) ? null : gscv::CssProductInputName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
