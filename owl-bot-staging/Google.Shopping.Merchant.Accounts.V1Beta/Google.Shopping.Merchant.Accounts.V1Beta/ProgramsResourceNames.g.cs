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
    /// <summary>Resource name for the <c>Program</c> resource.</summary>
    public sealed partial class ProgramName : gax::IResourceName, sys::IEquatable<ProgramName>
    {
        /// <summary>The possible contents of <see cref="ProgramName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/programs/{program}</c>.</summary>
            AccountProgram = 1,
        }

        private static gax::PathTemplate s_accountProgram = new gax::PathTemplate("accounts/{account}/programs/{program}");

        /// <summary>Creates a <see cref="ProgramName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProgramName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProgramName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProgramName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProgramName"/> with the pattern <c>accounts/{account}/programs/{program}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="programId">The <c>Program</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProgramName"/> constructed from the provided ids.</returns>
        public static ProgramName FromAccountProgram(string accountId, string programId) =>
            new ProgramName(ResourceNameType.AccountProgram, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), programId: gax::GaxPreconditions.CheckNotNullOrEmpty(programId, nameof(programId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProgramName"/> with pattern
        /// <c>accounts/{account}/programs/{program}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="programId">The <c>Program</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProgramName"/> with pattern
        /// <c>accounts/{account}/programs/{program}</c>.
        /// </returns>
        public static string Format(string accountId, string programId) => FormatAccountProgram(accountId, programId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProgramName"/> with pattern
        /// <c>accounts/{account}/programs/{program}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="programId">The <c>Program</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProgramName"/> with pattern
        /// <c>accounts/{account}/programs/{program}</c>.
        /// </returns>
        public static string FormatAccountProgram(string accountId, string programId) =>
            s_accountProgram.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(programId, nameof(programId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProgramName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/programs/{program}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="programName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProgramName"/> if successful.</returns>
        public static ProgramName Parse(string programName) => Parse(programName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProgramName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/programs/{program}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="programName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProgramName"/> if successful.</returns>
        public static ProgramName Parse(string programName, bool allowUnparsed) =>
            TryParse(programName, allowUnparsed, out ProgramName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProgramName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/programs/{program}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="programName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProgramName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string programName, out ProgramName result) => TryParse(programName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProgramName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/programs/{program}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="programName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProgramName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string programName, bool allowUnparsed, out ProgramName result)
        {
            gax::GaxPreconditions.CheckNotNull(programName, nameof(programName));
            gax::TemplatedResourceName resourceName;
            if (s_accountProgram.TryParseName(programName, out resourceName))
            {
                result = FromAccountProgram(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(programName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProgramName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string programId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            ProgramId = programId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProgramName"/> class from the component parts of pattern
        /// <c>accounts/{account}/programs/{program}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="programId">The <c>Program</c> ID. Must not be <c>null</c> or empty.</param>
        public ProgramName(string accountId, string programId) : this(ResourceNameType.AccountProgram, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), programId: gax::GaxPreconditions.CheckNotNullOrEmpty(programId, nameof(programId)))
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
        public override bool Equals(object obj) => Equals(obj as ProgramName);

        /// <inheritdoc/>
        public bool Equals(ProgramName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProgramName a, ProgramName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProgramName a, ProgramName b) => !(a == b);
    }

    public partial class Program
    {
        /// <summary>
        /// <see cref="gsmav::ProgramName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::ProgramName ProgramName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::ProgramName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetProgramRequest
    {
        /// <summary>
        /// <see cref="gsmav::ProgramName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::ProgramName ProgramName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::ProgramName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListProgramsRequest
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

    public partial class EnableProgramRequest
    {
        /// <summary>
        /// <see cref="gsmav::ProgramName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::ProgramName ProgramName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::ProgramName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DisableProgramRequest
    {
        /// <summary>
        /// <see cref="gsmav::ProgramName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmav::ProgramName ProgramName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmav::ProgramName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
