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
using gsmav = Google.Shopping.Merchant.Accounts.V1Beta;
using sys = System;

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Resource name for the <c>CheckoutSettings</c> resource.</summary>
    public sealed partial class CheckoutSettingsName : gax::IResourceName, sys::IEquatable<CheckoutSettingsName>
    {
        /// <summary>The possible contents of <see cref="CheckoutSettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>accounts/{account}/programs/{program}/checkoutSettings</c>.
            /// </summary>
            AccountProgram = 1,
        }

        private static gax::PathTemplate s_accountProgram = new gax::PathTemplate("accounts/{account}/programs/{program}/checkoutSettings");

        /// <summary>Creates a <see cref="CheckoutSettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CheckoutSettingsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CheckoutSettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CheckoutSettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CheckoutSettingsName"/> with the pattern
        /// <c>accounts/{account}/programs/{program}/checkoutSettings</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="programId">The <c>Program</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CheckoutSettingsName"/> constructed from the provided ids.</returns>
        public static CheckoutSettingsName FromAccountProgram(string accountId, string programId) =>
            new CheckoutSettingsName(ResourceNameType.AccountProgram, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), programId: gax::GaxPreconditions.CheckNotNullOrEmpty(programId, nameof(programId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CheckoutSettingsName"/> with pattern
        /// <c>accounts/{account}/programs/{program}/checkoutSettings</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="programId">The <c>Program</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CheckoutSettingsName"/> with pattern
        /// <c>accounts/{account}/programs/{program}/checkoutSettings</c>.
        /// </returns>
        public static string Format(string accountId, string programId) => FormatAccountProgram(accountId, programId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CheckoutSettingsName"/> with pattern
        /// <c>accounts/{account}/programs/{program}/checkoutSettings</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="programId">The <c>Program</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CheckoutSettingsName"/> with pattern
        /// <c>accounts/{account}/programs/{program}/checkoutSettings</c>.
        /// </returns>
        public static string FormatAccountProgram(string accountId, string programId) =>
            s_accountProgram.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(programId, nameof(programId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CheckoutSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/programs/{program}/checkoutSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="checkoutSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CheckoutSettingsName"/> if successful.</returns>
        public static CheckoutSettingsName Parse(string checkoutSettingsName) => Parse(checkoutSettingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CheckoutSettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/programs/{program}/checkoutSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="checkoutSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CheckoutSettingsName"/> if successful.</returns>
        public static CheckoutSettingsName Parse(string checkoutSettingsName, bool allowUnparsed) =>
            TryParse(checkoutSettingsName, allowUnparsed, out CheckoutSettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CheckoutSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/programs/{program}/checkoutSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="checkoutSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CheckoutSettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string checkoutSettingsName, out CheckoutSettingsName result) =>
            TryParse(checkoutSettingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CheckoutSettingsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/programs/{program}/checkoutSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="checkoutSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CheckoutSettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string checkoutSettingsName, bool allowUnparsed, out CheckoutSettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(checkoutSettingsName, nameof(checkoutSettingsName));
            gax::TemplatedResourceName resourceName;
            if (s_accountProgram.TryParseName(checkoutSettingsName, out resourceName))
            {
                result = FromAccountProgram(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(checkoutSettingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CheckoutSettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string programId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            ProgramId = programId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CheckoutSettingsName"/> class from the component parts of pattern
        /// <c>accounts/{account}/programs/{program}/checkoutSettings</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="programId">The <c>Program</c> ID. Must not be <c>null</c> or empty.</param>
        public CheckoutSettingsName(string accountId, string programId) : this(ResourceNameType.AccountProgram, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), programId: gax::GaxPreconditions.CheckNotNullOrEmpty(programId, nameof(programId)))
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
        /// The <c>Program</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProgramId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountProgram: return s_accountProgram.Expand(AccountId, ProgramId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CheckoutSettingsName);

        /// <inheritdoc/>
        public bool Equals(CheckoutSettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CheckoutSettingsName a, CheckoutSettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CheckoutSettingsName a, CheckoutSettingsName b) => !(a == b);
    }

    public partial class GetCheckoutSettingsRequest
    {
        /// <summary>
        /// <see cref="gsmav::CheckoutSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::CheckoutSettingsName CheckoutSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::CheckoutSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCheckoutSettingsRequest
    {
        /// <summary>
        /// <see cref="ProgramName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProgramName ParentAsProgramName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProgramName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCheckoutSettingsRequest
    {
        /// <summary>
        /// <see cref="gsmav::CheckoutSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::CheckoutSettingsName CheckoutSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::CheckoutSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CheckoutSettings
    {
        /// <summary>
        /// <see cref="gsmav::CheckoutSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::CheckoutSettingsName CheckoutSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::CheckoutSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
