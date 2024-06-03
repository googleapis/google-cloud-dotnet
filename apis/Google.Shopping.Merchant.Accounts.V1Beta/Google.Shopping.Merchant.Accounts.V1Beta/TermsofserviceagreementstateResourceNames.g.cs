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
using gsmav = Google.Shopping.Merchant.Accounts.V1Beta;
using sys = System;

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Resource name for the <c>TermsOfServiceAgreementState</c> resource.</summary>
    public sealed partial class TermsOfServiceAgreementStateName : gax::IResourceName, sys::IEquatable<TermsOfServiceAgreementStateName>
    {
        /// <summary>The possible contents of <see cref="TermsOfServiceAgreementStateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>accounts/{account}/termsOfServiceAgreementStates/{identifier}</c>.
            /// </summary>
            AccountIdentifier = 1,
        }

        private static gax::PathTemplate s_accountIdentifier = new gax::PathTemplate("accounts/{account}/termsOfServiceAgreementStates/{identifier}");

        /// <summary>
        /// Creates a <see cref="TermsOfServiceAgreementStateName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TermsOfServiceAgreementStateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TermsOfServiceAgreementStateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TermsOfServiceAgreementStateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TermsOfServiceAgreementStateName"/> with the pattern
        /// <c>accounts/{account}/termsOfServiceAgreementStates/{identifier}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="identifierId">The <c>Identifier</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="TermsOfServiceAgreementStateName"/> constructed from the provided ids.
        /// </returns>
        public static TermsOfServiceAgreementStateName FromAccountIdentifier(string accountId, string identifierId) =>
            new TermsOfServiceAgreementStateName(ResourceNameType.AccountIdentifier, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), identifierId: gax::GaxPreconditions.CheckNotNullOrEmpty(identifierId, nameof(identifierId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TermsOfServiceAgreementStateName"/> with
        /// pattern <c>accounts/{account}/termsOfServiceAgreementStates/{identifier}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="identifierId">The <c>Identifier</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TermsOfServiceAgreementStateName"/> with pattern
        /// <c>accounts/{account}/termsOfServiceAgreementStates/{identifier}</c>.
        /// </returns>
        public static string Format(string accountId, string identifierId) => FormatAccountIdentifier(accountId, identifierId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TermsOfServiceAgreementStateName"/> with
        /// pattern <c>accounts/{account}/termsOfServiceAgreementStates/{identifier}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="identifierId">The <c>Identifier</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TermsOfServiceAgreementStateName"/> with pattern
        /// <c>accounts/{account}/termsOfServiceAgreementStates/{identifier}</c>.
        /// </returns>
        public static string FormatAccountIdentifier(string accountId, string identifierId) =>
            s_accountIdentifier.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(identifierId, nameof(identifierId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TermsOfServiceAgreementStateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/termsOfServiceAgreementStates/{identifier}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="termsOfServiceAgreementStateName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="TermsOfServiceAgreementStateName"/> if successful.</returns>
        public static TermsOfServiceAgreementStateName Parse(string termsOfServiceAgreementStateName) =>
            Parse(termsOfServiceAgreementStateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TermsOfServiceAgreementStateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/termsOfServiceAgreementStates/{identifier}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="termsOfServiceAgreementStateName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TermsOfServiceAgreementStateName"/> if successful.</returns>
        public static TermsOfServiceAgreementStateName Parse(string termsOfServiceAgreementStateName, bool allowUnparsed) =>
            TryParse(termsOfServiceAgreementStateName, allowUnparsed, out TermsOfServiceAgreementStateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TermsOfServiceAgreementStateName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/termsOfServiceAgreementStates/{identifier}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="termsOfServiceAgreementStateName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TermsOfServiceAgreementStateName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string termsOfServiceAgreementStateName, out TermsOfServiceAgreementStateName result) =>
            TryParse(termsOfServiceAgreementStateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TermsOfServiceAgreementStateName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/termsOfServiceAgreementStates/{identifier}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="termsOfServiceAgreementStateName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TermsOfServiceAgreementStateName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string termsOfServiceAgreementStateName, bool allowUnparsed, out TermsOfServiceAgreementStateName result)
        {
            gax::GaxPreconditions.CheckNotNull(termsOfServiceAgreementStateName, nameof(termsOfServiceAgreementStateName));
            gax::TemplatedResourceName resourceName;
            if (s_accountIdentifier.TryParseName(termsOfServiceAgreementStateName, out resourceName))
            {
                result = FromAccountIdentifier(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(termsOfServiceAgreementStateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TermsOfServiceAgreementStateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string identifierId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            IdentifierId = identifierId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TermsOfServiceAgreementStateName"/> class from the component parts
        /// of pattern <c>accounts/{account}/termsOfServiceAgreementStates/{identifier}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="identifierId">The <c>Identifier</c> ID. Must not be <c>null</c> or empty.</param>
        public TermsOfServiceAgreementStateName(string accountId, string identifierId) : this(ResourceNameType.AccountIdentifier, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), identifierId: gax::GaxPreconditions.CheckNotNullOrEmpty(identifierId, nameof(identifierId)))
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
        /// The <c>Identifier</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IdentifierId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountIdentifier: return s_accountIdentifier.Expand(AccountId, IdentifierId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TermsOfServiceAgreementStateName);

        /// <inheritdoc/>
        public bool Equals(TermsOfServiceAgreementStateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TermsOfServiceAgreementStateName a, TermsOfServiceAgreementStateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TermsOfServiceAgreementStateName a, TermsOfServiceAgreementStateName b) => !(a == b);
    }

    public partial class TermsOfServiceAgreementState
    {
        /// <summary>
        /// <see cref="gsmav::TermsOfServiceAgreementStateName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gsmav::TermsOfServiceAgreementStateName TermsOfServiceAgreementStateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::TermsOfServiceAgreementStateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Accepted
    {
        /// <summary>
        /// <see cref="TermsOfServiceName"/>-typed view over the <see cref="TermsOfService"/> resource name property.
        /// </summary>
        public TermsOfServiceName TermsOfServiceAsTermsOfServiceName
        {
            get => string.IsNullOrEmpty(TermsOfService) ? null : TermsOfServiceName.Parse(TermsOfService, allowUnparsed: true);
            set => TermsOfService = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="AcceptedBy"/> resource name property.
        /// </summary>
        public AccountName AcceptedByAsAccountName
        {
            get => string.IsNullOrEmpty(AcceptedBy) ? null : AccountName.Parse(AcceptedBy, allowUnparsed: true);
            set => AcceptedBy = value?.ToString() ?? "";
        }
    }

    public partial class Required
    {
        /// <summary>
        /// <see cref="TermsOfServiceName"/>-typed view over the <see cref="TermsOfService"/> resource name property.
        /// </summary>
        public TermsOfServiceName TermsOfServiceAsTermsOfServiceName
        {
            get => string.IsNullOrEmpty(TermsOfService) ? null : TermsOfServiceName.Parse(TermsOfService, allowUnparsed: true);
            set => TermsOfService = value?.ToString() ?? "";
        }
    }

    public partial class GetTermsOfServiceAgreementStateRequest
    {
        /// <summary>
        /// <see cref="gsmav::TermsOfServiceAgreementStateName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gsmav::TermsOfServiceAgreementStateName TermsOfServiceAgreementStateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::TermsOfServiceAgreementStateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RetrieveForApplicationTermsOfServiceAgreementStateRequest
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
