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
using gcbbv = Google.Cloud.Billing.Budgets.V1;
using sys = System;

namespace Google.Cloud.Billing.Budgets.V1
{
    /// <summary>Resource name for the <c>Budget</c> resource.</summary>
    public sealed partial class BudgetName : gax::IResourceName, sys::IEquatable<BudgetName>
    {
        /// <summary>The possible contents of <see cref="BudgetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>billingAccounts/{billing_account}/budgets/{budget}</c>.
            /// </summary>
            BillingAccountBudget = 1,
        }

        private static gax::PathTemplate s_billingAccountBudget = new gax::PathTemplate("billingAccounts/{billing_account}/budgets/{budget}");

        /// <summary>Creates a <see cref="BudgetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BudgetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BudgetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BudgetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BudgetName"/> with the pattern <c>billingAccounts/{billing_account}/budgets/{budget}</c>
        /// .
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="budgetId">The <c>Budget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BudgetName"/> constructed from the provided ids.</returns>
        public static BudgetName FromBillingAccountBudget(string billingAccountId, string budgetId) =>
            new BudgetName(ResourceNameType.BillingAccountBudget, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), budgetId: gax::GaxPreconditions.CheckNotNullOrEmpty(budgetId, nameof(budgetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BudgetName"/> with pattern
        /// <c>billingAccounts/{billing_account}/budgets/{budget}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="budgetId">The <c>Budget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BudgetName"/> with pattern
        /// <c>billingAccounts/{billing_account}/budgets/{budget}</c>.
        /// </returns>
        public static string Format(string billingAccountId, string budgetId) =>
            FormatBillingAccountBudget(billingAccountId, budgetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BudgetName"/> with pattern
        /// <c>billingAccounts/{billing_account}/budgets/{budget}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="budgetId">The <c>Budget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BudgetName"/> with pattern
        /// <c>billingAccounts/{billing_account}/budgets/{budget}</c>.
        /// </returns>
        public static string FormatBillingAccountBudget(string billingAccountId, string budgetId) =>
            s_billingAccountBudget.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(budgetId, nameof(budgetId)));

        /// <summary>Parses the given resource name string into a new <see cref="BudgetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>billingAccounts/{billing_account}/budgets/{budget}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="budgetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BudgetName"/> if successful.</returns>
        public static BudgetName Parse(string budgetName) => Parse(budgetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BudgetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>billingAccounts/{billing_account}/budgets/{budget}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="budgetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BudgetName"/> if successful.</returns>
        public static BudgetName Parse(string budgetName, bool allowUnparsed) =>
            TryParse(budgetName, allowUnparsed, out BudgetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BudgetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>billingAccounts/{billing_account}/budgets/{budget}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="budgetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BudgetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string budgetName, out BudgetName result) => TryParse(budgetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BudgetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>billingAccounts/{billing_account}/budgets/{budget}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="budgetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BudgetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string budgetName, bool allowUnparsed, out BudgetName result)
        {
            gax::GaxPreconditions.CheckNotNull(budgetName, nameof(budgetName));
            gax::TemplatedResourceName resourceName;
            if (s_billingAccountBudget.TryParseName(budgetName, out resourceName))
            {
                result = FromBillingAccountBudget(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(budgetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BudgetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string budgetId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            BudgetId = budgetId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BudgetName"/> class from the component parts of pattern
        /// <c>billingAccounts/{billing_account}/budgets/{budget}</c>
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="budgetId">The <c>Budget</c> ID. Must not be <c>null</c> or empty.</param>
        public BudgetName(string billingAccountId, string budgetId) : this(ResourceNameType.BillingAccountBudget, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), budgetId: gax::GaxPreconditions.CheckNotNullOrEmpty(budgetId, nameof(budgetId)))
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
        /// The <c>Budget</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BudgetId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.BillingAccountBudget: return s_billingAccountBudget.Expand(BillingAccountId, BudgetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BudgetName);

        /// <inheritdoc/>
        public bool Equals(BudgetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BudgetName a, BudgetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BudgetName a, BudgetName b) => !(a == b);
    }

    public partial class Budget
    {
        /// <summary>
        /// <see cref="gcbbv::BudgetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbbv::BudgetName BudgetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbbv::BudgetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
